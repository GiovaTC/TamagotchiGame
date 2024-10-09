public class Tamagotchi
{
    public int Hambre { get; set; }
    public int Felicidad { get; set; }
    public int Energia { get; set; }

    public Tamagotchi()
    {
        Hambre = 50;
        Felicidad = 50;
        Energia = 50;
    }

    public void Alimentar()
    {
        Hambre -= 10;
        Felicidad += 5;
    }

    public void Jugar()
    {
        Felicidad += 10;
        Energia -= 10;
    }

    public void Dormir()
    {
        Energia += 20;
        Hambre += 5;
    }

    public void PasarTiempo()
    {
        Hambre += 5;
        Felicidad -= 3;
        Energia -= 2;
    }
}
