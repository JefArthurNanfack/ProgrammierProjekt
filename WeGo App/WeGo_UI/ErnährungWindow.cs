using Newtonsoft.Json;
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
    public partial class ErnährungWindow : Form
    {


        public static string apikey = "sk-proj-YlxCQnbX445tBp7TWqXaT3BlbkFJs3Gw9Phs3nfF5mFcjM20";
        public static string endpointURL = "https://api.openai.com/v1/completions";
        public static string modelType = "gpt-3.5-turbo-instruct";
        public static int maxTokens = 2000;
        public static double temp = 1.0f;
        public static readonly HttpClient client = new HttpClient();

        public ErnährungWindow()
        {
            InitializeComponent();
        }

        private void ErnährungWindow_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w - 1250, h - 600);
        }

        private void FoodListV_TextChanged(object sender, EventArgs e)
        {

        }

        private void AgeBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void HeightBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void WeightBx_TextChanged(object sender, EventArgs e)
        {

        }

        private async void CutBtn_Click(object sender, EventArgs e)
        {
            FoodListV.AppendText("Processing input...                                Please wait....");
            await ProcessInput(false);
        }

        private async void BulkBtn_Click(object sender, EventArgs e)
        {   
            FoodListV.AppendText("Processing input...                                Please wait....");
            await ProcessInput(true);
        }

        private async Task ProcessInput(bool bulking)
        {
            try
            {
                
                int age = int.Parse(AgeBx.Text);
                double weight = double.Parse(WeightBx.Text);
                double height = double.Parse(HeightBx.Text);

                double bmr = CalculateBMR(age, weight, height);
                double adjustedBmr = bmr * (bulking ? 1.15 : 0.85);      // Adjust BMR based on bulking or cutting.


                var prompt = $"Create a Three-days {(bulking ? "bulking" : "cutting")} meal plan for a person with a daily caloric need of {adjustedBmr} calories. Include daily meal plans, total caloric breakdown.";
                var response = await OpenAIComplete(apikey, endpointURL, modelType, prompt, maxTokens, temp, adjustedBmr, bulking);

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

                string mealPlan = completionResponse.Choices[0].text;
                DisplayMealPlan(mealPlan);
            }
            catch (Exception ex)
            {
                ShowMessageBox("Error: " + ex.Message);
            }
        }

        public static async Task<string> OpenAIComplete(string apikey, string endpointURL, string modelType, string prompt, int maxTokens, double temp, double bmr, bool bulking)
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

        private double CalculateBMR(int age, double weight, double height)
        {
            return (10 * weight) + (6.25 * height) - (5 * age) + 5; // Assuming gender-neutral formula
        }

        private void DisplayMealPlan(string mealPlan)
        {
            try
            {
                if (FoodListV.InvokeRequired)
                {
                    FoodListV.Invoke(new Action(() =>
                    {
                        FoodListV.Clear();
                        FoodListV.AppendText(mealPlan);
                    }));
                }
                else
                {
                    FoodListV.Clear();
                    FoodListV.AppendText(mealPlan);
                }
                
            }
            catch (Exception ex)
            {
                ShowMessageBox("Error displaying meal plan: " + ex.Message);
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

        public class Choice
        {
            public string text { get; set; }
        }

        public class TextCompletionResponse
        {
            public Choice[] Choices { get; set; }
        }

        public class CompletionRequest
        {
            public string Prompt { get; set; }
            public int MaxTokens { get; set; }
            public float Temperature { get; set; }
            public float TopP { get; set; }
            public bool Echo { get; set; }
            public string Stop { get; set; }
        }
    }
}
