

static int SumIntervals((int, int)[] intervals)
    {
        Array.Sort(intervals, (x,y) => x.Item1 - y.Item1);
        int max = int.MinValue;
        int total = 0;
        foreach (var interval in intervals) 
        {
            max = Math.Max(max, interval.Item1);
            total += Math.Max(0, interval.Item2 - max);
            max = Math.Max(max, interval.Item2);
        }
        return total;
    }


SumIntervals([(1, 5), (10, 20), (1, 6), (16, 19), (5, 11)]);    

/*
// Ordena os intervalos com base no início de cada intervalo
        var sortedIntervals = intervals.OrderBy(interval => interval.Item1).ToList();

        List<(int, int)> mergedIntervals = new List<(int, int)>();

        foreach (var interval in sortedIntervals)
        {
            // Se a lista de intervalos mesclados estiver vazia ou o intervalo atual não se sobrepõe ao último intervalo
            if (mergedIntervals.Count == 0 || mergedIntervals.Last().Item2 < interval.Item1)
            {
                // Não há sobreposição, apenas adiciona o intervalo
                mergedIntervals.Add(interval);
            }
            else
            {
                // Há sobreposição, mescla os intervalos
                var last = mergedIntervals.Last();
                mergedIntervals[mergedIntervals.Count - 1] = (last.Item1, Math.Max(last.Item2, interval.Item2));
            }
        }

        // Soma os comprimentos dos intervalos mesclados
        int result = 0;
        foreach (var interval in mergedIntervals)
        {
            result += interval.Item2 - interval.Item1;
        }

        return result;
    }
*/

/*
int result = 0; 
       for(int i = 0; i < intervals.Length; i++){
            if(intervals[i].Item1 == intervals[i].Item2) result+= 0;
            else{
                if(intervals[i].Item1 < intervals[i].Item2)
                result += - intervals[i].Item1 + intervals[i].Item2;
                else result += intervals[i].Item1 + intervals[i].Item2;
            }
       }
       return result;
*/       


/*
       int result = 0; 
       if(intervals[0].Item1 == intervals[0].Item2) result = 0;
       List<int> count = new List<int>();
       for(int i = 0; i < intervals.Length; i++ ){
        while(intervals[i].Item1 != intervals[i].Item2){
            intervals[i].Item1 = intervals[i].Item1 + 1;
            count.Add(intervals[i].Item1);
        }
       }
       result = count.Distinct().Count();
       return result;
*/