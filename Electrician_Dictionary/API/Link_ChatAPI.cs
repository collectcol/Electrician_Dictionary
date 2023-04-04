using OpenAI_API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrician_Dictionary.API
{
    internal static class Link_ChatAPI
    {
        private static OpenAIAPI? API { get; set; }
        private static string? Key { get; set; }

        public static void KeySetting(string key)
        {
            Key = key;
        }

        async public static void Link()
        {
            API = new OpenAIAPI(Key);
            var result = await API.Completions.GetCompletion("One Two Three One Two");
        }

        public static async Task<StringBuilder> ApiSetting(string request)
        {
            
            StringBuilder responseMessage = new StringBuilder();

            if (API == null) return responseMessage;

            var chat = API.Chat.CreateConversation();

            chat.AppendSystemMessage("You are a professor of electrical engineering. You can answer college students' questions accurately and concisely.");
            chat.AppendUserInput(request);

            await foreach (var res in chat.StreamResponseEnumerableFromChatbotAsync())
            {
                responseMessage.Append(res);
            }

            return responseMessage;

        }
        
    }
}
