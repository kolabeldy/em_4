﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace em.Properties {
    using System;
    
    
    /// <summary>
    ///   Класс ресурса со строгой типизацией для поиска локализованных строк и т.д.
    /// </summary>
    // Этот класс создан автоматически классом StronglyTypedResourceBuilder
    // с помощью такого средства, как ResGen или Visual Studio.
    // Чтобы добавить или удалить член, измените файл .ResX и снова запустите ResGen
    // с параметром /str или перестройте свой проект VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Возвращает кэшированный экземпляр ResourceManager, использованный этим классом.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("em.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Перезаписывает свойство CurrentUICulture текущего потока для всех
        ///   обращений к ресурсу с помощью этого класса ресурса со строгой типизацией.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на SELECT r1.IdProduct as Id, 
        ///ROUND(SUM(r1.FactCost) / (SUM(r2.Produced) / 1000), 2) as Value
        ///FROM
        ///(SELECT Period, IdProduct, ProductName, ROUND(SUM(FactCost), 1) as FactCost
        ///FROM
        ///(SELECT o.Period, o.IdProduct, o.ProductName, Produced, o.IdER, o.Name, 
        ///CASE WHEN (o.IdER = 950 OR IdER = 951) THEN o.Fact / 1000 ELSE o.Fact END as Fact, 
        ///CASE WHEN(o.IdER = 950 OR IdER = 951) THEN (o.Fact / 1000) * t.Value / 1000 ELSE o.Fact * t.Value / 1000 END as FactCost
        ///FROM 
        ///(SELECT Period, IdProduct, ProductName, P [остаток строки не уместился]&quot;;.
        /// </summary>
        internal static string sqlAllTariffs {
            get {
                return ResourceManager.GetString("sqlAllTariffs", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на SELECT * FROM CostCenters  #whereStr ORDER BY Id.
        /// </summary>
        internal static string sqlCostCenters_ToList {
            get {
                return ResourceManager.GetString("sqlCostCenters_ToList", resourceCulture);
            }
        }
    }
}
