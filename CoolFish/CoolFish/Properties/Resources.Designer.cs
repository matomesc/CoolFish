﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CoolFishNS.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CoolFishNS.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to ~Unknown~.
        /// </summary>
        internal static string BotAuthor {
            get {
                return ResourceManager.GetString("BotAuthor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please attach to a process and select a bot base to use..
        /// </summary>
        internal static string BotIsNotReadyError {
            get {
                return ResourceManager.GetString("BotIsNotReadyError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap btn_donate_SM {
            get {
                object obj = ResourceManager.GetObject("btn_donate_SM", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to if IsFishingLoot() then 
        ///	local numLootItems = GetNumLootItems()
        ///	for i=1,numLootItems do 
        ///	local Link = GetLootSlotLink(i)
        ///	local _,name, lootQuantity ,Quality  = GetLootSlotInfo(i)
        ///	
        ///		if Link and Quality and name and lootQuantity then
        ///
        ///		_, _, id = string.find(Link, &quot;item:(%d+):&quot;)
        ///			if Quality &gt;= LootQuality then
        ///				if LootLeftOnly or DontLootLeft then 
        ///					match = ItemsList[name] or ItemsList[id]
        ///                
        ///					if (match) and LootLeftOnly then 
        ///						LootSlot(i) 
        ///						ConfirmLootSlot(i)
        ///					 [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string DoLoot {
            get {
                return ResourceManager.GetString("DoLoot", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to stop Plugin Pulse Thread after 5 seconds...
        /// </summary>
        internal static string FailedToStopPlugins {
            get {
                return ResourceManager.GetString("FailedToStopPlugins", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to LureName = nil;
        ///
        ///local Lures = {
        ///	-- Consumable Lures
        ///	[67404] = true,
        ///	[6529] = true,
        ///	[6811] = true,
        ///	[6530] = true,
        ///	[6532] = true,
        ///	[7307] = true,
        ///	[6533] = true,
        ///	[62673] = true,
        ///	[46006] = true,
        ///	[34861] = true,
        ///	[68049] = true,
        ///	[118391] = true; -- Worm Supreme
        ///	-- Hats
        ///	[33820] = true, -- Weather
        ///	[117405] = true, -- Nat&apos;s Drinking Hat
        ///	[88710] = true, -- Nat&apos;s Hat
        ///	-- Poles
        ///	[116826] = true, -- Draenic Fishing Pole
        ///	[116825] = true -- Savage Fishing Pole
        ///}
        ///
        ///
        ///
        ///-- Function to find inventory slot lure [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string GetLureName {
            get {
                return ResourceManager.GetString("GetLureName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hit max time limit. Stopping bot..
        /// </summary>
        internal static string HitTimeLimit {
            get {
                return ResourceManager.GetString("HitTimeLimit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .
        /// </summary>
        internal static string NeedToApplyBait {
            get {
                return ResourceManager.GetString("NeedToApplyBait", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to local name; 
        ///
        ///name = GetSpellInfo(125167); 
        ///_,_,_,_,_,_,expires = UnitBuff(&quot;player&quot;,name); 
        ///
        ///if expires then 
        ///expires = expires-GetTime()
        ///
        ///if expires
        ///&lt; 30 then
        ///  expires= 1
        ///  else
        ///  expires= 0
        ///  end
        ///  else
        ///  expires= 1
        ///  end.
        /// </summary>
        internal static string NeedToRunCharm {
            get {
                return ResourceManager.GetString("NeedToRunCharm", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to local _, englishClass = UnitClass(&quot;player&quot;) 
        ///local name; 
        ///
        ///if englishClass == &quot;SHAMAN&quot; then 
        ///name = GetSpellInfo(546);  _,_,_,_,_,_,expires = UnitBuff(&quot;player&quot;,name); 
        ///if expires then 
        ///expires = expires-GetTime() 
        ///end 
        ///else 
        ///if englishClass == &quot;DEATHKNIGHT&quot; then 
        ///name = GetSpellInfo(3714); _,_,_,_,_,_,expires = UnitBuff(&quot;player&quot;,name); 
        ///if expires then 
        ///expires = expires-GetTime() 
        ///end 
        ///else 
        ///if englishClass == &quot;WARLOCK&quot; and GetSpecialization() == 1 then 
        ///name = GetSpellInfo(5697); _,_,_,_,_,_,expires = Uni [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string NeedToRunUseRaft {
            get {
                return ResourceManager.GetString("NeedToRunUseRaft", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to local name; 
        ///
        ///name = GetSpellInfo(45694); 
        ///_,_,_,_,_,_,expires = UnitBuff(&quot;player&quot;,name); 
        ///
        ///
        ///local count = 0; 
        ///for i=0,4 do 
        ///local numberOfSlots = GetContainerNumSlots(i); 
        ///for j=1,numberOfSlots do 
        ///local itemid = GetContainerItemID(i,j)
        ///if itemid then 
        ///if itemid ==  34832 then
        ///local _,stackCounter = GetContainerItemInfo(i,j);
        ///count = count + stackCounter; 
        ///end 
        ///end        
        ///end 
        ///end
        ///
        ///
        ///
        ///if expires then 
        ///expires = expires-GetTime()
        ///
        ///if expires
        ///&lt; 30 then
        ///  expires= 1
        ///  else
        ///  expires= 0
        ///  end
        ///  else
        ///  expires= [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string NeedToRunUseRumsey {
            get {
                return ResourceManager.GetString("NeedToRunUseRumsey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///
        ///&lt;Patterns&gt;
        ///  &lt;Pattern desc=&quot;PlayerPointer&quot;
        ///           pattern=&quot;\x55\x8b\xec\xa1\x00\x00\x00\x00\x83\xec\x10\x85\xc0\x75\x00\x8d\x45\xf0\x50\xe8\x00\x00\x00\x00\x68\x00\x00\x00\x00\x68\x00\x00\x00\x00\x8d\x45\xf0\x6a\x10\x50\xe8\x00\x00\x00\x00\x83\xc4\x14\xa3\x00\x00\x00\x00\xc9\xc3&quot;
        ///           mask=&quot;xxxx????xxxxxx?xxxxx????x????x????xxxxxxx????xxxx????xx&quot;&gt;
        ///    &lt;Add value=&quot;4&quot; /&gt;
        ///    &lt;Lea /&gt;
        ///  &lt;/Pattern&gt;
        ///  &lt;Pattern desc=&quot;FrameScript_ExecuteBuffer&quot; pattern=&quot;\x5 [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Patterns {
            get {
                return ResourceManager.GetString("Patterns", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&amp;hosted_button_id=MNTAWFX9F4M7N.
        /// </summary>
        internal static string PaypalLink {
            get {
                return ResourceManager.GetString("PaypalLink", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error with plugin: {0}.
        /// </summary>
        internal static string PluginError {
            get {
                return ResourceManager.GetString("PluginError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Disabling {0} due to an exception. Developers should catch their own exceptions..
        /// </summary>
        internal static string PluginPulseException {
            get {
                return ResourceManager.GetString("PluginPulseException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Congrats. You found the secret button..
        /// </summary>
        internal static string SecretBTNMessage {
            get {
                return ResourceManager.GetString("SecretBTNMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to local _, englishClass = UnitClass(&quot;player&quot;) 
        ///local name; 
        ///
        ///if englishClass == &quot;SHAMAN&quot; then 
        ///name = GetSpellInfo(546)
        ///TargetUnit(&quot;player&quot;) 
        ///CastSpellByName(name)
        ///TargetLastTarget()
        ///else 
        ///if englishClass == &quot;DEATHKNIGHT&quot; then 
        ///name = GetSpellInfo(3714) 
        ///TargetUnit(&quot;player&quot;) 
        ///CastSpellByName(name)
        ///TargetLastTarget()
        ///else 
        ///if englishClass == &quot;WARLOCK&quot; and GetSpecialization() == 1 then 
        ///if UnitPower(&quot;player&quot;,7)
        ///&lt; 1  then
        ///  name= GetSpellInfo(101976)
        ///  CastSpellByName( name)
        ///  while UnitChannelInfo(&quot;player&quot;) do
        /// [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string UseRaft {
            get {
                return ResourceManager.GetString("UseRaft", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to if not CoolFrame then
        ///CoolFrame = CreateFrame(&quot;FRAME&quot;);
        ///end
        ///
        ///
        ///NewMessage = 0; 
        ///CoolFrame:RegisterEvent(&quot;CHAT_MSG_WHISPER&quot;);
        ///CoolFrame:RegisterEvent(&quot;CHAT_MSG_BN_WHISPER&quot;);
        ///
        ///CoolFrame:SetScript(&quot;OnEvent&quot;,
        ///function(self,event,msg,author,language,status,msgid,unk,chatline,senderguid)
        ///NewMessage = 1; 
        ///Message = msg;
        ///Author = author;
        ///
        ///end);.
        /// </summary>
        internal static string WhisperNotes {
            get {
                return ResourceManager.GetString("WhisperNotes", resourceCulture);
            }
        }
    }
}
