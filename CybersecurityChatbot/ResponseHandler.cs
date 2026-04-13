using System;
using System.Collections.Generic;

namespace CybersecurityChatbot
{
    public class ResponseHandler
    {
        private Dictionary<string, Func<string, string>> responsePatterns;

        public ResponseHandler()
        {
            InitializeResponsePatterns();
        }

        private void InitializeResponsePatterns()
        {
            responsePatterns = new Dictionary<string, Func<string, string>>(StringComparer.OrdinalIgnoreCase)
            {
                { "how are you", (name) => GetHowAreYouResponse() },
                { "how are u", (name) => GetHowAreYouResponse() },
                { "purpose", (name) => GetPurposeResponse() },
                { "what can i ask", (name) => GetQuestionsListResponse() },
                { "what can you do", (name) => GetQuestionsListResponse() },
                { "help", (name) => GetQuestionsListResponse() },
                { "password", (name) => GetPasswordSafetyResponse(name) },
                { "passwords", (name) => GetPasswordSafetyResponse(name) },
                { "phish", (name) => GetPhishingResponse() },
                { "scam", (name) => GetPhishingResponse() },
                { "brows", (name) => GetSafeBrowsingResponse() },
                { "internet safe", (name) => GetSafeBrowsingResponse() },
                { "online safe", (name) => GetSafeBrowsingResponse() },
                { "cyber", (name) => GetGeneralCybersecurityResponse() },
                { "security", (name) => GetGeneralCybersecurityResponse() },
                { "2fa", (name) => GetTwoFactorResponse() },
                { "mfa", (name) => GetTwoFactorResponse() },
                { "two factor", (name) => GetTwoFactorResponse() }
            };
        }

        public string GetResponse(string userInput, string userName)
        {
            foreach (var pattern in responsePatterns)
            {
                if (userInput.Contains(pattern.Key))
                {
                    return pattern.Value(userName);
                }
            }
            return GetDefaultResponse();
        }

        private string GetHowAreYouResponse()
        {
            string[] responses = {
                "I'm doing great, thanks for asking! Ready to help you with cybersecurity!",
                "I'm fantastic! Always excited to talk about online safety! ",
                "Doing well! How can I help you stay secure today?"
            };
            return responses[new Random().Next(responses.Length)];
        }

        private string GetPurposeResponse()
        {
            return "My purpose is to educate and raise awareness about cybersecurity! \n" +
                   "I help people understand online threats and how to protect themselves.\n" +
                   "Think of me as your personal cybersecurity assistant";
        }

        private string GetQuestionsListResponse()
        {
            return " Here's what you can ask me about:\n" +
                   "   • Password safety tips\n" +
                   "   • How to identify phishing emails\n" +
                   "   • Safe browsing practices\n" +
                   "   • Two-factor authentication (2FA)\n" +
                   "   • General cybersecurity advice\n\n" +
                   "Just ask me about any of these topics! ";
        }

        private string GetPasswordSafetyResponse(string userName)
        {
            return $"Great question, {userName}! Here are password safety tips:\n" +
                   "Use long passwords (12+ characters)\n" +
                   "Mix uppercase, lowercase, numbers, and symbols\n" +
                   "Never reuse passwords across different sites\n" +
                   "Use a password manager like PasswordManager or LastPass\n" +
                   "Enable 2FA whenever possible\n" +
                   "Avoid using personal info (birthdays, names)";
        }

        private string GetPhishingResponse()
        {
            return " PHISHING AWARENESS:\n" +
                   "Watch out for these red flags:\n" +
                   "• Urgent or threatening language\n" +
                   "• Spelling and grammar mistakes\n" +
                   "• Suspicious sender email addresses\n" +
                   "• Requests for personal information\n" +
                   "• Links that don't match the claimed sender\n\n" +
                   "Always verify before clicking!";
        }

        private string GetSafeBrowsingResponse()
        {
            return " SAFE BROWSING TIPS:\n" +
                   "Look for 'https://' and padlock icon in address bar\n" +
                   "Keep your browser and extensions updated\n" +
                   "Use ad-blockers and script blockers\n" +
                   "Be cautious of pop-ups and downloads\n" +
                   "Clear cookies and cache regularly\n" +
                   "Use a reputable VPN on public Wi-Fi";
        }

        private string GetGeneralCybersecurityResponse()
        {
            return " GENERAL CYBERSECURITY ADVICE:\n" +
                   "• Keep all software updated\n" +
                   "• Use antivirus and firewall protection\n" +
                   "• Back up important data regularly\n" +
                   "• Be careful what you share on social media\n" +
                   "• Use unique passwords for every account\n" +
                   "• Stay informed about new threats!";
        }

        private string GetTwoFactorResponse()
        {
            return " TWO-FACTOR AUTHENTICATION (2FA):\n" +
                   "2FA adds an extra layer of security by requiring:\n" +
                   "1. Something you KNOW (password)\n" +
                   "2. Something you HAVE (phone/app)\n\n" +
                   "Benefits:\n" +
                   "Protects even if password is stolen\n" +
                   "Works with authenticator apps (Google/Microsoft Auth)\n" +
                   "SMS 2FA is better than nothing, but app-based is safer!\n\n" +
                   "Always enable 2FA when available!";
        }

        private string GetDefaultResponse()
        {
            string[] defaultResponses = {
                "I'm not sure I understood that. Could you rephrase?\nTry asking about: passwords, phishing, safe browsing, or 2FA!",
                "Hmm, I didn't quite catch that. Can you ask me about cybersecurity topics like password safety or phishing?",
                "I'm still learning! Could you ask me something about cybersecurity awareness?\nI can help with passwords, phishing, safe browsing, and more!",
                "Not sure about that one! Why not ask me about online safety, passwords, or how to spot scams?"
            };
            return defaultResponses[new Random().Next(defaultResponses.Length)];
        }
    }
}