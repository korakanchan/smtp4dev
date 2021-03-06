﻿namespace Rnwood.SmtpServer.Extensions.Auth
{
    public interface IAuthMechanismProcessor
    {
        AuthMechanismProcessorStatus ProcessResponse(string data);

        IAuthenticationCredentials Credentials
        {
            get;
        }
    }
}