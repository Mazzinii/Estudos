
using System.Globalization;

class Retangulo(){
    public double Largura;
    public double Altura;

    public double Area(){
        return Largura * Altura;
    }

    public double Perimetro(){
        return (Largura + Altura) * 2;
    }

    public double Diagonal(){
        double diagonal = Largura * Largura + Altura * Altura;
        return Math.Sqrt(diagonal);
    }
}