namespace NpsApi.Dominio
{
    public class RelatorioNps
    {
        public double Nps { get; }
        public int Promotores { get; }
        public int Detratores { get; }
        public int Total { get; }

        private RelatorioNps(double nps, int promotores, int detratores, int total)
        {
            Nps = nps;
            Promotores = promotores;
            Detratores = detratores;
            Total = total;
        }

        public static RelatorioNps Calcular(IEnumerable<Revisao> revisoes)
        {
            var total = revisoes.Count();
            if (total == 0) return new RelatorioNps(0, 0, 0, 0);

            var promotores = revisoes.Count(r => r.Score >= 4);
            var detratores = revisoes.Count(r => r.Score <= 2);

            var nps = ((double)(promotores - detratores) / total) * 100;
            return new RelatorioNps(nps, promotores, detratores, total);
        }
    }
}
