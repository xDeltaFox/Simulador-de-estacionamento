using System.Diagnostics;

namespace SimulandoEstacionamento;

public class Tempo
{
    private readonly Stopwatch _tempo = new Stopwatch();
    public TimeSpan TempoReal => _tempo.Elapsed;
    public TimeSpan _ultimotemporeal;
    public TimeSpan TempoQuadroReal;
    public int QuadroPorSegundo = 30;

    public Tempo()
    {
        _tempo.Start();
    }

    public void Atualizar()
    {
        var tempoatual = TempoReal;
        TempoQuadroReal = tempoatual - _ultimotemporeal;
        _ultimotemporeal = tempoatual;
    }
}