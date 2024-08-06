using Microsoft.VisualBasic.Devices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeGo_UI
{
    public partial class WorkoutWindow : Form
    {
        public static string apikey = "sk-proj-YlxCQnbX445tBp7TWqXaT3BlbkFJs3Gw9Phs3nfF5mFcjM20";
        public static string endpointURL = "https://api.openai.com/v1/completions";
        public static string modelType = "gpt-3.5-turbo-instruct";
        public static int maxTokens = 2000;
        public static double temp = 1.0f;
        public static readonly HttpClient client = new HttpClient();

        public WorkoutWindow()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void calisthenicsBx_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void HomeCBx_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void HomeBx_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = HomeBx.Checked;

            SetFadeState(CardioBx, !isChecked);
            SetFadeState(CuttingBx, !isChecked);
            SetFadeState(BulkingBx, !isChecked);
            if (isChecked)
            {
                CardioBx.Checked = false;
                CuttingBx.Checked = false;
                BulkingBx.Checked = false;
            }
            HomeCBx.Visible = isChecked;
            HomeCBx.Enabled = isChecked;
            calisthenicsBx.Visible = isChecked;
            calisthenicsBx.Enabled = isChecked;
        }

        private void CuttingBx_CheckedChanged(object sender, EventArgs e)
        {
            if (CuttingBx.Checked)
            {
                BulkingBx.Checked = false;
                CuttingBx.Checked = true;
            }
        }

        private void BulkingBx_CheckedChanged(object sender, EventArgs e)
        {
            if (BulkingBx.Checked)
            {
                BulkingBx.Checked = true;
                CuttingBx.Checked = false;
            }
        }

        private void CardioBx_CheckedChanged(object sender, EventArgs e)
        {
        }

        private async void ProcessWorkoutPlan()
        {
            try
            {
                string workoutType = GetWorkoutType();
                if (string.IsNullOrEmpty(workoutType))
                {
                    ShowMessageBox("Please select a workout type.");
                    return;
                }

                var prompt = $"Create a workout plan for {workoutType}. Provide a three-day workout routine.";
                var response = await OpenAIComplete(apikey, endpointURL, modelType, prompt, maxTokens, temp);

                if (response == null)
                {
                    ShowMessageBox("No response from OpenAI.");
                    return;
                }

                ShowMessageBox("Response received from OpenAI.");
                var completionResponse = JsonConvert.DeserializeObject<TextCompletionResponse>(response);

                if (completionResponse == null || completionResponse.Choices == null || completionResponse.Choices.Length == 0)
                {
                    ShowMessageBox("Invalid response format.");
                    return;
                }

                string workoutPlan = completionResponse.Choices[0].text;
                DisplayWorkoutPlan(workoutPlan);
            }
            catch (Exception ex)
            {
                ShowMessageBox("Error: " + ex.Message);
            }
        }

        private string GetWorkoutType()
        {
            if (CardioBx.Checked || HomeCBx.Checked)
            {
                return "cardio";
            }
            if (CuttingBx.Checked)
            {
                return "cutting";
            }
            if (BulkingBx.Checked)
            {
                return "bulking";
            }
            if (HomeBx.Checked)
            {
                if (HomeCBx.Checked && calisthenicsBx.Checked)
                {
                    return "home training and calisthenics";
                }
                if (HomeCBx.Checked)
                {
                    return "home training";
                }
                if (calisthenicsBx.Checked)
                {
                    return "calisthenics";
                }
                return "home training";
            }
            return string.Empty;
        }

        public static async Task<string> OpenAIComplete(string apikey, string endpointURL, string modelType, string prompt, int maxTokens, double temp)
        {
            var requestBody = new
            {
                model = modelType,
                prompt = prompt,
                max_tokens = maxTokens,
                temperature = temp
            };

            string jsonPayload = JsonConvert.SerializeObject(requestBody);
            var request = new HttpRequestMessage(HttpMethod.Post, endpointURL);
            request.Headers.Add("Authorization", $"Bearer {apikey}");
            request.Content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

            var httpResponse = await client.SendAsync(request);
            if (!httpResponse.IsSuccessStatusCode)
            {
                string errorContent = await httpResponse.Content.ReadAsStringAsync();
                throw new Exception($"Request failed with status code {httpResponse.StatusCode}: {errorContent}");
            }

            string responseContent = await httpResponse.Content.ReadAsStringAsync();
            return responseContent;
        }

        private void DisplayWorkoutPlan(string workoutPlan)
        {
            try
            {
                if (richTextBox1.InvokeRequired)
                {
                    richTextBox1.Invoke(new Action(() =>
                    {
                        richTextBox1.Clear();
                        richTextBox1.AppendText(workoutPlan);
                    }));
                }
                else
                {
                    richTextBox1.Clear();
                    richTextBox1.AppendText(workoutPlan);
                }
            }
            catch (Exception ex)
            {
                ShowMessageBox("Error displaying workout plan: " + ex.Message);
            }
        }

        private void ShowMessageBox(string message)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => MessageBox.Show(message)));
            }
            else
            {
                MessageBox.Show(message);
            }
        }

        private void SetFadeState(CheckBox checkBox, bool enabled)
        {
            checkBox.Enabled = enabled;
            checkBox.ForeColor = enabled ? SystemColors.ControlText : SystemColors.GrayText;
        }

        public class Choice
        {
            public string text { get; set; }
        }

        public class TextCompletionResponse
        {
            public Choice[] Choices { get; set; }
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("Processing input... Please wait....");
            ProcessWorkoutPlan();
        }
    }

}
