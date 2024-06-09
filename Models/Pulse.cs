using BrainStimulator.Utils;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;

namespace BrainStimulator.Models
{
    /// <summary>
    /// Classe que define o objeto Pulse que aparece no grid
    /// </summary>
    public class Pulse
    {
        private const string separator = "$";
        #region Static fields

        public static readonly Dictionary<string, int> columSizeFromProperties = ReflectionHandler.GetFromProperties_ColumnSizeAttribute<Pulse>();
        public static readonly Dictionary<string, string> displayNameFromProperties = ReflectionHandler.GetFromProperties_DisplayNameAttributes<Pulse>();

        public static readonly Dictionary<PulsePolariy, string> pulsePolarityToCombobox = ReflectionHandler.GetFromEnum_DescriptionAttributes<PulsePolariy>();
        public static readonly Dictionary<PulseCurrents, string> pulseCurrentToCombobox = ReflectionHandler.GetFromEnum_DescriptionAttributes<PulseCurrents>();
        public static readonly Dictionary<MeasureUnity, string> measureUnityToCombobox = ReflectionHandler.GetFromEnum_DescriptionAttributes<MeasureUnity>();
                       
        public static readonly Dictionary<PulsePolariy, double> pulsePolarityValues = ReflectionHandler.GetFromEnum_DefaultValueAttributes<PulsePolariy>();
        public static readonly Dictionary<PulseCurrents, double> pulseCurrentValues = ReflectionHandler.GetFromEnum_DefaultValueAttributes<PulseCurrents>();
        public static readonly Dictionary<MeasureUnity, double> measureUnityValues = ReflectionHandler.GetFromEnum_DefaultValueAttributes<MeasureUnity>();
                       
        public static readonly Dictionary<string, string> measureUnity_DefaultToAmbientRelation= ReflectionHandler.GetFromEnum_DescriptionAndAmbientValueAttributes<MeasureUnity>();

        public const string Layout = $"|{nameof(Pulse.PulseLength)}|{nameof(Pulse.PulseMeasureUnity)}|{nameof(Pulse.AfterPulseLength)}"
                                    + $"|{nameof(Pulse.AfterPulseMeasureUnity)}|{nameof(Pulse.Polarity)}";
        //+ $"|{nameof(Pulse.AfterPulseMeasureUnity)}|{nameof(Pulse.Current)}|{nameof(Pulse.Polarity)}";

        #endregion

        public Pulse(){}

        public Pulse(string newLine)
        {
            this.FromString(newLine);
        }

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

        public override string ToString()
        {            
            return $"SET{separator}{Current}{separator}{Polarity}{separator}{PulseLength}{measureUnity_DefaultToAmbientRelation[PulseMeasureUnity]}{separator}{AfterPulseLength}{measureUnity_DefaultToAmbientRelation[AfterPulseMeasureUnity]}>";
        }

        public void FromString(string pulseLikeString)
        {
            var splitedString = pulseLikeString.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            this.Current = splitedString[1];
            string pulsePolarityValue = splitedString[2];
            PulsePolariy polarity = pulsePolarityToCombobox.Where(p => p.Value == pulsePolarityValue).FirstOrDefault().Key;
            this.Polarity = pulsePolarityToCombobox[polarity];

            string pulse = splitedString[3].Substring(0, splitedString[3].Length - 1);
            string measure = Convert.ToString(splitedString[3].Last());
            this.PulseLength = Convert.ToDouble(pulse);
            this.PulseMeasureUnity = measureUnity_DefaultToAmbientRelation.Where(p => p.Value == measure).FirstOrDefault().Key;

            splitedString[4] = splitedString[4].Remove(splitedString[4].Length - 1, 1);
            pulse = splitedString[4].Substring(0, splitedString[4].Length - 1);
            measure = Convert.ToString(splitedString[4].Last());
            this.AfterPulseLength = Convert.ToDouble(pulse);
            this.AfterPulseMeasureUnity = measureUnity_DefaultToAmbientRelation.Where(p => p.Value == measure).FirstOrDefault().Key;
        }
    }

}