using System.Text.Json;

namespace Wamby.PreviousScansPersistence
{
    public class PreviousScansPersistenceService
    {
        public void SavePreviousScans(IList<PreviousScan> scans)
        {
            var content = JsonSerializer.Serialize(scans, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(PreviousScan.FILENAME, content);
        }

        public List<PreviousScan>? LoadPreviousScans()
        {
            if (File.Exists(PreviousScan.FILENAME))
            {
                var content = File.ReadAllText(PreviousScan.FILENAME);
                return JsonSerializer.Deserialize<List<PreviousScan>>(content);
            }
            else
            {
                return new List<PreviousScan>();
            }
        }
    }
}