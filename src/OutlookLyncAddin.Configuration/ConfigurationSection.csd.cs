//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OutlookLinkAddin.Configuration
{
    
    
    /// <summary>
    /// The OutloookLyncAddinSection Configuration Section.
    /// </summary>
    public partial class OutloookLyncAddinSection : global::System.Configuration.ConfigurationSection
    {
        
        #region Singleton Instance
        /// <summary>
        /// The XML name of the OutloookLyncAddinSection Configuration Section.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string OutloookLyncAddinSectionSectionName = "outloookLyncAddin";
        
        /// <summary>
        /// The XML path of the OutloookLyncAddinSection Configuration Section.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string OutloookLyncAddinSectionSectionPath = "outloookLyncAddin";
        
        /// <summary>
        /// Gets the OutloookLyncAddinSection instance.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public static global::OutlookLinkAddin.Configuration.OutloookLyncAddinSection Instance
        {
            get
            {
                return ((global::OutlookLinkAddin.Configuration.OutloookLyncAddinSection)(global::System.Configuration.ConfigurationManager.GetSection(global::OutlookLinkAddin.Configuration.OutloookLyncAddinSection.OutloookLyncAddinSectionSectionPath)));
            }
        }
        #endregion
        
        #region Xmlns Property
        /// <summary>
        /// The XML name of the <see cref="Xmlns"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string XmlnsPropertyName = "xmlns";
        
        /// <summary>
        /// Gets the XML namespace of this Configuration Section.
        /// </summary>
        /// <remarks>
        /// This property makes sure that if the configuration file contains the XML namespace,
        /// the parser doesn't throw an exception because it encounters the unknown "xmlns" attribute.
        /// </remarks>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::OutlookLinkAddin.Configuration.OutloookLyncAddinSection.XmlnsPropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public string Xmlns
        {
            get
            {
                return ((string)(base[global::OutlookLinkAddin.Configuration.OutloookLyncAddinSection.XmlnsPropertyName]));
            }
        }
        #endregion
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
        
        #region PhonePatterns Property
        /// <summary>
        /// The XML name of the <see cref="PhonePatterns"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string PhonePatternsPropertyName = "phonePatterns";
        
        /// <summary>
        /// Gets or sets the PhonePatterns.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        [global::System.ComponentModel.DescriptionAttribute("The PhonePatterns.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::OutlookLinkAddin.Configuration.OutloookLyncAddinSection.PhonePatternsPropertyName, IsRequired=true, IsKey=false, IsDefaultCollection=false)]
        public virtual global::OutlookLinkAddin.Configuration.PhonePatternCollection PhonePatterns
        {
            get
            {
                return ((global::OutlookLinkAddin.Configuration.PhonePatternCollection)(base[global::OutlookLinkAddin.Configuration.OutloookLyncAddinSection.PhonePatternsPropertyName]));
            }
            set
            {
                base[global::OutlookLinkAddin.Configuration.OutloookLyncAddinSection.PhonePatternsPropertyName] = value;
            }
        }
        #endregion
    }
}
namespace OutlookLinkAddin.Configuration
{
    
    
    /// <summary>
    /// The PhonePatternElement Configuration Element.
    /// </summary>
    public partial class PhonePatternElement : global::System.Configuration.ConfigurationElement
    {
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
        
        #region Value Property
        /// <summary>
        /// The XML name of the <see cref="Value"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string ValuePropertyName = "value";
        
        /// <summary>
        /// Gets or sets the Value.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        [global::System.ComponentModel.DescriptionAttribute("The Value.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::OutlookLinkAddin.Configuration.PhonePatternElement.ValuePropertyName, IsRequired=true, IsKey=true, IsDefaultCollection=false)]
        public virtual string Value
        {
            get
            {
                return ((string)(base[global::OutlookLinkAddin.Configuration.PhonePatternElement.ValuePropertyName]));
            }
            set
            {
                base[global::OutlookLinkAddin.Configuration.PhonePatternElement.ValuePropertyName] = value;
            }
        }
        #endregion
    }
}
namespace OutlookLinkAddin.Configuration
{
    
    
    /// <summary>
    /// A collection of PhonePatternElement instances.
    /// </summary>
    [global::System.Configuration.ConfigurationCollectionAttribute(typeof(global::OutlookLinkAddin.Configuration.PhonePatternElement), CollectionType=global::System.Configuration.ConfigurationElementCollectionType.BasicMapAlternate, AddItemName=global::OutlookLinkAddin.Configuration.PhonePatternCollection.PhonePatternElementPropertyName)]
    public partial class PhonePatternCollection : global::System.Configuration.ConfigurationElementCollection
    {
        
        #region Constants
        /// <summary>
        /// The XML name of the individual <see cref="global::OutlookLinkAddin.Configuration.PhonePatternElement"/> instances in this collection.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string PhonePatternElementPropertyName = "pattern";
        #endregion
        
