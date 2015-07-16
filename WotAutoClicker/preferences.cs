namespace WotAutoClicker
{
   
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
   public partial class root
   {
      private rootGraphicsPreferences graphicsPreferencesField;
      private rootDevicePreferences devicePreferencesField;
      private rootScriptsPreferences scriptsPreferencesField;
      private string consoleHistoryField;
      /// <remarks/>
      public rootGraphicsPreferences graphicsPreferences
      {
         get
         {
            return this.graphicsPreferencesField;
         }
         set
         {
            this.graphicsPreferencesField = value;
         }
      }
      /// <remarks/>
      public rootDevicePreferences devicePreferences
      {
         get
         {
            return this.devicePreferencesField;
         }
         set
         {
            this.devicePreferencesField = value;
         }
      }
      /// <remarks/>
      public rootScriptsPreferences scriptsPreferences
      {
         get
         {
            return this.scriptsPreferencesField;
         }
         set
         {
            this.scriptsPreferencesField = value;
         }
      }
      /// <remarks/>
      public string consoleHistory
      {
         get
         {
            return this.consoleHistoryField;
         }
         set
         {
            this.consoleHistoryField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
   public partial class rootGraphicsPreferences
   {
      private float graphicsSettingsVersionField;
      private float graphicsSettingsVersionMinorField;
      private float graphicsSettingsStatusField;
      private rootGraphicsPreferencesDetector detectorField;
      private string deviceGUIDField;
      private rootGraphicsPreferencesEntry[] entryField;
      private float particlSystemNoRenderGroupField;
      private float distributionLevelField;
      private float colorGradingStrengthField;
      /// <remarks/>
      public float graphicsSettingsVersion
      {
         get
         {
            return this.graphicsSettingsVersionField;
         }
         set
         {
            this.graphicsSettingsVersionField = value;
         }
      }
      /// <remarks/>
      public float graphicsSettingsVersionMinor
      {
         get
         {
            return this.graphicsSettingsVersionMinorField;
         }
         set
         {
            this.graphicsSettingsVersionMinorField = value;
         }
      }
      /// <remarks/>
      public float graphicsSettingsStatus
      {
         get
         {
            return this.graphicsSettingsStatusField;
         }
         set
         {
            this.graphicsSettingsStatusField = value;
         }
      }
      /// <remarks/>
      public rootGraphicsPreferencesDetector detector
      {
         get
         {
            return this.detectorField;
         }
         set
         {
            this.detectorField = value;
         }
      }
      /// <remarks/>
      public string deviceGUID
      {
         get
         {
            return this.deviceGUIDField;
         }
         set
         {
            this.deviceGUIDField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("entry")]
      public rootGraphicsPreferencesEntry[] entry
      {
         get
         {
            return this.entryField;
         }
         set
         {
            this.entryField = value;
         }
      }
      /// <remarks/>
      public float ParticlSystemNoRenderGroup
      {
         get
         {
            return this.particlSystemNoRenderGroupField;
         }
         set
         {
            this.particlSystemNoRenderGroupField = value;
         }
      }
      /// <remarks/>
      public float distributionLevel
      {
         get
         {
            return this.distributionLevelField;
         }
         set
         {
            this.distributionLevelField = value;
         }
      }
      /// <remarks/>
      public float colorGradingStrength
      {
         get
         {
            return this.colorGradingStrengthField;
         }
         set
         {
            this.colorGradingStrengthField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
   public partial class rootGraphicsPreferencesDetector
   {
      private float gpuMemoryField;
      private float gpuScoreField;
      private float ramField;
      private float virtualMemoryField;
      private float cpuFrequencyField;
      /// <remarks/>
      public float gpuMemory
      {
         get
         {
            return this.gpuMemoryField;
         }
         set
         {
            this.gpuMemoryField = value;
         }
      }
      /// <remarks/>
      public float gpuScore
      {
         get
         {
            return this.gpuScoreField;
         }
         set
         {
            this.gpuScoreField = value;
         }
      }
      /// <remarks/>
      public float ram
      {
         get
         {
            return this.ramField;
         }
         set
         {
            this.ramField = value;
         }
      }
      /// <remarks/>
      public float virtualMemory
      {
         get
         {
            return this.virtualMemoryField;
         }
         set
         {
            this.virtualMemoryField = value;
         }
      }
      /// <remarks/>
      public float cpuFrequency
      {
         get
         {
            return this.cpuFrequencyField;
         }
         set
         {
            this.cpuFrequencyField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
   public partial class rootGraphicsPreferencesEntry
   {
      private string labelField;
      private float activeOptionField;
      /// <remarks/>
      public string label
      {
         get
         {
            return this.labelField;
         }
         set
         {
            this.labelField = value;
         }
      }
      /// <remarks/>
      public float activeOption
      {
         get
         {
            return this.activeOptionField;
         }
         set
         {
            this.activeOptionField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
   public partial class rootDevicePreferences
   {
      private float adapterOrdinalField;
      private string windowedField;
      private float windowedWidthField;
      private float windowedHeightField;
      private float positionXField;
      private float positionYField;
      private string isWindowMaximizedField;
      private string waitVSyncField;
      private float customAAModeField;
      private string tripleBufferingField;
      private float multisamplingTypeField;
      private float multisamplingQualityField;
      private float aspectRatioField;
      private float gammaCorrectionField;
      private float drrScaleField;
      private string useAlternateFrameTimerField;
      private float textureQualityMemoryBlockField;
      private float fullscreenWidthField;
      private float fullscreenHeightField;
      private float fullscreenRefreshField;
      /// <remarks/>
      public float adapterOrdinal
      {
         get
         {
            return this.adapterOrdinalField;
         }
         set
         {
            this.adapterOrdinalField = value;
         }
      }
      /// <remarks/>
      public string windowed
      {
         get
         {
            return this.windowedField;
         }
         set
         {
            this.windowedField = value;
         }
      }
      /// <remarks/>
      public float windowedWidth
      {
         get
         {
            return this.windowedWidthField;
         }
         set
         {
            this.windowedWidthField = value;
         }
      }
      /// <remarks/>
      public float windowedHeight
      {
         get
         {
            return this.windowedHeightField;
         }
         set
         {
            this.windowedHeightField = value;
         }
      }
      /// <remarks/>
      public float positionX
      {
         get
         {
            return this.positionXField;
         }
         set
         {
            this.positionXField = value;
         }
      }
      /// <remarks/>
      public float positionY
      {
         get
         {
            return this.positionYField;
         }
         set
         {
            this.positionYField = value;
         }
      }
      /// <remarks/>
      public string isWindowMaximized
      {
         get
         {
            return this.isWindowMaximizedField;
         }
         set
         {
            this.isWindowMaximizedField = value;
         }
      }
      /// <remarks/>
      public string waitVSync
      {
         get
         {
            return this.waitVSyncField;
         }
         set
         {
            this.waitVSyncField = value;
         }
      }
      /// <remarks/>
      public float customAAMode
      {
         get
         {
            return this.customAAModeField;
         }
         set
         {
            this.customAAModeField = value;
         }
      }
      /// <remarks/>
      public string tripleBuffering
      {
         get
         {
            return this.tripleBufferingField;
         }
         set
         {
            this.tripleBufferingField = value;
         }
      }
      /// <remarks/>
      public float multisamplingType
      {
         get
         {
            return this.multisamplingTypeField;
         }
         set
         {
            this.multisamplingTypeField = value;
         }
      }
      /// <remarks/>
      public float multisamplingQuality
      {
         get
         {
            return this.multisamplingQualityField;
         }
         set
         {
            this.multisamplingQualityField = value;
         }
      }
      /// <remarks/>
      public float aspectRatio
      {
         get
         {
            return this.aspectRatioField;
         }
         set
         {
            this.aspectRatioField = value;
         }
      }
      /// <remarks/>
      public float gammaCorrection
      {
         get
         {
            return this.gammaCorrectionField;
         }
         set
         {
            this.gammaCorrectionField = value;
         }
      }
      /// <remarks/>
      public float drrScale
      {
         get
         {
            return this.drrScaleField;
         }
         set
         {
            this.drrScaleField = value;
         }
      }
      /// <remarks/>
      public string useAlternateFrameTimer
      {
         get
         {
            return this.useAlternateFrameTimerField;
         }
         set
         {
            this.useAlternateFrameTimerField = value;
         }
      }
      /// <remarks/>
      public float textureQualityMemoryBlock
      {
         get
         {
            return this.textureQualityMemoryBlockField;
         }
         set
         {
            this.textureQualityMemoryBlockField = value;
         }
      }
      /// <remarks/>
      public float fullscreenWidth
      {
         get
         {
            return this.fullscreenWidthField;
         }
         set
         {
            this.fullscreenWidthField = value;
         }
      }
      /// <remarks/>
      public float fullscreenHeight
      {
         get
         {
            return this.fullscreenHeightField;
         }
         set
         {
            this.fullscreenHeightField = value;
         }
      }
      /// <remarks/>
      public float fullscreenRefresh
      {
         get
         {
            return this.fullscreenRefreshField;
         }
         set
         {
            this.fullscreenRefreshField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
   public partial class rootScriptsPreferences
   {
      private rootScriptsPreferencesSoundPrefs soundPrefsField;
      private rootScriptsPreferencesReplayPrefs replayPrefsField;
      private rootScriptsPreferencesVibration vibrationField;
      private float fovField;
      private string dynamicFovField;
      private string guiNotifyInfoField;
      private rootScriptsPreferencesAccounts accountsField;
      private rootScriptsPreferencesWindowsStoredData windowsStoredDataField;
      private rootScriptsPreferencesLoginInfo loginInfoField;
      private rootScriptsPreferencesLoginPage loginPageField;
      private string captureDeviceField;
      private rootScriptsPreferencesControlMode controlModeField;
      private string showFPSField;
      private rootScriptsPreferencesXVM xVMField;
      private rootScriptsPreferencesCommandMapping commandMappingField;
      /// <remarks/>
      public rootScriptsPreferencesSoundPrefs soundPrefs
      {
         get
         {
            return this.soundPrefsField;
         }
         set
         {
            this.soundPrefsField = value;
         }
      }
      /// <remarks/>
      public rootScriptsPreferencesReplayPrefs replayPrefs
      {
         get
         {
            return this.replayPrefsField;
         }
         set
         {
            this.replayPrefsField = value;
         }
      }
      /// <remarks/>
      public rootScriptsPreferencesVibration vibration
      {
         get
         {
            return this.vibrationField;
         }
         set
         {
            this.vibrationField = value;
         }
      }
      /// <remarks/>
      public float fov
      {
         get
         {
            return this.fovField;
         }
         set
         {
            this.fovField = value;
         }
      }
      /// <remarks/>
      public string dynamicFov
      {
         get
         {
            return this.dynamicFovField;
         }
         set
         {
            this.dynamicFovField = value;
         }
      }
      /// <remarks/>
      public string guiNotifyInfo
      {
         get
         {
            return this.guiNotifyInfoField;
         }
         set
         {
            this.guiNotifyInfoField = value;
         }
      }
      /// <remarks/>
      public rootScriptsPreferencesAccounts accounts
      {
         get
         {
            return this.accountsField;
         }
         set
         {
            this.accountsField = value;
         }
      }
      /// <remarks/>
      public rootScriptsPreferencesWindowsStoredData windowsStoredData
      {
         get
         {
            return this.windowsStoredDataField;
         }
         set
         {
            this.windowsStoredDataField = value;
         }
      }
      /// <remarks/>
      public rootScriptsPreferencesLoginInfo loginInfo
      {
         get
         {
            return this.loginInfoField;
         }
         set
         {
            this.loginInfoField = value;
         }
      }
      /// <remarks/>
      public rootScriptsPreferencesLoginPage loginPage
      {
         get
         {
            return this.loginPageField;
         }
         set
         {
            this.loginPageField = value;
         }
      }
      /// <remarks/>
      public string captureDevice
      {
         get
         {
            return this.captureDeviceField;
         }
         set
         {
            this.captureDeviceField = value;
         }
      }
      /// <remarks/>
      public rootScriptsPreferencesControlMode controlMode
      {
         get
         {
            return this.controlModeField;
         }
         set
         {
            this.controlModeField = value;
         }
      }
      /// <remarks/>
      public string showFPS
      {
         get
         {
            return this.showFPSField;
         }
         set
         {
            this.showFPSField = value;
         }
      }
      /// <remarks/>
      public rootScriptsPreferencesXVM XVM
      {
         get
         {
            return this.xVMField;
         }
         set
         {
            this.xVMField = value;
         }
      }
      /// <remarks/>
      public rootScriptsPreferencesCommandMapping commandMapping
      {
         get
         {
            return this.commandMappingField;
         }
         set
         {
            this.commandMappingField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
   public partial class rootScriptsPreferencesSoundPrefs
   {
      private float masterVolumeField;
      private float volume_micVivoxField;
      private float volume_vehiclesField;
      private float volume_masterFadeVivoxField;
      private float volume_guiField;
      private float volume_masterVivoxField;
      private float volume_musicField;
      private float volume_effectsField;
      private float volume_ambientField;
      private float volume_voiceField;
      private string soundModeField;
      /// <remarks/>
      public float masterVolume
      {
         get
         {
            return this.masterVolumeField;
         }
         set
         {
            this.masterVolumeField = value;
         }
      }
      /// <remarks/>
      public float volume_micVivox
      {
         get
         {
            return this.volume_micVivoxField;
         }
         set
         {
            this.volume_micVivoxField = value;
         }
      }
      /// <remarks/>
      public float volume_vehicles
      {
         get
         {
            return this.volume_vehiclesField;
         }
         set
         {
            this.volume_vehiclesField = value;
         }
      }
      /// <remarks/>
      public float volume_masterFadeVivox
      {
         get
         {
            return this.volume_masterFadeVivoxField;
         }
         set
         {
            this.volume_masterFadeVivoxField = value;
         }
      }
      /// <remarks/>
      public float volume_gui
      {
         get
         {
            return this.volume_guiField;
         }
         set
         {
            this.volume_guiField = value;
         }
      }
      /// <remarks/>
      public float volume_masterVivox
      {
         get
         {
            return this.volume_masterVivoxField;
         }
         set
         {
            this.volume_masterVivoxField = value;
         }
      }
      /// <remarks/>
      public float volume_music
      {
         get
         {
            return this.volume_musicField;
         }
         set
         {
            this.volume_musicField = value;
         }
      }
      /// <remarks/>
      public float volume_effects
      {
         get
         {
            return this.volume_effectsField;
         }
         set
         {
            this.volume_effectsField = value;
         }
      }
      /// <remarks/>
      public float volume_ambient
      {
         get
         {
            return this.volume_ambientField;
         }
         set
         {
            this.volume_ambientField = value;
         }
      }
      /// <remarks/>
      public float volume_voice
      {
         get
         {
            return this.volume_voiceField;
         }
         set
         {
            this.volume_voiceField = value;
         }
      }
      /// <remarks/>
      public string soundMode
      {
         get
         {
            return this.soundModeField;
         }
         set
         {
            this.soundModeField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
   public partial class rootScriptsPreferencesReplayPrefs
   {
      private string replayEnabledField;
      private string useServerAimField;
      private string minimapAlphaField;
      private string enablePostMortemEffectField;
      private string enablePostMortemDelayField;
      private string showVehiclesCounterField;
      private string showMarksOnGunField;
      private string dynamicCameraField;
      private string horStabilizationSnpField;
      private string enableOlFilterField;
      private string enableSpamFilterField;
      private string datetimeIdxField;
      private string invitesFromFriendsOnlyField;
      private string storeReceiverInBattleField;
      private string disableBattleChatField;
      private string ppShowLevelsField;
      private string ppShowTypesField;
      private string ppStateField;
      private string gameplayMaskField;
      private string enableOpticalSnpEffectField;
      private string isColorBlindField;
      private string fpsPerfomancerField;
      private string alternativeVoicesField;
      private string mouseHorzInvertField;
      private string mouseVertInvertField;
      private string backDraftInvertField;
      private string cMD_MOVE_FORWARDField;
      private string cMD_MOVE_BACKWARDField;
      private string cMD_ROTATE_LEFTField;
      private string cMD_ROTATE_RIGHTField;
      private string cMD_CM_VEHICLE_SWITCH_AUTOROTATIONField;
      private string cMD_INCREMENT_CRUISE_MODEField;
      private string cMD_DECREMENT_CRUISE_MODEField;
      private string cMD_STOP_UNTIL_FIREField;
      private string cMD_CM_SHOOTField;
      private string cMD_CM_LOCK_TARGETField;
      private string cMD_CM_LOCK_TARGET_OFFField;
      private string cMD_CM_ALTERNATE_MODEField;
      private string cMD_RELOAD_PARTIAL_CLIPField;
      private string cMD_TOGGLE_GUIField;
      private string cMD_RADIAL_MENU_SHOWField;
      private string cMD_AMMO_CHOICE_1Field;
      private string cMD_AMMO_CHOICE_2Field;
      private string cMD_AMMO_CHOICE_3Field;
      private string cMD_AMMO_CHOICE_4Field;
      private string cMD_AMMO_CHOICE_5Field;
      private string cMD_AMMO_CHOICE_6Field;
      private string cMD_AMMO_CHOICE_7Field;
      private string cMD_AMMO_CHOICE_8Field;
      private string cMD_CHAT_SHORTCUT_ATTACKField;
      private string cMD_CHAT_SHORTCUT_BACKTOBASEField;
      private string cMD_CHAT_SHORTCUT_POSITIVEField;
      private string cMD_CHAT_SHORTCUT_NEGATIVEField;
      private string cMD_CHAT_SHORTCUT_HELPMEField;
      private string cMD_CHAT_SHORTCUT_RELOADField;
      private string cMD_CM_CAMERA_ROTATE_UPField;
      private string cMD_CM_CAMERA_ROTATE_DOWNField;
      private string cMD_CM_CAMERA_ROTATE_LEFTField;
      private string cMD_CM_CAMERA_ROTATE_RIGHTField;
      private string cMD_VOICECHAT_MUTEField;
      private string cMD_LOGITECH_SWITCH_VIEWField;
      private string cMD_MINIMAP_SIZE_UPField;
      private string cMD_MINIMAP_SIZE_DOWNField;
      private string cMD_MINIMAP_VISIBLEField;
      private string arcadeField;
      private string sniperField;
      private string enemyField;
      private string deadField;
      private string allyField;
      private string showVectorOnMapField;
      private string showSectorOnMapField;
      private string showVehModelsOnMapField;
      private string showBattleEfficiencyRibbonsField;
      private string receiveFriendshipRequestField;
      private string receiveInvitesInBattleField;
      private string chatContactsListOnlyField;
      /// <remarks/>
      public string replayEnabled
      {
         get
         {
            return this.replayEnabledField;
         }
         set
         {
            this.replayEnabledField = value;
         }
      }
      /// <remarks/>
      public string useServerAim
      {
         get
         {
            return this.useServerAimField;
         }
         set
         {
            this.useServerAimField = value;
         }
      }
      /// <remarks/>
      public string minimapAlpha
      {
         get
         {
            return this.minimapAlphaField;
         }
         set
         {
            this.minimapAlphaField = value;
         }
      }
      /// <remarks/>
      public string enablePostMortemEffect
      {
         get
         {
            return this.enablePostMortemEffectField;
         }
         set
         {
            this.enablePostMortemEffectField = value;
         }
      }
      /// <remarks/>
      public string enablePostMortemDelay
      {
         get
         {
            return this.enablePostMortemDelayField;
         }
         set
         {
            this.enablePostMortemDelayField = value;
         }
      }
      /// <remarks/>
      public string showVehiclesCounter
      {
         get
         {
            return this.showVehiclesCounterField;
         }
         set
         {
            this.showVehiclesCounterField = value;
         }
      }
      /// <remarks/>
      public string showMarksOnGun
      {
         get
         {
            return this.showMarksOnGunField;
         }
         set
         {
            this.showMarksOnGunField = value;
         }
      }
      /// <remarks/>
      public string dynamicCamera
      {
         get
         {
            return this.dynamicCameraField;
         }
         set
         {
            this.dynamicCameraField = value;
         }
      }
      /// <remarks/>
      public string horStabilizationSnp
      {
         get
         {
            return this.horStabilizationSnpField;
         }
         set
         {
            this.horStabilizationSnpField = value;
         }
      }
      /// <remarks/>
      public string enableOlFilter
      {
         get
         {
            return this.enableOlFilterField;
         }
         set
         {
            this.enableOlFilterField = value;
         }
      }
      /// <remarks/>
      public string enableSpamFilter
      {
         get
         {
            return this.enableSpamFilterField;
         }
         set
         {
            this.enableSpamFilterField = value;
         }
      }
      /// <remarks/>
      public string datetimeIdx
      {
         get
         {
            return this.datetimeIdxField;
         }
         set
         {
            this.datetimeIdxField = value;
         }
      }
      /// <remarks/>
      public string invitesFromFriendsOnly
      {
         get
         {
            return this.invitesFromFriendsOnlyField;
         }
         set
         {
            this.invitesFromFriendsOnlyField = value;
         }
      }
      /// <remarks/>
      public string storeReceiverInBattle
      {
         get
         {
            return this.storeReceiverInBattleField;
         }
         set
         {
            this.storeReceiverInBattleField = value;
         }
      }
      /// <remarks/>
      public string disableBattleChat
      {
         get
         {
            return this.disableBattleChatField;
         }
         set
         {
            this.disableBattleChatField = value;
         }
      }
      /// <remarks/>
      public string ppShowLevels
      {
         get
         {
            return this.ppShowLevelsField;
         }
         set
         {
            this.ppShowLevelsField = value;
         }
      }
      /// <remarks/>
      public string ppShowTypes
      {
         get
         {
            return this.ppShowTypesField;
         }
         set
         {
            this.ppShowTypesField = value;
         }
      }
      /// <remarks/>
      public string ppState
      {
         get
         {
            return this.ppStateField;
         }
         set
         {
            this.ppStateField = value;
         }
      }
      /// <remarks/>
      public string gameplayMask
      {
         get
         {
            return this.gameplayMaskField;
         }
         set
         {
            this.gameplayMaskField = value;
         }
      }
      /// <remarks/>
      public string enableOpticalSnpEffect
      {
         get
         {
            return this.enableOpticalSnpEffectField;
         }
         set
         {
            this.enableOpticalSnpEffectField = value;
         }
      }
      /// <remarks/>
      public string isColorBlind
      {
         get
         {
            return this.isColorBlindField;
         }
         set
         {
            this.isColorBlindField = value;
         }
      }
      /// <remarks/>
      public string fpsPerfomancer
      {
         get
         {
            return this.fpsPerfomancerField;
         }
         set
         {
            this.fpsPerfomancerField = value;
         }
      }
      /// <remarks/>
      public string alternativeVoices
      {
         get
         {
            return this.alternativeVoicesField;
         }
         set
         {
            this.alternativeVoicesField = value;
         }
      }
      /// <remarks/>
      public string mouseHorzInvert
      {
         get
         {
            return this.mouseHorzInvertField;
         }
         set
         {
            this.mouseHorzInvertField = value;
         }
      }
      /// <remarks/>
      public string mouseVertInvert
      {
         get
         {
            return this.mouseVertInvertField;
         }
         set
         {
            this.mouseVertInvertField = value;
         }
      }
      /// <remarks/>
      public string backDraftInvert
      {
         get
         {
            return this.backDraftInvertField;
         }
         set
         {
            this.backDraftInvertField = value;
         }
      }
      /// <remarks/>
      public string CMD_MOVE_FORWARD
      {
         get
         {
            return this.cMD_MOVE_FORWARDField;
         }
         set
         {
            this.cMD_MOVE_FORWARDField = value;
         }
      }
      /// <remarks/>
      public string CMD_MOVE_BACKWARD
      {
         get
         {
            return this.cMD_MOVE_BACKWARDField;
         }
         set
         {
            this.cMD_MOVE_BACKWARDField = value;
         }
      }
      /// <remarks/>
      public string CMD_ROTATE_LEFT
      {
         get
         {
            return this.cMD_ROTATE_LEFTField;
         }
         set
         {
            this.cMD_ROTATE_LEFTField = value;
         }
      }
      /// <remarks/>
      public string CMD_ROTATE_RIGHT
      {
         get
         {
            return this.cMD_ROTATE_RIGHTField;
         }
         set
         {
            this.cMD_ROTATE_RIGHTField = value;
         }
      }
      /// <remarks/>
      public string CMD_CM_VEHICLE_SWITCH_AUTOROTATION
      {
         get
         {
            return this.cMD_CM_VEHICLE_SWITCH_AUTOROTATIONField;
         }
         set
         {
            this.cMD_CM_VEHICLE_SWITCH_AUTOROTATIONField = value;
         }
      }
      /// <remarks/>
      public string CMD_INCREMENT_CRUISE_MODE
      {
         get
         {
            return this.cMD_INCREMENT_CRUISE_MODEField;
         }
         set
         {
            this.cMD_INCREMENT_CRUISE_MODEField = value;
         }
      }
      /// <remarks/>
      public string CMD_DECREMENT_CRUISE_MODE
      {
         get
         {
            return this.cMD_DECREMENT_CRUISE_MODEField;
         }
         set
         {
            this.cMD_DECREMENT_CRUISE_MODEField = value;
         }
      }
      /// <remarks/>
      public string CMD_STOP_UNTIL_FIRE
      {
         get
         {
            return this.cMD_STOP_UNTIL_FIREField;
         }
         set
         {
            this.cMD_STOP_UNTIL_FIREField = value;
         }
      }
      /// <remarks/>
      public string CMD_CM_SHOOT
      {
         get
         {
            return this.cMD_CM_SHOOTField;
         }
         set
         {
            this.cMD_CM_SHOOTField = value;
         }
      }
      /// <remarks/>
      public string CMD_CM_LOCK_TARGET
      {
         get
         {
            return this.cMD_CM_LOCK_TARGETField;
         }
         set
         {
            this.cMD_CM_LOCK_TARGETField = value;
         }
      }
      /// <remarks/>
      public string CMD_CM_LOCK_TARGET_OFF
      {
         get
         {
            return this.cMD_CM_LOCK_TARGET_OFFField;
         }
         set
         {
            this.cMD_CM_LOCK_TARGET_OFFField = value;
         }
      }
      /// <remarks/>
      public string CMD_CM_ALTERNATE_MODE
      {
         get
         {
            return this.cMD_CM_ALTERNATE_MODEField;
         }
         set
         {
            this.cMD_CM_ALTERNATE_MODEField = value;
         }
      }
      /// <remarks/>
      public string CMD_RELOAD_PARTIAL_CLIP
      {
         get
         {
            return this.cMD_RELOAD_PARTIAL_CLIPField;
         }
         set
         {
            this.cMD_RELOAD_PARTIAL_CLIPField = value;
         }
      }
      /// <remarks/>
      public string CMD_TOGGLE_GUI
      {
         get
         {
            return this.cMD_TOGGLE_GUIField;
         }
         set
         {
            this.cMD_TOGGLE_GUIField = value;
         }
      }
      /// <remarks/>
      public string CMD_RADIAL_MENU_SHOW
      {
         get
         {
            return this.cMD_RADIAL_MENU_SHOWField;
         }
         set
         {
            this.cMD_RADIAL_MENU_SHOWField = value;
         }
      }
      /// <remarks/>
      public string CMD_AMMO_CHOICE_1
      {
         get
         {
            return this.cMD_AMMO_CHOICE_1Field;
         }
         set
         {
            this.cMD_AMMO_CHOICE_1Field = value;
         }
      }
      /// <remarks/>
      public string CMD_AMMO_CHOICE_2
      {
         get
         {
            return this.cMD_AMMO_CHOICE_2Field;
         }
         set
         {
            this.cMD_AMMO_CHOICE_2Field = value;
         }
      }
      /// <remarks/>
      public string CMD_AMMO_CHOICE_3
      {
         get
         {
            return this.cMD_AMMO_CHOICE_3Field;
         }
         set
         {
            this.cMD_AMMO_CHOICE_3Field = value;
         }
      }
      /// <remarks/>
      public string CMD_AMMO_CHOICE_4
      {
         get
         {
            return this.cMD_AMMO_CHOICE_4Field;
         }
         set
         {
            this.cMD_AMMO_CHOICE_4Field = value;
         }
      }
      /// <remarks/>
      public string CMD_AMMO_CHOICE_5
      {
         get
         {
            return this.cMD_AMMO_CHOICE_5Field;
         }
         set
         {
            this.cMD_AMMO_CHOICE_5Field = value;
         }
      }
      /// <remarks/>
      public string CMD_AMMO_CHOICE_6
      {
         get
         {
            return this.cMD_AMMO_CHOICE_6Field;
         }
         set
         {
            this.cMD_AMMO_CHOICE_6Field = value;
         }
      }
      /// <remarks/>
      public string CMD_AMMO_CHOICE_7
      {
         get
         {
            return this.cMD_AMMO_CHOICE_7Field;
         }
         set
         {
            this.cMD_AMMO_CHOICE_7Field = value;
         }
      }
      /// <remarks/>
      public string CMD_AMMO_CHOICE_8
      {
         get
         {
            return this.cMD_AMMO_CHOICE_8Field;
         }
         set
         {
            this.cMD_AMMO_CHOICE_8Field = value;
         }
      }
      /// <remarks/>
      public string CMD_CHAT_SHORTCUT_ATTACK
      {
         get
         {
            return this.cMD_CHAT_SHORTCUT_ATTACKField;
         }
         set
         {
            this.cMD_CHAT_SHORTCUT_ATTACKField = value;
         }
      }
      /// <remarks/>
      public string CMD_CHAT_SHORTCUT_BACKTOBASE
      {
         get
         {
            return this.cMD_CHAT_SHORTCUT_BACKTOBASEField;
         }
         set
         {
            this.cMD_CHAT_SHORTCUT_BACKTOBASEField = value;
         }
      }
      /// <remarks/>
      public string CMD_CHAT_SHORTCUT_POSITIVE
      {
         get
         {
            return this.cMD_CHAT_SHORTCUT_POSITIVEField;
         }
         set
         {
            this.cMD_CHAT_SHORTCUT_POSITIVEField = value;
         }
      }
      /// <remarks/>
      public string CMD_CHAT_SHORTCUT_NEGATIVE
      {
         get
         {
            return this.cMD_CHAT_SHORTCUT_NEGATIVEField;
         }
         set
         {
            this.cMD_CHAT_SHORTCUT_NEGATIVEField = value;
         }
      }
      /// <remarks/>
      public string CMD_CHAT_SHORTCUT_HELPME
      {
         get
         {
            return this.cMD_CHAT_SHORTCUT_HELPMEField;
         }
         set
         {
            this.cMD_CHAT_SHORTCUT_HELPMEField = value;
         }
      }
      /// <remarks/>
      public string CMD_CHAT_SHORTCUT_RELOAD
      {
         get
         {
            return this.cMD_CHAT_SHORTCUT_RELOADField;
         }
         set
         {
            this.cMD_CHAT_SHORTCUT_RELOADField = value;
         }
      }
      /// <remarks/>
      public string CMD_CM_CAMERA_ROTATE_UP
      {
         get
         {
            return this.cMD_CM_CAMERA_ROTATE_UPField;
         }
         set
         {
            this.cMD_CM_CAMERA_ROTATE_UPField = value;
         }
      }
      /// <remarks/>
      public string CMD_CM_CAMERA_ROTATE_DOWN
      {
         get
         {
            return this.cMD_CM_CAMERA_ROTATE_DOWNField;
         }
         set
         {
            this.cMD_CM_CAMERA_ROTATE_DOWNField = value;
         }
      }
      /// <remarks/>
      public string CMD_CM_CAMERA_ROTATE_LEFT
      {
         get
         {
            return this.cMD_CM_CAMERA_ROTATE_LEFTField;
         }
         set
         {
            this.cMD_CM_CAMERA_ROTATE_LEFTField = value;
         }
      }
      /// <remarks/>
      public string CMD_CM_CAMERA_ROTATE_RIGHT
      {
         get
         {
            return this.cMD_CM_CAMERA_ROTATE_RIGHTField;
         }
         set
         {
            this.cMD_CM_CAMERA_ROTATE_RIGHTField = value;
         }
      }
      /// <remarks/>
      public string CMD_VOICECHAT_MUTE
      {
         get
         {
            return this.cMD_VOICECHAT_MUTEField;
         }
         set
         {
            this.cMD_VOICECHAT_MUTEField = value;
         }
      }
      /// <remarks/>
      public string CMD_LOGITECH_SWITCH_VIEW
      {
         get
         {
            return this.cMD_LOGITECH_SWITCH_VIEWField;
         }
         set
         {
            this.cMD_LOGITECH_SWITCH_VIEWField = value;
         }
      }
      /// <remarks/>
      public string CMD_MINIMAP_SIZE_UP
      {
         get
         {
            return this.cMD_MINIMAP_SIZE_UPField;
         }
         set
         {
            this.cMD_MINIMAP_SIZE_UPField = value;
         }
      }
      /// <remarks/>
      public string CMD_MINIMAP_SIZE_DOWN
      {
         get
         {
            return this.cMD_MINIMAP_SIZE_DOWNField;
         }
         set
         {
            this.cMD_MINIMAP_SIZE_DOWNField = value;
         }
      }
      /// <remarks/>
      public string CMD_MINIMAP_VISIBLE
      {
         get
         {
            return this.cMD_MINIMAP_VISIBLEField;
         }
         set
         {
            this.cMD_MINIMAP_VISIBLEField = value;
         }
      }
      /// <remarks/>
      public string arcade
      {
         get
         {
            return this.arcadeField;
         }
         set
         {
            this.arcadeField = value;
         }
      }
      /// <remarks/>
      public string sniper
      {
         get
         {
            return this.sniperField;
         }
         set
         {
            this.sniperField = value;
         }
      }
      /// <remarks/>
      public string enemy
      {
         get
         {
            return this.enemyField;
         }
         set
         {
            this.enemyField = value;
         }
      }
      /// <remarks/>
      public string dead
      {
         get
         {
            return this.deadField;
         }
         set
         {
            this.deadField = value;
         }
      }
      /// <remarks/>
      public string ally
      {
         get
         {
            return this.allyField;
         }
         set
         {
            this.allyField = value;
         }
      }
      /// <remarks/>
      public string showVectorOnMap
      {
         get
         {
            return this.showVectorOnMapField;
         }
         set
         {
            this.showVectorOnMapField = value;
         }
      }
      /// <remarks/>
      public string showSectorOnMap
      {
         get
         {
            return this.showSectorOnMapField;
         }
         set
         {
            this.showSectorOnMapField = value;
         }
      }
      /// <remarks/>
      public string showVehModelsOnMap
      {
         get
         {
            return this.showVehModelsOnMapField;
         }
         set
         {
            this.showVehModelsOnMapField = value;
         }
      }
      /// <remarks/>
      public string showBattleEfficiencyRibbons
      {
         get
         {
            return this.showBattleEfficiencyRibbonsField;
         }
         set
         {
            this.showBattleEfficiencyRibbonsField = value;
         }
      }
      /// <remarks/>
      public string receiveFriendshipRequest
      {
         get
         {
            return this.receiveFriendshipRequestField;
         }
         set
         {
            this.receiveFriendshipRequestField = value;
         }
      }
      /// <remarks/>
      public string receiveInvitesInBattle
      {
         get
         {
            return this.receiveInvitesInBattleField;
         }
         set
         {
            this.receiveInvitesInBattleField = value;
         }
      }
      /// <remarks/>
      public string chatContactsListOnly
      {
         get
         {
            return this.chatContactsListOnlyField;
         }
         set
         {
            this.chatContactsListOnlyField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
   public partial class rootScriptsPreferencesVibration
   {
      private float gainField;
      private string enabled_by_userField;
      private rootScriptsPreferencesVibrationGroups groupsField;
      /// <remarks/>
      public float gain
      {
         get
         {
            return this.gainField;
         }
         set
         {
            this.gainField = value;
         }
      }
      /// <remarks/>
      public string enabled_by_user
      {
         get
         {
            return this.enabled_by_userField;
         }
         set
         {
            this.enabled_by_userField = value;
         }
      }
      /// <remarks/>
      public rootScriptsPreferencesVibrationGroups groups
      {
         get
         {
            return this.groupsField;
         }
         set
         {
            this.groupsField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
   public partial class rootScriptsPreferencesVibrationGroups
   {
      private rootScriptsPreferencesVibrationGroupsEngine engineField;
      private rootScriptsPreferencesVibrationGroupsAcceleration accelerationField;
      private rootScriptsPreferencesVibrationGroupsShots shotsField;
      private rootScriptsPreferencesVibrationGroupsHits hitsField;
      private rootScriptsPreferencesVibrationGroupsDamage damageField;
      private rootScriptsPreferencesVibrationGroupsGui guiField;
      private rootScriptsPreferencesVibrationGroupsCollisions collisionsField;
      /// <remarks/>
      public rootScriptsPreferencesVibrationGroupsEngine engine
      {
         get
         {
            return this.engineField;
         }
         set
         {
            this.engineField = value;
         }
      }
      /// <remarks/>
      public rootScriptsPreferencesVibrationGroupsAcceleration acceleration
      {
         get
         {
            return this.accelerationField;
         }
         set
         {
            this.accelerationField = value;
         }
      }
      /// <remarks/>
      public rootScriptsPreferencesVibrationGroupsShots shots
      {
         get
         {
            return this.shotsField;
         }
         set
         {
            this.shotsField = value;
         }
      }
      /// <remarks/>
      public rootScriptsPreferencesVibrationGroupsHits hits
      {
         get
         {
            return this.hitsField;
         }
         set
         {
            this.hitsField = value;
         }
      }
      /// <remarks/>
      public rootScriptsPreferencesVibrationGroupsDamage damage
      {
         get
         {
            return this.damageField;
         }
         set
         {
            this.damageField = value;
         }
      }
      /// <remarks/>
      public rootScriptsPreferencesVibrationGroupsGui gui
      {
         get
         {
            return this.guiField;
         }
         set
         {
            this.guiField = value;
         }
      }
      /// <remarks/>
      public rootScriptsPreferencesVibrationGroupsCollisions collisions
      {
         get
         {
            return this.collisionsField;
         }
         set
         {
            this.collisionsField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
   public partial class rootScriptsPreferencesVibrationGroupsEngine
   {
      private string enabledField;
      private float gainField;
      /// <remarks/>
      public string enabled
      {
         get
         {
            return this.enabledField;
         }
         set
         {
            this.enabledField = value;
         }
      }
      /// <remarks/>
      public float gain
      {
         get
         {
            return this.gainField;
         }
         set
         {
            this.gainField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
   public partial class rootScriptsPreferencesVibrationGroupsAcceleration
   {
      private string enabledField;
      private float gainField;
      /// <remarks/>
      public string enabled
      {
         get
         {
            return this.enabledField;
         }
         set
         {
            this.enabledField = value;
         }
      }
      /// <remarks/>
      public float gain
      {
         get
         {
            return this.gainField;
         }
         set
         {
            this.gainField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
   public partial class rootScriptsPreferencesVibrationGroupsShots
   {
      private string enabledField;
      private float gainField;
      /// <remarks/>
      public string enabled
      {
         get
         {
            return this.enabledField;
         }
         set
         {
            this.enabledField = value;
         }
      }
      /// <remarks/>
      public float gain
      {
         get
         {
            return this.gainField;
         }
         set
         {
            this.gainField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
   public partial class rootScriptsPreferencesVibrationGroupsHits
   {
      private string enabledField;
      private float gainField;
      /// <remarks/>
      public string enabled
      {
         get
         {
            return this.enabledField;
         }
         set
         {
            this.enabledField = value;
         }
      }
      /// <remarks/>
      public float gain
      {
         get
         {
            return this.gainField;
         }
         set
         {
            this.gainField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
   public partial class rootScriptsPreferencesVibrationGroupsDamage
   {
      private string enabledField;
      private float gainField;
      /// <remarks/>
      public string enabled
      {
         get
         {
            return this.enabledField;
         }
         set
         {
            this.enabledField = value;
         }
      }
      /// <remarks/>
      public float gain
      {
         get
         {
            return this.gainField;
         }
         set
         {
            this.gainField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
   public partial class rootScriptsPreferencesVibrationGroupsGui
   {
      private string enabledField;
      private float gainField;
      /// <remarks/>
      public string enabled
      {
         get
         {
            return this.enabledField;
         }
         set
         {
            this.enabledField = value;
         }
      }
      /// <remarks/>
      public float gain
      {
         get
         {
            return this.gainField;
         }
         set
         {
            this.gainField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
   public partial class rootScriptsPreferencesVibrationGroupsCollisions
   {
      private string enabledField;
      private float gainField;
      /// <remarks/>
      public string enabled
      {
         get
         {
            return this.enabledField;
         }
         set
         {
            this.enabledField = value;
         }
      }
      /// <remarks/>
      public float gain
      {
         get
         {
            return this.gainField;
         }
         set
         {
            this.gainField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
   public partial class rootScriptsPreferencesAccounts
   {
      private float versionField;
      private rootScriptsPreferencesAccountsAccount[] accountField;
      /// <remarks/>
      public float version
      {
         get
         {
            return this.versionField;
         }
         set
         {
            this.versionField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("account")]
      public rootScriptsPreferencesAccountsAccount[] account
      {
         get
         {
            return this.accountField;
         }
         set
         {
            this.accountField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
   public partial class rootScriptsPreferencesAccountsAccount
   {
      private string loginField;
      private rootScriptsPreferencesAccountsAccountSettings settingsField;
      private rootScriptsPreferencesAccountsAccountFavorites favoritesField;
      private rootScriptsPreferencesAccountsAccountFilters filtersField;
      /// <remarks/>
      public string login
      {
         get
         {
            return this.loginField;
         }
         set
         {
            this.loginField = value;
         }
      }
      /// <remarks/>
      public rootScriptsPreferencesAccountsAccountSettings settings
      {
         get
         {
            return this.settingsField;
         }
         set
         {
            this.settingsField = value;
         }
      }
      /// <remarks/>
      public rootScriptsPreferencesAccountsAccountFavorites favorites
      {
         get
         {
            return this.favoritesField;
         }
         set
         {
            this.favoritesField = value;
         }
      }
      /// <remarks/>
      public rootScriptsPreferencesAccountsAccountFilters filters
      {
         get
         {
            return this.filtersField;
         }
         set
         {
            this.filtersField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
   public partial class rootScriptsPreferencesAccountsAccountSettings
   {
      private string questsField;
      private string minimapSizeField;
      private string statsSortingField;
      private string knownSelectorBattlesField;
      private string players_panelField;
      private string enableVoIPField;
      /// <remarks/>
      public string quests
      {
         get
         {
            return this.questsField;
         }
         set
         {
            this.questsField = value;
         }
      }
      /// <remarks/>
      public string minimapSize
      {
         get
         {
            return this.minimapSizeField;
         }
         set
         {
            this.minimapSizeField = value;
         }
      }
      /// <remarks/>
      public string statsSorting
      {
         get
         {
            return this.statsSortingField;
         }
         set
         {
            this.statsSortingField = value;
         }
      }
      /// <remarks/>
      public string knownSelectorBattles
      {
         get
         {
            return this.knownSelectorBattlesField;
         }
         set
         {
            this.knownSelectorBattlesField = value;
         }
      }
      /// <remarks/>
      public string players_panel
      {
         get
         {
            return this.players_panelField;
         }
         set
         {
            this.players_panelField = value;
         }
      }
      /// <remarks/>
      public string enableVoIP
      {
         get
         {
            return this.enableVoIPField;
         }
         set
         {
            this.enableVoIPField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
   public partial class rootScriptsPreferencesAccountsAccountFavorites
   {
      private string currentField;
      /// <remarks/>
      public string current
      {
         get
         {
            return this.currentField;
         }
         set
         {
            this.currentField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
   public partial class rootScriptsPreferencesAccountsAccountFilters
   {
      private string inventory_vehicleField;
      private string inventory_currentField;
      private string inventory_optionalDeviceField;
      private string inventory_moduleField;
      private string inventory_equipmentField;
      private string hEADER_TUTORIALField;
      private string pROMOField;
      /// <remarks/>
      public string inventory_vehicle
      {
         get
         {
            return this.inventory_vehicleField;
         }
         set
         {
            this.inventory_vehicleField = value;
         }
      }
      /// <remarks/>
      public string inventory_current
      {
         get
         {
            return this.inventory_currentField;
         }
         set
         {
            this.inventory_currentField = value;
         }
      }
      /// <remarks/>
      public string inventory_optionalDevice
      {
         get
         {
            return this.inventory_optionalDeviceField;
         }
         set
         {
            this.inventory_optionalDeviceField = value;
         }
      }
      /// <remarks/>
      public string inventory_module
      {
         get
         {
            return this.inventory_moduleField;
         }
         set
         {
            this.inventory_moduleField = value;
         }
      }
      /// <remarks/>
      public string inventory_equipment
      {
         get
         {
            return this.inventory_equipmentField;
         }
         set
         {
            this.inventory_equipmentField = value;
         }
      }
      /// <remarks/>
      public string HEADER_TUTORIAL
      {
         get
         {
            return this.hEADER_TUTORIALField;
         }
         set
         {
            this.hEADER_TUTORIALField = value;
         }
      }
      /// <remarks/>
      public string PROMO
      {
         get
         {
            return this.pROMOField;
         }
         set
         {
            this.pROMOField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
   public partial class rootScriptsPreferencesWindowsStoredData
   {
      private float maskField;
      private float revField;
      private string[] recordsField;
      /// <remarks/>
      public float mask
      {
         get
         {
            return this.maskField;
         }
         set
         {
            this.maskField = value;
         }
      }
      /// <remarks/>
      public float rev
      {
         get
         {
            return this.revField;
         }
         set
         {
            this.revField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlArrayItemAttribute("record", IsNullable=false)]
      public string[] records
      {
         get
         {
            return this.recordsField;
         }
         set
         {
            this.recordsField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
   public partial class rootScriptsPreferencesLoginInfo
   {
      private string loginField;
      private string rememberPwdField;
      private string hostField;
      private string token2Field;
      private string saltField;
      private string peripheryLifeTimeField;
      private string lastLoginTypeField;
      private string userField;
      /// <remarks/>
      public string login
      {
         get
         {
            return this.loginField;
         }
         set
         {
            this.loginField = value;
         }
      }
      /// <remarks/>
      public string rememberPwd
      {
         get
         {
            return this.rememberPwdField;
         }
         set
         {
            this.rememberPwdField = value;
         }
      }
      /// <remarks/>
      public string host
      {
         get
         {
            return this.hostField;
         }
         set
         {
            this.hostField = value;
         }
      }
      /// <remarks/>
      public string token2
      {
         get
         {
            return this.token2Field;
         }
         set
         {
            this.token2Field = value;
         }
      }
      /// <remarks/>
      public string salt
      {
         get
         {
            return this.saltField;
         }
         set
         {
            this.saltField = value;
         }
      }
      /// <remarks/>
      public string peripheryLifeTime
      {
         get
         {
            return this.peripheryLifeTimeField;
         }
         set
         {
            this.peripheryLifeTimeField = value;
         }
      }
      /// <remarks/>
      public string lastLoginType
      {
         get
         {
            return this.lastLoginTypeField;
         }
         set
         {
            this.lastLoginTypeField = value;
         }
      }
      /// <remarks/>
      public string user
      {
         get
         {
            return this.userField;
         }
         set
         {
            this.userField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
   public partial class rootScriptsPreferencesLoginPage
   {
      private string lastLoginBgImageField;
      private string showLoginWallpaperField;
      /// <remarks/>
      public string lastLoginBgImage
      {
         get
         {
            return this.lastLoginBgImageField;
         }
         set
         {
            this.lastLoginBgImageField = value;
         }
      }
      /// <remarks/>
      public string showLoginWallpaper
      {
         get
         {
            return this.showLoginWallpaperField;
         }
         set
         {
            this.showLoginWallpaperField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
   public partial class rootScriptsPreferencesControlMode
   {
      private rootScriptsPreferencesControlModeArcadeMode arcadeModeField;
      private rootScriptsPreferencesControlModeStrategicMode strategicModeField;
      private rootScriptsPreferencesControlModeSniperMode sniperModeField;
      /// <remarks/>
      public rootScriptsPreferencesControlModeArcadeMode arcadeMode
      {
         get
         {
            return this.arcadeModeField;
         }
         set
         {
            this.arcadeModeField = value;
         }
      }
      /// <remarks/>
      public rootScriptsPreferencesControlModeStrategicMode strategicMode
      {
         get
         {
            return this.strategicModeField;
         }
         set
         {
            this.strategicModeField = value;
         }
      }
      /// <remarks/>
      public rootScriptsPreferencesControlModeSniperMode sniperMode
      {
         get
         {
            return this.sniperModeField;
         }
         set
         {
            this.sniperModeField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
   public partial class rootScriptsPreferencesControlModeArcadeMode
   {
      private rootScriptsPreferencesControlModeArcadeModeCamera cameraField;
      /// <remarks/>
      public rootScriptsPreferencesControlModeArcadeModeCamera camera
      {
         get
         {
            return this.cameraField;
         }
         set
         {
            this.cameraField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
   public partial class rootScriptsPreferencesControlModeArcadeModeCamera
   {
      private string horzInvertField;
      private string vertInvertField;
      private float keySensitivityField;
      private float sensitivityField;
      private float scrollSensitivityField;
      private float startDistField;
      private float fovMultMinDistField;
      private float fovMultMaxDistField;
      private float startAngleField;
      /// <remarks/>
      public string horzInvert
      {
         get
         {
            return this.horzInvertField;
         }
         set
         {
            this.horzInvertField = value;
         }
      }
      /// <remarks/>
      public string vertInvert
      {
         get
         {
            return this.vertInvertField;
         }
         set
         {
            this.vertInvertField = value;
         }
      }
      /// <remarks/>
      public float keySensitivity
      {
         get
         {
            return this.keySensitivityField;
         }
         set
         {
            this.keySensitivityField = value;
         }
      }
      /// <remarks/>
      public float sensitivity
      {
         get
         {
            return this.sensitivityField;
         }
         set
         {
            this.sensitivityField = value;
         }
      }
      /// <remarks/>
      public float scrollSensitivity
      {
         get
         {
            return this.scrollSensitivityField;
         }
         set
         {
            this.scrollSensitivityField = value;
         }
      }
      /// <remarks/>
      public float startDist
      {
         get
         {
            return this.startDistField;
         }
         set
         {
            this.startDistField = value;
         }
      }
      /// <remarks/>
      public float fovMultMinDist
      {
         get
         {
            return this.fovMultMinDistField;
         }
         set
         {
            this.fovMultMinDistField = value;
         }
      }
      /// <remarks/>
      public float fovMultMaxDist
      {
         get
         {
            return this.fovMultMaxDistField;
         }
         set
         {
            this.fovMultMaxDistField = value;
         }
      }
      /// <remarks/>
      public float startAngle
      {
         get
         {
            return this.startAngleField;
         }
         set
         {
            this.startAngleField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
   public partial class rootScriptsPreferencesControlModeStrategicMode
   {
      private rootScriptsPreferencesControlModeStrategicModeCamera cameraField;
      /// <remarks/>
      public rootScriptsPreferencesControlModeStrategicModeCamera camera
      {
         get
         {
            return this.cameraField;
         }
         set
         {
            this.cameraField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
   public partial class rootScriptsPreferencesControlModeStrategicModeCamera
   {
      private float keySensitivityField;
      private float sensitivityField;
      private float scrollSensitivityField;
      private float camDistField;
      /// <remarks/>
      public float keySensitivity
      {
         get
         {
            return this.keySensitivityField;
         }
         set
         {
            this.keySensitivityField = value;
         }
      }
      /// <remarks/>
      public float sensitivity
      {
         get
         {
            return this.sensitivityField;
         }
         set
         {
            this.sensitivityField = value;
         }
      }
      /// <remarks/>
      public float scrollSensitivity
      {
         get
         {
            return this.scrollSensitivityField;
         }
         set
         {
            this.scrollSensitivityField = value;
         }
      }
      /// <remarks/>
      public float camDist
      {
         get
         {
            return this.camDistField;
         }
         set
         {
            this.camDistField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
   public partial class rootScriptsPreferencesControlModeSniperMode
   {
      private rootScriptsPreferencesControlModeSniperModeCamera cameraField;
      /// <remarks/>
      public rootScriptsPreferencesControlModeSniperModeCamera camera
      {
         get
         {
            return this.cameraField;
         }
         set
         {
            this.cameraField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
   public partial class rootScriptsPreferencesControlModeSniperModeCamera
   {
      private string horzInvertField;
      private string vertInvertField;
      private float keySensitivityField;
      private float sensitivityField;
      private float scrollSensitivityField;
      private float zoomField;
      /// <remarks/>
      public string horzInvert
      {
         get
         {
            return this.horzInvertField;
         }
         set
         {
            this.horzInvertField = value;
         }
      }
      /// <remarks/>
      public string vertInvert
      {
         get
         {
            return this.vertInvertField;
         }
         set
         {
            this.vertInvertField = value;
         }
      }
      /// <remarks/>
      public float keySensitivity
      {
         get
         {
            return this.keySensitivityField;
         }
         set
         {
            this.keySensitivityField = value;
         }
      }
      /// <remarks/>
      public float sensitivity
      {
         get
         {
            return this.sensitivityField;
         }
         set
         {
            this.sensitivityField = value;
         }
      }
      /// <remarks/>
      public float scrollSensitivity
      {
         get
         {
            return this.scrollSensitivityField;
         }
         set
         {
            this.scrollSensitivityField = value;
         }
      }
      /// <remarks/>
      public float zoom
      {
         get
         {
            return this.zoomField;
         }
         set
         {
            this.zoomField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
   public partial class rootScriptsPreferencesXVM
   {
      private string tcarouselfiltersField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("tcarousel.filters")]
      public string tcarouselfilters
      {
         get
         {
            return this.tcarouselfiltersField;
         }
         set
         {
            this.tcarouselfiltersField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
   public partial class rootScriptsPreferencesCommandMapping
   {
      private rootScriptsPreferencesCommandMappingCMD_CHAT_SHORTCUT_ATTACK cMD_CHAT_SHORTCUT_ATTACKField;
      private rootScriptsPreferencesCommandMappingCMD_CM_LOCK_TARGET_OFF cMD_CM_LOCK_TARGET_OFFField;
      /// <remarks/>
      public rootScriptsPreferencesCommandMappingCMD_CHAT_SHORTCUT_ATTACK CMD_CHAT_SHORTCUT_ATTACK
      {
         get
         {
            return this.cMD_CHAT_SHORTCUT_ATTACKField;
         }
         set
         {
            this.cMD_CHAT_SHORTCUT_ATTACKField = value;
         }
      }
      /// <remarks/>
      public rootScriptsPreferencesCommandMappingCMD_CM_LOCK_TARGET_OFF CMD_CM_LOCK_TARGET_OFF
      {
         get
         {
            return this.cMD_CM_LOCK_TARGET_OFFField;
         }
         set
         {
            this.cMD_CM_LOCK_TARGET_OFFField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
   public partial class rootScriptsPreferencesCommandMappingCMD_CHAT_SHORTCUT_ATTACK
   {
      private string fireKeyField;
      private string satelliteKeysField;
      /// <remarks/>
      public string fireKey
      {
         get
         {
            return this.fireKeyField;
         }
         set
         {
            this.fireKeyField = value;
         }
      }
      /// <remarks/>
      public string satelliteKeys
      {
         get
         {
            return this.satelliteKeysField;
         }
         set
         {
            this.satelliteKeysField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
   public partial class rootScriptsPreferencesCommandMappingCMD_CM_LOCK_TARGET_OFF
   {
      private string fireKeyField;
      private string satelliteKeysField;
      /// <remarks/>
      public string fireKey
      {
         get
         {
            return this.fireKeyField;
         }
         set
         {
            this.fireKeyField = value;
         }
      }
      /// <remarks/>
      public string satelliteKeys
      {
         get
         {
            return this.satelliteKeysField;
         }
         set
         {
            this.satelliteKeysField = value;
         }
      }
   }
}
