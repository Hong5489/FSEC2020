
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Content.Res;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.App;
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Security.Cryptography;
using System.Text;
using Xamarin.Essentials;
​
[assembly: CompilationRelaxations(8)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: ResourceDesigner("PwdGen.Resource", IsApplication = true)]
[assembly: AssemblyTitle("PwdChecker")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("PwdChecker")]
[assembly: AssemblyCopyright("Copyright Â©  2018")]
[assembly: AssemblyTrademark("")]
[assembly: ComVisible(false)]
[assembly: AssemblyFileVersion("1.0.0.0")]
[assembly: TargetFramework("MonoAndroid,Version=v8.1", FrameworkDisplayName = "Xamarin.Android v8.1 Support")]
[assembly: AssemblyVersion("1.0.0.0")]
namespace PwdGen
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private string key;
​
        private string stronkPwd;
​
        protected override void OnCreate(Bundle savedInstanceState)
        {
            ((Activity)this).OnCreate(savedInstanceState);
            Platform.Init((Activity)(object)this, savedInstanceState);
            ((Activity)this).SetContentView(2131361818);
            Toolbar supportActionBar = ((Activity)this).FindViewById<Toolbar>(2131230884);
            ((AppCompatActivity)this).SetSupportActionBar(supportActionBar);
            string iV = "3058591d-a6f3-48";
            byte[] cipherTextBytes = Utils.ReadAsset("enc.bin", ((Context)this).get_Assets());
            key = Utils.Decrypt(cipherTextBytes, iV);
            ((View)((Activity)this).FindViewById<Button>(2131230868)).add_Click((EventHandler)BtnOnClick);
        }
​
        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            ((Activity)this).get_MenuInflater().Inflate(2131427328, menu);
            return true;
        }
​
        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            if (item.get_ItemId() == 2131230743)
            {
                return true;
            }
            return ((Activity)this).OnOptionsItemSelected(item);
        }
​
        private void BtnOnClick(object sender, EventArgs eventArgs)
        {
            string text = ((TextView)((Activity)this).FindViewById<EditText>(2131230827)).get_Text();
            byte[] array = new byte[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                array[i] = (byte)(text[i] ^ key[i]);
            }
            char[] array2 = new char[5000];
            Convert.ToBase64CharArray(array, 0, array.Length, array2, 0);
            stronkPwd = new string(array2);
            stronkPwd = stronkPwd.Replace("\0", string.Empty);
            Toast.MakeText(Application.get_Context(), "New password is " + stronkPwd, (ToastLength)1).Show();
        }
