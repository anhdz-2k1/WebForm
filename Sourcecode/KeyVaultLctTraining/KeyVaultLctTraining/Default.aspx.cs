using Microsoft.Azure.KeyVault;
using Microsoft.Azure.KeyVault.Models;
using Microsoft.Azure.Services.AppAuthentication;
using System;
using System.Threading.Tasks;
using System.Web.UI;

namespace KeyVaultLctTraining
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public async Task<string> OnGetAsync(string secretName)
        {
            var Message = "Your application description page.";
            int retries = 0;
            bool retry = false;
            try
            {
                AzureServiceTokenProvider azureServiceTokenProvider = new AzureServiceTokenProvider();
                KeyVaultClient keyVaultClient =
                    new KeyVaultClient(new KeyVaultClient.AuthenticationCallback
                    (azureServiceTokenProvider.KeyVaultTokenCallback));

                var secret = await
                    keyVaultClient.GetSecretAsync("https://lcttrainingkeyvault.vault.azure.net/secrets/" + secretName)
                        .ConfigureAwait(false);
                Message = secret.Value;

                do
                {
                    long waitTime = Math.Min(getWaitTime(retries), 2000000);
                    secret = await
                        keyVaultClient.GetSecretAsync("https://lcttrainingkeyvault.vault.azure.net/secrets/" + secretName)
                        .ConfigureAwait(false);
                    retry = false;
                }
                while (retry && (retries++ < 10));
            }
            /// <exception cref="KeyVaultErrorException">
            /// Thrown when the operation returned an invalid status code
            /// </exception>
            catch (KeyVaultErrorException keyVaultException)
            {
                Message = keyVaultException.Message;
                if ((int)keyVaultException.Response.StatusCode == 429)
                    retry = true;
            }

            SecretTextBox.Text = Message;

            return Message;

        }


        private static long getWaitTime(int retryCount)
        {
            long waitTime = ((long)Math.Pow(2, retryCount) * 100L);
            return waitTime;
        }

        public async Task<string> GetAccessTokenAsync()
        {
            var azureServiceTokenProvider = new AzureServiceTokenProvider();
            string accessToken = await azureServiceTokenProvider.GetAccessTokenAsync("https://vault.azure.net");
            return accessToken;
        }

        protected void GetSecretButton_Click(object sender, EventArgs e)
        {
            var a = OnGetAsync(NameTextBox.Text).Result;
            SecretTextBox.Text = a;
        }  
    }
}