        #region Overrides
        /// <summary>
        /// Gets the type of the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <returns>The <see cref="global::System.Configuration.ConfigurationElementCollectionType"/> of this collection.</returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public override global::System.Configuration.ConfigurationElementCollectionType CollectionType
        {
            get
            {
                return global::System.Configuration.ConfigurationElementCollectionType.BasicMapAlternate;
            }
        }
        
        /// <summary>
        /// Gets the name used to identify this collection of elements
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        protected override string ElementName
        {
            get
            {
                return global::OutlookLinkAddin.Configuration.PhonePatternCollection.PhonePatternElementPropertyName;
            }
        }
        
        /// <summary>
        /// Indicates whether the specified <see cref="global::System.Configuration.ConfigurationElement"/> exists in the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <param name="elementName">The name of the element to verify.</param>
        /// <returns>
        /// <see langword="true"/> if the element exists in the collection; otherwise, <see langword="false"/>.
        /// </returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        protected override bool IsElementName(string elementName)
        {
            return (elementName == global::OutlookLinkAddin.Configuration.PhonePatternCollection.PhonePatternElementPropertyName);
        }
        
        /// <summary>
        /// Gets the element key for the specified configuration element.
        /// </summary>
        /// <param name="element">The <see cref="global::System.Configuration.ConfigurationElement"/> to return the key for.</param>
        /// <returns>
        /// An <see cref="object"/> that acts as the key for the specified <see cref="global::System.Configuration.ConfigurationElement"/>.
        /// </returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        protected override object GetElementKey(global::System.Configuration.ConfigurationElement element)
        {
            return ((global::OutlookLinkAddin.Configuration.PhonePatternElement)(element)).Value;
        }
        
        /// <summary>
        /// Creates a new <see cref="global::OutlookLinkAddin.Configuration.PhonePatternElement"/>.
        /// </summary>
        /// <returns>
        /// A new <see cref="global::OutlookLinkAddin.Configuration.PhonePatternElement"/>.
        /// </returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        protected override global::System.Configuration.ConfigurationElement CreateNewElement()
        {
            return new global::OutlookLinkAddin.Configuration.PhonePatternElement();
        }
        #endregion
        
        #region Indexer
        /// <summary>
        /// Gets the <see cref="global::OutlookLinkAddin.Configuration.PhonePatternElement"/> at the specified index.
        /// </summary>
        /// <param name="index">The index of the <see cref="global::OutlookLinkAddin.Configuration.PhonePatternElement"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public global::OutlookLinkAddin.Configuration.PhonePatternElement this[int index]
        {
            get
            {
                return ((global::OutlookLinkAddin.Configuration.PhonePatternElement)(base.BaseGet(index)));
            }
        }
        
        /// <summary>
        /// Gets the <see cref="global::OutlookLinkAddin.Configuration.PhonePatternElement"/> with the specified key.
        /// </summary>
        /// <param name="value">The key of the <see cref="global::OutlookLinkAddin.Configuration.PhonePatternElement"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public global::OutlookLinkAddin.Configuration.PhonePatternElement this[object value]
        {
            get
            {
                return ((global::OutlookLinkAddin.Configuration.PhonePatternElement)(base.BaseGet(value)));
            }
        }
        #endregion
        
        #region Add
        /// <summary>
        /// Adds the specified <see cref="global::OutlookLinkAddin.Configuration.PhonePatternElement"/> to the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <param name="pattern">The <see cref="global::OutlookLinkAddin.Configuration.PhonePatternElement"/> to add.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public void Add(global::OutlookLinkAddin.Configuration.PhonePatternElement pattern)
        {
            base.BaseAdd(pattern);
        }
        #endregion
        
        #region Remove
        /// <summary>
        /// Removes the specified <see cref="global::OutlookLinkAddin.Configuration.PhonePatternElement"/> from the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <param name="pattern">The <see cref="global::OutlookLinkAddin.Configuration.PhonePatternElement"/> to remove.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public void Remove(global::OutlookLinkAddin.Configuration.PhonePatternElement pattern)
        {
            base.BaseRemove(this.GetElementKey(pattern));
        }
        #endregion
        
        #region GetItem
        /// <summary>
        /// Gets the <see cref="global::OutlookLinkAddin.Configuration.PhonePatternElement"/> at the specified index.
        /// </summary>
        /// <param name="index">The index of the <see cref="global::OutlookLinkAddin.Configuration.PhonePatternElement"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public global::OutlookLinkAddin.Configuration.PhonePatternElement GetItemAt(int index)
        {
            return ((global::OutlookLinkAddin.Configuration.PhonePatternElement)(base.BaseGet(index)));
        }
        
        /// <summary>
        /// Gets the <see cref="global::OutlookLinkAddin.Configuration.PhonePatternElement"/> with the specified key.
        /// </summary>
        /// <param name="value">The key of the <see cref="global::OutlookLinkAddin.Configuration.PhonePatternElement"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public global::OutlookLinkAddin.Configuration.PhonePatternElement GetItemByKey(string value)
        {
            return ((global::OutlookLinkAddin.Configuration.PhonePatternElement)(base.BaseGet(((object)(value)))));
        }
        #endregion
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
    }
}
