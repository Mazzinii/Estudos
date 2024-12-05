static ulong[] productFib(ulong prod) {
        
    ulong a = 1, b = 1;
        
    while (a * b < prod)
    {  
        ulong fibonacci = a + b;
        a = b;
        b = fibonacci;
    }
    return new ulong[] {a ,b ,(a * b == prod) ? 1UL : 0UL};
}

productFib(714);