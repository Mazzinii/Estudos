 GetReadableTime(0);

 static string GetReadableTime(int seconds)
    {   
        int horas = seconds / 3600;
        int minutos = (seconds % 3600) / 60;
        int segundos = seconds % 60;

        return $"{horas:D2}:{minutos:D2}:{segundos:D2}";
    }

