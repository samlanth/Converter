using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace UnitConverter
{
    // Auteur: Nicolas Chourot
    // Ce source contient le nécessaire pour gérer des unités de mesure et effectuer des conversions

    /// <summary>
    /// Énumération des types d'unité de mesure
    /// </summary>
    public enum UnitType { Distance, Volume, Poids }

    /// <summary>
    /// Conserve les informations concernant une unité de mesure
    /// </summary>
    public class Unit
    {
        // Séparateur des champs d'informations d'une ligne de fichier texte
        private const char StreamLineTokenSeparator = '|';
        /// <summary>
        /// Type d'unité de mesure
        /// </summary>
        public UnitType Type { get; set; }

        /// <summary>
        /// Nom de l'unité de mesure
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Valeur unitaire en système métrique
        /// </summary>
        public Decimal MetricValue { get; set; }

        /// <summary>
        /// Convertion en chaine de caractères
        /// </summary>
        /// <returns>Nom de l'unité de mesure</returns>
        public override string ToString()
        {
            return Name;
        }

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Unit()
        {
            Type = UnitType.Distance;
            Name = "sans nom";
            MetricValue = 0.0M;
        }

        /// <summary>
        /// Converti une chaine de caractère provenant d'un fichier texte en un objet Unit
        /// </summary>
        /// <param name="streamLine"></param>
        /// <returns></returns>
        public static Unit FromStreamLine(string streamLine)
        {
            string[] tokens = streamLine.Split(StreamLineTokenSeparator);
            Unit fromStreamUnit = new Unit();
            try
            {
                fromStreamUnit.Type = (UnitType)int.Parse(tokens[0]);
                fromStreamUnit.Name = tokens[1];
                fromStreamUnit.MetricValue = decimal.Parse(tokens[2].Replace('.', CONVERTER.DecimalSymbol));
            }
            catch (Exception ex)
            {
                // à faire: Afficher le message d'erreur ex.Message
            }
            return fromStreamUnit;
        }

        /// <summary>
        /// Converti en chaine de caractères destinée à être ajoutée dans un fichier
        /// </summary>
        /// <param name="streamLine"></param>
        /// <returns></returns>
        public string ToStreamLine()
        {
            return ((int)Type).ToString() + StreamLineTokenSeparator +
                    Name + StreamLineTokenSeparator +
                    MetricValue.ToString().Replace(CONVERTER.DecimalSymbol, '.');
        }
    }

    /// <summary>
    /// Cette classe (singleton) permet la gestion des unités de mesure et la conversion entre elles.
    /// Elle conserve aussi automatiquement dans le fichier Units.dat du répertoire de l'éxécutable 
    /// toutes les unités de mesure.
    /// </summary>
    public sealed class CONVERTER
    {
        // Déclenchement du constructeur automatique
        private static readonly CONVERTER instance = new CONVERTER();

        // Fichier d'unités de mesure qui sera créé dans le répertoire de l'éxécutable
        private const string UnitsFile = "Units.dat";

        // Liste des unités de mesure
        private static List<Unit> Units;

        /// <summary>
        /// Contient le charactères jouant le rôle de séparateur entre la partie entière et la partie décimale
        /// selon la location du système d'opération de l'utilisateur
        /// </summary>
        public static char DecimalSymbol { get; set; }

        /// <summary>
        /// Contructeur et initialisation de la liste des unités de mesure de base
        /// </summary>
        private CONVERTER()
        {
            // Déterminer le symbole du point décimal (virgule ou point selon la localisation)
            DecimalSymbol = (System.Threading.Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName == "fr" ? ',' : '.');

            // Lire le fichier des unités de mesure
            ReadUnitList();
        }

        // Lecture du fichier d'unités de mesure se trouvant dans le répertoire de l'éxécutable.
        // Si le fichier n'existe pas encore, initialiser la liste d'unités de mesure et ensuite
        // créer le fichier
        private static void ReadUnitList()
        {
            if (File.Exists(UnitsFile))
            {
                Units = new List<Unit>();
                StreamReader sr = new StreamReader(UnitsFile);
                while (!sr.EndOfStream)
                {
                    Units.Add(Unit.FromStreamLine(sr.ReadLine()));
                }
                sr.Close();
            }
            else
            {
                InitUnitList();
                WriteUnitList();
            }
        }

        // Création/mise à jour du fichier d'unité de mesure
        private static void WriteUnitList()
        {
            StreamWriter sw = new StreamWriter(UnitsFile);
            foreach (Unit unit in Units)
            {
                sw.WriteLine(unit.ToStreamLine());
            }
            sw.Close();
        }

        // Initialisation de la liste d'unités de mesure de base
        private static void InitUnitList()
        {
            Units = new List<Unit>();
            /////////////////////////////////////////////////////////////////////////////////////////////
            // Distance métrique
            Add(new Unit { Type = UnitType.Distance, Name = "millimètres", MetricValue = 0.001M });
            Add(new Unit { Type = UnitType.Distance, Name = "centimètres", MetricValue = 0.01M });
            Add(new Unit { Type = UnitType.Distance, Name = "mètres", MetricValue = 1M });
            Add(new Unit { Type = UnitType.Distance, Name = "kilomètres", MetricValue = 1000M });

            // Distance impériale UK/US
            Add(new Unit { Type = UnitType.Distance, Name = "pieds", MetricValue = 0.3048M });
            Add(new Unit { Type = UnitType.Distance, Name = "pouces", MetricValue = 0.0254M });
            Add(new Unit { Type = UnitType.Distance, Name = "verges", MetricValue = 0.9144M });
            Add(new Unit { Type = UnitType.Distance, Name = "milles", MetricValue = 1609.344M });
            Add(new Unit { Type = UnitType.Distance, Name = "milles marin", MetricValue = 1852.0M });

            /////////////////////////////////////////////////////////////////////////////////////////////
            // Volume métrique
            Add(new Unit { Type = UnitType.Volume, Name = "millilitres", MetricValue = 0.001M });
            Add(new Unit { Type = UnitType.Volume, Name = "centimètres cube", MetricValue = 0.001M });
            Add(new Unit { Type = UnitType.Volume, Name = "litres", MetricValue = 1M });
            Add(new Unit { Type = UnitType.Volume, Name = "mètres cube", MetricValue = 1000M });

            // Volume impérial UK/US
            Add(new Unit { Type = UnitType.Volume, Name = "onces UK", MetricValue = 0.0284130625M });
            Add(new Unit { Type = UnitType.Volume, Name = "onces US", MetricValue = 0.0295735295625M });
            Add(new Unit { Type = UnitType.Volume, Name = "pouces cube", MetricValue = 0.016387063999928M });
            Add(new Unit { Type = UnitType.Volume, Name = "pieds cube", MetricValue = 28.316846592392M });
            Add(new Unit { Type = UnitType.Volume, Name = "pintes UK", MetricValue = 0.56826125M });
            Add(new Unit { Type = UnitType.Volume, Name = "pintes US", MetricValue = 0.473176473M });
            Add(new Unit { Type = UnitType.Volume, Name = "gallons UK", MetricValue = 4.54609M });
            Add(new Unit { Type = UnitType.Volume, Name = "gallons US", MetricValue = 3.785411784M });
            Add(new Unit { Type = UnitType.Volume, Name = "barils de pétrole", MetricValue = 158.98729492881M });

            /////////////////////////////////////////////////////////////////////////////////////////////
            // Poids métrique
            Add(new Unit { Type = UnitType.Poids, Name = "milligrammes", MetricValue = 0.000001M });
            Add(new Unit { Type = UnitType.Poids, Name = "grammes", MetricValue = 0.001M });
            Add(new Unit { Type = UnitType.Poids, Name = "kilogrammes", MetricValue = 1M });
            Add(new Unit { Type = UnitType.Poids, Name = "tonnes", MetricValue = 1000M });

            // Poids impérial UK/US
            Add(new Unit { Type = UnitType.Poids, Name = "onces", MetricValue = 0.028349523125M });
            Add(new Unit { Type = UnitType.Poids, Name = "livres", MetricValue = 0.45359237000021M });
            Add(new Unit { Type = UnitType.Poids, Name = "tonnes UK", MetricValue = 1016.0536476326M });
            Add(new Unit { Type = UnitType.Poids, Name = "tonnes US", MetricValue = 907.19404880704M });
        }

        /// <summary>
        /// Ajout d'une unité de mesure
        /// </summary>
        /// <param name="unit">Unité de mesure à ajouter</param>
        public static void Add(Unit unit)
        {
            Units.Add(unit);
            WriteUnitList();
        }

        /// <summary>
        /// Retrait d'une unité de mesure
        /// </summary>
        /// <param name="unit">Unité de mesure à retirer</param>
        public static void Delete(Unit unit)
        {
            Units.Remove(unit);
            WriteUnitList();
        }

        /// <summary>
        /// Retrait d'une unité de mesure en spécifaint son nom
        /// </summary>
        /// <param name="name">Nom de l'unité de mesure</param>
        public static void DeleteByName(string name)
        {
            Unit unitFound = GetUnitByName(name);
            if (unitFound != null)
            {
                Units.Remove(unitFound);
                WriteUnitList();
            }
        }

        /// <summary>
        /// Obtenir la liste des unités de mesure correspondantes au type d'unité de mesure
        /// </summary>
        /// <param name="unitType">Type d'unité de mesure</param>
        /// <returns></returns>
        public static List<Unit> GetUnitsByType(UnitType unitType)
        {
            List<Unit> unitsByType = new List<Unit>();
            foreach (Unit unit in Units)
            {
                if (unit.Type == unitType)
                    unitsByType.Add(unit);
            }
            return unitsByType;
        }

        /// <summary>
        /// Obtenir la liste de toutes les unités de mesure en ordre alphabétique de nom
        /// </summary>
        /// <returns></returns>
        public static List<Unit> GetAllUnits()
        {
            return Units.OrderBy(u => u.Name).ToList();
        }

        /// <summary>
        /// Obtenir l'unité de mesure par son nom
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Nom de l'unité de mesure</returns>
        private static Unit GetUnitByName(string name)
        {
            foreach (Unit unit in Units)
            {
                if (unit.Name == name)
                    return unit;
            }
            return null;
        }

        /// <summary>
        /// Convertion d'une valeur
        /// </summary>
        /// <param name="value">Valeur à convertir</param>
        /// <param name="fromUnit">Unité de mesure de la valeur à convertir</param>
        /// <param name="toUnit">Unité de mesure de la valeur convertie</param>
        /// <param name="nbDecimal">Nombre de chiffres décimaux maximum pour la valeur convertie</param>
        /// <returns>La valeur convertie sous forme de chaine de caractères</returns>
        public static string Convert(decimal value, Unit fromUnit, Unit toUnit, int nbDecimal = 3)
        {
            decimal converted_Value = 0;

            try
            {
                converted_Value = Math.Round(value * (fromUnit.MetricValue / toUnit.MetricValue), nbDecimal);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return converted_Value.ToString();
        }

        /// <summary>
        /// Convertion d'une valeur
        /// </summary>
        /// <param name="stringValue">Valeur à convertir sous forme de chaine de caractères</param>
        /// <param name="fromUnitName">Nom de l'unité de mesure de la valeur à convertir</param>
        /// <param name="toUnitName">Nom de l'unité de mesure de la valeur convertie</param>
        /// <param name="nbDecimal">Nombre de chiffres décimaux maximum pour la valeur convertie</param>
        /// <returns>La valeur convertie sous forme de chaine de caractères</returns>
        public static string Convert(string stringValue, string fromUnitName, string toUnitName, int nbDecimal = 3)
        {
            decimal value = 0;

            if (stringValue == "." || stringValue == ",")
                stringValue = "0";

            try
            {
                value = decimal.Parse(stringValue, System.Globalization.NumberStyles.AllowDecimalPoint);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

            Unit fromUnit = GetUnitByName(fromUnitName);
            Unit toUnit = GetUnitByName(toUnitName);

            if ((fromUnit == null) || (toUnit == null))
                return "Unités introuvables";

            if (fromUnit.Type != toUnit.Type)
                return "unités incompatibles";

            return Convert(value, fromUnit, toUnit, nbDecimal).ToString();
        }
     }
}
