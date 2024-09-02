class Notas(){
    public string Nome;
    public double Tri1;
    public double Tri2;
    public double Tri3;

    public double Media(){
        return  Tri1 + Tri2 + Tri3;
    }

    
    public string VerifMedia(){
        if(Media() < 60 ){
            double Falta = 60 - Media(); 
            return "REPROVADO " + "FALTARAM " + Falta;
            
        }
        else{
            return "APROVADO";
        }
    }
}