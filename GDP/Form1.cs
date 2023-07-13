using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Text;
using Microsoft.Win32.SafeHandles;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Drawing.Imaging;
using System.Net;
using MetroSet_UI.Forms;
using System.Drawing.Drawing2D;


namespace GDP
{
    public partial class Form1 : Form
    {
        private bool isDragging = false, ignoreSwitchEvent = false;
        private Point dragStartPosition;
        private Bitmap screenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
        private bool isProcessing = false, loggedIn = false;
        private int selectedLeagueId = 0, lastKey;
        GlobalKeyboardHook gHook;

        private ContextMenuStrip notifyIconContextMenu;

        private void InitializeNotifyIconContextMenu()
        {
            notifyIconContextMenu = new ContextMenuStrip();
            ToolStripMenuItem exitMenuItem = new ToolStripMenuItem("Exit");
            exitMenuItem.Click += ExitMenuItem_Click;
            notifyIconContextMenu.Items.Add(exitMenuItem);
        }
        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            // Clean up any resources if needed

            // Close the form and exit the application
            Close();
            Application.Exit();
        }

        public class ApiResponse
        {
            public string Message { get; set; }
            // Add other properties if needed
        }
        public Form1()
        {
            InitializeComponent();
            InitializeNotifyIconContextMenu();
            Region = CreateRoundRegion(ClientRectangle, 10); // Adjust the radius as needed           
        }
        private Region CreateRoundRegion(Rectangle bounds, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90);
            path.AddArc(bounds.X + bounds.Width - radius, bounds.Y, radius, radius, 270, 90);
            path.AddArc(bounds.X + bounds.Width - radius, bounds.Y + bounds.Height - radius, radius, radius, 0, 90);
            path.AddArc(bounds.X, bounds.Y + bounds.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return new Region(path);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            accessKey_text.BackColor = Color.DarkSlateBlue;
            uri_text.BackColor = Color.DarkSlateBlue;
            oauthButton.NormalColor = Color.DarkSlateBlue;
            oauthButton.NormalBorderColor = Color.DarkSlateBlue;
            league_box.BackgroundColor = Color.DarkSlateBlue;
            uri_text.HoverColor = Color.DarkSlateBlue;
            accessKey_text.HoverColor = Color.DarkSlateBlue;
            uri_text.BorderColor = Color.DarkSlateBlue;
            accessKey_text.BorderColor = Color.DarkSlateBlue;
            league_box.BorderColor = Color.DarkSlateBlue;
            lockSwitch.BorderColor = Color.DarkSlateBlue;
            lockSwitch.CheckColor = Color.Transparent;
            lockSwitch.SymbolColor = Color.DarkSlateBlue;
            lockSwitch.UnCheckColor = Color.Transparent;
            league_box.SelectedItemBackColor = Color.DarkSlateBlue;
            league_box.BorderColor = Color.DarkSlateBlue;
            league_box.Visible = false;
            // Check if the setting "SomeSetting" is set
            if (!string.IsNullOrEmpty(Properties.Settings.Default.AccessToken) && !string.IsNullOrEmpty(Properties.Settings.Default.Url))
            {
                accessKey_text.Text = Properties.Settings.Default.AccessToken;
                uri_text.Text = Properties.Settings.Default.Url;
                SendWelcomeRequest();
            }

            gHook = new GlobalKeyboardHook(); // Create a new GlobalKeyboardHook
                                              // Declare a KeyDown Event
            gHook.KeyDown += new KeyEventHandler(gHook_KeyDown);
            // Add the keys you want to hook to the HookedKeys list
            foreach (Keys key in Enum.GetValues(typeof(Keys)))
                gHook.HookedKeys.Add(key);
            gHook.hook();
        }

        // Handle the KeyDown Event
        public void gHook_KeyDown(object sender, KeyEventArgs e)
        {
            if (lastKey == 160 && e.KeyValue == 190 && !isProcessing && loggedIn) // if left shift + "." pressed
            {
                isProcessing = true;
                SendCreateMatchRequest();
                UpdateTextBox("match creating...");
            }
            lastKey = e.KeyValue;
        }

