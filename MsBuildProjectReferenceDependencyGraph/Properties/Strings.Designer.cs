﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MsBuildProjectReferenceDependencyGraph.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MsBuildProjectReferenceDependencyGraph.Properties.Strings", typeof(Strings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
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
        ///   Looks up a localized string similar to Anonymizes the names of all references.
        /// </summary>
        internal static string AnonymizeDescription {
            get {
                return ResourceManager.GetString("AnonymizeDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Show this message and exit.
        /// </summary>
        internal static string HelpDescription {
            get {
                return ResourceManager.GetString("HelpDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You must provide a valid target Project or Solution File. Received `{0}`.
        /// </summary>
        internal static string InvalidTargetArgument {
            get {
                return ResourceManager.GetString("InvalidTargetArgument", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Takes either an MsBuild Project File or Visual Studio Solution File and generate
        ///a DOT Graph of all its ProjectReference Elements..
        /// </summary>
        internal static string LongDescription {
            get {
                return ResourceManager.GetString("LongDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MsBuildProjectReferenceDependencyGraph.
        /// </summary>
        internal static string ProgramName {
            get {
                return ResourceManager.GetString("ProgramName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Usage: MyProject.sln-or-proj [-s][-a][-sar][-spr][-sA].
        /// </summary>
        internal static string ShortUsageMessage {
            get {
                return ResourceManager.GetString("ShortUsageMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Show both &quot;Assembly&quot; and &quot;PackageReference&quot; References in graph.
        /// </summary>
        internal static string ShowAllReferencesDescription {
            get {
                return ResourceManager.GetString("ShowAllReferencesDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Show &quot;Assembly&quot; References in graph.
        /// </summary>
        internal static string ShowAssemblyReferencesDescription {
            get {
                return ResourceManager.GetString("ShowAssemblyReferencesDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Show &quot;PackageReference&quot; References in graph.
        /// </summary>
        internal static string ShowPackageReferencesDescription {
            get {
                return ResourceManager.GetString("ShowPackageReferencesDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sort the output of this tool.
        /// </summary>
        internal static string SortDescription {
            get {
                return ResourceManager.GetString("SortDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Project or Solution to evaluate.
        /// </summary>
        internal static string TargetArgumentDescription {
            get {
                return ResourceManager.GetString("TargetArgumentDescription", resourceCulture);
            }
        }
    }
}
