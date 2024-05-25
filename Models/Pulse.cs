using SynaptiPulse.Utils;
using System.ComponentModel;
using System.Globalization;

namespace SynaptiPulse.Models
{
    /// <summary>
    /// Classe que define o objeto Pulse que aparece no grid
    /// </summary>
    public class Pulse
    {
        #region Static fields

        private static readonly Dictionary<string, int> columSizeFromProperties = ReflectionHandler.GetFromProperties_ColumnSizeAttribute<Pulse>();
        private static readonly Dictionary<string, string> displayNameFromProperties = ReflectionHandler.GetFromProperties_DisplayNameAttributes<Pulse>();

        private static readonly Dictionary<PulsePolariy, string> pulsePolarityToCombobox = ReflectionHandler.GetFromEnum_DescriptionAttributes<PulsePolariy>();
        private static readonly Dictionary<PulseCurrents, string> pulseCurrentToCombobox = ReflectionHandler.GetFromEnum_DescriptionAttributes<PulseCurrents>();
        private static readonly Dictionary<MeasureUnity, string> measureUnityToCombobox = ReflectionHandler.GetFromEnum_DescriptionAttributes<MeasureUnity>();

        private static readonly Dictionary<PulsePolariy, double> pulsePolarityValues = ReflectionHandler.GetFromEnum_DefaultValueAttributes<PulsePolariy>();
        private static readonly Dictionary<PulseCurrents, double> pulseCurrentValues = ReflectionHandler.GetFromEnum_DefaultValueAttributes<PulseCurrents>();
        private static readonly Dictionary<MeasureUnity, double> measureUnityValues = ReflectionHandler.GetFromEnum_DefaultValueAttributes<MeasureUnity>();

        private static readonly Dictionary<string, string> measureUnity_DefaultToAmbientRelation = ReflectionHandler.GetFromEnum_DescriptionAndAmbientValueAttributes<MeasureUnity>();

        #endregion

        public const string SingleLayout = $"|{nameof(Pulse.AfterPulseLength)}|{nameof(Pulse.AfterPulseMeasureUnity)}";
        public const string CompleteLayout = $"|{nameof(Pulse.PulseLength)}|{nameof(Pulse.PulseMeasureUnity)}|{nameof(Pulse.AfterPulseLength)}|{nameof(Pulse.AfterPulseMeasureUnity)}|{nameof(Pulse.Polarity)}|{nameof(Pulse.Current)}";

        public Pulse() { }

        #region Encapsulated Properties to Static Fields

        public static Dictionary<string, int> ColumSizeFromProperties { get => columSizeFromProperties; }
        public static Dictionary<string, string> DisplayNameFromProperties { get => displayNameFromProperties; }

        public static Dictionary<PulsePolariy, string> PulsePolarityToCombobox { get => pulsePolarityToCombobox; }
        public static Dictionary<PulseCurrents, string> PulseCurrentToCombobox { get => pulseCurrentToCombobox; }
        public static Dictionary<MeasureUnity, string> MeasureUnityToCombobox { get => measureUnityToCombobox; }

        public static Dictionary<PulsePolariy, double> PulsePolarityValues { get => pulsePolarityValues; }
        public static Dictionary<PulseCurrents, double> PulseCurrentValues { get => pulseCurrentValues; }
        public static Dictionary<MeasureUnity, double> MeasureUnityValues { get => measureUnityValues; }

        public static Dictionary<string, string> MeasureUnity_DefaultToAmbientRelation { get => measureUnity_DefaultToAmbientRelation; }

        #endregion

        #region Display Grid Properties

        #region Largura do Pulso

        private double _pulseLength = 100;

        [DisplayName("Largura do Pulso"), ColumnSize(90)]
        public double PulseLength
        {
            get { return _pulseLength; }
            set
            {
                var val = double.Parse(value.ToString().Replace(",", "."), CultureInfo.InvariantCulture);
                if (PulseMeasureUnity.Equals(MeasureUnity.Microseconds)) _pulseLength = Math.Round(val, 0);
                else _pulseLength = val;
            }
        }

        #endregion

        #region Intervalo entre Pulsos

        private double _afterPulseLength = 100;

        [DisplayName("Intervalo entre Pulsos"), ColumnSize(110)]
        public double AfterPulseLength
        {
            get { return _afterPulseLength; }
            set
            {
                var val = double.Parse(value.ToString().Replace(",", "."), CultureInfo.InvariantCulture);
                if (PulseMeasureUnity.Equals(MeasureUnity.Microseconds)) _afterPulseLength = Math.Round(val, 0);
                else _afterPulseLength = val;
            }
        }

        #endregion

        [DisplayName("Unidade de medida da largura do pulso"), ColumnSize(180)]
        public string PulseMeasureUnity { get; set; } = measureUnityToCombobox[MeasureUnity.Microseconds];

        [DisplayName("Unidade de medida do Intervalo entre pulsos"), ColumnSize(180)]
        public string AfterPulseMeasureUnity { get; set; } = measureUnityToCombobox[MeasureUnity.Milliseconds];

        [DisplayName("Corrente [uA]"), ColumnSize(90)]
        public string Current { get; set; } = pulseCurrentToCombobox[PulseCurrents.Hundred];

        [DisplayName("Polaridade [uA]"), ColumnSize(90)]
        public string Polarity { get; set; } = pulsePolarityToCombobox[PulsePolariy.Positive];

        #endregion

        public override string ToString()
        {
            string separator = "$";
            return $"SET{separator}{Current}{separator}{Polarity}{separator}{PulseLength}{measureUnity_DefaultToAmbientRelation[PulseMeasureUnity]}{separator}{AfterPulseLength}{measureUnity_DefaultToAmbientRelation[AfterPulseMeasureUnity]}>";
        }
    }

}