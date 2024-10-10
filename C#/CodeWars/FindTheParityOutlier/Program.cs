

static int Find(int[] integers)
    {
        //iterating array to know if is entirely odd or even
        int[] numberEven = integers.Where(x => x % 2 != 0).ToArray();
        int[] numberOdd = integers.Where(x => x % 2 == 0).ToArray();

        //cheking if the iterating result is equal or less than one 
        //if so return the outlier 
        if (numberEven.Length <= 1) return numberEven[0];
        
        if (numberOdd.Length <= 1) return numberOdd[0];

        return -1;
        
    }

Find([160, 3, 1719, 19, 11, 13, -21]);

