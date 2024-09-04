class ConversorDeMoedas(){

    public static double Cambio(double cotaçao, double valor){
        valor += valor * 0.06;
        return cotaçao * valor;
    }
}