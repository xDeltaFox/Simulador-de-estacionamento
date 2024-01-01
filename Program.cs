using System.Collections.Immutable;

namespace SimulandoEstacionamento;

public class Program
{
    private static Tempo _tempo = new Tempo();
    private static Estacionamento _estacionamento = new Estacionamento(_tempo);

    public static void Main(string[] args)
    {
        int i = 0;
        while(i < (_tempo.QuadroPorSegundo*20))
        {
            _tempo.Atualizar();


            if(new Random().NextDouble() > 0.8)
                _estacionamento.AdcionarVeiculo("Uno");

            if(new Random().NextDouble() < 0.1 && _estacionamento._vagasocupadas.Count > 5)
                _estacionamento.RemoverVeiculo(_estacionamento._vagasocupadas.Keys.ToImmutableList()[new Random().Next(_estacionamento._vagasocupadas.Count)]);



            Thread.Sleep(TimeSpan.FromMilliseconds(1000/_tempo.QuadroPorSegundo));

            i++;
        }
    }
}