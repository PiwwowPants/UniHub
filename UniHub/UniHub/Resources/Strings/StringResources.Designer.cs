﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UniHub.Resources.Strings {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class StringResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal StringResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("UniHub.Resources.Strings.StringResources", typeof(StringResources).Assembly);
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
        ///   Looks up a localized string similar to UniHub.
        /// </summary>
        internal static string AppName {
            get {
                return ResourceManager.GetString("AppName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Feeds.
        /// </summary>
        internal static string HomeTabFeeds {
            get {
                return ResourceManager.GetString("HomeTabFeeds", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Issues.
        /// </summary>
        internal static string HomeTabIssues {
            get {
                return ResourceManager.GetString("HomeTabIssues", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Pull Requests.
        /// </summary>
        internal static string HomeTabPullRequests {
            get {
                return ResourceManager.GetString("HomeTabPullRequests", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sign in using your GitHub account to use UniHub.
        /// </summary>
        internal static string LoginPrompt {
            get {
                return ResourceManager.GetString("LoginPrompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to OAuth.
        /// </summary>
        internal static string LoginTypeOAuth {
            get {
                return ResourceManager.GetString("LoginTypeOAuth", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Choose your login type.
        /// </summary>
        internal static string LoginTypePrompt {
            get {
                return ResourceManager.GetString("LoginTypePrompt", resourceCulture);
            }
        }
    }
}