​
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Permission[] grantResults)
        {
            Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            ((FragmentActivity)this).OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
​
        public MainActivity()
            : this()
        {
        }
    }
    [GeneratedCode("Xamarin.Android.Build.Tasks", "1.0.0.0")]
    public class Resource
    {
        public class Animation
        {
            public const int abc_fade_in = 2130771968;
​
            public const int abc_fade_out = 2130771969;
​
            public const int abc_grow_fade_in_from_bottom = 2130771970;
​
            public const int abc_popup_enter = 2130771971;
​
            public const int abc_popup_exit = 2130771972;
​
            public const int abc_shrink_fade_out_from_bottom = 2130771973;
​
            public const int abc_slide_in_bottom = 2130771974;
​
            public const int abc_slide_in_top = 2130771975;
​
            public const int abc_slide_out_bottom = 2130771976;
​
            public const int abc_slide_out_top = 2130771977;
​
            public const int design_bottom_sheet_slide_in = 2130771978;
​
            public const int design_bottom_sheet_slide_out = 2130771979;
​
            public const int design_snackbar_in = 2130771980;
​
            public const int design_snackbar_out = 2130771981;
​
            public const int tooltip_enter = 2130771982;
​
            public const int tooltip_exit = 2130771983;
​
            static Animation()
            {
                ResourceIdManager.UpdateIdValues();
            }
​
            private Animation()
            {
            }
        }
​
        public class Animator
        {
            public const int design_appbar_state_list_animator = 2130837504;
​
            static Animator()
            {
                ResourceIdManager.UpdateIdValues();
            }
​
            private Animator()
            {
            }
        }
​
        public class Attribute
        {
            public const int actionBarDivider = 2130903040;
​
            public const int actionBarItemBackground = 2130903041;
​
            public const int actionBarPopupTheme = 2130903042;
​
            public const int actionBarSize = 2130903043;
​
            public const int actionBarSplitStyle = 2130903044;
​
            public const int actionBarStyle = 2130903045;
​
            public const int actionBarTabBarStyle = 2130903046;
​
            public const int actionBarTabStyle = 2130903047;
​
            public const int actionBarTabTextStyle = 2130903048;
​
            public const int actionBarTheme = 2130903049;
​
            public const int actionBarWidgetTheme = 2130903050;
​
            public const int actionButtonStyle = 2130903051;
​
            public const int actionDropDownStyle = 2130903052;
​
            public const int actionLayout = 2130903053;
​
            public const int actionMenuTextAppearance = 2130903054;
​
            public const int actionMenuTextColor = 2130903055;
​
            public const int actionModeBackground = 2130903056;
​
            public const int actionModeCloseButtonStyle = 2130903057;
​
            public const int actionModeCloseDrawable = 2130903058;
​
            public const int actionModeCopyDrawable = 2130903059;
​
            public const int actionModeCutDrawable = 2130903060;
​
            public const int actionModeFindDrawable = 2130903061;
​
            public const int actionModePasteDrawable = 2130903062;
​
            public const int actionModePopupWindowStyle = 2130903063;
​
            public const int actionModeSelectAllDrawable = 2130903064;
​
            public const int actionModeShareDrawable = 2130903065;
​
            public const int actionModeSplitBackground = 2130903066;
​
            public const int actionModeStyle = 2130903067;
​
            public const int actionModeWebSearchDrawable = 2130903068;
​
            public const int actionOverflowButtonStyle = 2130903069;
​
            public const int actionOverflowMenuStyle = 2130903070;
​
            public const int actionProviderClass = 2130903071;
​
            public const int actionViewClass = 2130903072;
​
            public const int activityChooserViewStyle = 2130903073;
​
            public const int alertDialogButtonGroupStyle = 2130903074;
​
            public const int alertDialogCenterButtons = 2130903075;
​
            public const int alertDialogStyle = 2130903076;
​
            public const int alertDialogTheme = 2130903077;
​
            public const int allowStacking = 2130903078;
​
            public const int alpha = 2130903079;
​
            public const int alphabeticModifiers = 2130903080;
​
            public const int arrowHeadLength = 2130903081;
​
            public const int arrowShaftLength = 2130903082;
​
            public const int autoCompleteTextViewStyle = 2130903083;
​
            public const int autoSizeMaxTextSize = 2130903084;
​
            public const int autoSizeMinTextSize = 2130903085;
​
            public const int autoSizePresetSizes = 2130903086;
​
            public const int autoSizeStepGranularity = 2130903087;
​
            public const int autoSizeTextType = 2130903088;
​
            public const int background = 2130903089;
​
            public const int backgroundSplit = 2130903090;
​
            public const int backgroundStacked = 2130903091;
​
            public const int backgroundTint = 2130903092;
​
            public const int backgroundTintMode = 2130903093;
​
            public const int barLength = 2130903094;
​
            public const int behavior_autoHide = 2130903095;
​
            public const int behavior_hideable = 2130903096;
​
            public const int behavior_overlapTop = 2130903097;
​
            public const int behavior_peekHeight = 2130903098;
​
            public const int behavior_skipCollapsed = 2130903099;
​
            public const int borderlessButtonStyle = 2130903101;
​
            public const int borderWidth = 2130903100;
​
            public const int bottomSheetDialogTheme = 2130903102;
​
            public const int bottomSheetStyle = 2130903103;
​
            public const int buttonBarButtonStyle = 2130903104;
​
            public const int buttonBarNegativeButtonStyle = 2130903105;
​
            public const int buttonBarNeutralButtonStyle = 2130903106;
​
            public const int buttonBarPositiveButtonStyle = 2130903107;
​
            public const int buttonBarStyle = 2130903108;
​
            public const int buttonGravity = 2130903109;
​
            public const int buttonPanelSideLayout = 2130903110;
​
            public const int buttonStyle = 2130903111;
​
            public const int buttonStyleSmall = 2130903112;
​
            public const int buttonTint = 2130903113;
​
            public const int buttonTintMode = 2130903114;
​
            public const int checkboxStyle = 2130903115;
​
            public const int checkedTextViewStyle = 2130903116;
​
            public const int closeIcon = 2130903117;
​
            public const int closeItemLayout = 2130903118;
​
            public const int collapseContentDescription = 2130903119;
​
            public const int collapsedTitleGravity = 2130903121;
​
            public const int collapsedTitleTextAppearance = 2130903122;
​
            public const int collapseIcon = 2130903120;
​
            public const int color = 2130903123;
​
            public const int colorAccent = 2130903124;
​
            public const int colorBackgroundFloating = 2130903125;
​
            public const int colorButtonNormal = 2130903126;
​
            public const int colorControlActivated = 2130903127;
​
            public const int colorControlHighlight = 2130903128;
​
            public const int colorControlNormal = 2130903129;
​
            public const int colorError = 2130903130;
​
            public const int colorPrimary = 2130903131;
​
            public const int colorPrimaryDark = 2130903132;
​
            public const int colorSwitchThumbNormal = 2130903133;
​
            public const int commitIcon = 2130903134;
​
            public const int contentDescription = 2130903135;
​
            public const int contentInsetEnd = 2130903136;
​
            public const int contentInsetEndWithActions = 2130903137;
​
            public const int contentInsetLeft = 2130903138;
​
            public const int contentInsetRight = 2130903139;
​
            public const int contentInsetStart = 2130903140;
​
            public const int contentInsetStartWithNavigation = 2130903141;
​
            public const int contentScrim = 2130903142;
​
            public const int controlBackground = 2130903143;
​
            public const int counterEnabled = 2130903144;
​
            public const int counterMaxLength = 2130903145;
​
            public const int counterOverflowTextAppearance = 2130903146;
​
            public const int counterTextAppearance = 2130903147;
​
            public const int customNavigationLayout = 2130903148;
​
            public const int defaultQueryHint = 2130903149;
​
            public const int dialogPreferredPadding = 2130903150;
​
            public const int dialogTheme = 2130903151;
​
            public const int displayOptions = 2130903152;
​
            public const int divider = 2130903153;
​
            public const int dividerHorizontal = 2130903154;
​
            public const int dividerPadding = 2130903155;
​
            public const int dividerVertical = 2130903156;
​
            public const int drawableSize = 2130903157;
​
            public const int drawerArrowStyle = 2130903158;
​
            public const int dropdownListPreferredItemHeight = 2130903160;
​
            public const int dropDownListViewStyle = 2130903159;
​
            public const int editTextBackground = 2130903161;
​
            public const int editTextColor = 2130903162;
​
            public const int editTextStyle = 2130903163;
​
            public const int elevation = 2130903164;
​
            public const int errorEnabled = 2130903165;
​
            public const int errorTextAppearance = 2130903166;
​
            public const int expandActivityOverflowButtonDrawable = 2130903167;
​
            public const int expanded = 2130903168;
​
            public const int expandedTitleGravity = 2130903169;
​
            public const int expandedTitleMargin = 2130903170;
​
            public const int expandedTitleMarginBottom = 2130903171;
​
            public const int expandedTitleMarginEnd = 2130903172;
​
            public const int expandedTitleMarginStart = 2130903173;
​
            public const int expandedTitleMarginTop = 2130903174;
​
            public const int expandedTitleTextAppearance = 2130903175;
​
            public const int fabSize = 2130903176;
​
            public const int fastScrollEnabled = 2130903177;
​
            public const int fastScrollHorizontalThumbDrawable = 2130903178;
​
            public const int fastScrollHorizontalTrackDrawable = 2130903179;
​
            public const int fastScrollVerticalThumbDrawable = 2130903180;
​
            public const int fastScrollVerticalTrackDrawable = 2130903181;
​
            public const int font = 2130903182;
​
            public const int fontFamily = 2130903183;
​
            public const int fontProviderAuthority = 2130903184;
​
            public const int fontProviderCerts = 2130903185;
​
            public const int fontProviderFetchStrategy = 2130903186;
​
            public const int fontProviderFetchTimeout = 2130903187;
​
            public const int fontProviderPackage = 2130903188;
​
            public const int fontProviderQuery = 2130903189;
​
            public const int fontStyle = 2130903190;
​
            public const int fontWeight = 2130903191;
​
            public const int foregroundInsidePadding = 2130903192;
​
            public const int gapBetweenBars = 2130903193;
​
            public const int goIcon = 2130903194;
​
            public const int headerLayout = 2130903195;
​
            public const int height = 2130903196;
​
            public const int hideOnContentScroll = 2130903197;
​
            public const int hintAnimationEnabled = 2130903198;
​
            public const int hintEnabled = 2130903199;
​
            public const int hintTextAppearance = 2130903200;
​
            public const int homeAsUpIndicator = 2130903201;
​
            public const int homeLayout = 2130903202;
​
            public const int icon = 2130903203;
​
            public const int iconifiedByDefault = 2130903206;
​
            public const int iconTint = 2130903204;
​
            public const int iconTintMode = 2130903205;
​
            public const int imageButtonStyle = 2130903207;
​
            public const int indeterminateProgressStyle = 2130903208;
​
            public const int initialActivityCount = 2130903209;
​
            public const int insetForeground = 2130903210;
​
            public const int isLightTheme = 2130903211;
​
            public const int itemBackground = 2130903212;
​
            public const int itemIconTint = 2130903213;
​
            public const int itemPadding = 2130903214;
​
            public const int itemTextAppearance = 2130903215;
​
            public const int itemTextColor = 2130903216;
​
            public const int keylines = 2130903217;
​
            public const int layout = 2130903218;
​
            public const int layoutManager = 2130903219;
​
            public const int layout_anchor = 2130903220;
​
            public const int layout_anchorGravity = 2130903221;
​
            public const int layout_behavior = 2130903222;
​
            public const int layout_collapseMode = 2130903223;
​
            public const int layout_collapseParallaxMultiplier = 2130903224;
​
            public const int layout_dodgeInsetEdges = 2130903225;
​
            public const int layout_insetEdge = 2130903226;
​
            public const int layout_keyline = 2130903227;
​
            public const int layout_scrollFlags = 2130903228;
​
            public const int layout_scrollInterpolator = 2130903229;
​
            public const int listChoiceBackgroundIndicator = 2130903230;
​
            public const int listDividerAlertDialog = 2130903231;
​
            public const int listItemLayout = 2130903232;
​
            public const int listLayout = 2130903233;
​
            public const int listMenuViewStyle = 2130903234;
​
            public const int listPopupWindowStyle = 2130903235;
​
            public const int listPreferredItemHeight = 2130903236;
​
            public const int listPreferredItemHeightLarge = 2130903237;
​
            public const int listPreferredItemHeightSmall = 2130903238;
​
            public const int listPreferredItemPaddingLeft = 2130903239;
​
            public const int listPreferredItemPaddingRight = 2130903240;
​
            public const int logo = 2130903241;
​
            public const int logoDescription = 2130903242;
​
            public const int maxActionInlineWidth = 2130903243;
​
            public const int maxButtonHeight = 2130903244;
​
            public const int measureWithLargestChild = 2130903245;
​
            public const int menu = 2130903246;
​
            public const int multiChoiceItemLayout = 2130903247;
​
            public const int navigationContentDescription = 2130903248;
​
            public const int navigationIcon = 2130903249;
​
            public const int navigationMode = 2130903250;
​
            public const int numericModifiers = 2130903251;
​
            public const int overlapAnchor = 2130903252;
​
            public const int paddingBottomNoButtons = 2130903253;
​
            public const int paddingEnd = 2130903254;
​
            public const int paddingStart = 2130903255;
​
            public const int paddingTopNoTitle = 2130903256;
​
            public const int panelBackground = 2130903257;
​
            public const int panelMenuListTheme = 2130903258;
​
            public const int panelMenuListWidth = 2130903259;
​
            public const int passwordToggleContentDescription = 2130903260;
​
            public const int passwordToggleDrawable = 2130903261;
​
            public const int passwordToggleEnabled = 2130903262;
​
            public const int passwordToggleTint = 2130903263;
​
            public const int passwordToggleTintMode = 2130903264;
​
            public const int popupMenuStyle = 2130903265;
​
            public const int popupTheme = 2130903266;
​
            public const int popupWindowStyle = 2130903267;
​
            public const int preserveIconSpacing = 2130903268;
​
            public const int pressedTranslationZ = 2130903269;
​
            public const int progressBarPadding = 2130903270;
​
            public const int progressBarStyle = 2130903271;
​
            public const int queryBackground = 2130903272;
​
            public const int queryHint = 2130903273;
​
            public const int radioButtonStyle = 2130903274;
​
            public const int ratingBarStyle = 2130903275;
​
            public const int ratingBarStyleIndicator = 2130903276;
​
            public const int ratingBarStyleSmall = 2130903277;
​
            public const int reverseLayout = 2130903278;
​
            public const int rippleColor = 2130903279;
​
            public const int scrimAnimationDuration = 2130903280;
​
            public const int scrimVisibleHeightTrigger = 2130903281;
​
            public const int searchHintIcon = 2130903282;
​
            public const int searchIcon = 2130903283;
​
            public const int searchViewStyle = 2130903284;
​
            public const int seekBarStyle = 2130903285;
​
            public const int selectableItemBackground = 2130903286;
​
            public const int selectableItemBackgroundBorderless = 2130903287;
​
            public const int showAsAction = 2130903288;
​
            public const int showDividers = 2130903289;
​
            public const int showText = 2130903290;
​
            public const int showTitle = 2130903291;
​
            public const int singleChoiceItemLayout = 2130903292;
​
            public const int spanCount = 2130903293;
​
            public const int spinBars = 2130903294;
​
            public const int spinnerDropDownItemStyle = 2130903295;
​
            public const int spinnerStyle = 2130903296;
​
            public const int splitTrack = 2130903297;
​
            public const int srcCompat = 2130903298;
​
            public const int stackFromEnd = 2130903299;
​
            public const int state_above_anchor = 2130903300;
​
            public const int state_collapsed = 2130903301;
​
            public const int state_collapsible = 2130903302;
​
            public const int statusBarBackground = 2130903303;
​
            public const int statusBarScrim = 2130903304;
​
            public const int subMenuArrow = 2130903305;
​
            public const int submitBackground = 2130903306;
​
            public const int subtitle = 2130903307;
​
            public const int subtitleTextAppearance = 2130903308;
​
            public const int subtitleTextColor = 2130903309;
​
            public const int subtitleTextStyle = 2130903310;
​
            public const int suggestionRowLayout = 2130903311;
​
            public const int switchMinWidth = 2130903312;
​
            public const int switchPadding = 2130903313;
​
            public const int switchStyle = 2130903314;
​
            public const int switchTextAppearance = 2130903315;
​
            public const int tabBackground = 2130903316;
​
            public const int tabContentStart = 2130903317;
​
            public const int tabGravity = 2130903318;
​
            public const int tabIndicatorColor = 2130903319;
​
            public const int tabIndicatorHeight = 2130903320;
​
            public const int tabMaxWidth = 2130903321;
​
            public const int tabMinWidth = 2130903322;
​
            public const int tabMode = 2130903323;
​
            public const int tabPadding = 2130903324;
​
            public const int tabPaddingBottom = 2130903325;
​
            public const int tabPaddingEnd = 2130903326;
​
            public const int tabPaddingStart = 2130903327;
​
            public const int tabPaddingTop = 2130903328;
​
            public const int tabSelectedTextColor = 2130903329;
​
            public const int tabTextAppearance = 2130903330;
​
            public const int tabTextColor = 2130903331;
​
            public const int textAllCaps = 2130903332;
​
            public const int textAppearanceLargePopupMenu = 2130903333;
​
            public const int textAppearanceListItem = 2130903334;
​
            public const int textAppearanceListItemSecondary = 2130903335;
​
            public const int textAppearanceListItemSmall = 2130903336;
​
            public const int textAppearancePopupMenuHeader = 2130903337;
​
            public const int textAppearanceSearchResultSubtitle = 2130903338;
​
            public const int textAppearanceSearchResultTitle = 2130903339;
​
            public const int textAppearanceSmallPopupMenu = 2130903340;
​
            public const int textColorAlertDialogListItem = 2130903341;
​
            public const int textColorError = 2130903342;
​
            public const int textColorSearchUrl = 2130903343;
​
            public const int theme = 2130903344;
​
            public const int thickness = 2130903345;
​
            public const int thumbTextPadding = 2130903346;
​
            public const int thumbTint = 2130903347;
​
            public const int thumbTintMode = 2130903348;
​
            public const int tickMark = 2130903349;
​
            public const int tickMarkTint = 2130903350;
​
            public const int tickMarkTintMode = 2130903351;
​
            public const int tint = 2130903352;
​
            public const int tintMode = 2130903353;
​
            public const int title = 2130903354;
​
            public const int titleEnabled = 2130903355;
​
            public const int titleMargin = 2130903356;
​
            public const int titleMarginBottom = 2130903357;
​
            public const int titleMarginEnd = 2130903358;
​
            public const int titleMargins = 2130903361;
​
            public const int titleMarginStart = 2130903359;
​
            public const int titleMarginTop = 2130903360;
​
            public const int titleTextAppearance = 2130903362;
​
            public const int titleTextColor = 2130903363;
​
            public const int titleTextStyle = 2130903364;
​
            public const int toolbarId = 2130903365;
​
            public const int toolbarNavigationButtonStyle = 2130903366;
​
            public const int toolbarStyle = 2130903367;
​
            public const int tooltipForegroundColor = 2130903368;
​
            public const int tooltipFrameBackground = 2130903369;
​
            public const int tooltipText = 2130903370;
​
            public const int track = 2130903371;
​
            public const int trackTint = 2130903372;
​
            public const int trackTintMode = 2130903373;
​
            public const int useCompatPadding = 2130903374;
​
            public const int voiceIcon = 2130903375;
​
            public const int windowActionBar = 2130903376;
​
            public const int windowActionBarOverlay = 2130903377;
​
            public const int windowActionModeOverlay = 2130903378;
​
            public const int windowFixedHeightMajor = 2130903379;
​
            public const int windowFixedHeightMinor = 2130903380;
​
            public const int windowFixedWidthMajor = 2130903381;
​
            public const int windowFixedWidthMinor = 2130903382;
​
            public const int windowMinWidthMajor = 2130903383;
​
            public const int windowMinWidthMinor = 2130903384;
​
            public const int windowNoTitle = 2130903385;
​
            static Attribute()
            {
                ResourceIdManager.UpdateIdValues();
            }
​
            private Attribute()
            {
            }
        }
​
        public class Boolean
        {
            public const int abc_action_bar_embed_tabs = 2130968576;
​
            public const int abc_allow_stacked_button_bar = 2130968577;
​
            public const int abc_config_actionMenuItemAllCaps = 2130968578;
​
            public const int abc_config_closeDialogWhenTouchOutside = 2130968579;
​
            public const int abc_config_showMenuShortcutsWhenKeyboardPresent = 2130968580;
​
            static Boolean()
            {
                ResourceIdManager.UpdateIdValues();
            }
​
            private Boolean()
            {
            }
        }
​
        public class Color
        {
            public const int abc_background_cache_hint_selector_material_dark = 2131034112;
​
            public const int abc_background_cache_hint_selector_material_light = 2131034113;
​
            public const int abc_btn_colored_borderless_text_material = 2131034114;
​
            public const int abc_btn_colored_text_material = 2131034115;
​
            public const int abc_color_highlight_material = 2131034116;
​
            public const int abc_hint_foreground_material_dark = 2131034117;
​
            public const int abc_hint_foreground_material_light = 2131034118;
​
            public const int abc_input_method_navigation_guard = 2131034119;
​
            public const int abc_primary_text_disable_only_material_dark = 2131034120;
​
            public const int abc_primary_text_disable_only_material_light = 2131034121;
​
            public const int abc_primary_text_material_dark = 2131034122;
​
            public const int abc_primary_text_material_light = 2131034123;
​
            public const int abc_search_url_text = 2131034124;
​
            public const int abc_search_url_text_normal = 2131034125;
​
            public const int abc_search_url_text_pressed = 2131034126;
​
            public const int abc_search_url_text_selected = 2131034127;
​
            public const int abc_secondary_text_material_dark = 2131034128;
​
            public const int abc_secondary_text_material_light = 2131034129;
​
            public const int abc_tint_btn_checkable = 2131034130;
​
            public const int abc_tint_default = 2131034131;
​
            public const int abc_tint_edittext = 2131034132;
​
            public const int abc_tint_seek_thumb = 2131034133;
​
            public const int abc_tint_spinner = 2131034134;
​
            public const int abc_tint_switch_track = 2131034135;
​
            public const int accent_material_dark = 2131034136;
​
            public const int accent_material_light = 2131034137;
​
            public const int background_floating_material_dark = 2131034138;
​
            public const int background_floating_material_light = 2131034139;
​
            public const int background_material_dark = 2131034140;
​
            public const int background_material_light = 2131034141;
​
            public const int bright_foreground_disabled_material_dark = 2131034142;
​
            public const int bright_foreground_disabled_material_light = 2131034143;
​
            public const int bright_foreground_inverse_material_dark = 2131034144;
​
            public const int bright_foreground_inverse_material_light = 2131034145;
​
            public const int bright_foreground_material_dark = 2131034146;
​
            public const int bright_foreground_material_light = 2131034147;
​
            public const int button_material_dark = 2131034148;
​
            public const int button_material_light = 2131034149;
​
            public const int colorAccent = 2131034150;
​
            public const int colorPrimary = 2131034151;
​
            public const int colorPrimaryDark = 2131034152;
​
            public const int design_bottom_navigation_shadow_color = 2131034153;
​
            public const int design_error = 2131034154;
​
            public const int design_fab_shadow_end_color = 2131034155;
​
            public const int design_fab_shadow_mid_color = 2131034156;
​
            public const int design_fab_shadow_start_color = 2131034157;
​
            public const int design_fab_stroke_end_inner_color = 2131034158;
​
            public const int design_fab_stroke_end_outer_color = 2131034159;
​
            public const int design_fab_stroke_top_inner_color = 2131034160;
​
            public const int design_fab_stroke_top_outer_color = 2131034161;
​
            public const int design_snackbar_background_color = 2131034162;
​
            public const int design_tint_password_toggle = 2131034163;
​
            public const int dim_foreground_disabled_material_dark = 2131034164;
​
            public const int dim_foreground_disabled_material_light = 2131034165;
​
            public const int dim_foreground_material_dark = 2131034166;
​
            public const int dim_foreground_material_light = 2131034167;
​
            public const int error_color_material = 2131034168;
​
            public const int foreground_material_dark = 2131034169;
​
            public const int foreground_material_light = 2131034170;
​
            public const int highlighted_text_material_dark = 2131034171;
​
            public const int highlighted_text_material_light = 2131034172;
​
            public const int ic_launcher_background = 2131034173;
​
            public const int material_blue_grey_800 = 2131034174;
​
            public const int material_blue_grey_900 = 2131034175;
​
            public const int material_blue_grey_950 = 2131034176;
​
            public const int material_deep_teal_200 = 2131034177;
​
            public const int material_deep_teal_500 = 2131034178;
​
            public const int material_grey_100 = 2131034179;
​
            public const int material_grey_300 = 2131034180;
​
            public const int material_grey_50 = 2131034181;
​
            public const int material_grey_600 = 2131034182;
​
            public const int material_grey_800 = 2131034183;
​
            public const int material_grey_850 = 2131034184;
​
            public const int material_grey_900 = 2131034185;
​
            public const int notification_action_color_filter = 2131034186;
​
            public const int notification_icon_bg_color = 2131034187;
​
            public const int notification_material_background_media_default_color = 2131034188;
​
            public const int primary_dark_material_dark = 2131034189;
​
            public const int primary_dark_material_light = 2131034190;
​
            public const int primary_material_dark = 2131034191;
​
            public const int primary_material_light = 2131034192;
​
            public const int primary_text_default_material_dark = 2131034193;
​
            public const int primary_text_default_material_light = 2131034194;
​
            public const int primary_text_disabled_material_dark = 2131034195;
​
            public const int primary_text_disabled_material_light = 2131034196;
​
            public const int ripple_material_dark = 2131034197;
​
            public const int ripple_material_light = 2131034198;
​
            public const int secondary_text_default_material_dark = 2131034199;
​
            public const int secondary_text_default_material_light = 2131034200;
​
            public const int secondary_text_disabled_material_dark = 2131034201;
​
            public const int secondary_text_disabled_material_light = 2131034202;
​
            public const int switch_thumb_disabled_material_dark = 2131034203;
​
            public const int switch_thumb_disabled_material_light = 2131034204;
​
            public const int switch_thumb_material_dark = 2131034205;
​
            public const int switch_thumb_material_light = 2131034206;
​
            public const int switch_thumb_normal_material_dark = 2131034207;
​
            public const int switch_thumb_normal_material_light = 2131034208;
​
            public const int tooltip_background_dark = 2131034209;
​
            public const int tooltip_background_light = 2131034210;
​
            static Color()
            {
                ResourceIdManager.UpdateIdValues();
            }
​
            private Color()
            {
            }
        }
​
        public class Dimension
        {
            public const int abc_action_bar_content_inset_material = 2131099648;
​
            public const int abc_action_bar_content_inset_with_nav = 2131099649;
​
            public const int abc_action_bar_default_height_material = 2131099650;
​
            public const int abc_action_bar_default_padding_end_material = 2131099651;
​
            public const int abc_action_bar_default_padding_start_material = 2131099652;
​
            public const int abc_action_bar_elevation_material = 2131099653;
​
            public const int abc_action_bar_icon_vertical_padding_material = 2131099654;
​
            public const int abc_action_bar_overflow_padding_end_material = 2131099655;
​
            public const int abc_action_bar_overflow_padding_start_material = 2131099656;
​
            public const int abc_action_bar_progress_bar_size = 2131099657;
​
            public const int abc_action_bar_stacked_max_height = 2131099658;
​
            public const int abc_action_bar_stacked_tab_max_width = 2131099659;
​
            public const int abc_action_bar_subtitle_bottom_margin_material = 2131099660;
​
            public const int abc_action_bar_subtitle_top_margin_material = 2131099661;
​
            public const int abc_action_button_min_height_material = 2131099662;
​
            public const int abc_action_button_min_width_material = 2131099663;
​
            public const int abc_action_button_min_width_overflow_material = 2131099664;
​
            public const int abc_alert_dialog_button_bar_height = 2131099665;
​
            public const int abc_button_inset_horizontal_material = 2131099666;
​
            public const int abc_button_inset_vertical_material = 2131099667;
​
            public const int abc_button_padding_horizontal_material = 2131099668;
​
            public const int abc_button_padding_vertical_material = 2131099669;
​
            public const int abc_cascading_menus_min_smallest_width = 2131099670;
​
            public const int abc_config_prefDialogWidth = 2131099671;
​
            public const int abc_control_corner_material = 2131099672;
​
            public const int abc_control_inset_material = 2131099673;
​
            public const int abc_control_padding_material = 2131099674;
​
            public const int abc_dialog_fixed_height_major = 2131099675;
​
            public const int abc_dialog_fixed_height_minor = 2131099676;
​
            public const int abc_dialog_fixed_width_major = 2131099677;
​
            public const int abc_dialog_fixed_width_minor = 2131099678;
​
            public const int abc_dialog_list_padding_bottom_no_buttons = 2131099679;
​
            public const int abc_dialog_list_padding_top_no_title = 2131099680;
​
            public const int abc_dialog_min_width_major = 2131099681;
​
            public const int abc_dialog_min_width_minor = 2131099682;
​
            public const int abc_dialog_padding_material = 2131099683;
​
            public const int abc_dialog_padding_top_material = 2131099684;
​
            public const int abc_dialog_title_divider_material = 2131099685;
​
            public const int abc_disabled_alpha_material_dark = 2131099686;
​
            public const int abc_disabled_alpha_material_light = 2131099687;
​
            public const int abc_dropdownitem_icon_width = 2131099688;
​
            public const int abc_dropdownitem_text_padding_left = 2131099689;
​
            public const int abc_dropdownitem_text_padding_right = 2131099690;
​
            public const int abc_edit_text_inset_bottom_material = 2131099691;
​
            public const int abc_edit_text_inset_horizontal_material = 2131099692;
​
            public const int abc_edit_text_inset_top_material = 2131099693;
​
            public const int abc_floating_window_z = 2131099694;
​
            public const int abc_list_item_padding_horizontal_material = 2131099695;
​
            public const int abc_panel_menu_list_width = 2131099696;
​
            public const int abc_progress_bar_height_material = 2131099697;
​
            public const int abc_search_view_preferred_height = 2131099698;
​
            public const int abc_search_view_preferred_width = 2131099699;
​
            public const int abc_seekbar_track_background_height_material = 2131099700;
​
            public const int abc_seekbar_track_progress_height_material = 2131099701;
​
            public const int abc_select_dialog_padding_start_material = 2131099702;
​
            public const int abc_switch_padding = 2131099703;
​
            public const int abc_text_size_body_1_material = 2131099704;
​
            public const int abc_text_size_body_2_material = 2131099705;
​
            public const int abc_text_size_button_material = 2131099706;
​
            public const int abc_text_size_caption_material = 2131099707;
​
            public const int abc_text_size_display_1_material = 2131099708;
​
            public const int abc_text_size_display_2_material = 2131099709;
​
            public const int abc_text_size_display_3_material = 2131099710;
​
            public const int abc_text_size_display_4_material = 2131099711;
​
            public const int abc_text_size_headline_material = 2131099712;
​
            public const int abc_text_size_large_material = 2131099713;
​
            public const int abc_text_size_medium_material = 2131099714;
​
            public const int abc_text_size_menu_header_material = 2131099715;
​
            public const int abc_text_size_menu_material = 2131099716;
​
            public const int abc_text_size_small_material = 2131099717;
​
            public const int abc_text_size_subhead_material = 2131099718;
​
            public const int abc_text_size_subtitle_material_toolbar = 2131099719;
​
            public const int abc_text_size_title_material = 2131099720;
​
            public const int abc_text_size_title_material_toolbar = 2131099721;
​
            public const int compat_button_inset_horizontal_material = 2131099722;
​
            public const int compat_button_inset_vertical_material = 2131099723;
​
            public const int compat_button_padding_horizontal_material = 2131099724;
​
            public const int compat_button_padding_vertical_material = 2131099725;
​
            public const int compat_control_corner_material = 2131099726;
​
            public const int design_appbar_elevation = 2131099727;
​
            public const int design_bottom_navigation_active_item_max_width = 2131099728;
​
            public const int design_bottom_navigation_active_text_size = 2131099729;
​
            public const int design_bottom_navigation_elevation = 2131099730;
​
            public const int design_bottom_navigation_height = 2131099731;
​
            public const int design_bottom_navigation_item_max_width = 2131099732;
​
            public const int design_bottom_navigation_item_min_width = 2131099733;
​
            public const int design_bottom_navigation_margin = 2131099734;
​
            public const int design_bottom_navigation_shadow_height = 2131099735;
​
            public const int design_bottom_navigation_text_size = 2131099736;
​
            public const int design_bottom_sheet_modal_elevation = 2131099737;
​
            public const int design_bottom_sheet_peek_height_min = 2131099738;
​
            public const int design_fab_border_width = 2131099739;
​
            public const int design_fab_elevation = 2131099740;
​
            public const int design_fab_image_size = 2131099741;
​
            public const int design_fab_size_mini = 2131099742;
​
            public const int design_fab_size_normal = 2131099743;
​
            public const int design_fab_translation_z_pressed = 2131099744;
​
            public const int design_navigation_elevation = 2131099745;
​
            public const int design_navigation_icon_padding = 2131099746;
​
            public const int design_navigation_icon_size = 2131099747;
​
            public const int design_navigation_max_width = 2131099748;
​
            public const int design_navigation_padding_bottom = 2131099749;
​
            public const int design_navigation_separator_vertical_padding = 2131099750;
​
            public const int design_snackbar_action_inline_max_width = 2131099751;
​
            public const int design_snackbar_background_corner_radius = 2131099752;
​
            public const int design_snackbar_elevation = 2131099753;
​
            public const int design_snackbar_extra_spacing_horizontal = 2131099754;
​
            public const int design_snackbar_max_width = 2131099755;
​
            public const int design_snackbar_min_width = 2131099756;
​
            public const int design_snackbar_padding_horizontal = 2131099757;
​
            public const int design_snackbar_padding_vertical = 2131099758;
​
            public const int design_snackbar_padding_vertical_2lines = 2131099759;
​
            public const int design_snackbar_text_size = 2131099760;
​
            public const int design_tab_max_width = 2131099761;
​
            public const int design_tab_scrollable_min_width = 2131099762;
​
            public const int design_tab_text_size = 2131099763;
​
            public const int design_tab_text_size_2line = 2131099764;
​
            public const int disabled_alpha_material_dark = 2131099765;
​
            public const int disabled_alpha_material_light = 2131099766;
​
            public const int fab_margin = 2131099767;
​
            public const int fastscroll_default_thickness = 2131099768;
​
            public const int fastscroll_margin = 2131099769;
​
            public const int fastscroll_minimum_range = 2131099770;
​
            public const int highlight_alpha_material_colored = 2131099771;
​
            public const int highlight_alpha_material_dark = 2131099772;
​
            public const int highlight_alpha_material_light = 2131099773;
​
            public const int hint_alpha_material_dark = 2131099774;
​
            public const int hint_alpha_material_light = 2131099775;
​
            public const int hint_pressed_alpha_material_dark = 2131099776;
​
            public const int hint_pressed_alpha_material_light = 2131099777;
​
            public const int item_touch_helper_max_drag_scroll_per_frame = 2131099778;
​
            public const int item_touch_helper_swipe_escape_max_velocity = 2131099779;
​
            public const int item_touch_helper_swipe_escape_velocity = 2131099780;
​
            public const int notification_action_icon_size = 2131099781;
​
            public const int notification_action_text_size = 2131099782;
​
            public const int notification_big_circle_margin = 2131099783;
​
            public const int notification_content_margin_start = 2131099784;
​
            public const int notification_large_icon_height = 2131099785;
​
            public const int notification_large_icon_width = 2131099786;
​
            public const int notification_main_column_padding_top = 2131099787;
​
            public const int notification_media_narrow_margin = 2131099788;
​
            public const int notification_right_icon_size = 2131099789;
​
            public const int notification_right_side_padding_top = 2131099790;
​
            public const int notification_small_icon_background_padding = 2131099791;
​
            public const int notification_small_icon_size_as_large = 2131099792;
​
            public const int notification_subtext_size = 2131099793;
​
            public const int notification_top_pad = 2131099794;
​
            public const int notification_top_pad_large_text = 2131099795;
​
            public const int tooltip_corner_radius = 2131099796;
​
            public const int tooltip_horizontal_padding = 2131099797;
​
            public const int tooltip_margin = 2131099798;
​
            public const int tooltip_precise_anchor_extra_offset = 2131099799;
​
            public const int tooltip_precise_anchor_threshold = 2131099800;
​
            public const int tooltip_vertical_padding = 2131099801;
​
            public const int tooltip_y_offset_non_touch = 2131099802;
​
            public const int tooltip_y_offset_touch = 2131099803;
​
            static Dimension()
            {
                ResourceIdManager.UpdateIdValues();
            }
​
            private Dimension()
            {
            }
        }
​
        public class Drawable
        {
            public const int abc_ab_share_pack_mtrl_alpha = 2131165190;
​
            public const int abc_action_bar_item_background_material = 2131165191;
​
            public const int abc_btn_borderless_material = 2131165192;
​
            public const int abc_btn_check_material = 2131165193;
​
            public const int abc_btn_check_to_on_mtrl_000 = 2131165194;
​
            public const int abc_btn_check_to_on_mtrl_015 = 2131165195;
​
            public const int abc_btn_colored_material = 2131165196;
​
            public const int abc_btn_default_mtrl_shape = 2131165197;
​
            public const int abc_btn_radio_material = 2131165198;
​
            public const int abc_btn_radio_to_on_mtrl_000 = 2131165199;
​
            public const int abc_btn_radio_to_on_mtrl_015 = 2131165200;
​
            public const int abc_btn_switch_to_on_mtrl_00001 = 2131165201;
​
            public const int abc_btn_switch_to_on_mtrl_00012 = 2131165202;
​
            public const int abc_cab_background_internal_bg = 2131165203;
​
            public const int abc_cab_background_top_material = 2131165204;
​
            public const int abc_cab_background_top_mtrl_alpha = 2131165205;
​
            public const int abc_control_background_material = 2131165206;
​
            public const int abc_dialog_material_background = 2131165207;
​
            public const int abc_edit_text_material = 2131165208;
​
            public const int abc_ic_ab_back_material = 2131165209;
​
            public const int abc_ic_arrow_drop_right_black_24dp = 2131165210;
​
            public const int abc_ic_clear_material = 2131165211;
​
            public const int abc_ic_commit_search_api_mtrl_alpha = 2131165212;
​
            public const int abc_ic_go_search_api_material = 2131165213;
​
            public const int abc_ic_menu_copy_mtrl_am_alpha = 2131165214;
​
            public const int abc_ic_menu_cut_mtrl_alpha = 2131165215;
​
            public const int abc_ic_menu_overflow_material = 2131165216;
​
            public const int abc_ic_menu_paste_mtrl_am_alpha = 2131165217;
​
            public const int abc_ic_menu_selectall_mtrl_alpha = 2131165218;
​
            public const int abc_ic_menu_share_mtrl_alpha = 2131165219;
​
            public const int abc_ic_search_api_material = 2131165220;
​
            public const int abc_ic_star_black_16dp = 2131165221;
​
            public const int abc_ic_star_black_36dp = 2131165222;
​
            public const int abc_ic_star_black_48dp = 2131165223;
​
            public const int abc_ic_star_half_black_16dp = 2131165224;
​
            public const int abc_ic_star_half_black_36dp = 2131165225;
​
            public const int abc_ic_star_half_black_48dp = 2131165226;
​
            public const int abc_ic_voice_search_api_material = 2131165227;
​
            public const int abc_item_background_holo_dark = 2131165228;
​
            public const int abc_item_background_holo_light = 2131165229;
​
            public const int abc_list_divider_mtrl_alpha = 2131165230;
​
            public const int abc_list_focused_holo = 2131165231;
​
            public const int abc_list_longpressed_holo = 2131165232;
​
            public const int abc_list_pressed_holo_dark = 2131165233;
​
            public const int abc_list_pressed_holo_light = 2131165234;
​
            public const int abc_list_selector_background_transition_holo_dark = 2131165235;
​
            public const int abc_list_selector_background_transition_holo_light = 2131165236;
​
            public const int abc_list_selector_disabled_holo_dark = 2131165237;
​
            public const int abc_list_selector_disabled_holo_light = 2131165238;
​
            public const int abc_list_selector_holo_dark = 2131165239;
​
            public const int abc_list_selector_holo_light = 2131165240;
​
            public const int abc_menu_hardkey_panel_mtrl_mult = 2131165241;
​
            public const int abc_popup_background_mtrl_mult = 2131165242;
​
            public const int abc_ratingbar_indicator_material = 2131165243;
​
            public const int abc_ratingbar_material = 2131165244;
​
            public const int abc_ratingbar_small_material = 2131165245;
​
            public const int abc_scrubber_control_off_mtrl_alpha = 2131165246;
​
            public const int abc_scrubber_control_to_pressed_mtrl_000 = 2131165247;
​
            public const int abc_scrubber_control_to_pressed_mtrl_005 = 2131165248;
​
            public const int abc_scrubber_primary_mtrl_alpha = 2131165249;
​
            public const int abc_scrubber_track_mtrl_alpha = 2131165250;
​
            public const int abc_seekbar_thumb_material = 2131165251;
​
            public const int abc_seekbar_tick_mark_material = 2131165252;
​
            public const int abc_seekbar_track_material = 2131165253;
​
            public const int abc_spinner_mtrl_am_alpha = 2131165254;
​
            public const int abc_spinner_textfield_background_material = 2131165255;
​
            public const int abc_switch_thumb_material = 2131165256;
​
            public const int abc_switch_track_mtrl_alpha = 2131165257;
​
            public const int abc_tab_indicator_material = 2131165258;
​
            public const int abc_tab_indicator_mtrl_alpha = 2131165259;
​
            public const int abc_textfield_activated_mtrl_alpha = 2131165267;
​
            public const int abc_textfield_default_mtrl_alpha = 2131165268;
​
            public const int abc_textfield_search_activated_mtrl_alpha = 2131165269;
​
            public const int abc_textfield_search_default_mtrl_alpha = 2131165270;
​
            public const int abc_textfield_search_material = 2131165271;
​
            public const int abc_text_cursor_material = 2131165260;
​
            public const int abc_text_select_handle_left_mtrl_dark = 2131165261;
​
            public const int abc_text_select_handle_left_mtrl_light = 2131165262;
​
            public const int abc_text_select_handle_middle_mtrl_dark = 2131165263;
​
            public const int abc_text_select_handle_middle_mtrl_light = 2131165264;
​
            public const int abc_text_select_handle_right_mtrl_dark = 2131165265;
​
            public const int abc_text_select_handle_right_mtrl_light = 2131165266;
​
            public const int abc_vector_test = 2131165272;
​
            public const int avd_hide_password = 2131165273;
​
            public const int avd_show_password = 2131165274;
​
            public const int design_bottom_navigation_item_background = 2131165275;
​
            public const int design_fab_background = 2131165276;
​
            public const int design_ic_visibility = 2131165277;
​
            public const int design_ic_visibility_off = 2131165278;
​
            public const int design_password_eye = 2131165279;
​
            public const int design_snackbar_background = 2131165280;
​
            public const int navigation_empty_icon = 2131165281;
​
            public const int notification_action_background = 2131165282;
​
            public const int notification_bg = 2131165283;
​
            public const int notification_bg_low = 2131165284;
​
            public const int notification_bg_low_normal = 2131165285;
​
            public const int notification_bg_low_pressed = 2131165286;
​
            public const int notification_bg_normal = 2131165287;
​
            public const int notification_bg_normal_pressed = 2131165288;
​
            public const int notification_icon_background = 2131165289;
​
            public const int notification_template_icon_bg = 2131165290;
​
            public const int notification_template_icon_low_bg = 2131165291;
​
            public const int notification_tile_bg = 2131165292;
​
            public const int notify_panel_notification_icon_bg = 2131165293;
​
            public const int tooltip_frame_dark = 2131165294;
​
            public const int tooltip_frame_light = 2131165295;
​
            static Drawable()
            {
                ResourceIdManager.UpdateIdValues();
            }
​
            private Drawable()
            {
            }
        }
​
        public class Id
        {
            public const int action0 = 2131230726;
​
            public const int actions = 2131230745;
​
            public const int action_bar = 2131230727;
​
            public const int action_bar_activity_content = 2131230728;
​
            public const int action_bar_container = 2131230729;
​
            public const int action_bar_root = 2131230730;
​
            public const int action_bar_spinner = 2131230731;
​
            public const int action_bar_subtitle = 2131230732;
​
            public const int action_bar_title = 2131230733;
​
            public const int action_container = 2131230734;
​
            public const int action_context_bar = 2131230735;
​
            public const int action_divider = 2131230736;
​
            public const int action_image = 2131230737;
​
            public const int action_menu_divider = 2131230738;
​
            public const int action_menu_presenter = 2131230739;
​
            public const int action_mode_bar = 2131230740;
​
            public const int action_mode_bar_stub = 2131230741;
​
            public const int action_mode_close_button = 2131230742;
​
            public const int action_settings = 2131230743;
​
            public const int action_text = 2131230744;
​
            public const int activity_chooser_view_content = 2131230746;
​
            public const int add = 2131230747;
​
            public const int alertTitle = 2131230748;
​
            public const int all = 2131230749;
​
            public const int ALT = 2131230720;
​
            public const int always = 2131230750;
​
            public const int async = 2131230751;
​
            public const int auto = 2131230752;
​
            public const int beginning = 2131230753;
​
            public const int blocking = 2131230754;
​
            public const int bottom = 2131230755;
​
            public const int buttonPanel = 2131230756;
​
            public const int cancel_action = 2131230757;
​
            public const int center = 2131230758;
​
            public const int center_horizontal = 2131230759;
​
            public const int center_vertical = 2131230760;
​
            public const int checkbox = 2131230761;
​
            public const int chronometer = 2131230762;
​
            public const int clip_horizontal = 2131230763;
​
            public const int clip_vertical = 2131230764;
​
            public const int collapseActionView = 2131230765;
​
            public const int container = 2131230766;
​
            public const int contentPanel = 2131230767;
​
            public const int coordinator = 2131230768;
​
            public const int CTRL = 2131230721;
​
            public const int custom = 2131230769;
​
            public const int customPanel = 2131230770;
​
            public const int decor_content_parent = 2131230771;
​
            public const int default_activity_button = 2131230772;
​
            public const int design_bottom_sheet = 2131230773;
​
            public const int design_menu_item_action_area = 2131230774;
​
            public const int design_menu_item_action_area_stub = 2131230775;
​
            public const int design_menu_item_text = 2131230776;
​
            public const int design_navigation_view = 2131230777;
​
            public const int disableHome = 2131230778;
​
            public const int edit_query = 2131230779;
​
            public const int end = 2131230780;
​
            public const int end_padder = 2131230781;
​
            public const int enterAlways = 2131230782;
​
            public const int enterAlwaysCollapsed = 2131230783;
​
            public const int exitUntilCollapsed = 2131230784;
​
            public const int expanded_menu = 2131230786;
​
            public const int expand_activities_button = 2131230785;
​
            public const int fill = 2131230787;
​
            public const int fill_horizontal = 2131230788;
​
            public const int fill_vertical = 2131230789;
​
            public const int @fixed = 2131230790;
​
            public const int forever = 2131230791;
​
            public const int FUNCTION = 2131230722;
​
            public const int ghost_view = 2131230792;
​
            public const int home = 2131230793;
​
            public const int homeAsUp = 2131230794;
​
            public const int icon = 2131230795;
​
            public const int icon_group = 2131230796;
​
            public const int ifRoom = 2131230797;
​
            public const int image = 2131230798;
​
            public const int info = 2131230799;
​
            public const int italic = 2131230800;
​
            public const int item_touch_helper_previous_elevation = 2131230801;
​
            public const int largeLabel = 2131230802;
​
            public const int left = 2131230803;
​
            public const int line1 = 2131230804;
​
            public const int line3 = 2131230805;
​
            public const int listMode = 2131230806;
​
            public const int list_item = 2131230807;
​
            public const int masked = 2131230808;
​
            public const int media_actions = 2131230809;
​
            public const int message = 2131230810;
​
            public const int META = 2131230723;
​
            public const int middle = 2131230811;
​
            public const int mini = 2131230812;
​
            public const int multiply = 2131230813;
​
            public const int navigation_header_container = 2131230814;
​
            public const int never = 2131230815;
​
            public const int none = 2131230816;
​
            public const int normal = 2131230817;
​
            public const int notification_background = 2131230818;
​
            public const int notification_main_column = 2131230819;
​
            public const int notification_main_column_container = 2131230820;
​
            public const int parallax = 2131230821;
​
            public const int parentPanel = 2131230822;
​
            public const int parent_matrix = 2131230823;
​
            public const int pin = 2131230824;
​
            public const int progress_circular = 2131230825;
​
            public const int progress_horizontal = 2131230826;
​
            public const int pwdInput = 2131230827;
​
            public const int radio = 2131230828;
​
            public const int right = 2131230829;
​
            public const int right_icon = 2131230830;
​
            public const int right_side = 2131230831;
​
            public const int save_image_matrix = 2131230832;
​
            public const int save_non_transition_alpha = 2131230833;
​
            public const int save_scale_type = 2131230834;
​
            public const int screen = 2131230835;
​
            public const int scroll = 2131230836;
​
            public const int scrollable = 2131230840;
​
            public const int scrollIndicatorDown = 2131230837;
​
            public const int scrollIndicatorUp = 2131230838;
​
            public const int scrollView = 2131230839;
​
            public const int search_badge = 2131230841;
​
            public const int search_bar = 2131230842;
​
            public const int search_button = 2131230843;
​
            public const int search_close_btn = 2131230844;
​
            public const int search_edit_frame = 2131230845;
​
            public const int search_go_btn = 2131230846;
​
            public const int search_mag_icon = 2131230847;
​
            public const int search_plate = 2131230848;
​
            public const int search_src_text = 2131230849;
​
            public const int search_voice_btn = 2131230850;
​
            public const int select_dialog_listview = 2131230851;
​
            public const int SHIFT = 2131230724;
​
            public const int shortcut = 2131230852;
​
            public const int showCustom = 2131230853;
​
            public const int showHome = 2131230854;
​
            public const int showTitle = 2131230855;
​
            public const int smallLabel = 2131230856;
​
            public const int snackbar_action = 2131230857;
​
            public const int snackbar_text = 2131230858;
​
            public const int snap = 2131230859;
​
            public const int spacer = 2131230860;
​
            public const int split_action_bar = 2131230861;
​
            public const int src_atop = 2131230862;
​
            public const int src_in = 2131230863;
​
            public const int src_over = 2131230864;
​
            public const int start = 2131230865;
​
            public const int status_bar_latest_event_content = 2131230866;
​
            public const int submenuarrow = 2131230867;
​
            public const int submitBtn = 2131230868;
​
            public const int submit_area = 2131230869;
​
            public const int SYM = 2131230725;
​
            public const int tabMode = 2131230870;
​
            public const int tag_transition_group = 2131230871;
​
            public const int text = 2131230872;
​
            public const int text2 = 2131230873;
​
            public const int textinput_counter = 2131230878;
​
            public const int textinput_error = 2131230879;
​
            public const int textSpacerNoButtons = 2131230874;
​
            public const int textSpacerNoTitle = 2131230875;
​
            public const int textView1 = 2131230876;
​
            public const int text_input_password_toggle = 2131230877;
​
            public const int time = 2131230880;
​
            public const int title = 2131230881;
​
            public const int titleDividerNoCustom = 2131230882;
​
            public const int title_template = 2131230883;
​
            public const int toolbar = 2131230884;
​
            public const int top = 2131230885;
​
            public const int topPanel = 2131230886;
​
            public const int touch_outside = 2131230887;
​
            public const int transition_current_scene = 2131230888;
​
            public const int transition_layout_save = 2131230889;
​
            public const int transition_position = 2131230890;
​
            public const int transition_scene_layoutid_cache = 2131230891;
​
            public const int transition_transform = 2131230892;
​
            public const int uniform = 2131230893;
​
            public const int up = 2131230894;
​
            public const int useLogo = 2131230895;
​
            public const int view_offset_helper = 2131230896;
​
            public const int visible = 2131230897;
​
            public const int withText = 2131230898;
​
            public const int wrap_content = 2131230899;
​
            static Id()
            {
                ResourceIdManager.UpdateIdValues();
            }
​
            private Id()
            {
            }
        }
​
        public class Integer
        {
            public const int abc_config_activityDefaultDur = 2131296256;
​
            public const int abc_config_activityShortDur = 2131296257;
​
            public const int app_bar_elevation_anim_duration = 2131296258;
​
            public const int bottom_sheet_slide_duration = 2131296259;
​
            public const int cancel_button_image_alpha = 2131296260;
​
            public const int config_tooltipAnimTime = 2131296261;
​
            public const int design_snackbar_text_max_lines = 2131296262;
​
            public const int hide_password_duration = 2131296263;
​
            public const int show_password_duration = 2131296264;
​
            public const int status_bar_notification_info_maxnum = 2131296265;
​
            static Integer()
            {
                ResourceIdManager.UpdateIdValues();
            }
​
            private Integer()
            {
            }
        }
​
        public class Layout
        {
            public const int abc_action_bar_title_item = 2131361792;
​
            public const int abc_action_bar_up_container = 2131361793;
​
            public const int abc_action_menu_item_layout = 2131361794;
​
            public const int abc_action_menu_layout = 2131361795;
​
            public const int abc_action_mode_bar = 2131361796;
​
            public const int abc_action_mode_close_item_material = 2131361797;
​
            public const int abc_activity_chooser_view = 2131361798;
​
            public const int abc_activity_chooser_view_list_item = 2131361799;
​
            public const int abc_alert_dialog_button_bar_material = 2131361800;
​
            public const int abc_alert_dialog_material = 2131361801;
​
            public const int abc_alert_dialog_title_material = 2131361802;
​
            public const int abc_dialog_title_material = 2131361803;
​
            public const int abc_expanded_menu_layout = 2131361804;
​
            public const int abc_list_menu_item_checkbox = 2131361805;
​
            public const int abc_list_menu_item_icon = 2131361806;
​
            public const int abc_list_menu_item_layout = 2131361807;
​
            public const int abc_list_menu_item_radio = 2131361808;
​
            public const int abc_popup_menu_header_item_layout = 2131361809;
​
            public const int abc_popup_menu_item_layout = 2131361810;
​
            public const int abc_screen_content_include = 2131361811;
​
            public const int abc_screen_simple = 2131361812;
​
            public const int abc_screen_simple_overlay_action_mode = 2131361813;
​
            public const int abc_screen_toolbar = 2131361814;
​
            public const int abc_search_dropdown_item_icons_2line = 2131361815;
​
            public const int abc_search_view = 2131361816;
​
            public const int abc_select_dialog_material = 2131361817;
​
            public const int activity_main = 2131361818;
​
            public const int content_main = 2131361819;
​
            public const int design_bottom_navigation_item = 2131361820;
​
            public const int design_bottom_sheet_dialog = 2131361821;
​
            public const int design_layout_snackbar = 2131361822;
​
            public const int design_layout_snackbar_include = 2131361823;
​
            public const int design_layout_tab_icon = 2131361824;
​
            public const int design_layout_tab_text = 2131361825;
​
            public const int design_menu_item_action_area = 2131361826;
​
            public const int design_navigation_item = 2131361827;
​
            public const int design_navigation_item_header = 2131361828;
​
            public const int design_navigation_item_separator = 2131361829;
​
            public const int design_navigation_item_subheader = 2131361830;
​
            public const int design_navigation_menu = 2131361831;
​
            public const int design_navigation_menu_item = 2131361832;
​
            public const int design_text_input_password_icon = 2131361833;
​
            public const int notification_action = 2131361834;
​
            public const int notification_action_tombstone = 2131361835;
​
            public const int notification_media_action = 2131361836;
​
            public const int notification_media_cancel_action = 2131361837;
​
            public const int notification_template_big_media = 2131361838;
​
            public const int notification_template_big_media_custom = 2131361839;
​
            public const int notification_template_big_media_narrow = 2131361840;
​
            public const int notification_template_big_media_narrow_custom = 2131361841;
​
            public const int notification_template_custom_big = 2131361842;
​
            public const int notification_template_icon_group = 2131361843;
​
            public const int notification_template_lines_media = 2131361844;
​
            public const int notification_template_media = 2131361845;
​
            public const int notification_template_media_custom = 2131361846;
​
            public const int notification_template_part_chronometer = 2131361847;
​
            public const int notification_template_part_time = 2131361848;
​
            public const int select_dialog_item_material = 2131361849;
​
            public const int select_dialog_multichoice_material = 2131361850;
​
            public const int select_dialog_singlechoice_material = 2131361851;
​
            public const int support_simple_spinner_dropdown_item = 2131361852;
​
            public const int tooltip = 2131361853;
​
            static Layout()
            {
                ResourceIdManager.UpdateIdValues();
            }
​
            private Layout()
            {
            }
        }
​
        public class Menu
        {
            public const int menu_main = 2131427328;
​
            static Menu()
            {
                ResourceIdManager.UpdateIdValues();
            }
​
            private Menu()
            {
            }
        }
​
        public class Mipmap
        {
            public const int ic_launcher = 2131492864;
​
            public const int ic_launcher_foreground = 2131492865;
​
            public const int ic_launcher_round = 2131492866;
​
            static Mipmap()
            {
                ResourceIdManager.UpdateIdValues();
            }
​
            private Mipmap()
            {
            }
        }
​
        public class String
        {
            public const int abc_action_bar_home_description = 2131558400;
​
            public const int abc_action_bar_up_description = 2131558401;
​
            public const int abc_action_menu_overflow_description = 2131558402;
​
            public const int abc_action_mode_done = 2131558403;
​
            public const int abc_activitychooserview_choose_application = 2131558405;
​
            public const int abc_activity_chooser_view_see_all = 2131558404;
​
            public const int abc_capital_off = 2131558406;
​
            public const int abc_capital_on = 2131558407;
​
            public const int abc_font_family_body_1_material = 2131558408;
​
            public const int abc_font_family_body_2_material = 2131558409;
​
            public const int abc_font_family_button_material = 2131558410;
​
            public const int abc_font_family_caption_material = 2131558411;
​
            public const int abc_font_family_display_1_material = 2131558412;
​
            public const int abc_font_family_display_2_material = 2131558413;
​
            public const int abc_font_family_display_3_material = 2131558414;
​
            public const int abc_font_family_display_4_material = 2131558415;
​
            public const int abc_font_family_headline_material = 2131558416;
​
            public const int abc_font_family_menu_material = 2131558417;
​
            public const int abc_font_family_subhead_material = 2131558418;
​
            public const int abc_font_family_title_material = 2131558419;
​
            public const int abc_searchview_description_clear = 2131558421;
​
            public const int abc_searchview_description_query = 2131558422;
​
            public const int abc_searchview_description_search = 2131558423;
​
            public const int abc_searchview_description_submit = 2131558424;
​
            public const int abc_searchview_description_voice = 2131558425;
​
            public const int abc_search_hint = 2131558420;
​
            public const int abc_shareactionprovider_share_with = 2131558426;
​
            public const int abc_shareactionprovider_share_with_application = 2131558427;
​
            public const int abc_toolbar_collapse_description = 2131558428;
​
            public const int action_settings = 2131558429;
​
            public const int appbar_scrolling_view_behavior = 2131558431;
​
            public const int app_name = 2131558430;
​
            public const int bottom_sheet_behavior = 2131558432;
​
            public const int character_counter_pattern = 2131558433;
​
            public const int password_toggle_content_description = 2131558434;
​
            public const int path_password_eye = 2131558435;
​
            public const int path_password_eye_mask_strike_through = 2131558436;
​
            public const int path_password_eye_mask_visible = 2131558437;
​
            public const int path_password_strike_through = 2131558438;
​
            public const int search_menu_title = 2131558439;
​
            public const int status_bar_notification_info_overflow = 2131558440;
​
            static String()
            {
                ResourceIdManager.UpdateIdValues();
            }
​
            private String()
            {
            }
        }
​
        public class Style
        {
            public const int AlertDialog_AppCompat = 2131623936;
​
            public const int AlertDialog_AppCompat_Light = 2131623937;
​
            public const int Animation_AppCompat_Dialog = 2131623938;
​
            public const int Animation_AppCompat_DropDownUp = 2131623939;
​
            public const int Animation_AppCompat_Tooltip = 2131623940;
​
            public const int Animation_Design_BottomSheetDialog = 2131623941;
​
            public const int AppTheme = 2131623942;
​
            public const int AppTheme_AppBarOverlay = 2131623943;
​
            public const int AppTheme_NoActionBar = 2131623944;
​
            public const int AppTheme_PopupOverlay = 2131623945;
​
            public const int Base_AlertDialog_AppCompat = 2131623946;
​
            public const int Base_AlertDialog_AppCompat_Light = 2131623947;
​
            public const int Base_Animation_AppCompat_Dialog = 2131623948;
​
            public const int Base_Animation_AppCompat_DropDownUp = 2131623949;
​
            public const int Base_Animation_AppCompat_Tooltip = 2131623950;
​
            public const int Base_DialogWindowTitleBackground_AppCompat = 2131623952;
​
            public const int Base_DialogWindowTitle_AppCompat = 2131623951;
​
            public const int Base_TextAppearance_AppCompat = 2131623953;
​
            public const int Base_TextAppearance_AppCompat_Body1 = 2131623954;
​
            public const int Base_TextAppearance_AppCompat_Body2 = 2131623955;
​
            public const int Base_TextAppearance_AppCompat_Button = 2131623956;
​
            public const int Base_TextAppearance_AppCompat_Caption = 2131623957;
​
            public const int Base_TextAppearance_AppCompat_Display1 = 2131623958;
​
            public const int Base_TextAppearance_AppCompat_Display2 = 2131623959;
​
            public const int Base_TextAppearance_AppCompat_Display3 = 2131623960;
​
            public const int Base_TextAppearance_AppCompat_Display4 = 2131623961;
​
            public const int Base_TextAppearance_AppCompat_Headline = 2131623962;
​
            public const int Base_TextAppearance_AppCompat_Inverse = 2131623963;
​
            public const int Base_TextAppearance_AppCompat_Large = 2131623964;
​
            public const int Base_TextAppearance_AppCompat_Large_Inverse = 2131623965;
​
            public const int Base_TextAppearance_AppCompat_Light_Widget_PopupMenu_Large = 2131623966;
​
            public const int Base_TextAppearance_AppCompat_Light_Widget_PopupMenu_Small = 2131623967;
​
            public const int Base_TextAppearance_AppCompat_Medium = 2131623968;
​
            public const int Base_TextAppearance_AppCompat_Medium_Inverse = 2131623969;
​
            public const int Base_TextAppearance_AppCompat_Menu = 2131623970;
​
            public const int Base_TextAppearance_AppCompat_SearchResult = 2131623971;
​
            public const int Base_TextAppearance_AppCompat_SearchResult_Subtitle = 2131623972;
​
            public const int Base_TextAppearance_AppCompat_SearchResult_Title = 2131623973;
​
            public const int Base_TextAppearance_AppCompat_Small = 2131623974;
​
            public const int Base_TextAppearance_AppCompat_Small_Inverse = 2131623975;
​
            public const int Base_TextAppearance_AppCompat_Subhead = 2131623976;
​
            public const int Base_TextAppearance_AppCompat_Subhead_Inverse = 2131623977;
​
            public const int Base_TextAppearance_AppCompat_Title = 2131623978;
​
            public const int Base_TextAppearance_AppCompat_Title_Inverse = 2131623979;
​
            public const int Base_TextAppearance_AppCompat_Tooltip = 2131623980;
​
            public const int Base_TextAppearance_AppCompat_Widget_ActionBar_Menu = 2131623981;
​
            public const int Base_TextAppearance_AppCompat_Widget_ActionBar_Subtitle = 2131623982;
​
            public const int Base_TextAppearance_AppCompat_Widget_ActionBar_Subtitle_Inverse = 2131623983;
​
            public const int Base_TextAppearance_AppCompat_Widget_ActionBar_Title = 2131623984;
​
            public const int Base_TextAppearance_AppCompat_Widget_ActionBar_Title_Inverse = 2131623985;
​
            public const int Base_TextAppearance_AppCompat_Widget_ActionMode_Subtitle = 2131623986;
​
            public const int Base_TextAppearance_AppCompat_Widget_ActionMode_Title = 2131623987;
​
            public const int Base_TextAppearance_AppCompat_Widget_Button = 2131623988;
​
            public const int Base_TextAppearance_AppCompat_Widget_Button_Borderless_Colored = 2131623989;
​
            public const int Base_TextAppearance_AppCompat_Widget_Button_Colored = 2131623990;
​
            public const int Base_TextAppearance_AppCompat_Widget_Button_Inverse = 2131623991;
​
            public const int Base_TextAppearance_AppCompat_Widget_DropDownItem = 2131623992;
​
            public const int Base_TextAppearance_AppCompat_Widget_PopupMenu_Header = 2131623993;
​
            public const int Base_TextAppearance_AppCompat_Widget_PopupMenu_Large = 2131623994;
​
            public const int Base_TextAppearance_AppCompat_Widget_PopupMenu_Small = 2131623995;
​
            public const int Base_TextAppearance_AppCompat_Widget_Switch = 2131623996;
​
            public const int Base_TextAppearance_AppCompat_Widget_TextView_SpinnerItem = 2131623997;
​
            public const int Base_TextAppearance_Widget_AppCompat_ExpandedMenu_Item = 2131623998;
​
            public const int Base_TextAppearance_Widget_AppCompat_Toolbar_Subtitle = 2131623999;
​
            public const int Base_TextAppearance_Widget_AppCompat_Toolbar_Title = 2131624000;
​
            public const int Base_ThemeOverlay_AppCompat = 2131624015;
​
            public const int Base_ThemeOverlay_AppCompat_ActionBar = 2131624016;
​
            public const int Base_ThemeOverlay_AppCompat_Dark = 2131624017;
​
            public const int Base_ThemeOverlay_AppCompat_Dark_ActionBar = 2131624018;
​
            public const int Base_ThemeOverlay_AppCompat_Dialog = 2131624019;
​
            public const int Base_ThemeOverlay_AppCompat_Dialog_Alert = 2131624020;
​
            public const int Base_ThemeOverlay_AppCompat_Light = 2131624021;
​
            public const int Base_Theme_AppCompat = 2131624001;
​
            public const int Base_Theme_AppCompat_CompactMenu = 2131624002;
​
            public const int Base_Theme_AppCompat_Dialog = 2131624003;
​
            public const int Base_Theme_AppCompat_DialogWhenLarge = 2131624007;
​
            public const int Base_Theme_AppCompat_Dialog_Alert = 2131624004;
​
            public const int Base_Theme_AppCompat_Dialog_FixedSize = 2131624005;
​
            public const int Base_Theme_AppCompat_Dialog_MinWidth = 2131624006;
​
            public const int Base_Theme_AppCompat_Light = 2131624008;
​
            public const int Base_Theme_AppCompat_Light_DarkActionBar = 2131624009;
​
            public const int Base_Theme_AppCompat_Light_Dialog = 2131624010;
​
            public const int Base_Theme_AppCompat_Light_DialogWhenLarge = 2131624014;
​
            public const int Base_Theme_AppCompat_Light_Dialog_Alert = 2131624011;
​
            public const int Base_Theme_AppCompat_Light_Dialog_FixedSize = 2131624012;
​
            public const int Base_Theme_AppCompat_Light_Dialog_MinWidth = 2131624013;
​
            public const int Base_V11_ThemeOverlay_AppCompat_Dialog = 2131624024;
​
            public const int Base_V11_Theme_AppCompat_Dialog = 2131624022;
​
            public const int Base_V11_Theme_AppCompat_Light_Dialog = 2131624023;
​
            public const int Base_V12_Widget_AppCompat_AutoCompleteTextView = 2131624025;
​
            public const int Base_V12_Widget_AppCompat_EditText = 2131624026;
​
            public const int Base_V14_Widget_Design_AppBarLayout = 2131624027;
​
            public const int Base_V21_ThemeOverlay_AppCompat_Dialog = 2131624032;
​
            public const int Base_V21_Theme_AppCompat = 2131624028;
​
            public const int Base_V21_Theme_AppCompat_Dialog = 2131624029;
​
            public const int Base_V21_Theme_AppCompat_Light = 2131624030;
​
            public const int Base_V21_Theme_AppCompat_Light_Dialog = 2131624031;
​
            public const int Base_V21_Widget_Design_AppBarLayout = 2131624033;
​
            public const int Base_V22_Theme_AppCompat = 2131624034;
​
            public const int Base_V22_Theme_AppCompat_Light = 2131624035;
​
            public const int Base_V23_Theme_AppCompat = 2131624036;
​
            public const int Base_V23_Theme_AppCompat_Light = 2131624037;
​
            public const int Base_V26_Theme_AppCompat = 2131624038;
​
            public const int Base_V26_Theme_AppCompat_Light = 2131624039;
​
            public const int Base_V26_Widget_AppCompat_Toolbar = 2131624040;
​
            public const int Base_V26_Widget_Design_AppBarLayout = 2131624041;
​
            public const int Base_V7_ThemeOverlay_AppCompat_Dialog = 2131624046;
​
            public const int Base_V7_Theme_AppCompat = 2131624042;
​
            public const int Base_V7_Theme_AppCompat_Dialog = 2131624043;
​
            public const int Base_V7_Theme_AppCompat_Light = 2131624044;
​
            public const int Base_V7_Theme_AppCompat_Light_Dialog = 2131624045;
​
            public const int Base_V7_Widget_AppCompat_AutoCompleteTextView = 2131624047;
​
            public const int Base_V7_Widget_AppCompat_EditText = 2131624048;
​
            public const int Base_V7_Widget_AppCompat_Toolbar = 2131624049;
​
            public const int Base_Widget_AppCompat_ActionBar = 2131624050;
​
            public const int Base_Widget_AppCompat_ActionBar_Solid = 2131624051;
​
            public const int Base_Widget_AppCompat_ActionBar_TabBar = 2131624052;
​
            public const int Base_Widget_AppCompat_ActionBar_TabText = 2131624053;
​
            public const int Base_Widget_AppCompat_ActionBar_TabView = 2131624054;
​
            public const int Base_Widget_AppCompat_ActionButton = 2131624055;
​
            public const int Base_Widget_AppCompat_ActionButton_CloseMode = 2131624056;
​
            public const int Base_Widget_AppCompat_ActionButton_Overflow = 2131624057;
​
            public const int Base_Widget_AppCompat_ActionMode = 2131624058;
​
            public const int Base_Widget_AppCompat_ActivityChooserView = 2131624059;
​
            public const int Base_Widget_AppCompat_AutoCompleteTextView = 2131624060;
​
            public const int Base_Widget_AppCompat_Button = 2131624061;
​
            public const int Base_Widget_AppCompat_ButtonBar = 2131624067;
​
            public const int Base_Widget_AppCompat_ButtonBar_AlertDialog = 2131624068;
​
            public const int Base_Widget_AppCompat_Button_Borderless = 2131624062;
​
            public const int Base_Widget_AppCompat_Button_Borderless_Colored = 2131624063;
​
            public const int Base_Widget_AppCompat_Button_ButtonBar_AlertDialog = 2131624064;
​
            public const int Base_Widget_AppCompat_Button_Colored = 2131624065;
​
            public const int Base_Widget_AppCompat_Button_Small = 2131624066;
​
            public const int Base_Widget_AppCompat_CompoundButton_CheckBox = 2131624069;
​
            public const int Base_Widget_AppCompat_CompoundButton_RadioButton = 2131624070;
​
            public const int Base_Widget_AppCompat_CompoundButton_Switch = 2131624071;
​
            public const int Base_Widget_AppCompat_DrawerArrowToggle = 2131624072;
​
            public const int Base_Widget_AppCompat_DrawerArrowToggle_Common = 2131624073;
​
            public const int Base_Widget_AppCompat_DropDownItem_Spinner = 2131624074;
​
            public const int Base_Widget_AppCompat_EditText = 2131624075;
​
            public const int Base_Widget_AppCompat_ImageButton = 2131624076;
​
            public const int Base_Widget_AppCompat_Light_ActionBar = 2131624077;
​
            public const int Base_Widget_AppCompat_Light_ActionBar_Solid = 2131624078;
​
            public const int Base_Widget_AppCompat_Light_ActionBar_TabBar = 2131624079;
​
            public const int Base_Widget_AppCompat_Light_ActionBar_TabText = 2131624080;
​
            public const int Base_Widget_AppCompat_Light_ActionBar_TabText_Inverse = 2131624081;
​
            public const int Base_Widget_AppCompat_Light_ActionBar_TabView = 2131624082;
​
            public const int Base_Widget_AppCompat_Light_PopupMenu = 2131624083;
​
            public const int Base_Widget_AppCompat_Light_PopupMenu_Overflow = 2131624084;
​
            public const int Base_Widget_AppCompat_ListMenuView = 2131624085;
​
            public const int Base_Widget_AppCompat_ListPopupWindow = 2131624086;
​
            public const int Base_Widget_AppCompat_ListView = 2131624087;
​
            public const int Base_Widget_AppCompat_ListView_DropDown = 2131624088;
​
            public const int Base_Widget_AppCompat_ListView_Menu = 2131624089;
​
            public const int Base_Widget_AppCompat_PopupMenu = 2131624090;
​
            public const int Base_Widget_AppCompat_PopupMenu_Overflow = 2131624091;
​
            public const int Base_Widget_AppCompat_PopupWindow = 2131624092;
​
            public const int Base_Widget_AppCompat_ProgressBar = 2131624093;
​
            public const int Base_Widget_AppCompat_ProgressBar_Horizontal = 2131624094;
​
            public const int Base_Widget_AppCompat_RatingBar = 2131624095;
​
            public const int Base_Widget_AppCompat_RatingBar_Indicator = 2131624096;
​
            public const int Base_Widget_AppCompat_RatingBar_Small = 2131624097;
​
            public const int Base_Widget_AppCompat_SearchView = 2131624098;
​
            public const int Base_Widget_AppCompat_SearchView_ActionBar = 2131624099;
​
            public const int Base_Widget_AppCompat_SeekBar = 2131624100;
​
            public const int Base_Widget_AppCompat_SeekBar_Discrete = 2131624101;
​
            public const int Base_Widget_AppCompat_Spinner = 2131624102;
​
            public const int Base_Widget_AppCompat_Spinner_Underlined = 2131624103;
​
            public const int Base_Widget_AppCompat_TextView_SpinnerItem = 2131624104;
​
            public const int Base_Widget_AppCompat_Toolbar = 2131624105;
​
            public const int Base_Widget_AppCompat_Toolbar_Button_Navigation = 2131624106;
​
            public const int Base_Widget_Design_AppBarLayout = 2131624107;
​
            public const int Base_Widget_Design_TabLayout = 2131624108;
​
            public const int Platform_AppCompat = 2131624109;
​
            public const int Platform_AppCompat_Light = 2131624110;
​
            public const int Platform_ThemeOverlay_AppCompat = 2131624111;
​
            public const int Platform_ThemeOverlay_AppCompat_Dark = 2131624112;
​
            public const int Platform_ThemeOverlay_AppCompat_Light = 2131624113;
​
            public const int Platform_V11_AppCompat = 2131624114;
​
            public const int Platform_V11_AppCompat_Light = 2131624115;
​
            public const int Platform_V14_AppCompat = 2131624116;
​
            public const int Platform_V14_AppCompat_Light = 2131624117;
​
            public const int Platform_V21_AppCompat = 2131624118;
​
            public const int Platform_V21_AppCompat_Light = 2131624119;
​
            public const int Platform_V25_AppCompat = 2131624120;
​
            public const int Platform_V25_AppCompat_Light = 2131624121;
​
            public const int Platform_Widget_AppCompat_Spinner = 2131624122;
​
            public const int RtlOverlay_DialogWindowTitle_AppCompat = 2131624123;
​
            public const int RtlOverlay_Widget_AppCompat_ActionBar_TitleItem = 2131624124;
​
            public const int RtlOverlay_Widget_AppCompat_DialogTitle_Icon = 2131624125;
​
            public const int RtlOverlay_Widget_AppCompat_PopupMenuItem = 2131624126;
​
            public const int RtlOverlay_Widget_AppCompat_PopupMenuItem_InternalGroup = 2131624127;
​
            public const int RtlOverlay_Widget_AppCompat_PopupMenuItem_Text = 2131624128;
​
            public const int RtlOverlay_Widget_AppCompat_SearchView_MagIcon = 2131624134;
​
            public const int RtlOverlay_Widget_AppCompat_Search_DropDown = 2131624129;
​
            public const int RtlOverlay_Widget_AppCompat_Search_DropDown_Icon1 = 2131624130;
​
            public const int RtlOverlay_Widget_AppCompat_Search_DropDown_Icon2 = 2131624131;
​
            public const int RtlOverlay_Widget_AppCompat_Search_DropDown_Query = 2131624132;
​
            public const int RtlOverlay_Widget_AppCompat_Search_DropDown_Text = 2131624133;
​
            public const int RtlUnderlay_Widget_AppCompat_ActionButton = 2131624135;
​
            public const int RtlUnderlay_Widget_AppCompat_ActionButton_Overflow = 2131624136;
​
            public const int TextAppearance_AppCompat = 2131624137;
​
            public const int TextAppearance_AppCompat_Body1 = 2131624138;
​
            public const int TextAppearance_AppCompat_Body2 = 2131624139;
​
            public const int TextAppearance_AppCompat_Button = 2131624140;
​
            public const int TextAppearance_AppCompat_Caption = 2131624141;
​
            public const int TextAppearance_AppCompat_Display1 = 2131624142;
​
            public const int TextAppearance_AppCompat_Display2 = 2131624143;
​
            public const int TextAppearance_AppCompat_Display3 = 2131624144;
​
            public const int TextAppearance_AppCompat_Display4 = 2131624145;
​
            public const int TextAppearance_AppCompat_Headline = 2131624146;
​
            public const int TextAppearance_AppCompat_Inverse = 2131624147;
​
            public const int TextAppearance_AppCompat_Large = 2131624148;
​
            public const int TextAppearance_AppCompat_Large_Inverse = 2131624149;
​
            public const int TextAppearance_AppCompat_Light_SearchResult_Subtitle = 2131624150;
​
            public const int TextAppearance_AppCompat_Light_SearchResult_Title = 2131624151;
​
            public const int TextAppearance_AppCompat_Light_Widget_PopupMenu_Large = 2131624152;
​
            public const int TextAppearance_AppCompat_Light_Widget_PopupMenu_Small = 2131624153;
​
            public const int TextAppearance_AppCompat_Medium = 2131624154;
​
            public const int TextAppearance_AppCompat_Medium_Inverse = 2131624155;
​
            public const int TextAppearance_AppCompat_Menu = 2131624156;
​
            public const int TextAppearance_AppCompat_SearchResult_Subtitle = 2131624157;
​
            public const int TextAppearance_AppCompat_SearchResult_Title = 2131624158;
​
            public const int TextAppearance_AppCompat_Small = 2131624159;
​
            public const int TextAppearance_AppCompat_Small_Inverse = 2131624160;
​
            public const int TextAppearance_AppCompat_Subhead = 2131624161;
​
            public const int TextAppearance_AppCompat_Subhead_Inverse = 2131624162;
​
            public const int TextAppearance_AppCompat_Title = 2131624163;
​
            public const int TextAppearance_AppCompat_Title_Inverse = 2131624164;
​
            public const int TextAppearance_AppCompat_Tooltip = 2131624165;
​
            public const int TextAppearance_AppCompat_Widget_ActionBar_Menu = 2131624166;
​
            public const int TextAppearance_AppCompat_Widget_ActionBar_Subtitle = 2131624167;
​
            public const int TextAppearance_AppCompat_Widget_ActionBar_Subtitle_Inverse = 2131624168;
​
            public const int TextAppearance_AppCompat_Widget_ActionBar_Title = 2131624169;
​
            public const int TextAppearance_AppCompat_Widget_ActionBar_Title_Inverse = 2131624170;
​
            public const int TextAppearance_AppCompat_Widget_ActionMode_Subtitle = 2131624171;
​
            public const int TextAppearance_AppCompat_Widget_ActionMode_Subtitle_Inverse = 2131624172;
​
            public const int TextAppearance_AppCompat_Widget_ActionMode_Title = 2131624173;
​
            public const int TextAppearance_AppCompat_Widget_ActionMode_Title_Inverse = 2131624174;
​
            public const int TextAppearance_AppCompat_Widget_Button = 2131624175;
​
            public const int TextAppearance_AppCompat_Widget_Button_Borderless_Colored = 2131624176;
​
            public const int TextAppearance_AppCompat_Widget_Button_Colored = 2131624177;
​
            public const int TextAppearance_AppCompat_Widget_Button_Inverse = 2131624178;
​
            public const int TextAppearance_AppCompat_Widget_DropDownItem = 2131624179;
​
            public const int TextAppearance_AppCompat_Widget_PopupMenu_Header = 2131624180;
​
            public const int TextAppearance_AppCompat_Widget_PopupMenu_Large = 2131624181;
​
            public const int TextAppearance_AppCompat_Widget_PopupMenu_Small = 2131624182;
​
            public const int TextAppearance_AppCompat_Widget_Switch = 2131624183;
​
            public const int TextAppearance_AppCompat_Widget_TextView_SpinnerItem = 2131624184;
​
            public const int TextAppearance_Compat_Notification = 2131624185;
​
            public const int TextAppearance_Compat_Notification_Info = 2131624186;
​
            public const int TextAppearance_Compat_Notification_Info_Media = 2131624187;
​
            public const int TextAppearance_Compat_Notification_Line2 = 2131624188;
​
            public const int TextAppearance_Compat_Notification_Line2_Media = 2131624189;
​
            public const int TextAppearance_Compat_Notification_Media = 2131624190;
​
            public const int TextAppearance_Compat_Notification_Time = 2131624191;
​
            public const int TextAppearance_Compat_Notification_Time_Media = 2131624192;
​
            public const int TextAppearance_Compat_Notification_Title = 2131624193;
​
            public const int TextAppearance_Compat_Notification_Title_Media = 2131624194;
​
            public const int TextAppearance_Design_CollapsingToolbar_Expanded = 2131624195;
​
            public const int TextAppearance_Design_Counter = 2131624196;
​
            public const int TextAppearance_Design_Counter_Overflow = 2131624197;
​
            public const int TextAppearance_Design_Error = 2131624198;
​
            public const int TextAppearance_Design_Hint = 2131624199;
​
            public const int TextAppearance_Design_Snackbar_Message = 2131624200;
​
            public const int TextAppearance_Design_Tab = 2131624201;
​
            public const int TextAppearance_Widget_AppCompat_ExpandedMenu_Item = 2131624202;
​
            public const int TextAppearance_Widget_AppCompat_Toolbar_Subtitle = 2131624203;
​
            public const int TextAppearance_Widget_AppCompat_Toolbar_Title = 2131624204;
​
            public const int ThemeOverlay_AppCompat = 2131624232;
​
            public const int ThemeOverlay_AppCompat_ActionBar = 2131624233;
​
            public const int ThemeOverlay_AppCompat_Dark = 2131624234;
​
            public const int ThemeOverlay_AppCompat_Dark_ActionBar = 2131624235;
​
            public const int ThemeOverlay_AppCompat_Dialog = 2131624236;
​
            public const int ThemeOverlay_AppCompat_Dialog_Alert = 2131624237;
​
            public const int ThemeOverlay_AppCompat_Light = 2131624238;
​
            public const int Theme_AppCompat = 2131624205;
​
            public const int Theme_AppCompat_CompactMenu = 2131624206;
​
            public const int Theme_AppCompat_DayNight = 2131624207;
​
            public const int Theme_AppCompat_DayNight_DarkActionBar = 2131624208;
​
            public const int Theme_AppCompat_DayNight_Dialog = 2131624209;
​
            public const int Theme_AppCompat_DayNight_DialogWhenLarge = 2131624212;
​
            public const int Theme_AppCompat_DayNight_Dialog_Alert = 2131624210;
​
            public const int Theme_AppCompat_DayNight_Dialog_MinWidth = 2131624211;
​
            public const int Theme_AppCompat_DayNight_NoActionBar = 2131624213;
​
            public const int Theme_AppCompat_Dialog = 2131624214;
​
            public const int Theme_AppCompat_DialogWhenLarge = 2131624217;
​
            public const int Theme_AppCompat_Dialog_Alert = 2131624215;
​
            public const int Theme_AppCompat_Dialog_MinWidth = 2131624216;
​
            public const int Theme_AppCompat_Light = 2131624218;
​
            public const int Theme_AppCompat_Light_DarkActionBar = 2131624219;
​
            public const int Theme_AppCompat_Light_Dialog = 2131624220;
​
            public const int Theme_AppCompat_Light_DialogWhenLarge = 2131624223;
​
            public const int Theme_AppCompat_Light_Dialog_Alert = 2131624221;
​
            public const int Theme_AppCompat_Light_Dialog_MinWidth = 2131624222;
​
            public const int Theme_AppCompat_Light_NoActionBar = 2131624224;
​
            public const int Theme_AppCompat_NoActionBar = 2131624225;
​
            public const int Theme_Design = 2131624226;
​
            public const int Theme_Design_BottomSheetDialog = 2131624227;
​
            public const int Theme_Design_Light = 2131624228;
​
            public const int Theme_Design_Light_BottomSheetDialog = 2131624229;
​
            public const int Theme_Design_Light_NoActionBar = 2131624230;
​
            public const int Theme_Design_NoActionBar = 2131624231;
​
            public const int Widget_AppCompat_ActionBar = 2131624239;
​
            public const int Widget_AppCompat_ActionBar_Solid = 2131624240;
​
            public const int Widget_AppCompat_ActionBar_TabBar = 2131624241;
​
            public const int Widget_AppCompat_ActionBar_TabText = 2131624242;
​
            public const int Widget_AppCompat_ActionBar_TabView = 2131624243;
​
            public const int Widget_AppCompat_ActionButton = 2131624244;
​
            public const int Widget_AppCompat_ActionButton_CloseMode = 2131624245;
​
            public const int Widget_AppCompat_ActionButton_Overflow = 2131624246;
​
            public const int Widget_AppCompat_ActionMode = 2131624247;
​
            public const int Widget_AppCompat_ActivityChooserView = 2131624248;
​
            public const int Widget_AppCompat_AutoCompleteTextView = 2131624249;
​
            public const int Widget_AppCompat_Button = 2131624250;
​
            public const int Widget_AppCompat_ButtonBar = 2131624256;
​
            public const int Widget_AppCompat_ButtonBar_AlertDialog = 2131624257;
​
            public const int Widget_AppCompat_Button_Borderless = 2131624251;
​
            public const int Widget_AppCompat_Button_Borderless_Colored = 2131624252;
​
            public const int Widget_AppCompat_Button_ButtonBar_AlertDialog = 2131624253;
​
            public const int Widget_AppCompat_Button_Colored = 2131624254;
​
            public const int Widget_AppCompat_Button_Small = 2131624255;
​
            public const int Widget_AppCompat_CompoundButton_CheckBox = 2131624258;
​
            public const int Widget_AppCompat_CompoundButton_RadioButton = 2131624259;
​
            public const int Widget_AppCompat_CompoundButton_Switch = 2131624260;
​
            public const int Widget_AppCompat_DrawerArrowToggle = 2131624261;
​
            public const int Widget_AppCompat_DropDownItem_Spinner = 2131624262;
​
            public const int Widget_AppCompat_EditText = 2131624263;
​
            public const int Widget_AppCompat_ImageButton = 2131624264;
​
            public const int Widget_AppCompat_Light_ActionBar = 2131624265;
​
            public const int Widget_AppCompat_Light_ActionBar_Solid = 2131624266;
​
            public const int Widget_AppCompat_Light_ActionBar_Solid_Inverse = 2131624267;
​
            public const int Widget_AppCompat_Light_ActionBar_TabBar = 2131624268;
​
            public const int Widget_AppCompat_Light_ActionBar_TabBar_Inverse = 2131624269;
​
            public const int Widget_AppCompat_Light_ActionBar_TabText = 2131624270;
​
            public const int Widget_AppCompat_Light_ActionBar_TabText_Inverse = 2131624271;
​
            public const int Widget_AppCompat_Light_ActionBar_TabView = 2131624272;
​
            public const int Widget_AppCompat_Light_ActionBar_TabView_Inverse = 2131624273;
​
            public const int Widget_AppCompat_Light_ActionButton = 2131624274;
​
            public const int Widget_AppCompat_Light_ActionButton_CloseMode = 2131624275;
​
            public const int Widget_AppCompat_Light_ActionButton_Overflow = 2131624276;
​
            public const int Widget_AppCompat_Light_ActionMode_Inverse = 2131624277;
​
            public const int Widget_AppCompat_Light_ActivityChooserView = 2131624278;
​
            public const int Widget_AppCompat_Light_AutoCompleteTextView = 2131624279;
​
            public const int Widget_AppCompat_Light_DropDownItem_Spinner = 2131624280;
​
            public const int Widget_AppCompat_Light_ListPopupWindow = 2131624281;
​
            public const int Widget_AppCompat_Light_ListView_DropDown = 2131624282;
​
            public const int Widget_AppCompat_Light_PopupMenu = 2131624283;
​
            public const int Widget_AppCompat_Light_PopupMenu_Overflow = 2131624284;
​
            public const int Widget_AppCompat_Light_SearchView = 2131624285;
​
            public const int Widget_AppCompat_Light_Spinner_DropDown_ActionBar = 2131624286;
​
            public const int Widget_AppCompat_ListMenuView = 2131624287;
​
            public const int Widget_AppCompat_ListPopupWindow = 2131624288;
​
            public const int Widget_AppCompat_ListView = 2131624289;
​
            public const int Widget_AppCompat_ListView_DropDown = 2131624290;
​
            public const int Widget_AppCompat_ListView_Menu = 2131624291;
​
            public const int Widget_AppCompat_PopupMenu = 2131624292;
​
            public const int Widget_AppCompat_PopupMenu_Overflow = 2131624293;
​
            public const int Widget_AppCompat_PopupWindow = 2131624294;
​
            public const int Widget_AppCompat_ProgressBar = 2131624295;
​
            public const int Widget_AppCompat_ProgressBar_Horizontal = 2131624296;
​
            public const int Widget_AppCompat_RatingBar = 2131624297;
​
            public const int Widget_AppCompat_RatingBar_Indicator = 2131624298;
​
            public const int Widget_AppCompat_RatingBar_Small = 2131624299;
​
            public const int Widget_AppCompat_SearchView = 2131624300;
​
            public const int Widget_AppCompat_SearchView_ActionBar = 2131624301;
​
            public const int Widget_AppCompat_SeekBar = 2131624302;
​
            public const int Widget_AppCompat_SeekBar_Discrete = 2131624303;
​
            public const int Widget_AppCompat_Spinner = 2131624304;
​
            public const int Widget_AppCompat_Spinner_DropDown = 2131624305;
​
            public const int Widget_AppCompat_Spinner_DropDown_ActionBar = 2131624306;
​
            public const int Widget_AppCompat_Spinner_Underlined = 2131624307;
​
            public const int Widget_AppCompat_TextView_SpinnerItem = 2131624308;
​
            public const int Widget_AppCompat_Toolbar = 2131624309;
​
            public const int Widget_AppCompat_Toolbar_Button_Navigation = 2131624310;
​
            public const int Widget_Compat_NotificationActionContainer = 2131624311;
​
            public const int Widget_Compat_NotificationActionText = 2131624312;
​
            public const int Widget_Design_AppBarLayout = 2131624313;
​
            public const int Widget_Design_BottomNavigationView = 2131624314;
​
            public const int Widget_Design_BottomSheet_Modal = 2131624315;
​
            public const int Widget_Design_CollapsingToolbar = 2131624316;
​
            public const int Widget_Design_CoordinatorLayout = 2131624317;
​
            public const int Widget_Design_FloatingActionButton = 2131624318;
​
            public const int Widget_Design_NavigationView = 2131624319;
​
            public const int Widget_Design_ScrimInsetsFrameLayout = 2131624320;
​
            public const int Widget_Design_Snackbar = 2131624321;
​
            public const int Widget_Design_TabLayout = 2131624322;
​
            public const int Widget_Design_TextInputLayout = 2131624323;
​
            static Style()
            {
                ResourceIdManager.UpdateIdValues();
            }
​
            private Style()
            {
            }
        }
​
        public class Styleable
        {
            public static int[] ActionBar;
​
            public static int[] ActionBarLayout;
​
            public const int ActionBarLayout_android_layout_gravity = 0;
​
            public const int ActionBar_background = 0;
​
            public const int ActionBar_backgroundSplit = 1;
​
            public const int ActionBar_backgroundStacked = 2;
​
            public const int ActionBar_contentInsetEnd = 3;
​
            public const int ActionBar_contentInsetEndWithActions = 4;
​
            public const int ActionBar_contentInsetLeft = 5;
​
            public const int ActionBar_contentInsetRight = 6;
​
            public const int ActionBar_contentInsetStart = 7;
​
            public const int ActionBar_contentInsetStartWithNavigation = 8;
​
            public const int ActionBar_customNavigationLayout = 9;
​
            public const int ActionBar_displayOptions = 10;
​
            public const int ActionBar_divider = 11;
​
            public const int ActionBar_elevation = 12;
​
            public const int ActionBar_height = 13;
​
            public const int ActionBar_hideOnContentScroll = 14;
​
            public const int ActionBar_homeAsUpIndicator = 15;
​
            public const int ActionBar_homeLayout = 16;
​
            public const int ActionBar_icon = 17;
​
            public const int ActionBar_indeterminateProgressStyle = 18;
​
            public const int ActionBar_itemPadding = 19;
​
            public const int ActionBar_logo = 20;
​
            public const int ActionBar_navigationMode = 21;
​
            public const int ActionBar_popupTheme = 22;
​
            public const int ActionBar_progressBarPadding = 23;
​
            public const int ActionBar_progressBarStyle = 24;
​
            public const int ActionBar_subtitle = 25;
​
            public const int ActionBar_subtitleTextStyle = 26;
​
            public const int ActionBar_title = 27;
​
            public const int ActionBar_titleTextStyle = 28;
​
            public static int[] ActionMenuItemView;
​
            public const int ActionMenuItemView_android_minWidth = 0;
​
            public static int[] ActionMenuView;
​
            public static int[] ActionMode;
​
            public const int ActionMode_background = 0;
​
            public const int ActionMode_backgroundSplit = 1;
​
            public const int ActionMode_closeItemLayout = 2;
​
            public const int ActionMode_height = 3;
​
            public const int ActionMode_subtitleTextStyle = 4;
​
            public const int ActionMode_titleTextStyle = 5;
​
            public static int[] ActivityChooserView;
​
            public const int ActivityChooserView_expandActivityOverflowButtonDrawable = 0;
​
            public const int ActivityChooserView_initialActivityCount = 1;
​
            public static int[] AlertDialog;
​
            public const int AlertDialog_android_layout = 0;
​
            public const int AlertDialog_buttonPanelSideLayout = 1;
​
            public const int AlertDialog_listItemLayout = 2;
​
            public const int AlertDialog_listLayout = 3;
​
            public const int AlertDialog_multiChoiceItemLayout = 4;
​
            public const int AlertDialog_showTitle = 5;
​
            public const int AlertDialog_singleChoiceItemLayout = 6;
​
            public static int[] AppBarLayout;
​
            public static int[] AppBarLayoutStates;
​
            public const int AppBarLayoutStates_state_collapsed = 0;
​
            public const int AppBarLayoutStates_state_collapsible = 1;
​
            public const int AppBarLayout_android_background = 0;
​
            public const int AppBarLayout_android_keyboardNavigationCluster = 2;
​
            public const int AppBarLayout_android_touchscreenBlocksFocus = 1;
​
            public const int AppBarLayout_elevation = 3;
​
            public const int AppBarLayout_expanded = 4;
​
            public static int[] AppBarLayout_Layout;
​
            public const int AppBarLayout_Layout_layout_scrollFlags = 0;
​
            public const int AppBarLayout_Layout_layout_scrollInterpolator = 1;
​
            public static int[] AppCompatImageView;
​
            public const int AppCompatImageView_android_src = 0;
​
            public const int AppCompatImageView_srcCompat = 1;
​
            public const int AppCompatImageView_tint = 2;
​
            public const int AppCompatImageView_tintMode = 3;
​
            public static int[] AppCompatSeekBar;
​
            public const int AppCompatSeekBar_android_thumb = 0;
​
            public const int AppCompatSeekBar_tickMark = 1;
​
            public const int AppCompatSeekBar_tickMarkTint = 2;
​
            public const int AppCompatSeekBar_tickMarkTintMode = 3;
​
            public static int[] AppCompatTextHelper;
​
            public const int AppCompatTextHelper_android_drawableBottom = 2;
​
            public const int AppCompatTextHelper_android_drawableEnd = 6;
​
            public const int AppCompatTextHelper_android_drawableLeft = 3;
​
            public const int AppCompatTextHelper_android_drawableRight = 4;
​
            public const int AppCompatTextHelper_android_drawableStart = 5;
​
            public const int AppCompatTextHelper_android_drawableTop = 1;
​
            public const int AppCompatTextHelper_android_textAppearance = 0;
​
            public static int[] AppCompatTextView;
​
            public const int AppCompatTextView_android_textAppearance = 0;
​
            public const int AppCompatTextView_autoSizeMaxTextSize = 1;
​
            public const int AppCompatTextView_autoSizeMinTextSize = 2;
​
            public const int AppCompatTextView_autoSizePresetSizes = 3;
​
            public const int AppCompatTextView_autoSizeStepGranularity = 4;
​
            public const int AppCompatTextView_autoSizeTextType = 5;
​
            public const int AppCompatTextView_fontFamily = 6;
​
            public const int AppCompatTextView_textAllCaps = 7;
​
            public static int[] AppCompatTheme;
​
            public const int AppCompatTheme_actionBarDivider = 2;
​
            public const int AppCompatTheme_actionBarItemBackground = 3;
​
            public const int AppCompatTheme_actionBarPopupTheme = 4;
​
            public const int AppCompatTheme_actionBarSize = 5;
​
            public const int AppCompatTheme_actionBarSplitStyle = 6;
​
            public const int AppCompatTheme_actionBarStyle = 7;
​
            public const int AppCompatTheme_actionBarTabBarStyle = 8;
​
            public const int AppCompatTheme_actionBarTabStyle = 9;
​
            public const int AppCompatTheme_actionBarTabTextStyle = 10;
​
            public const int AppCompatTheme_actionBarTheme = 11;
​
            public const int AppCompatTheme_actionBarWidgetTheme = 12;
​
            public const int AppCompatTheme_actionButtonStyle = 13;
​
            public const int AppCompatTheme_actionDropDownStyle = 14;
​
            public const int AppCompatTheme_actionMenuTextAppearance = 15;
​
            public const int AppCompatTheme_actionMenuTextColor = 16;
​
            public const int AppCompatTheme_actionModeBackground = 17;
​
            public const int AppCompatTheme_actionModeCloseButtonStyle = 18;
​
            public const int AppCompatTheme_actionModeCloseDrawable = 19;
​
            public const int AppCompatTheme_actionModeCopyDrawable = 20;
​
            public const int AppCompatTheme_actionModeCutDrawable = 21;
​
            public const int AppCompatTheme_actionModeFindDrawable = 22;
​
            public const int AppCompatTheme_actionModePasteDrawable = 23;
​
            public const int AppCompatTheme_actionModePopupWindowStyle = 24;
​
            public const int AppCompatTheme_actionModeSelectAllDrawable = 25;
​
            public const int AppCompatTheme_actionModeShareDrawable = 26;
​
            public const int AppCompatTheme_actionModeSplitBackground = 27;
​
            public const int AppCompatTheme_actionModeStyle = 28;
​
            public const int AppCompatTheme_actionModeWebSearchDrawable = 29;
​
            public const int AppCompatTheme_actionOverflowButtonStyle = 30;
​
            public const int AppCompatTheme_actionOverflowMenuStyle = 31;
​
            public const int AppCompatTheme_activityChooserViewStyle = 32;
​
            public const int AppCompatTheme_alertDialogButtonGroupStyle = 33;
​
            public const int AppCompatTheme_alertDialogCenterButtons = 34;
​
            public const int AppCompatTheme_alertDialogStyle = 35;
​
            public const int AppCompatTheme_alertDialogTheme = 36;
​
            public const int AppCompatTheme_android_windowAnimationStyle = 1;
​
            public const int AppCompatTheme_android_windowIsFloating = 0;
​
            public const int AppCompatTheme_autoCompleteTextViewStyle = 37;
​
            public const int AppCompatTheme_borderlessButtonStyle = 38;
​
            public const int AppCompatTheme_buttonBarButtonStyle = 39;
​
            public const int AppCompatTheme_buttonBarNegativeButtonStyle = 40;
​
            public const int AppCompatTheme_buttonBarNeutralButtonStyle = 41;
​
            public const int AppCompatTheme_buttonBarPositiveButtonStyle = 42;
​
            public const int AppCompatTheme_buttonBarStyle = 43;
​
            public const int AppCompatTheme_buttonStyle = 44;
​
            public const int AppCompatTheme_buttonStyleSmall = 45;
​
            public const int AppCompatTheme_checkboxStyle = 46;
​
            public const int AppCompatTheme_checkedTextViewStyle = 47;
​
            public const int AppCompatTheme_colorAccent = 48;
​
            public const int AppCompatTheme_colorBackgroundFloating = 49;
​
            public const int AppCompatTheme_colorButtonNormal = 50;
​
            public const int AppCompatTheme_colorControlActivated = 51;
​
            public const int AppCompatTheme_colorControlHighlight = 52;
​
            public const int AppCompatTheme_colorControlNormal = 53;
​
            public const int AppCompatTheme_colorError = 54;
​
            public const int AppCompatTheme_colorPrimary = 55;
​
            public const int AppCompatTheme_colorPrimaryDark = 56;
​
            public const int AppCompatTheme_colorSwitchThumbNormal = 57;
​
            public const int AppCompatTheme_controlBackground = 58;
​
            public const int AppCompatTheme_dialogPreferredPadding = 59;
​
            public const int AppCompatTheme_dialogTheme = 60;
​
            public const int AppCompatTheme_dividerHorizontal = 61;
​
            public const int AppCompatTheme_dividerVertical = 62;
​
            public const int AppCompatTheme_dropdownListPreferredItemHeight = 64;
​
            public const int AppCompatTheme_dropDownListViewStyle = 63;
​
            public const int AppCompatTheme_editTextBackground = 65;
​
            public const int AppCompatTheme_editTextColor = 66;
​
            public const int AppCompatTheme_editTextStyle = 67;
​
            public const int AppCompatTheme_homeAsUpIndicator = 68;
​
            public const int AppCompatTheme_imageButtonStyle = 69;
​
            public const int AppCompatTheme_listChoiceBackgroundIndicator = 70;
​
            public const int AppCompatTheme_listDividerAlertDialog = 71;
​
            public const int AppCompatTheme_listMenuViewStyle = 72;
​
            public const int AppCompatTheme_listPopupWindowStyle = 73;
​
            public const int AppCompatTheme_listPreferredItemHeight = 74;
​
            public const int AppCompatTheme_listPreferredItemHeightLarge = 75;
​
            public const int AppCompatTheme_listPreferredItemHeightSmall = 76;
​
            public const int AppCompatTheme_listPreferredItemPaddingLeft = 77;
​
            public const int AppCompatTheme_listPreferredItemPaddingRight = 78;
​
            public const int AppCompatTheme_panelBackground = 79;
​
            public const int AppCompatTheme_panelMenuListTheme = 80;
​
            public const int AppCompatTheme_panelMenuListWidth = 81;
​
            public const int AppCompatTheme_popupMenuStyle = 82;
​
            public const int AppCompatTheme_popupWindowStyle = 83;
​
            public const int AppCompatTheme_radioButtonStyle = 84;
​
            public const int AppCompatTheme_ratingBarStyle = 85;
​
            public const int AppCompatTheme_ratingBarStyleIndicator = 86;
​
            public const int AppCompatTheme_ratingBarStyleSmall = 87;
​
            public const int AppCompatTheme_searchViewStyle = 88;
​
            public const int AppCompatTheme_seekBarStyle = 89;
​
            public const int AppCompatTheme_selectableItemBackground = 90;
​
            public const int AppCompatTheme_selectableItemBackgroundBorderless = 91;
​
            public const int AppCompatTheme_spinnerDropDownItemStyle = 92;
​
            public const int AppCompatTheme_spinnerStyle = 93;
​
            public const int AppCompatTheme_switchStyle = 94;
​
            public const int AppCompatTheme_textAppearanceLargePopupMenu = 95;
​
            public const int AppCompatTheme_textAppearanceListItem = 96;
​
            public const int AppCompatTheme_textAppearanceListItemSecondary = 97;
​
            public const int AppCompatTheme_textAppearanceListItemSmall = 98;
​
            public const int AppCompatTheme_textAppearancePopupMenuHeader = 99;
​
            public const int AppCompatTheme_textAppearanceSearchResultSubtitle = 100;
​
            public const int AppCompatTheme_textAppearanceSearchResultTitle = 101;
​
            public const int AppCompatTheme_textAppearanceSmallPopupMenu = 102;
​
            public const int AppCompatTheme_textColorAlertDialogListItem = 103;
​
            public const int AppCompatTheme_textColorSearchUrl = 104;
​
            public const int AppCompatTheme_toolbarNavigationButtonStyle = 105;
​
            public const int AppCompatTheme_toolbarStyle = 106;
​
            public const int AppCompatTheme_tooltipForegroundColor = 107;
​
            public const int AppCompatTheme_tooltipFrameBackground = 108;
​
            public const int AppCompatTheme_windowActionBar = 109;
​
            public const int AppCompatTheme_windowActionBarOverlay = 110;
​
            public const int AppCompatTheme_windowActionModeOverlay = 111;
​
            public const int AppCompatTheme_windowFixedHeightMajor = 112;
​
            public const int AppCompatTheme_windowFixedHeightMinor = 113;
​
            public const int AppCompatTheme_windowFixedWidthMajor = 114;
​
            public const int AppCompatTheme_windowFixedWidthMinor = 115;
​
            public const int AppCompatTheme_windowMinWidthMajor = 116;
​
            public const int AppCompatTheme_windowMinWidthMinor = 117;
​
            public const int AppCompatTheme_windowNoTitle = 118;
​
            public static int[] BottomNavigationView;
​
            public const int BottomNavigationView_elevation = 0;
​
            public const int BottomNavigationView_itemBackground = 1;
​
            public const int BottomNavigationView_itemIconTint = 2;
​
            public const int BottomNavigationView_itemTextColor = 3;
​
            public const int BottomNavigationView_menu = 4;
​
            public static int[] BottomSheetBehavior_Layout;
​
            public const int BottomSheetBehavior_Layout_behavior_hideable = 0;
​
            public const int BottomSheetBehavior_Layout_behavior_peekHeight = 1;
​
            public const int BottomSheetBehavior_Layout_behavior_skipCollapsed = 2;
​
            public static int[] ButtonBarLayout;
​
            public const int ButtonBarLayout_allowStacking = 0;
​
            public static int[] CollapsingToolbarLayout;
​
            public const int CollapsingToolbarLayout_collapsedTitleGravity = 0;
​
            public const int CollapsingToolbarLayout_collapsedTitleTextAppearance = 1;
​
            public const int CollapsingToolbarLayout_contentScrim = 2;
​
            public const int CollapsingToolbarLayout_expandedTitleGravity = 3;
​
            public const int CollapsingToolbarLayout_expandedTitleMargin = 4;
​
            public const int CollapsingToolbarLayout_expandedTitleMarginBottom = 5;
​
            public const int CollapsingToolbarLayout_expandedTitleMarginEnd = 6;
​
            public const int CollapsingToolbarLayout_expandedTitleMarginStart = 7;
​
            public const int CollapsingToolbarLayout_expandedTitleMarginTop = 8;
​
            public const int CollapsingToolbarLayout_expandedTitleTextAppearance = 9;
​
            public static int[] CollapsingToolbarLayout_Layout;
​
            public const int CollapsingToolbarLayout_Layout_layout_collapseMode = 0;
​
            public const int CollapsingToolbarLayout_Layout_layout_collapseParallaxMultiplier = 1;
​
            public const int CollapsingToolbarLayout_scrimAnimationDuration = 10;
​
            public const int CollapsingToolbarLayout_scrimVisibleHeightTrigger = 11;
​
            public const int CollapsingToolbarLayout_statusBarScrim = 12;
​
            public const int CollapsingToolbarLayout_title = 13;
​
            public const int CollapsingToolbarLayout_titleEnabled = 14;
​
            public const int CollapsingToolbarLayout_toolbarId = 15;
​
            public static int[] ColorStateListItem;
​
            public const int ColorStateListItem_alpha = 2;
​
            public const int ColorStateListItem_android_alpha = 1;
​
            public const int ColorStateListItem_android_color = 0;
​
            public static int[] CompoundButton;
​
            public const int CompoundButton_android_button = 0;
​
            public const int CompoundButton_buttonTint = 1;
​
            public const int CompoundButton_buttonTintMode = 2;
​
            public static int[] CoordinatorLayout;
​
            public const int CoordinatorLayout_keylines = 0;
​
            public static int[] CoordinatorLayout_Layout;
​
            public const int CoordinatorLayout_Layout_android_layout_gravity = 0;
​
            public const int CoordinatorLayout_Layout_layout_anchor = 1;
​
            public const int CoordinatorLayout_Layout_layout_anchorGravity = 2;
​
            public const int CoordinatorLayout_Layout_layout_behavior = 3;
​
            public const int CoordinatorLayout_Layout_layout_dodgeInsetEdges = 4;
​
            public const int CoordinatorLayout_Layout_layout_insetEdge = 5;
​
            public const int CoordinatorLayout_Layout_layout_keyline = 6;
​
            public const int CoordinatorLayout_statusBarBackground = 1;
​
            public static int[] DesignTheme;
​
            public const int DesignTheme_bottomSheetDialogTheme = 0;
​
            public const int DesignTheme_bottomSheetStyle = 1;
​
            public const int DesignTheme_textColorError = 2;
​
            public static int[] DrawerArrowToggle;
​
            public const int DrawerArrowToggle_arrowHeadLength = 0;
​
            public const int DrawerArrowToggle_arrowShaftLength = 1;
​
            public const int DrawerArrowToggle_barLength = 2;
​
            public const int DrawerArrowToggle_color = 3;
​
            public const int DrawerArrowToggle_drawableSize = 4;
​
            public const int DrawerArrowToggle_gapBetweenBars = 5;
​
            public const int DrawerArrowToggle_spinBars = 6;
​
            public const int DrawerArrowToggle_thickness = 7;
​
            public static int[] FloatingActionButton;
​
            public const int FloatingActionButton_backgroundTint = 0;
​
            public const int FloatingActionButton_backgroundTintMode = 1;
​
            public static int[] FloatingActionButton_Behavior_Layout;
​
            public const int FloatingActionButton_Behavior_Layout_behavior_autoHide = 0;
​
            public const int FloatingActionButton_borderWidth = 2;
​
            public const int FloatingActionButton_elevation = 3;
​
            public const int FloatingActionButton_fabSize = 4;
​
            public const int FloatingActionButton_pressedTranslationZ = 5;
​
            public const int FloatingActionButton_rippleColor = 6;
​
            public const int FloatingActionButton_useCompatPadding = 7;
​
            public static int[] FontFamily;
​
            public static int[] FontFamilyFont;
​
            public const int FontFamilyFont_android_font = 0;
​
            public const int FontFamilyFont_android_fontStyle = 2;
​
            public const int FontFamilyFont_android_fontWeight = 1;
​
            public const int FontFamilyFont_font = 3;
​
            public const int FontFamilyFont_fontStyle = 4;
​
            public const int FontFamilyFont_fontWeight = 5;
​
            public const int FontFamily_fontProviderAuthority = 0;
​
            public const int FontFamily_fontProviderCerts = 1;
​
            public const int FontFamily_fontProviderFetchStrategy = 2;
​
            public const int FontFamily_fontProviderFetchTimeout = 3;
​
            public const int FontFamily_fontProviderPackage = 4;
​
            public const int FontFamily_fontProviderQuery = 5;
​
            public static int[] ForegroundLinearLayout;
​
            public const int ForegroundLinearLayout_android_foreground = 0;
​
            public const int ForegroundLinearLayout_android_foregroundGravity = 1;
​
            public const int ForegroundLinearLayout_foregroundInsidePadding = 2;
​
            public static int[] LinearLayoutCompat;
​
            public const int LinearLayoutCompat_android_baselineAligned = 2;
​
            public const int LinearLayoutCompat_android_baselineAlignedChildIndex = 3;
​
            public const int LinearLayoutCompat_android_gravity = 0;
​
            public const int LinearLayoutCompat_android_orientation = 1;
​
            public const int LinearLayoutCompat_android_weightSum = 4;
​
            public const int LinearLayoutCompat_divider = 5;
​
            public const int LinearLayoutCompat_dividerPadding = 6;
​
            public static int[] LinearLayoutCompat_Layout;
​
            public const int LinearLayoutCompat_Layout_android_layout_gravity = 0;
​
            public const int LinearLayoutCompat_Layout_android_layout_height = 2;
​
            public const int LinearLayoutCompat_Layout_android_layout_weight = 3;
​
            public const int LinearLayoutCompat_Layout_android_layout_width = 1;
​
            public const int LinearLayoutCompat_measureWithLargestChild = 7;
​
            public const int LinearLayoutCompat_showDividers = 8;
​
            public static int[] ListPopupWindow;
​
            public const int ListPopupWindow_android_dropDownHorizontalOffset = 0;
​
            public const int ListPopupWindow_android_dropDownVerticalOffset = 1;
​
            public static int[] MenuGroup;
​
            public const int MenuGroup_android_checkableBehavior = 5;
​
            public const int MenuGroup_android_enabled = 0;
​
            public const int MenuGroup_android_id = 1;
​
            public const int MenuGroup_android_menuCategory = 3;
​
            public const int MenuGroup_android_orderInCategory = 4;
​
            public const int MenuGroup_android_visible = 2;
​
            public static int[] MenuItem;
​
            public const int MenuItem_actionLayout = 13;
​
            public const int MenuItem_actionProviderClass = 14;
​
            public const int MenuItem_actionViewClass = 15;
​
            public const int MenuItem_alphabeticModifiers = 16;
​
            public const int MenuItem_android_alphabeticShortcut = 9;
​
            public const int MenuItem_android_checkable = 11;
​
            public const int MenuItem_android_checked = 3;
​
            public const int MenuItem_android_enabled = 1;
​
            public const int MenuItem_android_icon = 0;
​
            public const int MenuItem_android_id = 2;
​
            public const int MenuItem_android_menuCategory = 5;
​
            public const int MenuItem_android_numericShortcut = 10;
​
            public const int MenuItem_android_onClick = 12;
​
            public const int MenuItem_android_orderInCategory = 6;
​
            public const int MenuItem_android_title = 7;
​
            public const int MenuItem_android_titleCondensed = 8;
​
            public const int MenuItem_android_visible = 4;
​
            public const int MenuItem_contentDescription = 17;
​
            public const int MenuItem_iconTint = 18;
​
            public const int MenuItem_iconTintMode = 19;
​
            public const int MenuItem_numericModifiers = 20;
​
            public const int MenuItem_showAsAction = 21;
​
            public const int MenuItem_tooltipText = 22;
​
            public static int[] MenuView;
​
            public const int MenuView_android_headerBackground = 4;
​
            public const int MenuView_android_horizontalDivider = 2;
​
            public const int MenuView_android_itemBackground = 5;
​
            public const int MenuView_android_itemIconDisabledAlpha = 6;
​
            public const int MenuView_android_itemTextAppearance = 1;
​
            public const int MenuView_android_verticalDivider = 3;
​
            public const int MenuView_android_windowAnimationStyle = 0;
​
            public const int MenuView_preserveIconSpacing = 7;
​
            public const int MenuView_subMenuArrow = 8;
​
            public static int[] NavigationView;
​
            public const int NavigationView_android_background = 0;
​
            public const int NavigationView_android_fitsSystemWindows = 1;
​
            public const int NavigationView_android_maxWidth = 2;
​
            public const int NavigationView_elevation = 3;
​
            public const int NavigationView_headerLayout = 4;
​
            public const int NavigationView_itemBackground = 5;
​
            public const int NavigationView_itemIconTint = 6;
​
            public const int NavigationView_itemTextAppearance = 7;
​
            public const int NavigationView_itemTextColor = 8;
​
            public const int NavigationView_menu = 9;
​
            public static int[] PopupWindow;
​
            public static int[] PopupWindowBackgroundState;
​
            public const int PopupWindowBackgroundState_state_above_anchor = 0;
​
            public const int PopupWindow_android_popupAnimationStyle = 1;
​
            public const int PopupWindow_android_popupBackground = 0;
​
            public const int PopupWindow_overlapAnchor = 2;
​
            public static int[] RecycleListView;
​
            public const int RecycleListView_paddingBottomNoButtons = 0;
​
            public const int RecycleListView_paddingTopNoTitle = 1;
​
            public static int[] RecyclerView;
​
            public const int RecyclerView_android_descendantFocusability = 1;
​
            public const int RecyclerView_android_orientation = 0;
​
            public const int RecyclerView_fastScrollEnabled = 2;
​
            public const int RecyclerView_fastScrollHorizontalThumbDrawable = 3;
​
            public const int RecyclerView_fastScrollHorizontalTrackDrawable = 4;
​
            public const int RecyclerView_fastScrollVerticalThumbDrawable = 5;
​
            public const int RecyclerView_fastScrollVerticalTrackDrawable = 6;
​
            public const int RecyclerView_layoutManager = 7;
​
            public const int RecyclerView_reverseLayout = 8;
​
            public const int RecyclerView_spanCount = 9;
​
            public const int RecyclerView_stackFromEnd = 10;
​
            public static int[] ScrimInsetsFrameLayout;
​
            public const int ScrimInsetsFrameLayout_insetForeground = 0;
​
            public static int[] ScrollingViewBehavior_Layout;
​
            public const int ScrollingViewBehavior_Layout_behavior_overlapTop = 0;
​
            public static int[] SearchView;
​
            public const int SearchView_android_focusable = 0;
​
            public const int SearchView_android_imeOptions = 3;
​
            public const int SearchView_android_inputType = 2;
​
            public const int SearchView_android_maxWidth = 1;
​
            public const int SearchView_closeIcon = 4;
​
            public const int SearchView_commitIcon = 5;
​
            public const int SearchView_defaultQueryHint = 6;
​
            public const int SearchView_goIcon = 7;
​
            public const int SearchView_iconifiedByDefault = 8;
​
            public const int SearchView_layout = 9;
​
            public const int SearchView_queryBackground = 10;
​
            public const int SearchView_queryHint = 11;
​
            public const int SearchView_searchHintIcon = 12;
​
            public const int SearchView_searchIcon = 13;
​
            public const int SearchView_submitBackground = 14;
​
            public const int SearchView_suggestionRowLayout = 15;
​
            public const int SearchView_voiceIcon = 16;
​
            public static int[] SnackbarLayout;
​
            public const int SnackbarLayout_android_maxWidth = 0;
​
            public const int SnackbarLayout_elevation = 1;
​
            public const int SnackbarLayout_maxActionInlineWidth = 2;
​
            public static int[] Spinner;
​
            public const int Spinner_android_dropDownWidth = 3;
​
            public const int Spinner_android_entries = 0;
​
            public const int Spinner_android_popupBackground = 1;
​
            public const int Spinner_android_prompt = 2;
​
            public const int Spinner_popupTheme = 4;
​
            public static int[] SwitchCompat;
​
            public const int SwitchCompat_android_textOff = 1;
​
            public const int SwitchCompat_android_textOn = 0;
​
            public const int SwitchCompat_android_thumb = 2;
​
            public const int SwitchCompat_showText = 3;
​
            public const int SwitchCompat_splitTrack = 4;
​
            public const int SwitchCompat_switchMinWidth = 5;
​
            public const int SwitchCompat_switchPadding = 6;
​
            public const int SwitchCompat_switchTextAppearance = 7;
​
            public const int SwitchCompat_thumbTextPadding = 8;
​
            public const int SwitchCompat_thumbTint = 9;
​
            public const int SwitchCompat_thumbTintMode = 10;
​
            public const int SwitchCompat_track = 11;
​
            public const int SwitchCompat_trackTint = 12;
​
            public const int SwitchCompat_trackTintMode = 13;
​
            public static int[] TabItem;
​
            public const int TabItem_android_icon = 0;
​
            public const int TabItem_android_layout = 1;
​
            public const int TabItem_android_text = 2;
​
            public static int[] TabLayout;
​
            public const int TabLayout_tabBackground = 0;
​
            public const int TabLayout_tabContentStart = 1;
​
            public const int TabLayout_tabGravity = 2;
​
            public const int TabLayout_tabIndicatorColor = 3;
​
            public const int TabLayout_tabIndicatorHeight = 4;
​
            public const int TabLayout_tabMaxWidth = 5;
​
            public const int TabLayout_tabMinWidth = 6;
​
            public const int TabLayout_tabMode = 7;
​
            public const int TabLayout_tabPadding = 8;
​
            public const int TabLayout_tabPaddingBottom = 9;
​
            public const int TabLayout_tabPaddingEnd = 10;
​
            public const int TabLayout_tabPaddingStart = 11;
​
            public const int TabLayout_tabPaddingTop = 12;
​
            public const int TabLayout_tabSelectedTextColor = 13;
​
            public const int TabLayout_tabTextAppearance = 14;
​
            public const int TabLayout_tabTextColor = 15;
​
            public static int[] TextAppearance;
​
            public const int TextAppearance_android_fontFamily = 10;
​
            public const int TextAppearance_android_shadowColor = 6;
​
            public const int TextAppearance_android_shadowDx = 7;
​
            public const int TextAppearance_android_shadowDy = 8;
​
            public const int TextAppearance_android_shadowRadius = 9;
​
            public const int TextAppearance_android_textColor = 3;
​
            public const int TextAppearance_android_textColorHint = 4;
​
            public const int TextAppearance_android_textColorLink = 5;
​
            public const int TextAppearance_android_textSize = 0;
​
            public const int TextAppearance_android_textStyle = 2;
​
            public const int TextAppearance_android_typeface = 1;
​
            public const int TextAppearance_fontFamily = 11;
​
            public const int TextAppearance_textAllCaps = 12;
​
            public static int[] TextInputLayout;
​
            public const int TextInputLayout_android_hint = 1;
​
            public const int TextInputLayout_android_textColorHint = 0;
​
            public const int TextInputLayout_counterEnabled = 2;
​
            public const int TextInputLayout_counterMaxLength = 3;
​
            public const int TextInputLayout_counterOverflowTextAppearance = 4;
​
            public const int TextInputLayout_counterTextAppearance = 5;
​
            public const int TextInputLayout_errorEnabled = 6;
​
            public const int TextInputLayout_errorTextAppearance = 7;
​
            public const int TextInputLayout_hintAnimationEnabled = 8;
​
            public const int TextInputLayout_hintEnabled = 9;
​
            public const int TextInputLayout_hintTextAppearance = 10;
​
            public const int TextInputLayout_passwordToggleContentDescription = 11;
​
            public const int TextInputLayout_passwordToggleDrawable = 12;
​
            public const int TextInputLayout_passwordToggleEnabled = 13;
​
            public const int TextInputLayout_passwordToggleTint = 14;
​
            public const int TextInputLayout_passwordToggleTintMode = 15;
​
            public static int[] Toolbar;
​
            public const int Toolbar_android_gravity = 0;
​
            public const int Toolbar_android_minHeight = 1;
​
            public const int Toolbar_buttonGravity = 2;
​
            public const int Toolbar_collapseContentDescription = 3;
​
            public const int Toolbar_collapseIcon = 4;
​
            public const int Toolbar_contentInsetEnd = 5;
​
            public const int Toolbar_contentInsetEndWithActions = 6;
​
            public const int Toolbar_contentInsetLeft = 7;
​
            public const int Toolbar_contentInsetRight = 8;
​
            public const int Toolbar_contentInsetStart = 9;
​
            public const int Toolbar_contentInsetStartWithNavigation = 10;
​
            public const int Toolbar_logo = 11;
​
            public const int Toolbar_logoDescription = 12;
​
            public const int Toolbar_maxButtonHeight = 13;
​
            public const int Toolbar_navigationContentDescription = 14;
​
            public const int Toolbar_navigationIcon = 15;
​
            public const int Toolbar_popupTheme = 16;
​
            public const int Toolbar_subtitle = 17;
​
            public const int Toolbar_subtitleTextAppearance = 18;
​
            public const int Toolbar_subtitleTextColor = 19;
​
            public const int Toolbar_title = 20;
​
            public const int Toolbar_titleMargin = 21;
​
            public const int Toolbar_titleMarginBottom = 22;
​
            public const int Toolbar_titleMarginEnd = 23;
​
            public const int Toolbar_titleMargins = 26;
​
            public const int Toolbar_titleMarginStart = 24;
​
            public const int Toolbar_titleMarginTop = 25;
​
            public const int Toolbar_titleTextAppearance = 27;
​
            public const int Toolbar_titleTextColor = 28;
​
            public static int[] View;
​
            public static int[] ViewBackgroundHelper;
​
            public const int ViewBackgroundHelper_android_background = 0;
​
            public const int ViewBackgroundHelper_backgroundTint = 1;
​
            public const int ViewBackgroundHelper_backgroundTintMode = 2;
​
            public static int[] ViewStubCompat;
​
            public const int ViewStubCompat_android_id = 0;
​
            public const int ViewStubCompat_android_inflatedId = 2;
​
            public const int ViewStubCompat_android_layout = 1;
​
            public const int View_android_focusable = 1;
​
            public const int View_android_theme = 0;
​
            public const int View_paddingEnd = 2;
​
            public const int View_paddingStart = 3;
​
            public const int View_theme = 4;
​
            static Styleable()
            {
                ActionBar = new int[29]
                {
                    2130903089,
                    2130903090,
                    2130903091,
                    2130903136,
                    2130903137,
                    2130903138,
                    2130903139,
                    2130903140,
                    2130903141,
                    2130903148,
                    2130903152,
                    2130903153,
                    2130903164,
                    2130903196,
                    2130903197,
                    2130903201,
                    2130903202,
                    2130903203,
                    2130903208,
                    2130903214,
                    2130903241,
                    2130903250,
                    2130903266,
                    2130903270,
                    2130903271,
                    2130903307,
                    2130903310,
                    2130903354,
                    2130903364
                };
                ActionBarLayout = new int[1]
                {
                    16842931
                };
                ActionMenuItemView = new int[1]
                {
                    16843071
                };
                ActionMenuView = new int[1]
                {
                    -1
                };
                ActionMode = new int[6]
                {
                    2130903089,
                    2130903090,
                    2130903118,
                    2130903196,
                    2130903310,
                    2130903364
                };
                ActivityChooserView = new int[2]
                {
                    2130903167,
                    2130903209
                };
                AlertDialog = new int[7]
                {
                    16842994,
                    2130903110,
                    2130903232,
                    2130903233,
                    2130903247,
                    2130903291,
                    2130903292
                };
                AppBarLayout = new int[5]
                {
                    16842964,
                    16843919,
                    16844096,
                    2130903164,
                    2130903168
                };
                AppBarLayoutStates = new int[2]
                {
                    2130903301,
                    2130903302
                };
                AppBarLayout_Layout = new int[2]
                {
                    2130903228,
                    2130903229
                };
                AppCompatImageView = new int[4]
                {
                    16843033,
                    2130903298,
                    2130903352,
                    2130903353
                };
                AppCompatSeekBar = new int[4]
                {
                    16843074,
                    2130903349,
                    2130903350,
                    2130903351
                };
                AppCompatTextHelper = new int[7]
                {
                    16842804,
                    16843117,
                    16843118,
                    16843119,
                    16843120,
                    16843666,
                    16843667
                };
                AppCompatTextView = new int[8]
                {
                    16842804,
                    2130903084,
                    2130903085,
                    2130903086,
                    2130903087,
                    2130903088,
                    2130903183,
                    2130903332
                };
                AppCompatTheme = new int[119]
                {
                    16842839,
                    16842926,
                    2130903040,
                    2130903041,
                    2130903042,
                    2130903043,
                    2130903044,
                    2130903045,
                    2130903046,
                    2130903047,
                    2130903048,
                    2130903049,
                    2130903050,
                    2130903051,
                    2130903052,
                    2130903054,
                    2130903055,
                    2130903056,
                    2130903057,
                    2130903058,
                    2130903059,
                    2130903060,
                    2130903061,
                    2130903062,
                    2130903063,
                    2130903064,
                    2130903065,
                    2130903066,
                    2130903067,
                    2130903068,
                    2130903069,
                    2130903070,
                    2130903073,
                    2130903074,
                    2130903075,
                    2130903076,
                    2130903077,
                    2130903083,
                    2130903101,
                    2130903104,
                    2130903105,
                    2130903106,
                    2130903107,
                    2130903108,
                    2130903111,
                    2130903112,
                    2130903115,
                    2130903116,
                    2130903124,
                    2130903125,
                    2130903126,
                    2130903127,
                    2130903128,
                    2130903129,
                    2130903130,
                    2130903131,
                    2130903132,
                    2130903133,
                    2130903143,
                    2130903150,
                    2130903151,
                    2130903154,
                    2130903156,
                    2130903159,
                    2130903160,
                    2130903161,
                    2130903162,
                    2130903163,
                    2130903201,
                    2130903207,
                    2130903230,
                    2130903231,
                    2130903234,
                    2130903235,
                    2130903236,
                    2130903237,
                    2130903238,
                    2130903239,
                    2130903240,
                    2130903257,
                    2130903258,
                    2130903259,
                    2130903265,
                    2130903267,
                    2130903274,
                    2130903275,
                    2130903276,
                    2130903277,
                    2130903284,
                    2130903285,
                    2130903286,
                    2130903287,
                    2130903295,
                    2130903296,
                    2130903314,
                    2130903333,
                    2130903334,
                    2130903335,
                    2130903336,
                    2130903337,
                    2130903338,
                    2130903339,
                    2130903340,
                    2130903341,
                    2130903343,
                    2130903366,
                    2130903367,
                    2130903368,
                    2130903369,
                    2130903376,
                    2130903377,
                    2130903378,
                    2130903379,
                    2130903380,
                    2130903381,
                    2130903382,
                    2130903383,
                    2130903384,
                    2130903385
                };
                BottomNavigationView = new int[5]
                {
                    2130903164,
                    2130903212,
                    2130903213,
                    2130903216,
                    2130903246
                };
                BottomSheetBehavior_Layout = new int[3]
                {
                    2130903096,
                    2130903098,
                    2130903099
                };
                ButtonBarLayout = new int[1]
                {
                    2130903078
                };
                CollapsingToolbarLayout = new int[16]
                {
                    2130903121,
                    2130903122,
                    2130903142,
                    2130903169,
                    2130903170,
                    2130903171,
                    2130903172,
                    2130903173,
                    2130903174,
                    2130903175,
                    2130903280,
                    2130903281,
                    2130903304,
                    2130903354,
                    2130903355,
                    2130903365
                };
                CollapsingToolbarLayout_Layout = new int[2]
                {
                    2130903223,
                    2130903224
                };
                ColorStateListItem = new int[3]
                {
                    16843173,
                    16843551,
                    2130903079
                };
                CompoundButton = new int[3]
                {
                    16843015,
                    2130903113,
                    2130903114
                };
                CoordinatorLayout = new int[2]
                {
                    2130903217,
                    2130903303
                };
                CoordinatorLayout_Layout = new int[7]
                {
                    16842931,
                    2130903220,
                    2130903221,
                    2130903222,
                    2130903225,
                    2130903226,
                    2130903227
                };
                DesignTheme = new int[3]
                {
                    2130903102,
                    2130903103,
                    2130903342
                };
                DrawerArrowToggle = new int[8]
                {
                    2130903081,
                    2130903082,
                    2130903094,
                    2130903123,
                    2130903157,
                    2130903193,
                    2130903294,
                    2130903345
                };
                FloatingActionButton = new int[8]
                {
                    2130903092,
                    2130903093,
                    2130903100,
                    2130903164,
                    2130903176,
                    2130903269,
                    2130903279,
                    2130903374
                };
                FloatingActionButton_Behavior_Layout = new int[1]
                {
                    2130903095
                };
                FontFamily = new int[6]
                {
                    2130903184,
                    2130903185,
                    2130903186,
                    2130903187,
                    2130903188,
                    2130903189
                };
                FontFamilyFont = new int[6]
                {
                    16844082,
                    16844083,
                    16844095,
                    2130903182,
                    2130903190,
                    2130903191
                };
                ForegroundLinearLayout = new int[3]
                {
                    16843017,
                    16843264,
                    2130903192
                };
                LinearLayoutCompat = new int[9]
                {
                    16842927,
                    16842948,
                    16843046,
                    16843047,
                    16843048,
                    2130903153,
                    2130903155,
                    2130903245,
                    2130903289
                };
                LinearLayoutCompat_Layout = new int[4]
                {
                    16842931,
                    16842996,
                    16842997,
                    16843137
                };
                ListPopupWindow = new int[2]
                {
                    16843436,
                    16843437
                };
                MenuGroup = new int[6]
                {
                    16842766,
                    16842960,
                    16843156,
                    16843230,
                    16843231,
                    16843232
                };
                MenuItem = new int[23]
                {
                    16842754,
                    16842766,
                    16842960,
                    16843014,
                    16843156,
                    16843230,
                    16843231,
                    16843233,
                    16843234,
                    16843235,
                    16843236,
                    16843237,
                    16843375,
                    2130903053,
                    2130903071,
                    2130903072,
                    2130903080,
                    2130903135,
                    2130903204,
                    2130903205,
                    2130903251,
                    2130903288,
                    2130903370
                };
                MenuView = new int[9]
                {
                    16842926,
                    16843052,
                    16843053,
                    16843054,
                    16843055,
                    16843056,
                    16843057,
                    2130903268,
                    2130903305
                };
                NavigationView = new int[10]
                {
                    16842964,
                    16842973,
                    16843039,
                    2130903164,
                    2130903195,
                    2130903212,
                    2130903213,
                    2130903215,
                    2130903216,
                    2130903246
                };
                PopupWindow = new int[3]
                {
                    16843126,
                    16843465,
                    2130903252
                };
                PopupWindowBackgroundState = new int[1]
                {
                    2130903300
                };
                RecycleListView = new int[2]
                {
                    2130903253,
                    2130903256
                };
                RecyclerView = new int[11]
                {
                    16842948,
                    16842993,
                    2130903177,
                    2130903178,
                    2130903179,
                    2130903180,
                    2130903181,
                    2130903219,
                    2130903278,
                    2130903293,
                    2130903299
                };
                ScrimInsetsFrameLayout = new int[1]
                {
                    2130903210
                };
                ScrollingViewBehavior_Layout = new int[1]
                {
                    2130903097
                };
                SearchView = new int[17]
                {
                    16842970,
                    16843039,
                    16843296,
                    16843364,
                    2130903117,
                    2130903134,
                    2130903149,
                    2130903194,
                    2130903206,
                    2130903218,
                    2130903272,
                    2130903273,
                    2130903282,
                    2130903283,
                    2130903306,
                    2130903311,
                    2130903375
                };
                SnackbarLayout = new int[3]
                {
                    16843039,
                    2130903164,
                    2130903243
                };
                Spinner = new int[5]
                {
                    16842930,
                    16843126,
                    16843131,
                    16843362,
                    2130903266
                };
                SwitchCompat = new int[14]
                {
                    16843044,
                    16843045,
                    16843074,
                    2130903290,
                    2130903297,
                    2130903312,
                    2130903313,
                    2130903315,
                    2130903346,
                    2130903347,
                    2130903348,
                    2130903371,
                    2130903372,
                    2130903373
                };
                TabItem = new int[3]
                {
                    16842754,
                    16842994,
                    16843087
                };
                TabLayout = new int[16]
                {
                    2130903316,
                    2130903317,
                    2130903318,
                    2130903319,
                    2130903320,
                    2130903321,
                    2130903322,
                    2130903323,
                    2130903324,
                    2130903325,
                    2130903326,
                    2130903327,
                    2130903328,
                    2130903329,
                    2130903330,
                    2130903331
                };
                TextAppearance = new int[13]
                {
                    16842901,
                    16842902,
                    16842903,
                    16842904,
                    16842906,
                    16842907,
                    16843105,
                    16843106,
                    16843107,
                    16843108,
                    16843692,
                    2130903183,
                    2130903332
                };
                TextInputLayout = new int[16]
                {
                    16842906,
                    16843088,
                    2130903144,
                    2130903145,
                    2130903146,
                    2130903147,
                    2130903165,
                    2130903166,
                    2130903198,
                    2130903199,
                    2130903200,
                    2130903260,
                    2130903261,
                    2130903262,
                    2130903263,
                    2130903264
                };
                Toolbar = new int[29]
                {
                    16842927,
                    16843072,
                    2130903109,
                    2130903119,
                    2130903120,
                    2130903136,
                    2130903137,
                    2130903138,
                    2130903139,
                    2130903140,
                    2130903141,
                    2130903241,
                    2130903242,
                    2130903244,
                    2130903248,
                    2130903249,
                    2130903266,
                    2130903307,
                    2130903308,
                    2130903309,
                    2130903354,
                    2130903356,
                    2130903357,
                    2130903358,
                    2130903359,
                    2130903360,
                    2130903361,
                    2130903362,
                    2130903363
                };
                View = new int[5]
                {
                    16842752,
                    16842970,
                    2130903254,
                    2130903255,
                    2130903344
                };
                ViewBackgroundHelper = new int[3]
                {
                    16842964,
                    2130903092,
                    2130903093
                };
                ViewStubCompat = new int[3]
                {
                    16842960,
                    16842994,
                    16842995
                };
                ResourceIdManager.UpdateIdValues();
            }
​
            private Styleable()
            {
            }
        }
​
        public class Xml
        {
            public const int xamarin_essentials_fileprovider_file_paths = 2131755008;
​
            static Xml()
            {
                ResourceIdManager.UpdateIdValues();
            }
​
            private Xml()
            {
            }
        }
​
        static Resource()
        {
            ResourceIdManager.UpdateIdValues();
        }
​
        public static void UpdateIdValues()
        {
            Attribute.font = 2130903182;
            Attribute.fontProviderAuthority = 2130903184;
            Attribute.fontProviderCerts = 2130903185;
            Attribute.fontProviderFetchStrategy = 2130903186;
            Attribute.fontProviderFetchTimeout = 2130903187;
            Attribute.fontProviderPackage = 2130903188;
            Attribute.fontProviderQuery = 2130903189;
            Attribute.fontStyle = 2130903190;
            Attribute.fontWeight = 2130903191;
            Boolean.abc_action_bar_embed_tabs = 2130968576;
            Color.notification_action_color_filter = 2131034186;
            Color.notification_icon_bg_color = 2131034187;
            Color.ripple_material_light = 2131034198;
            Color.secondary_text_default_material_light = 2131034200;
            Dimension.compat_button_inset_horizontal_material = 2131099722;
            Dimension.compat_button_inset_vertical_material = 2131099723;
            Dimension.compat_button_padding_horizontal_material = 2131099724;
            Dimension.compat_button_padding_vertical_material = 2131099725;
            Dimension.compat_control_corner_material = 2131099726;
            Dimension.notification_action_icon_size = 2131099781;
            Dimension.notification_action_text_size = 2131099782;
            Dimension.notification_big_circle_margin = 2131099783;
            Dimension.notification_content_margin_start = 2131099784;
            Dimension.notification_large_icon_height = 2131099785;
            Dimension.notification_large_icon_width = 2131099786;
            Dimension.notification_main_column_padding_top = 2131099787;
            Dimension.notification_media_narrow_margin = 2131099788;
            Dimension.notification_right_icon_size = 2131099789;
            Dimension.notification_right_side_padding_top = 2131099790;
            Dimension.notification_small_icon_background_padding = 2131099791;
            Dimension.notification_small_icon_size_as_large = 2131099792;
            Dimension.notification_subtext_size = 2131099793;
            Dimension.notification_top_pad = 2131099794;
            Dimension.notification_top_pad_large_text = 2131099795;
            Drawable.notification_action_background = 2131165282;
            Drawable.notification_bg = 2131165283;
            Drawable.notification_bg_low = 2131165284;
            Drawable.notification_bg_low_normal = 2131165285;
            Drawable.notification_bg_low_pressed = 2131165286;
            Drawable.notification_bg_normal = 2131165287;
            Drawable.notification_bg_normal_pressed = 2131165288;
            Drawable.notification_icon_background = 2131165289;
            Drawable.notification_template_icon_bg = 2131165290;
            Drawable.notification_template_icon_low_bg = 2131165291;
            Drawable.notification_tile_bg = 2131165292;
            Drawable.notify_panel_notification_icon_bg = 2131165293;
            Id.action_container = 2131230734;
            Id.action_divider = 2131230736;
            Id.action_image = 2131230737;
            Id.action_text = 2131230744;
            Id.actions = 2131230745;
            Id.async = 2131230751;
            Id.blocking = 2131230754;
            Id.chronometer = 2131230762;
            Id.forever = 2131230791;
            Id.icon = 2131230795;
            Id.icon_group = 2131230796;
            Id.info = 2131230799;
            Id.italic = 2131230800;
            Id.line1 = 2131230804;
            Id.line3 = 2131230805;
            Id.normal = 2131230817;
            Id.notification_background = 2131230818;
            Id.notification_main_column = 2131230819;
            Id.notification_main_column_container = 2131230820;
            Id.right_icon = 2131230830;
            Id.right_side = 2131230831;
            Id.tag_transition_group = 2131230871;
            Id.text = 2131230872;
            Id.text2 = 2131230873;
            Id.time = 2131230880;
            Id.title = 2131230881;
            Integer.status_bar_notification_info_maxnum = 2131296265;
            Layout.notification_action = 2131361834;
            Layout.notification_action_tombstone = 2131361835;
            Layout.notification_template_custom_big = 2131361842;
            Layout.notification_template_icon_group = 2131361843;
            Layout.notification_template_part_chronometer = 2131361847;
            Layout.notification_template_part_time = 2131361848;
            String.status_bar_notification_info_overflow = 2131558440;
            Style.TextAppearance_Compat_Notification = 2131624185;
            Style.TextAppearance_Compat_Notification_Info = 2131624186;
            Style.TextAppearance_Compat_Notification_Line2 = 2131624188;
            Style.TextAppearance_Compat_Notification_Time = 2131624191;
            Style.TextAppearance_Compat_Notification_Title = 2131624193;
            Style.Widget_Compat_NotificationActionContainer = 2131624311;
            Style.Widget_Compat_NotificationActionText = 2131624312;
            Xml.xamarin_essentials_fileprovider_file_paths = 2131755008;
            Styleable.FontFamily = Styleable.FontFamily;
            Styleable.FontFamily_fontProviderAuthority = 0;
            Styleable.FontFamily_fontProviderCerts = 1;
            Styleable.FontFamily_fontProviderFetchStrategy = 2;
            Styleable.FontFamily_fontProviderFetchTimeout = 3;
            Styleable.FontFamily_fontProviderPackage = 4;
            Styleable.FontFamily_fontProviderQuery = 5;
            Styleable.FontFamilyFont = Styleable.FontFamilyFont;
            Styleable.FontFamilyFont_android_font = 0;
            Styleable.FontFamilyFont_android_fontStyle = 2;
            Styleable.FontFamilyFont_android_fontWeight = 1;
            Styleable.FontFamilyFont_font = 3;
            Styleable.FontFamilyFont_fontStyle = 4;
            Styleable.FontFamilyFont_fontWeight = 5;
        }
    }
    internal class Utils
    {
        private static readonly string PasswordHash = "BIGBROTHERCORP";
​
        private static readonly string SaltKey = "MEINSALT";
​
        public static string GenerateIV()
        {
            return Guid.NewGuid().ToString().Substring(0, 16);
        }
​
        public static byte[] ReadAsset(string assetName, AssetManager assetManager)
        {
            Stream stream = assetManager.Open(assetName);
            byte[] array = new byte[32];
            stream.Read(array, 0, 32);
            return array;
        }
​
        public static byte[] Encrypt(string plainText, string IV)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(plainText);
            byte[] bytes2 = new Rfc2898DeriveBytes(PasswordHash, Encoding.ASCII.GetBytes(SaltKey)).GetBytes(32);
            ICryptoTransform transform = new RijndaelManaged
            {
                Mode = CipherMode.CBC,
                Padding = PaddingMode.Zeros
            }.CreateEncryptor(bytes2, Encoding.ASCII.GetBytes(IV));
            using (MemoryStream memoryStream = new MemoryStream())
            {
                byte[] result;
                using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write))
                {
                    cryptoStream.Write(bytes, 0, bytes.Length);
                    cryptoStream.FlushFinalBlock();
                    result = memoryStream.ToArray();
                    cryptoStream.Close();
                }
                memoryStream.Close();
                return result;
            }
        }
​
        public static string Decrypt(byte[] cipherTextBytes, string IV)
        {
            byte[] bytes = new Rfc2898DeriveBytes(PasswordHash, Encoding.ASCII.GetBytes(SaltKey)).GetBytes(32);
            ICryptoTransform transform = new RijndaelManaged
            {
                Mode = CipherMode.CBC,
                Padding = PaddingMode.None
            }.CreateDecryptor(bytes, Encoding.ASCII.GetBytes(IV));
            MemoryStream memoryStream = new MemoryStream(cipherTextBytes);
            CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read);
            byte[] array = new byte[cipherTextBytes.Length];
            int count = cryptoStream.Read(array, 0, array.Length);
            memoryStream.Close();
            cryptoStream.Close();
            return Encoding.UTF8.GetString(array, 0, count).TrimEnd("\0".ToArray());
        }
    }
}
​
