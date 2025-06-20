using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace OneDotLearnCore.Training
{
    public enum ProductCategory : byte
    {
        Normal = 1,
        Rapid,
        Expert,
        Marvel,
        Package
    }

    public enum ProductStatus : byte
    {
        Proposed = 1,
        Requested,
        Planned,
        Reserved,
        Running,
        Withheld,
        Cancelled
    }

    public enum CycleStartTime : byte
    {
        NineAm = 9,
        TwoPm = 14,
        SixPm = 18,
    }

    public enum CycleStatus : byte
    {
        Proposed = 1,
        Requested,
        Planned,
        Reserved,
        Started,
        Paused,
        Cancelled,
        Finished
    }

    public enum ProductLevel : byte
    {
        Beginner = 1,
        Advanced,
        Expert,
        Marvel
    }

    public enum RequestSource : byte
    {
        Trainee = 1,
        Instructor,
    }

    public enum EnglishTrainingLevel : byte
    {
        Beginner = 1,
        LowerIntermediate,
        Intermediate,
        UpperIntermediate,
        Advanced,
    }

    public enum EvaluationDegree : byte
    {
        OneStar = 1,
        TwoStars,
        ThreeStars,
        FourStars,
        FiveStars
    }
}