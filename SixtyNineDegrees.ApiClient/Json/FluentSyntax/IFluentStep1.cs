﻿namespace SixtyNineDegrees.ApiClient.Json.FluentSyntax
{
    public interface IFluentStep1
    {
        IFluentStep2 To(string relativeUriFormat, params object[] parameters);
    }
}