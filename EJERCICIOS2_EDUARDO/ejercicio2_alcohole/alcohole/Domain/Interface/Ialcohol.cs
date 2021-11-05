using System;
namespace alcohole.Domain.Interface
{
    public interface Ialcohol
    {
        void calcularalcoholingerido(string bebida, int cantidad);

         void calcularP(int peso);
    
          String respuesta();
    }

}