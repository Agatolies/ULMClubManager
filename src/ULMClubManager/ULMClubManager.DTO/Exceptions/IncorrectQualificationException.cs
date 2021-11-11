﻿using System.Runtime.Serialization;
using ULMClubManager.DTO.Enums;

namespace ULMClubManager.DTO.Exceptions;

/// <summary>
/// Représente une exception pour une qualification incompatible avec la réservation
/// </summary>
[Serializable]
public class IncorrectQualificationException : BusinessException
{
    public IncorrectQualificationException()
        : base(ContextError.RES, "BS_RES_QUAL")
    {
    }

    protected IncorrectQualificationException(ContextError context, string tokenError)
        : base(context, tokenError)
    {
    }

    public IncorrectQualificationException(string message)
        : base(message)
    {
    }

    public IncorrectQualificationException(string message, System.Exception innerException)
        : base(message, innerException)
    {
    }

    protected IncorrectQualificationException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }
}