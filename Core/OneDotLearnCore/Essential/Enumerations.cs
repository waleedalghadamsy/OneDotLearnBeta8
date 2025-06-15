using System;
using System.Collections.Generic;
using System.Text;

namespace OneDotLearnCore.Essential
{
    public enum EntityStatus : byte
    {
        Active = 1,
        Pending,
        Idle,
    }

    public enum Gender : byte
    {
        Male = 1,
        Female
    }

    public enum Continent : byte
    {
        Africa = 1, Asia, Europe, NorthAmerica, SouthAmerica, Australia
    }

    public enum EnglishNumerals
    {
        One = 1, Two = 2, Three = 3, Four = 4, Five = 5, Six = 6, Seven = 7, Eight = 8, Nine = 9, Ten = 10,
        Eleven = 11, Twelve = 12, Thirteen = 13, Fourteen = 14, Fifteen = 15, Sixteen = 16, Seventeen = 17, Eighteen = 18, Nineteen = 19,
        Twenty = 20, Thirty = 30, Fourty = 40, Fifty = 50, Sixty = 60, Seventy = 70, Eighty = 80, Ninety = 90,
        Hundred = 100, Thousand = 1000, Million = 1000000, Billion = 1000000000
    }

    public enum MeasurementDimension : byte
    {
        None, Piece, Length, Mass, Volume
    }

    public enum PieceUnit : byte
    {
        None, Onepiece = 1, Dozen = 12
    }

    public enum LengthUnit
    {
        None,
        Micrometer = 1, Millimeter = 1000, Centimeter = 10000, Inch = 25400, Foot = 304800, Yard = 914400,
        Meter = 1000000, Kilometer = 1000000000, Mile = 1609344000
    }

    public enum MassUnit : ulong
    {
        None, Microgram = 1, Milligram = 1000, Carat = 200000, Gram = 1000000, Kilogram = 1000000000, 
        Ton = 1000000000000
    }

    public enum VolumeUnit : short
    {
        None, Cubiccentimeter = 1, Milliliter = 1, Liter = 1000
    }

    public enum EntityType : byte
    {
        Course = 1,
        Cycle,
        Instructor
    }

    public enum NotificationStatus : byte
    {
        InOutbox = 1,
        Sent,
        Received,
        Opened
    }

    public enum NotificationAttachmentType : byte
    {
        Picture = 1,
        AudioVideo,
    }

    public enum SortingOption
    {
        ByDate = 1,
        ByStatus,
        ByName,
        ByAddress,
        ByPaymentMethod
    }

    public enum EvaluationDegree : byte
    {
        OneStar = 1,
        TwoStars,
        ThreeStars,
        FourStars,
        FiveStars
    }

    public enum StudyPlaceLevel : byte
    {
        ElementarySchool = 1, PreparatorySchool, SecondarySchool, MidInstitute, HighInstitute, University
    }

    public enum ProductType : byte
    {
        Course = 1,
        Package
    }

    public enum RequestType : byte
    {
        Course = 1,
        Cycle,
        Consultation,
        SWDevelopment
    }
}
