using System;

namespace Eventos2.Interfaces
{
    public interface IObtenerDiferenciaFecha
    {
        int ObtenerDiferenciaDias(DateTime dtFechaBase, DateTime dtFechaComparar);
        int ObtenerDiferenciaMes(DateTime dtFechaBase, DateTime dtFechaComparar);
        int ObtenerDiferenciaHoras(DateTime dtFechaBase, DateTime dtFechaComparar);
        int ObtenerDiferenciaMinutos(DateTime dtFechaBase, DateTime dtFechaComparar);
    }
}
