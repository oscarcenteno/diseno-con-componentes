class Sujetos
{
    public static string UnSujetoDeAutenticacionParaUnNacional()
    {
        return "CN=MARCELINO NAVARRO QUIROS (AUTENTICACION)," +
            " OU=CIUDADANO, O=PERSONA FISICA, C=CR, GivenName=MARCELINO," +
            " Surname=NAVARRO QUIROS, SERIALNUMBER=CPF-01-0078-5935";
    }

    public static string UnSujetoDeFirmaParaUnExtranjero()
    {
        return "CN=JOSE MIGUEL SUAREZ GODINEZ (FIRMA)," +
            " OU=EXTRANJERO, O=PERSONA FISICA, C=CR, GivenName=JOSE MIGUEL," +
            " Surname=SUAREZ GODINEZ, SERIALNUMBER=NUP-114145540011";
    }

    public static string UnSujetoDeFirmaParaUnNacional()
    {
        return "CN=MARCELINO NAVARRO QUIROS (FIRMA)," +
            " OU=CIUDADANO, O=PERSONA FISICA, C=CR, GivenName=MARCELINO," +
            " Surname=NAVARRO QUIROS, SERIALNUMBER=CPF-01-0078-5935";
    }

    public static string UnSujetoDeAutenticacionParaUnExtranjero()
    {
        return "CN=JOSE MIGUEL SUAREZ GODINEZ (AUTENTICACION)," +
            " OU=EXTRANJERO, O=PERSONA FISICA, C=CR, GivenName=JOSE MIGUEL," +
            " Surname=SUAREZ GODINEZ, SERIALNUMBER=NUP-114145540011";
    }

    public static string UnSujetoDeAutenticacionParaUnExtranjeroConUnSoloApellido()
    {
        return "CN=JOHN SMITH (AUTENTICACION)," +
            " OU=EXTRANJERO, O=PERSONA FISICA, C=CR, GivenName=JOHN," +
            " Surname=SMITH, SERIALNUMBER=NUP-114145540011";
    }

    public static string UnSujetoDeFirmaParaUnExtranjeroConUnSoloApellido()
    {
        return "CN=JOHN SMITH (FIRMA)," +
            " OU=EXTRANJERO, O=PERSONA FISICA, C=CR, GivenName=JOHN," +
            " Surname=SMITH, SERIALNUMBER=NUP-114145540011";
    }
}