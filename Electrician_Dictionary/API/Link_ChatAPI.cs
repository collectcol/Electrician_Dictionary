using Electrician_Dictionary.ElecDictionary;
using OpenAI_API;
using OpenAI_API.Chat;
using OpenAI_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Electrician_Dictionary.API
{
    internal static class Link_ChatAPI
    {
        public static OpenAIAPI? API { get; set; }
        private static string? Key { get; set; }
        public static string? result { get; set; }
        public static StartForm? startForm { get; set; }

        public static int Prompt = 0;
        public static void KeySetting(string key)
        {
            Key = key;
        }

        async public static void Link()
        {
            API = new OpenAIAPI(Key);
            var results = await API.Chat.CreateChatCompletionAsync(new OpenAI_API.Chat.ChatRequest()
            {
                Model = Model.ChatGPTTurbo,
                Temperature = 0.5f,
                MaxTokens = 100,
                Messages = new ChatMessage[]
                {
                    new ChatMessage(ChatMessageRole.User, "Hello!")
                }
            });
            //result = await API.Completions.GetCompletion("hi. you tell me hi?");
            var reply = results.Choices[0].Message;
            result = reply.Content;
            if (!string.IsNullOrWhiteSpace(result))
            {
                MessageBox.Show(result.Replace("\n", ""));
                InformationFind informationFind = new InformationFind();
                informationFind.Show();
                startForm?.Close();
            }
        }

        public static async Task<string> ApiSetting(string request)
        {

            string? responseMessage = "";

            if (API == null) return responseMessage;

            var chat = API.Chat.CreateConversation();


            // 응답메세지
            if(Prompt == 0)
                chat.AppendSystemMessage("You are a professor of electrical engineering. You have to answer the questions of college students by entering examples accurately and specifically.");
            chat.AppendUserInput(request);

            await foreach (var res in chat.StreamResponseEnumerableFromChatbotAsync())
            {
                responseMessage += res;
            }

            return responseMessage;

        }
        
    }
}
