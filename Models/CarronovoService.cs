namespace BH_Automoveis.Models
{
    public class CarronovoService
    {
    public int CreateCarronovo(Carronovos novoCarro)
    {
        using(var context = new BhautomoveisContext())
        {
            context.Add(novoCarro);
            context.SaveChanges();
            return novoCarro.Id;
        }
    }
}}