using System;
using System.Collections.Generic;
using ULMClubManager.DTO.Enums;
using ULMClubManager.DTO.Exceptions;

namespace ULMClubManager.BL
{

    public static class Rules
    {
        private static Dictionary<ContextError, Dictionary<string, string>> dic;

        static Rules()
        {
            Rules.dic = new Dictionary<ContextError, Dictionary<string, string>>
            {
                { ContextError.MBR, GetMbrDic() },
                { ContextError.RES, GetResDic() }
            };
        }

        private static Dictionary<string, string> GetMbrDic()
        {
            return new Dictionary<string, string>
            {
                { "CHK_MBR_DTE_NAI", "Un membre doit avoir au moins 18 ans." },
                { "CHK_MBR_NOM", "Le nom de famille doit avoir au minimum 3 caractères." },
                { "CHK_MBR_PRN", "Le prénom doit avoir au minimum 3 caractères." },
                { "ERR_LOGIN", "Administrateur ? Le nom d'utilisateur ou le mot de passe est incorrect." },
                { "ERR_ADMIN", "YOU SHALL NOT PAAAAAAAAASS! Vous n'êtes pas administrateur." }
            };
        }

        private static Dictionary<string, string> GetResDic()
        {
            return new Dictionary<string, string>
            {
                { "CHK_RES_DTE", "La date de réservation ne peut pas être supérieure à la date d'encodage plus trois mois." },
                { "CHK_RES_DTE_NOT_IN_PAST", "La date de réservation ne peut pas être passée." },
                { "CHK_RES_HEU_FIN", "La durée d'une réservation doit être comprise entre 1 et 6 heures." },
                { "CHK_RES_IS_VALID_LICENCE", "La date de réservation doit être antérieure à la date d'expiration de la licence + 1 mois." }
            };
        }

        public static string MessageDecoder(ContextError context, string message)
        {
            string msg = message;

            foreach (string clé in Rules.dic[context].Keys)
                if (message.Contains(clé))
                {
                    msg = Rules.dic[context][clé];
                    break;
                }

            return msg;
        }

        public static string MessageDecoder(BusinessException businessException)
        {
            return MessageDecoder(businessException.Context, businessException.TokenError);
        }

        public static string MessageDecoder(DataAccessException dataAccessException)
        {
            return MessageDecoder(dataAccessException.Context, dataAccessException.TokenError);
        }
    }
}