        private async void SendWelcomeRequest()
        {
            try
            {
                string urlEndpointText = uri_text.Text.ToString();
                // Construct the API endpoint based on the main domain
                string apiEndpoint = urlEndpointText + "api/welcome";

                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = null; // Set base address to null since the complete URL is provided
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessKey_text.Text.ToString());

                    HttpResponseMessage response = await client.GetAsync(apiEndpoint);

                    if (response.IsSuccessStatusCode)
                    {
                        string result = await response.Content.ReadAsStringAsync();
                        if(response.StatusCode ==  HttpStatusCode.Accepted)
                        {
                            Properties.Settings.Default.AccessToken = accessKey_text.Text.ToString();
                            Properties.Settings.Default.Url = uri_text.Text.ToString();
                            Properties.Settings.Default.Save();
                            isLock(false, true);
                            UpdateLeagueBox(result);
                            SetLeagueBox();
                            UpdateTextBox("Do not forget to select a league. Can not see any league? Go and create some from: " + uri_text.Text.ToString());
                            loggedIn = true;
                        }
                        else
                        {
                            ResetSettings();
                            uri_text.ResetText(); ;
                            UpdateTextBox("Invalid API credentials.");
                        }

                    }
                    else
                    {
                        string errorMessage = "API request failed. Status code: " + response.StatusCode;
                        ResetSettings();
                        uri_text.ResetText(); ;
                        UpdateTextBox(errorMessage);
                    }
                }
            }
            catch (Exception ex)
            {
                ResetSettings();
                uri_text.ResetText();

                string errorMessage =ex.Message;
                UpdateTextBox(errorMessage);
            }

        }

        private async void SendCreateMatchRequest()
        {
            try
            {
                string urlEndpointText = uri_text.Text.ToString();
                // Construct the API endpoint based on the main domain
                string apiEndpoint = urlEndpointText + "api/create_match";

                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = null;
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessKey_text.Text.ToString());

                    // Create a new MultipartFormDataContent to hold the form data and image
                    MultipartFormDataContent formData = new MultipartFormDataContent();

                    // Add the league ID to the form data
                    string leagueId = selectedLeagueId.ToString();
                    formData.Add(new StringContent(leagueId), "league_id");

                    // Set the desired resolution for the screenshot
                    int width = 1920; // Replace with your desired width
                    int height = 1080; // Replace with your desired height

                    // Set the desired quality level for the JPEG codec
                    int qualityLevel = 100; // Replace with your desired quality level (0-100)

                    // Capture the screen at the desired resolution
                    using (Bitmap screenshot = new Bitmap(width, height))
                    {
                        using (Graphics graphics = Graphics.FromImage(screenshot))
                        {
                            graphics.CopyFromScreen(0, 0, 0, 0, screenshot.Size);
                        }

                        // Convert the bitmap to a byte array with the desired codec quality
                        using (MemoryStream stream = new MemoryStream())
                        {
                            // Create an EncoderParameters object to specify the quality level for the JPEG codec
                            EncoderParameters encoderParams = new EncoderParameters(1);
                            encoderParams.Param[0] = new System.Drawing.Imaging.EncoderParameter(System.Drawing.Imaging.Encoder.Quality, qualityLevel);

                            // Save the screenshot with the desired quality level
                            ImageCodecInfo jpegCodec = GetEncoderInfo(ImageFormat.Jpeg);
                            screenshot.Save(stream, jpegCodec, encoderParams);
                            byte[] imageBytes = stream.ToArray();

                            // Add the image file to the form data
                            ByteArrayContent imageContent = new ByteArrayContent(imageBytes);
                            formData.Add(imageContent, "image", "image.jpg"); // Replace "image.jpg" with the desired filename

                            // Send the POST request with the form data
                            HttpResponseMessage response = await client.PostAsync(apiEndpoint, formData);

                            

                            if (response.StatusCode == HttpStatusCode.Created)
                            {
                                string result = await response.Content.ReadAsStringAsync();
                                // Deserialize the response JSON into ApiResponse class
                                ApiResponse apiResponse = JsonConvert.DeserializeObject<ApiResponse>(result);
                                // Extract the message from the ApiResponse
                                string message = apiResponse.Message;
                                // Update the text box with the message
                                UpdateTextBox(message);
                            }
                            else if (response.StatusCode == HttpStatusCode.BadRequest ||response.StatusCode == HttpStatusCode.Forbidden)
                            {
                                string result = await response.Content.ReadAsStringAsync();
                                // Deserialize the response JSON into ApiResponse class
                                ApiResponse apiResponse = JsonConvert.DeserializeObject<ApiResponse>(result);
                                // Extract the message from the ApiResponse
                                string message = apiResponse.Message;
                                // Update the text box with the message
                                UpdateTextBox(message);
                                notifyIcon.ShowBalloonTip(5000, "Request Failed", "Failed to create a match.", ToolTipIcon.Error);
                            }
                            else
                            {
                                // Update the text box with the message
                                UpdateTextBox("An unknown error occured, please refresh your API credentials.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ResetSettings();
                uri_text.ResetText();
                string errorMessage = "An error occurred: " + ex.Message;
                UpdateTextBox(errorMessage);
            }
            isProcessing = false;
        }

        // Helper method to get the codec info for a specified image format
        private ImageCodecInfo GetEncoderInfo(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }


        private void UpdateTextBox(string text)
        {
            if (log_text.InvokeRequired)
            {
                log_text.Invoke(new Action<string>(UpdateTextBox), new object[] { text });
            }
            else
            {
                log_text.Text = text;
            }
        }

        private void UpdateLeagueBox(string jsonData)
        {
            try
            {
                dynamic json = JsonConvert.DeserializeObject(jsonData);

                league_box.Items.Clear();
                foreach (var item in json["league"])
                {
                    int id = item["id"];
                    string title = item["title"];

                    KeyValuePair<int, string> league = new KeyValuePair<int, string>(id, title);
                    league_box.Items.Add(league);
                }

                league_box.DisplayMember = "Value";
                league_box.ValueMember = "Key";
            }
            catch (JsonException ex)
            {
                string errorMessage = "Failed to parse JSON data: " + ex.Message;
                UpdateTextBox(errorMessage);
            }
        }

        private void SetLeagueBox()
        {
            string searchValue = Properties.Settings.Default.LastSelectedLeague ?? null;
            if (searchValue != null)
            {
                int selectedIndex = -1;

                for (int i = 0; i < league_box.Items.Count; i++)
                {
                    KeyValuePair<int, string> league = (KeyValuePair<int, string>)league_box.Items[i];

                    if (league.Value == searchValue)
                    {
                        selectedIndex = i;
                        break;
                    }
                }

                league_box.SelectedIndex = selectedIndex;
            }
        }



        private void oauthButton_Click(object sender, EventArgs e)
        {
            SendWelcomeRequest();
        }

        private void league_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (league_box.SelectedItem != null)
            {
                KeyValuePair<int, string> selectedLeague = (KeyValuePair<int, string>)league_box.SelectedItem;
                selectedLeagueId = selectedLeague.Key;
                Properties.Settings.Default.LastSelectedLeague = selectedLeague.Value;
                Properties.Settings.Default.Save();
                UpdateTextBox("Selected league ID: " + selectedLeagueId.ToString());
            }
            else
            {
                UpdateTextBox("No league is selected.");
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                notifyIcon.Visible = true;
                Hide();
            }
        }
        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                notifyIconContextMenu.Show(Cursor.Position);
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Show();
                WindowState = FormWindowState.Normal;
                notifyIcon.Visible = false;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                dragStartPosition = new Point(e.X, e.Y);
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point currentPosition = PointToScreen(e.Location);
                Location = new Point(currentPosition.X - dragStartPosition.X, currentPosition.Y - dragStartPosition.Y);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }
        private void lockSwitch_SwitchedChanged(object sender)
        {
            if (!ignoreSwitchEvent)
            {
                if (lockSwitch.Switched)
                {
                    isLock(false, true);
                }
                else
                {
                    isLock(true, false);
                }
            }
        }

        private void isLock(bool textStatus, bool checkStatus)
        {
            accessKey_text.Visible = textStatus;
            uri_text.Visible = textStatus;
            oauthButton.Visible= textStatus;
            league_box.Visible = !textStatus;
            accessKey_text.BackColor = Color.DarkSlateBlue;
            uri_text.BackColor = Color.DarkSlateBlue;
            oauthButton.NormalColor = Color.DarkSlateBlue;
            ignoreSwitchEvent = true;  // Temporarily ignore the event
            lockSwitch.Switched = checkStatus;
            ignoreSwitchEvent = false; // Re-enable the event handling
        }

        private void ResetSettings()
        {
            Properties.Settings.Default.Reset();
            Properties.Settings.Default.Save();
        }

    }
}
