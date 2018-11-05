�
tG:\Working\Maintenance\VideoPlayControl\VideoPlayControl\VideoPlayControl\VideoPlayControl\Enum\Enum_SDKEventType.cs
	namespace 	
VideoPlayControl
 
{ 
public

 

enum

 
Enum_SDKEventType

 !
{ 
Unrecognized 
, 
	ConnectOK 
, 
ConnectTimeOut 
, 
DisconnectOK 
, 
ConnectAbnormally## 
,## 
UserAccessError(( 
}** 
}++ �
pG:\Working\Maintenance\VideoPlayControl\VideoPlayControl\VideoPlayControl\VideoPlayControl\Enum\Enum_SDKState.cs
	namespace 	
VideoPlayControl
 
{ 
public

 

enum

 


 
{ 
SDK_ReleaseFail 
= 
- 
$num 
, 
SDK_InitFail 
= 
- 
$num 
, 
SDK_Release 
= 
- 
$num 
, 
SDK_Null 
= 
$num 
, 
SDK_Init## 
=## 
$num## 
}%% 
}&& �
yG:\Working\Maintenance\VideoPlayControl\VideoPlayControl\VideoPlayControl\VideoPlayControl\Enum\Enum_SDKStateEventType.cs
	namespace 	
VideoPlayControl
 
{ 
public

 

enum

 "
Enum_SDKStateEventType

 &
{ 
SDKInitStart 
= 
$num 
, 

SDKInitEnd 
= 
$num 
, 
SDKReleaseStart 
= 
$num 
, 

= 
$num 
, 
SDKInitException## 
=## 
$num## 
,## 
SDKReleaseException(( 
=(( 
$num(( 
,((  
SDKConnectException-- 
=-- 
$num-- 
}.. 
}// �
uG:\Working\Maintenance\VideoPlayControl\VideoPlayControl\VideoPlayControl\VideoPlayControl\Enum\Enum_VideoConnType.cs
	namespace 	
VideoPlayControl
 
. 
Enum 
{ 
public

 

enum

 
Enum_VideoConnType

 "
{ 
Auto 
= 
$num
, 
Direct 
= 
$num 
, 
Clound 
= 
$num 
, 
} 
} �

wG:\Working\Maintenance\VideoPlayControl\VideoPlayControl\VideoPlayControl\VideoPlayControl\Enum\Enum_VideoPTZControl.cs
	namespace 	
VideoPlayControl
 
{ 
public

 

enum

  
Enum_VideoPTZControl

 $
{ 

= 
$num 
, 
PTZControl_Down 
= 
$num 
, 
PTZControl_Left 
= 
$num 
, 
PTZControl_Right 
= 
$num 
, 
PTZControl_LeftUp 
= 
$num 
, 
PTZControl_RightUp## 
=## 
$num## 
,## 
PTZControl_LeftDown'' 
='' 
$num'' 
,''   
PTZControl_RightDown++ 
=++ 
$num++  
,++  !
PTZControl_Zoom_Out00 
=00 
$num00 
,00  
PTZControl_Zoom_In55 
=55 
$num55 
,55   
PTZControl_SetPreset:: 
=:: 
$num:: !
,::! "!
PTZControl_GoToPreser?? 
=?? 
$num??  "
,??" # 
PTZControl_DelPresetDD 
=DD 
$numDD !
,DD! "
}EE 
}FF �
zG:\Working\Maintenance\VideoPlayControl\VideoPlayControl\VideoPlayControl\VideoPlayControl\Enum\Enum_VideoPlayEventType.cs
	namespace 	
VideoPlayControl
 
{ 
public

 

enum

 #
Enum_VideoPlayEventType

 '
{ 
InitEnd 
= 
$num 
, 
LoadEnd 
= 
$num 
, 
SetVideoInfo 
= 
$num 
, 
VideoTypeNotExists 
= 
$num 
, 
DeviceNotExist%% 
=%% 
$num%% 
,%% 
VideoPlayException33 
=33 
$num33 
,33  

VideoClose99 
=99 
$num99 
,99 
RequestConn>> 
=>> 
$num>> 
,>> 
ConnSuccessCC 
=CC 
$numCC 
,CC 

ConnFailedHH 
=HH 
$numHH 
,HH 
	VideoPlayMM 
=MM 
$numMM 
,MM 
RequestVideoTimeoutRR 
=RR 
$numRR  
,RR  !

ConnNumMaxWW 
=WW 
$numWW 
,WW %
DeviceStreamTypeException\\ !
=\\" #
$num\\# &
,\\& '
StartVideoRecorddd 
=dd 
$numdd 
,dd 
StopVideoRecordii 
=ii 
$numii 
,ii %
StartVideoRecordExceptionnn !
=nn" #
$numnn$ &
,nn& '$
StopVideoRecordExceptionss  
=ss! "
$numss# %
,ss% &

LoginStart|| 
=|| 
$num|| 
,|| 
LogonIn
�� 
=
�� 
$num
�� 
,
�� 
LoginSuccess
�� 
=
�� 
$num
�� 
,
�� 
DevLoginException
�� 
=
�� 
$num
�� 
,
�� 
UserAccessError
�� 
=
�� 
$num
�� 
,
�� "
VideoDeviceNotOnline
�� 
=
�� 
$num
�� !
,
��! "
NoDeviceAuthority
�� 
=
�� 
$num
�� 
,
�� 
Unidentified
�� 
=
�� 
$num
�� 
,
�� 
}
�� 
}�� �
vG:\Working\Maintenance\VideoPlayControl\VideoPlayControl\VideoPlayControl\VideoPlayControl\Enum\Enum_VideoPlayState.cs
	namespace 	
VideoPlayControl
 
{ 
public

 

enum

 
Enum_VideoPlayState

 #
{ 

= 
$num 
, 

= 
$num 
, 
InPlayState 
= 
$num 
, 

Connecting 
= 
$num 
, 
NotInPlayState## 
=## 
-## 
$num## 
}$$ 
public** 

enum** #
Enum_VideoPlaybackState** '
{++ 
Null// 
=// 
$num//
,// 
Stopped44 
=44 
$num44 
,44 
Paused99 
=99 
$num99 
,99 
Playing>> 
=>> 
$num>> 
}?? 
}@@ �-
kG:\Working\Maintenance\VideoPlayControl\VideoPlayControl\VideoPlayControl\VideoPlayControl\ProgConstants.cs
	namespace 	
VideoPlayControl
 
{ 
public

 

static

 
class

 


 %
{ 
public 
const 
string %
c_strCloundSeeSDKFilePath 5
=6 7
$str8 L
;L M
public 
const 
string '
c_strEzvizSDKOldSDKFilePath 7
=8 9
$str: Z
;Z [
public 
const 
string !
c_strEzvizSDKFilePath 1
=2 3
$str4 P
;P Q
public 
const 
string "
c_strHuaMaiSDKFilePath 2
=3 4
$str5 B
;B C
public## 
const## 
string## #
c_strSKVideoSDKFilePath## 3
=##4 5
$str##6 Q
;##Q R
public(( 
const(( 
string(( $
c_strHikVideoSDKFilePath(( 4
=((5 6
$str((7 R
;((R S
public-- 
const-- 
string-- #
c_strXMVideoSDKFilePath-- 3
=--4 5
$str--6 P
;--P Q
public22 
const22 
string22 (
c_strBlueSkyVideoSDKFilePath22 8
=229 :
$str22; Z
;22Z [
public44 
const44 
string44 )
c_strBlueSkyVideoSDKFilePath144 9
=44: ;
$str44< c
;44c d
public99 
const99 
string99 '
c_strTalkManagerSDKFilePath99 7
=998 9
$str99: Z
;99Z [
publicDD 
constDD 
intDD *
c_intCloundSee_intLocStartPortDD 7
=DD8 9
-DD: ;
$numDD; <
;DD< =
publicII 
staticII 
readonlyII 
stringII %'
ro_strCloundSee_TempDicPathII& A
=IIB C
EnvironmentIID O
.IIO P
CurrentDirectoryIIP `
+IIa b
$strIIc x
;IIx y
publicNN 
staticNN 
readonlyNN 
stringNN %#
strCloundSee_RecDicPathNN& =
=NN> ?
EnvironmentNN@ K
.NNK L
CurrentDirectoryNNL \
+NN] ^
$strNN_ s
;NNs t
publicUU 
staticUU 
readonlyUU 
stringUU %
strIPCWA_RecDicPathUU& 9
=UU: ;
EnvironmentUU< G
.UUG H
CurrentDirectoryUUH X
+UUY Z
$strUU[ k
;UUk l
public\\ 
const\\ 
string\\ '
c_strEzviz_AuthAddr_Default\\ 7
=\\8 9
$str\\: P
;\\P Q
publicaa 
constaa 
stringaa '
c_strEzviz_PlatForm_Defaultaa 7
=aa8 9
$straa: P
;aaP Q
publichh 
consthh 
stringhh $
c_strEzviz_AppID_Defaulthh 4
=hh5 6
$strhh7 Y
;hhY Z
publicnn 
constnn 
stringnn (
c_strEzviz_AppSecret_Defaultnn 8
=nn9 :
$strnn; ]
;nn] ^
publicss 
staticss 
readonlyss 
stringss %
strEzviz_RecDicPathss& 9
=ss: ;
Environmentss< G
.ssG H
CurrentDirectoryssH X
+ssY Z
$strss[ k
;ssk l
publiczz 
constzz 
stringzz '
c_strHuaMaiSDK_LoginInfo_IPzz 7
=zz8 9
$strzz: I
;zzI J
public~~ 
const~~ 
int~~ )
c_strHuaMaiSDK_LoginInfo_Port~~ 6
=~~7 8
$num~~9 ;
;~~; <
public
�� 
const
�� 
string
�� /
!c_strHuaMaiSDK_LoginInfo_PlatType
�� =
=
��> ?
$str
��@ D
;
��D E
public
�� 
const
�� 
string
�� .
 c_strHuaMaiSDK_LoginInfo_HardVer
�� <
=
��= >
$str
��? I
;
��I J
public
�� 
const
�� 
string
�� .
 c_strHuaMaiSDK_LoginInfo_SoftVer
�� <
=
��= >
$str
��? L
;
��L M
public
�� 
const
�� 
UInt32
�� )
c_iHuaMaiSDK_Result_Success
�� 7
=
��8 9
$num
��: ;
;
��; <
public
�� 
readonly
�� 
static
�� 
string
��  &$
strHikVideo_RecDicPath
��' =
=
��> ?
Environment
��@ K
.
��K L
CurrentDirectory
��L \
+
��] ^
$str
��_ r
;
��r s
public
�� 
readonly
�� 
static
�� 
string
�� %#
strXMVideo_RecDicPath
��& ;
=
��< =
Environment
��> I
.
��I J
CurrentDirectory
��J Z
+
��[ \
$str
��] o
;
��o p
public
�� 
readonly
�� 
static
�� 
string
�� %(
strBlueSkyVideo_RecDicPath
��& @
=
��A B
Environment
��C N
.
��N O
CurrentDirectory
��O _
+
��` a
$str
��b y
;
��y z
public
�� 
const
�� 
int
�� '
c_intSKVideoTalkMode_Talk
�� 2
=
��3 4
$num
��5 6
;
��6 7
public
�� 
const
�� 
int
�� *
c_intSKVideoTalkMode_Monitor
�� 5
=
��6 7
$num
��8 9
;
��9 :
public
�� 
const
�� 
int
�� (
c_intSKVideoTalkMode_Shout
�� 3
=
��4 5
$num
��6 7
;
��7 8
}
�� 
}�� �
kG:\Working\Maintenance\VideoPlayControl\VideoPlayControl\VideoPlayControl\VideoPlayControl\ProgParameter.cs
	namespace 	
VideoPlayControl
 
{ 
public

 

class

 


 
{ 
public
static
string
ProgLogAddress
=
$str
;
public 
static 
int (
intCloundSee_intLocStartPort 6
=7 8

.F G*
c_intCloundSee_intLocStartPortG e
;e f
public 
static 
string $
strCloundSee_TempDicPath 5
=6 7

.E F'
ro_strCloundSee_TempDicPathF a
;a b
public 
static 
string 
strEzviz__AuthAddr /
=0 1

.? @'
c_strEzviz_AuthAddr_Default@ [
;[ \
public$$ 
static$$ 
string$$ 
strEzviz__PlatForm$$ /
=$$0 1

.$$? @'
c_strEzviz_PlatForm_Default$$@ [
;$$[ \
public)) 
static)) 
string)) 
strEzviz__AppID)) ,
=))- .

.))< =$
c_strEzviz_AppID_Default))= U
;))U V
public.. 
static.. 
string.. 
strEzviz_AppSecret.. /
=..0 1

...? @(
c_strEzviz_AppSecret_Default..@ \
;..\ ]
public00 
static00 
string00  
strEzviz_AccessToken00 1
=002 3
$str004 v
;00v w
public88 
static88 
UInt1688 #
uintSKVideo_ControlPort88 4
=885 6
$num887 <
;88< =
public== 
static== 
UInt16== !
uintSKVideo_VideoPort== 2
===3 4
$num==5 :
;==: ;
publicBB 
staticBB 
UInt16BB !
uintSKVideo_AudioPortBB 2
=BB3 4
$numBB5 :
;BB: ;
publicFF 
staticFF 
UInt16FF 
uintSKVideo_AVPortFF /
=FF0 1
$numFF2 7
;FF7 8
publicKK 
staticKK 
stringKK 
strSKVideo_ServerIPKK 0
=KK1 2
$strKK3 A
;KKA B
publicPP 
staticPP 
stringPP !
strSKVideo_ClientUGIDPP 2
=PP3 4
$strPP5 <
;PP< =
publicYY 
staticYY 
stringYY (
strHuaMaiLoginInfo_LoginNameYY 9
=YY: ;
$strYY< F
;YYF G
public^^ 
static^^ 
string^^ '
strHuaMaiLoginInfo_LoginPwd^^ 8
=^^9 :
$str^^; C
;^^C D
publiccc 
staticcc 
IntPtrcc 
HuaMai_iServercc +
=cc, -
IntPtrcc. 4
.cc4 5
Zerocc5 9
;cc9 :
publichh 
statichh 
IntPtrhh 
HuaMai_iTreehh )
=hh* +
IntPtrhh, 2
.hh2 3
Zerohh3 7
;hh7 8
publicoo 
staticoo 
stringoo 
strHikStreamVoiceIPoo 0
=oo0 1
$stroo1 :
;oo: ;
publicss 
staticss 
intss '
intHikStreamVoiceServerPortss 5
=ss6 7
$numss8 <
;ss< =
publicww 
staticww 
intww '
intHikStreamVoiceClientPortww 5
=ww6 7
$numww8 <
;ww< =
}yy 
}zz �
uG:\Working\Maintenance\VideoPlayControl\VideoPlayControl\VideoPlayControl\VideoPlayControl\Properties\AssemblyInfo.cs
[ 
assembly 	
:	 


( 
$str +
)+ ,
], -
[		 
assembly		 	
:			 

AssemblyDescription		 
(		 
$str		 !
)		! "
]		" #
[

 
assembly

 	
:

	 
!
AssemblyConfiguration

  
(

  !
$str

! #
)

# $
]

$ %
[ 
assembly 	
:	 

AssemblyCompany 
( 
$str &
)& '
]' (
[ 
assembly 	
:	 

AssemblyProduct 
( 
$str -
)- .
]. /
[
assembly
:

AssemblyCopyright
(
$str
)
]
[ 
assembly 	
:	 

AssemblyTrademark 
( 
$str 
)  
]  !
[ 
assembly 	
:	 

AssemblyCulture 
( 
$str 
) 
] 
[ 
assembly 	
:	 


ComVisible 
( 
false 
) 
] 
[ 
assembly 	
:	 

Guid 
( 
$str 6
)6 7
]7 8
[## 
assembly## 	
:##	 

AssemblyVersion## 
(## 
$str## $
)##$ %
]##% &
[$$ 
assembly$$ 	
:$$	 

AssemblyFileVersion$$ 
($$ 
$str$$ (
)$$( )
]$$) *�"
{G:\Working\Maintenance\VideoPlayControl\VideoPlayControl\VideoPlayControl\VideoPlayControl\Properties\Resources.Designer.cs
	namespace 	
VideoPlayControl
 
. 

Properties %
{& '
[ 
global 
:: 
System
. 
CodeDom 
. 
Compiler $
.$ %"
GeneratedCodeAttribute% ;
(; <
$str< q
,q r
$strs }
)} ~
]~ 
[ 
global 
:: 
System
. 
Diagnostics 
.  (
DebuggerNonUserCodeAttribute  <
(< =
)= >
]> ?
[ 
global 
:: 
System
. 
Runtime 
. 
CompilerServices ,
., -&
CompilerGeneratedAttribute- G
(G H
)H I
]I J
internal 
class
	Resources 
{ 
private 
static 
global 
:: 
System %
.% &
	Resources& /
./ 0
ResourceManager0 ?
resourceMan@ K
;K L
private 
static 
global 
:: 
System %
.% &

.3 4
CultureInfo4 ?
resourceCulture@ O
;O P
[ 	
global	 
:: 
System 
. 
Diagnostics #
.# $
CodeAnalysis$ 0
.0 1$
SuppressMessageAttribute1 I
(I J
$strJ a
,a b
$str	c �
)
� �
]
� �
internal   
	Resources   
(   
)   
{   
}!! 	
[&& 	
global&&	 
::&& 
System&& 
.&& 
ComponentModel&& &
.&&& '$
EditorBrowsableAttribute&&' ?
(&&? @
global&&@ F
::&&F H
System&&H N
.&&N O
ComponentModel&&O ]
.&&] ^ 
EditorBrowsableState&&^ r
.&&r s
Advanced&&s {
)&&{ |
]&&| }
internal'' 
static'' 
global'' 
::''  
System''  &
.''& '
	Resources''' 0
.''0 1
ResourceManager''1 @
ResourceManager''A P
{''Q R
get(( 
{(( 
if)) 
()) 
object)) 
.)) 
ReferenceEquals)) *
())* +
resourceMan))+ 6
,))6 7
null))8 <
)))< =
)))= >
{))? @
global** 
::** 
System** "
.**" #
	Resources**# ,
.**, -
ResourceManager**- <
temp**= A
=**B C
new**D G
global**H N
::**N P
System**P V
.**V W
	Resources**W `
.**` a
ResourceManager**a p
(**p q
$str	**q �
,
**� �
typeof
**� �
(
**� �
	Resources
**� �
)
**� �
.
**� �
Assembly
**� �
)
**� �
;
**� �
resourceMan++ 
=++  !
temp++" &
;++& '
},, 
return-- 
resourceMan-- "
;--" #
}.. 
}// 	
[55 	
global55	 
::55 
System55 
.55 
ComponentModel55 &
.55& '$
EditorBrowsableAttribute55' ?
(55? @
global55@ F
::55F H
System55H N
.55N O
ComponentModel55O ]
.55] ^ 
EditorBrowsableState55^ r
.55r s
Advanced55s {
)55{ |
]55| }
internal66 
static66 
global66 
::66  
System66  &
.66& '

.664 5
CultureInfo665 @
Culture66A H
{66I J
get77 
{77 
return88 
resourceCulture88 &
;88& '
}99 
set:: 
{:: 
resourceCulture;; 
=;;  !
value;;" '
;;;' (
}<< 
}== 	
}>> 
}?? �
iG:\Working\Maintenance\VideoPlayControl\VideoPlayControl\VideoPlayControl\VideoPlayControl\PubDelegate.cs
	namespace 	
VideoPlayControl
 
{ 
public 

delegate 
bool %
VideoPlayCallbackDelegate 2
(2 3
object3 9
sender: @
,@ A"
VideoPlayCallbackValueB X
evValueY `
)` a
;a b
public 

delegate 
bool $
TalkStausChangedDelegate 1
(1 2
object2 8
sender9 ?
,? @
objectA G!
TalkStausChangedValueH ]
)] ^
;^ _
public   

delegate   
bool    
StartTalkingDelegate   -
(  - .
object  . 4
sender  5 ;
,  ; <
object  = C
StartTalkBeginValue  D W
)  W X
;  X Y
}!! ��
fG:\Working\Maintenance\VideoPlayControl\VideoPlayControl\VideoPlayControl\VideoPlayControl\SDKState.cs
	namespace 	
VideoPlayControl
 
{ 
public 

static 
class 
SDKState  
{
public$$ 
delegate$$ 
void$$ "
SDKStateChangeDelegate$$ 3
($$3 4
PublicClassCurrency$$4 G
.$$G H
Enum_VideoType$$H V
sdkType$$W ^
,$$^ _

sdkState$$n v
)$$v w
;$$w x
public)) 
static)) 
event)) "
SDKStateChangeDelegate)) 2
SDKStateChangeEvent))3 F
;))F G
private.. 
static.. 
void.. 
SDKStateChange.. *
(..* +
PublicClassCurrency..+ >
...> ?
Enum_VideoType..? M
sdkType..N U
,..U V

sdkState..e m
)..m n
{// 	
if00 
(00 
SDKStateChangeEvent00 #
!=00$ &
null00' +
)00+ ,
{11 
SDKStateChangeEvent22 #
(22# $
sdkType22$ +
,22+ ,
sdkState22- 5
)225 6
;226 7
}33 
}44 	
public?? 
delegate?? 
void?? !
SDKEventStateDelegate?? 2
(??2 3
PublicClassCurrency??3 F
.??F G
Enum_VideoType??G U
sdkType??V ]
,??] ^"
Enum_SDKStateEventType??_ u
sdkState??v ~
)??~ 
;	?? �
publicDD 
staticDD 
eventDD !
SDKEventStateDelegateDD 1
SDKEventStateEventDD2 D
;DDD E
privateII 
staticII 
voidII 
SDKEventCallBackII ,
(II, -
PublicClassCurrencyII- @
.II@ A
Enum_VideoTypeIIA O
sdkTypeIIP W
,IIW X"
Enum_SDKStateEventTypeIIY o

)II} ~
{JJ 	
ifKK 
(KK 
SDKEventStateEventKK "
!=KK# %
nullKK& *
)KK* +
{LL 
SDKEventStateEventMM "
(MM" #
sdkTypeMM# *
,MM* +

)MM9 :
;MM: ;
}NN 
}OO 	
privateYY 
staticYY 

s_CloundSeeSDKStateYY% 8
=YY9 :

.YYH I
SDK_NullYYI Q
;YYQ R
public]] 
static]] 

CloundSeeSDKState]]$ 5
{^^ 	
get__ 
{__ 
return__ 
s_CloundSeeSDKState__ ,
;__, -
}__. /
set`` 
{aa 
s_CloundSeeSDKStatebb #
=bb$ %
valuebb& +
;bb+ ,
SDKStateChangecc 
(cc 
PublicClassCurrencycc 2
.cc2 3
Enum_VideoTypecc3 A
.ccA B
	CloundSeeccB K
,ccK L
s_CloundSeeSDKStateccM `
)cc` a
;cca b
}dd 
}ee 	
publickk 
statickk 
voidkk 
CloundSee_SDKInitkk ,
(kk, -
intkk- 0
intLocStartPortkk1 @
=kkA B
-kkC D
$numkkD E
,kkE F
stringkkG M
strTempFileDicPathkkN `
=kka b
$strkkc e
)kke f
{ll 	
ifmm 
(mm 
SDKStatemm 
.mm 
CloundSeeSDKStatemm *
!=mm+ -

.mm; <
SDK_Initmm< D
)mmD E
{nn 
SDKEventCallBackoo  
(oo  !
Enum_VideoTypeoo! /
.oo/ 0
	CloundSeeoo0 9
,oo9 :"
Enum_SDKStateEventTypeoo; Q
.ooQ R
SDKInitStartooR ^
)oo^ _
;oo_ `

.qq (
intCloundSee_intLocStartPortqq :
=qq; <
intLocStartPortqq= L
;qqL M
ifrr 
(rr 
stringrr 
.rr 

(rr( )
strTempFileDicPathrr) ;
.rr; <
Trimrr< @
(rr@ A
)rrA B
)rrB C
)rrC D
{ss 

.tt! "$
strCloundSee_TempDicPathtt" :
=tt; <

.ttJ K'
ro_strCloundSee_TempDicPathttK f
;ttf g
}uu 
elsevv 
{ww 

.xx! "$
strCloundSee_TempDicPathxx" :
=xx; <
strTempFileDicPathxx= O
;xxO P
}yy 
if|| 
(|| 
	SDK_JCSDK|| 
.|| 

(||+ ,

.||9 :(
intCloundSee_intLocStartPort||: V
,||V W

.||e f$
strCloundSee_TempDicPath||f ~
)||~ 
)	|| �
{}} 
SDKState~~ 
.~~ 
CloundSeeSDKState~~ .
=~~/ 0

.~~> ?
SDK_Init~~? G
;~~G H
} 
else
�� 
{
�� 
SDKState
�� 
.
�� 
CloundSeeSDKState
�� .
=
��/ 0

��1 >
.
��> ?
SDK_InitFail
��? K
;
��K L
return
�� 
;
�� 
}
�� 
SDKEventCallBack
��  
(
��  !
Enum_VideoType
��! /
.
��/ 0
	CloundSee
��0 9
,
��9 :$
Enum_SDKStateEventType
��; Q
.
��Q R

SDKInitEnd
��R \
)
��\ ]
;
��] ^
}
�� 
}
�� 	
public
�� 
static
�� 
void
�� "
ColundSee_SDKRelease
�� /
(
��/ 0
)
��0 1
{
�� 	
SDKEventCallBack
�� 
(
�� 
Enum_VideoType
�� +
.
��+ ,
	CloundSee
��, 5
,
��5 6$
Enum_SDKStateEventType
��7 M
.
��M N
SDKReleaseStart
��N ]
)
��] ^
;
��^ _
	SDK_JCSDK
�� 
.
�� 
JCSDK_ReleaseSDK
�� &
(
��& '
)
��' (
;
��( )
SDKState
�� 
.
�� 
CloundSeeSDKState
�� &
=
��' (

��) 6
.
��6 7
SDK_Release
��7 B
;
��B C
SDKEventCallBack
�� 
(
�� 
Enum_VideoType
�� +
.
��+ ,
	CloundSee
��, 5
,
��5 6$
Enum_SDKStateEventType
��7 M
.
��M N

��N [
)
��[ \
;
��\ ]
}
�� 	
private
�� 
static
�� 

�� $
s_IPCWASDKState
��% 4
=
��5 6

��7 D
.
��D E
SDK_Null
��E M
;
��M N
public
�� 
static
�� 

�� #

��$ 1
{
�� 	
get
�� 
{
�� 
return
�� 
s_IPCWASDKState
�� (
;
��( )
}
��* +
set
�� 
{
�� 
s_IPCWASDKState
�� 
=
��  !
value
��" '
;
��' (
SDKStateChange
�� 
(
�� !
PublicClassCurrency
�� 2
.
��2 3
Enum_VideoType
��3 A
.
��A B
IPCWA
��B G
,
��G H
s_IPCWASDKState
��I X
)
��X Y
;
��Y Z
}
�� 
}
�� 	
private
�� 
static
�� 

�� $
s_EzvizSDKState
��% 4
=
��5 6

��7 D
.
��D E
SDK_Null
��E M
;
��M N
public
�� 
static
�� 

�� #

��$ 1
{
�� 	
get
�� 
{
�� 
return
�� 
s_EzvizSDKState
�� (
;
��( )
}
��* +
set
�� 
{
�� 
s_EzvizSDKState
�� 
=
��  !
value
��" '
;
��' (
SDKStateChange
�� 
(
�� 
Enum_VideoType
�� -
.
��- .
Ezviz
��. 3
,
��3 4
s_EzvizSDKState
��5 D
)
��D E
;
��E F
}
�� 
}
�� 	
public
�� 
static
�� 
void
�� 
Ezviz_SDKInit_Old
�� ,
(
��, -
)
��- .
{
�� 	
if
�� 
(
�� 

�� 
!=
��  

��! .
.
��. /
SDK_Init
��/ 7
)
��7 8
{
�� 
if
�� 
(
�� 
SDK_EzvizSDK_Old
�� $
.
��$ %
OpenSDK_InitLib
��% 4
(
��4 5

��5 B
.
��B C 
strEzviz__AuthAddr
��C U
,
��U V

��W d
.
��d e 
strEzviz__PlatForm
��e w
,
��w x

.��� �
strEzviz__AppID��� �
)��� �
==��� �
$num��� �
)��� �
{
�� 

�� !
=
��" #

��$ 1
.
��1 2
SDK_Init
��2 :
;
��: ;
}
�� 
else
�� 
{
�� 

�� !
=
��" #

��$ 1
.
��1 2
SDK_InitFail
��2 >
;
��> ?
}
�� 
}
�� 
}
�� 	
public
�� 
static
�� 
void
�� "
Ezviz_SDKRelease_Old
�� /
(
��/ 0
)
��0 1
{
�� 	
SDKEventCallBack
�� 
(
�� 
Enum_VideoType
�� +
.
��+ ,
Ezviz
��, 1
,
��1 2$
Enum_SDKStateEventType
��3 I
.
��I J
SDKReleaseStart
��J Y
)
��Y Z
;
��Z [
SDK_EzvizSDK_Old
�� 
.
�� 
OpenSDK_FiniLib
�� ,
(
��, -
)
��- .
;
��. /
SDKState
�� 
.
�� 

�� "
=
��# $

��% 2
.
��2 3
SDK_Release
��3 >
;
��> ?
SDKEventCallBack
�� 
(
�� 
Enum_VideoType
�� +
.
��+ ,
Ezviz
��, 1
,
��1 2$
Enum_SDKStateEventType
��3 I
.
��I J

��J W
)
��W X
;
��X Y
}
�� 	
public
�� 
static
�� 

�� #

��$ 1
(
��1 2
)
��2 3
{
�� 	
SDKEventCallBack
�� 
(
�� 
Enum_VideoType
�� +
.
��+ ,
Ezviz
��, 1
,
��1 2$
Enum_SDKStateEventType
��3 I
.
��I J
SDKInitStart
��J V
)
��V W
;
��W X
if
�� 
(
�� 

�� 
!=
��  

��! .
.
��. /
SDK_Init
��/ 7
)
��7 8
{
�� 
if
�� 
(
�� 
SDK_EzvizSDK
��  
.
��  !
OpenSDK_InitLib
��! 0
(
��0 1

��1 >
.
��> ? 
strEzviz__AuthAddr
��? Q
,
��Q R

��S `
.
��` a 
strEzviz__PlatForm
��a s
,
��s t

.��� �
strEzviz__AppID��� �
)��� �
==��� �
$num��� �
)��� �
{
�� 

�� !
=
��" #

��$ 1
.
��1 2
SDK_Init
��2 :
;
��: ;
SDK_EzvizSDK
��  
.
��  !
GetAccessToken
��! /
(
��/ 0
)
��0 1
;
��1 2
IntPtr
�� 
intptrToken
�� &
=
��' (
Marshal
��) 0
.
��0 1!
StringToHGlobalAnsi
��1 D
(
��D E

��E R
.
��R S"
strEzviz_AccessToken
��S g
)
��g h
;
��h i
SDK_EzvizSDK
��  
.
��  !$
OpenSDK_SetAccessToken
��! 7
(
��7 8
intptrToken
��8 C
)
��C D
;
��D E
}
�� 
else
�� 
{
�� 

�� !
=
��" #

��$ 1
.
��1 2
SDK_InitFail
��2 >
;
��> ?
}
�� 
}
�� 
SDKEventCallBack
�� 
(
�� 
Enum_VideoType
�� +
.
��+ ,
Ezviz
��, 1
,
��1 2$
Enum_SDKStateEventType
��3 I
.
��I J

SDKInitEnd
��J T
)
��T U
;
��U V
return
�� 

��  
;
��  !
}
�� 	
public
�� 
static
�� 

�� #
Ezviz_SDKRelease
��$ 4
(
��4 5
)
��5 6
{
�� 	
SDKEventCallBack
�� 
(
�� 
Enum_VideoType
�� +
.
��+ ,
Ezviz
��, 1
,
��1 2$
Enum_SDKStateEventType
��3 I
.
��I J
SDKReleaseStart
��J Y
)
��Y Z
;
��Z [
SDK_EzvizSDK
�� 
.
�� 
OpenSDK_FiniLib
�� (
(
��( )
)
��) *
;
��* +

�� 
=
�� 

�� )
.
��) *
SDK_Release
��* 5
;
��5 6
SDKEventCallBack
�� 
(
�� 
Enum_VideoType
�� +
.
��+ ,
Ezviz
��, 1
,
��1 2$
Enum_SDKStateEventType
��3 I
.
��I J

��J W
)
��W X
;
��X Y
return
�� 

��  
;
��  !
}
�� 	
private
�� 
static
�� 

�� $
s_SKVideoSDKState
��% 6
=
��7 8

��9 F
.
��F G
SDK_Null
��G O
;
��O P
public
�� 
static
�� 

�� #
SKVideoSDKState
��$ 3
{
�� 	
get
�� 
{
�� 
return
�� 
s_SKVideoSDKState
�� *
;
��* +
}
��, -
set
�� 
{
�� 
s_SKVideoSDKState
�� !
=
��" #
value
��$ )
;
��) *
SDKStateChange
�� 
(
�� 
Enum_VideoType
�� -
.
��- .
Ezviz
��. 3
,
��3 4
s_SKVideoSDKState
��5 F
)
��F G
;
��G H
}
�� 
}
�� 	
public
�� 
static
�� 

�� #
SKVideoSDKInit
��$ 2
(
��2 3
)
��3 4
{
�� 	
SDKEventCallBack
�� 
(
�� 
Enum_VideoType
�� +
.
��+ ,
SKVideo
��, 3
,
��3 4$
Enum_SDKStateEventType
��5 K
.
��K L
SDKInitStart
��L X
)
��X Y
;
��Y Z
SDK_SKVideoSDK
�� 
.
�� '
p_sdkc_set_server_av_port
�� 4
(
��4 5

��5 B
.
��B C 
uintSKVideo_AVPort
��C U
)
��U V
;
��V W
SDK_SKVideoSDK
�� 
.
��  
p_sdkc_init_client
�� -
(
��- .

��. ;
.
��; <#
strSKVideo_ClientUGID
��< Q
,
��Q R

��S `
.
��` a!
strSKVideo_ServerIP
��a t
,
��t u

.��� �'
uintSKVideo_ControlPort��� �
,��� �

.��� �%
uintSKVideo_VideoPort��� �
,��� �

.��� �%
uintSKVideo_AudioPort��� �
,��� �
$str��� �
)��� �
;��� �
SDK_SKVideoSDK
�� 
.
�� &
p_sdkc_disable_hw_render
�� 3
(
��3 4
)
��4 5
;
��5 6
SKVideoSDKState
�� 
=
�� 

�� +
.
��+ ,
SDK_Init
��, 4
;
��4 5
SDKEventCallBack
�� 
(
�� 
Enum_VideoType
�� +
.
��+ ,
SKVideo
��, 3
,
��3 4$
Enum_SDKStateEventType
��5 K
.
��K L

SDKInitEnd
��L V
)
��V W
;
��W X
return
�� 
SKVideoSDKState
�� "
;
��" #
}
�� 	
public
�� 
static
�� 
int
�� '
GetSKSDKClientOlineStatus
�� 3
(
��3 4
)
��4 5
{
�� 	
return
�� 
SDK_SKVideoSDK
�� !
.
��! "
p_sdkc_get_online
��" 3
(
��3 4
)
��4 5
;
��5 6
}
�� 	
private
�� 
static
�� 

�� $
s_HuaMaiSDKState
��% 5
=
��6 7

��8 E
.
��E F
SDK_Null
��F N
;
��N O
public
�� 
static
�� 

�� #
HuaMaiSDKState
��$ 2
{
�� 	
get
�� 
{
�� 
return
�� 
s_HuaMaiSDKState
�� )
;
��) *
}
��+ ,
set
�� 
{
�� 
s_HuaMaiSDKState
��  
=
��! "
value
��# (
;
��( )
SDKStateChange
�� 
(
�� 
Enum_VideoType
�� -
.
��- .
Ezviz
��. 3
,
��3 4
s_HuaMaiSDKState
��5 E
)
��E F
;
��F G
}
�� 
}
�� 	
public
�� 
static
�� 

�� #
HuaMai_Init
��$ /
(
��/ 0
)
��0 1
{
�� 	
SDKEventCallBack
�� 
(
�� 
Enum_VideoType
�� +
.
��+ ,
Ezviz
��, 1
,
��1 2$
Enum_SDKStateEventType
��3 I
.
��I J
SDKInitStart
��J V
)
��V W
;
��W X
UInt32
�� 
iResult
�� 
=
�� 
$num
�� 
;
�� 
UInt32
�� 
Temp_iResult
�� 
=
��  !
$num
��" #
;
��# $
Temp_iResult
�� 
=
�� 

SDK_HuaMai
�� %
.
��% &
hm_sdk_init
��& 1
(
��1 2
)
��2 3
;
��3 4
if
�� 
(
�� 
Temp_iResult
�� 
!=
�� 

��  -
.
��- .)
c_iHuaMaiSDK_Result_Success
��. I
)
��I J
{
�� 
SDKEventCallBack
��  
(
��  !
Enum_VideoType
��! /
.
��/ 0
Ezviz
��0 5
,
��5 6$
Enum_SDKStateEventType
��7 M
.
��M N
SDKInitException
��N ^
)
��^ _
;
��_ `
HuaMaiSDKState
�� 
=
��  

��! .
.
��. /
SDK_InitFail
��/ ;
;
��; <
return
�� 
HuaMaiSDKState
�� %
;
��% &
}
�� 

SDK_HuaMai
�� 
.
��  
_LOGIN_SERVER_INFO
�� )
	loginInfo
��* 3
=
��4 5
new
��6 9

SDK_HuaMai
��: D
.
��D E 
_LOGIN_SERVER_INFO
��E W
(
��W X
)
��X Y
;
��Y Z
	loginInfo
�� 
.
�� 
ip
�� 
=
�� 

�� (
.
��( ))
c_strHuaMaiSDK_LoginInfo_IP
��) D
;
��D E
	loginInfo
�� 
.
�� 
port
�� 
=
�� 

�� *
.
��* ++
c_strHuaMaiSDK_LoginInfo_Port
��+ H
;
��H I
	loginInfo
�� 
.
�� 
user
�� 
=
�� 

�� *
.
��* +*
strHuaMaiLoginInfo_LoginName
��+ G
;
��G H
	loginInfo
�� 
.
�� 
password
�� 
=
��  

��! .
.
��. /)
strHuaMaiLoginInfo_LoginPwd
��/ J
;
��J K
	loginInfo
�� 
.
�� 
	plat_type
�� 
=
��  !
$str
��" &
;
��& '
	loginInfo
�� 
.
�� 
hard_ver
�� 
=
��  
$str
��! +
;
��+ ,
	loginInfo
�� 
.
�� 
soft_ver
�� 
=
��  
$str
��! .
;
��. /
IntPtr
�� 
iServerInfo
�� 
=
��  
Marshal
��! (
.
��( )
AllocHGlobal
��) 5
(
��5 6
Marshal
��6 =
.
��= >
SizeOf
��> D
(
��D E
typeof
��E K
(
��K L

SDK_HuaMai
��L V
.
��V W 
_LOGIN_SERVER_INFO
��W i
)
��i j
)
��j k
)
��k l
;
��l m
Marshal
�� 
.
�� 
StructureToPtr
�� "
(
��" #
	loginInfo
��# ,
,
��, -
iServerInfo
��. 9
,
��9 :
false
��; @
)
��@ A
;
��A B
Temp_iResult
�� 
=
�� 

SDK_HuaMai
�� %
.
��% &
hm_server_connect
��& 7
(
��7 8
iServerInfo
��8 C
,
��C D
ref
��E H

��I V
.
��V W
HuaMai_iServer
��W e
,
��e f
$num
��g h
,
��h i
$num
��j k
)
��k l
;
��l m
if
�� 
(
�� 
Temp_iResult
�� 
!=
�� 

��  -
.
��- .)
c_iHuaMaiSDK_Result_Success
��. I
)
��I J
{
�� 
SDKEventCallBack
��  
(
��  !
Enum_VideoType
��! /
.
��/ 0
Ezviz
��0 5
,
��5 6$
Enum_SDKStateEventType
��7 M
.
��M N!
SDKConnectException
��N a
)
��a b
;
��b c
HuaMaiSDKState
�� 
=
��  

��! .
.
��. /
SDK_InitFail
��/ ;
;
��; <
return
�� 
HuaMaiSDKState
�� %
;
��% &
}
�� 
Temp_iResult
�� 
=
�� 

SDK_HuaMai
�� %
.
��% &'
hm_server_get_device_list
��& ?
(
��? @

��@ M
.
��M N
HuaMai_iServer
��N \
)
��\ ]
;
��] ^
if
�� 
(
�� 
Temp_iResult
�� 
!=
�� 

��  -
.
��- .)
c_iHuaMaiSDK_Result_Success
��. I
)
��I J
{
�� 
SDKEventCallBack
��  
(
��  !
Enum_VideoType
��! /
.
��/ 0
Ezviz
��0 5
,
��5 6$
Enum_SDKStateEventType
��7 M
.
��M N
SDKInitException
��N ^
)
��^ _
;
��_ `
HuaMaiSDKState
�� 
=
��  

��! .
.
��. /
SDK_InitFail
��/ ;
;
��; <
return
�� 
HuaMaiSDKState
�� %
;
��% &
}
�� 
Temp_iResult
�� 
=
�� 

SDK_HuaMai
�� %
.
��% &)
hm_server_get_transfer_info
��& A
(
��A B

��B O
.
��O P
HuaMai_iServer
��P ^
)
��^ _
;
��_ `
if
�� 
(
�� 
Temp_iResult
�� 
!=
�� 

��  -
.
��- .)
c_iHuaMaiSDK_Result_Success
��. I
)
��I J
{
�� 
SDKEventCallBack
��  
(
��  !
Enum_VideoType
��! /
.
��/ 0
Ezviz
��0 5
,
��5 6$
Enum_SDKStateEventType
��7 M
.
��M N
SDKInitException
��N ^
)
��^ _
;
��_ `
HuaMaiSDKState
�� 
=
��  

��! .
.
��. /
SDK_InitFail
��/ ;
;
��; <
return
�� 
HuaMaiSDKState
�� %
;
��% &
}
�� 
Temp_iResult
�� 
=
�� 

SDK_HuaMai
�� %
.
��% & 
hm_server_get_tree
��& 8
(
��8 9

��9 F
.
��F G
HuaMai_iServer
��G U
,
��U V
ref
��W Z

��[ h
.
��h i
HuaMai_iTree
��i u
)
��u v
;
��v w
if
�� 
(
�� 
Temp_iResult
�� 
!=
�� 

��  -
.
��- .)
c_iHuaMaiSDK_Result_Success
��. I
)
��I J
{
�� 
SDKEventCallBack
��  
(
��  !
Enum_VideoType
��! /
.
��/ 0
Ezviz
��0 5
,
��5 6$
Enum_SDKStateEventType
��7 M
.
��M N
SDKInitException
��N ^
)
��^ _
;
��_ `
HuaMaiSDKState
�� 
=
��  

��! .
.
��. /
SDK_InitFail
��/ ;
;
��; <
return
�� 
HuaMaiSDKState
�� %
;
��% &
}
�� 
HuaMaiSDKState
�� 
=
�� 

�� *
.
��* +
SDK_Init
��+ 3
;
��3 4
SDKEventCallBack
�� 
(
�� 
Enum_VideoType
�� +
.
��+ ,
Ezviz
��, 1
,
��1 2$
Enum_SDKStateEventType
��3 I
.
��I J

SDKInitEnd
��J T
)
��T U
;
��U V
return
�� 
HuaMaiSDKState
�� !
;
��! "
}
�� 	
public
�� 
static
�� 

�� #
Huamai_Release
��$ 2
(
��2 3
)
��3 4
{
�� 	
SDKEventCallBack
�� 
(
�� 
Enum_VideoType
�� +
.
��+ ,
Ezviz
��, 1
,
��1 2$
Enum_SDKStateEventType
��3 I
.
��I J
SDKReleaseStart
��J Y
)
��Y Z
;
��Z [
UInt32
�� 
Temp_iResult
�� 
=
��  !
$num
��" #
;
��# $
Temp_iResult
�� 
=
�� 

SDK_HuaMai
�� %
.
��% &$
hm_server_release_tree
��& <
(
��< =

��= J
.
��J K
HuaMai_iServer
��K Y
)
��Y Z
;
��Z [
Temp_iResult
�� 
=
�� 

SDK_HuaMai
�� %
.
��% &"
hm_server_disconnect
��& :
(
��: ;

��; H
.
��H I
HuaMai_iServer
��I W
)
��W X
;
��X Y
HuaMaiSDKState
�� 
=
�� 

�� *
.
��* +
SDK_Release
��+ 6
;
��6 7
SDKEventCallBack
�� 
(
�� 
Enum_VideoType
�� +
.
��+ ,
Ezviz
��, 1
,
��1 2$
Enum_SDKStateEventType
��3 I
.
��I J

��J W
)
��W X
;
��X Y
return
�� 
HuaMaiSDKState
�� !
;
��! "
}
�� 	
public
�� 
static
�� 

�� #
s_HikDVRSDKState
��$ 4
=
��5 6

��7 D
.
��D E
SDK_Null
��E M
;
��M N
public
�� 
static
�� 

�� #
HikDVRSDKState
��$ 2
{
�� 	
get
�� 
{
�� 
return
�� 
s_HikDVRSDKState
�� )
;
��) *
}
��+ ,
private
�� 
set
�� 
{
�� 
s_HikDVRSDKState
��  
=
��! "
value
��# (
;
��( )
SDKStateChange
�� 
(
�� 
Enum_VideoType
�� -
.
��- .
HikDVR
��. 4
,
��4 5
s_HikDVRSDKState
��6 F
)
��F G
;
��G H
}
�� 
}
�� 	
public
�� 
static
�� 

�� #
HikDVRSDK_Init
��$ 2
(
��2 3
)
��3 4
{
�� 	
HikDVRSDKState
�� 
=
�� 
SDK_HikClientSDK
�� -
.
��- .
NET_DVR_Init
��. :
(
��: ;
)
��; <
?
��= >

��? L
.
��L M
SDK_Init
��M U
:
��V W

��X e
.
��e f
SDK_InitFail
��f r
;
��r s
return
�� 
HikDVRSDKState
�� !
;
��! "
}
�� 	
public
�� 
static
�� 

�� #
HikDVRSDK_Release
��$ 5
(
��5 6
)
��6 7
{
�� 	
HikDVRSDKState
�� 
=
�� 
SDK_HikClientSDK
�� -
.
��- .
NET_DVR_Cleanup
��. =
(
��= >
)
��> ?
?
��@ A

��B O
.
��O P
SDK_Release
��P [
:
��\ ]

��^ k
.
��k l
SDK_ReleaseFail
��l {
;
��{ |
return
�� 
HikDVRSDKState
�� !
;
��! "
}
�� 	
public
�� 
static
�� 

�� #$
s_HikDVRStreamSDKState
��$ :
=
��; <

��= J
.
��J K
SDK_Null
��K S
;
��S T
public
�� 
static
�� 

�� #"
HikDVRStreamSDKState
��$ 8
{
�� 	
get
�� 
{
�� 
return
�� $
s_HikDVRStreamSDKState
�� /
;
��/ 0
}
��1 2
private
�� 
set
�� 
{
�� 
s_HikDVRStreamSDKState
�� &
=
��' (
value
��) .
;
��. /
SDKStateChange
�� 
(
�� 
Enum_VideoType
�� -
.
��- .
HikDVRStream
��. :
,
��: ;$
s_HikDVRStreamSDKState
��< R
)
��R S
;
��S T
}
�� 
}
�� 	
public
�� 
static
�� 

�� #"
HikDVRSDKStream_Init
��$ 8
(
��8 9
)
��9 :
{
�� 	"
HikDVRStreamSDKState
��  
=
��! " 
SDK_TalkManagerSDK
��# 5
.
��5 6
Init_Client
��6 A
(
��A B
)
��B C
?
��D E

��F S
.
��S T
SDK_Init
��T \
:
��] ^

��_ l
.
��l m
SDK_InitFail
��m y
;
��y z
return
�� "
HikDVRStreamSDKState
�� '
;
��' (
}
�� 	
public
�� 
static
�� 

�� #%
HikDVRSDKStream_Release
��$ ;
(
��; <
)
��< =
{
�� 	"
HikDVRStreamSDKState
��  
=
��! " 
SDK_TalkManagerSDK
��# 5
.
��5 6
Dispose_Client
��6 D
(
��D E
)
��E F
?
��G H

��I V
.
��V W
SDK_Release
��W b
:
��c d

��e r
.
��r s
SDK_ReleaseFail��s �
;��� �
return
�� "
HikDVRStreamSDKState
�� '
;
��' (
}
�� 	
public
�� 
static
�� 

�� #
s_XMSDKState
��$ 0
=
��1 2

��3 @
.
��@ A
SDK_Null
��A I
;
��I J
private
�� 
static
�� 
	SDK_XMSDK
��  
.
��  !
fDisConnect
��! ,
disCallback
��- 8
;
��8 9
public
�� 
static
�� 

�� #

XMSDKState
��$ .
{
�� 	
get
�� 
{
�� 
return
�� 
s_XMSDKState
�� %
;
��% &
}
��' (
private
�� 
set
�� 
{
�� 
s_XMSDKState
�� 
=
�� 
value
�� $
;
��$ %
SDKStateChange
�� 
(
�� 
Enum_VideoType
�� -
.
��- .
	XMaiVideo
��. 7
,
��7 8
s_XMSDKState
��9 E
)
��E F
;
��F G
}
�� 
}
�� 	
public
�� 
static
�� 

�� #

XMSDK_Init
��$ .
(
��. /
)
��/ 0
{
�� 	
disCallback
�� 
=
�� 
new
�� 
	SDK_XMSDK
�� '
.
��' (
fDisConnect
��( 3
(
��3 4$
DisConnectBackCallFunc
��4 J
)
��J K
;
��K L

XMSDKState
�� 
=
�� 
	SDK_XMSDK
�� "
.
��" #

��# 0
(
��0 1
disCallback
��1 <
,
��< =
IntPtr
��> D
.
��D E
Zero
��E I
)
��I J
==
��K M
$num
��N O
?
��P Q

��R _
.
��_ `
SDK_Init
��` h
:
��i j

��k x
.
��x y
SDK_InitFail��y �
;��� �
	SDK_XMSDK
�� 
.
�� %
H264_DVR_SetConnectTime
�� -
(
��- .
$num
��. 2
,
��2 3
$num
��4 5
)
��5 6
;
��6 7
return
�� 

XMSDKState
�� 
;
�� 
}
�� 	
private
�� 
static
�� 
void
�� $
DisConnectBackCallFunc
�� 2
(
��2 3
int
��3 6
lLoginID
��7 ?
,
��? @
string
��A G
pchDVRIP
��H P
,
��P Q
int
��R U
nDVRPort
��V ^
,
��^ _
IntPtr
��` f
dwUser
��g m
)
��m n
{
�� 	
int
�� 
Temp_intResult
�� 
=
��  
-
��! "
$num
��" #
;
��# $
foreach
�� 
(
�� 
	VideoInfo
�� 
v
��  
in
��! #
	SDK_XMSDK
��$ -
.
��- .
dicXMVideoList
��. <
.
��< =
Values
��= C
)
��C D
{
�� 
if
�� 
(
�� 
v
�� 
.
�� 
LoginHandle
�� !
==
��" $
lLoginID
��% -
)
��- .
{
�� 
Temp_intResult
�� "
=
��# $
	SDK_XMSDK
��% .
.
��. /
H264_DVR_Logout
��/ >
(
��> ?
v
��? @
.
��@ A
LoginHandle
��A L
)
��L M
;
��M N
v
�� 
.
�� 
LoginHandle
�� !
=
��" #
-
��$ %
$num
��% &
;
��& '
v
�� 
.
�� 

LoginState
��  
=
��! "
$num
��# $
;
��$ %
}
�� 
}
�� 
}
�� 	
public
�� 
static
�� 

�� #

��$ 1
(
��1 2
)
��2 3
{
�� 	

XMSDKState
�� 
=
�� 
	SDK_XMSDK
�� "
.
��" #
H264_DVR_Cleanup
��# 3
(
��3 4
)
��4 5
?
��6 7

��8 E
.
��E F
SDK_Release
��F Q
:
��R S

��T a
.
��a b
SDK_ReleaseFail
��b q
;
��q r
foreach
�� 
(
�� 
	VideoInfo
�� 
v
��  
in
��! #
	SDK_XMSDK
��$ -
.
��- .
dicXMVideoList
��. <
.
��< =
Values
��= C
)
��C D
{
�� 
v
�� 
.
�� 
LoginHandle
�� 
=
�� 
-
��  !
$num
��! "
;
��" #
v
�� 
.
�� 

LoginState
�� 
=
�� 
$num
��  
;
��  !
}
�� 
return
�� 

XMSDKState
�� 
;
�� 
}
�� 	
public
�� 
static
�� 

�� #
s_BlueState
��$ /
=
��0 1

��2 ?
.
��? @
SDK_Null
��@ H
;
��H I
public
�� 
static
�� 

�� #
BlueSkySDKState
��$ 3
{
�� 	
get
�� 
{
�� 
return
�� 
s_BlueState
�� $
;
��$ %
}
��& '
private
�� 
set
�� 
{
�� 
s_BlueState
�� 
=
�� 
value
�� #
;
��# $
SDKStateChange
�� 
(
�� 
Enum_VideoType
�� -
.
��- .
BlueSky
��. 5
,
��5 6
s_BlueState
��7 B
)
��B C
;
��C D
}
�� 
}
�� 	
public
�� 
static
�� 

�� #
BlueSkySDK_Init
��$ 3
(
��3 4
)
��4 5
{
�� 	
BlueSkySDKState
�� 
=
�� 
SDK_BlueSDK
�� )
.
��) *

dvxSdkInit
��* 4
(
��4 5
)
��5 6
==
��7 9
$num
��: ;
?
��< =

��> K
.
��K L
SDK_Init
��L T
:
��U V

��W d
.
��d e
SDK_InitFail
��e q
;
��q r
return
�� 
BlueSkySDKState
�� "
;
��" #
}
�� 	
public
�� 
static
�� 

�� #
BlueSkySDK_UnInit
��$ 5
(
��5 6
)
��6 7
{
�� 	
BlueSkySDKState
�� 
=
�� 
SDK_BlueSDK
�� )
.
��) *
dvxSdkDeInit
��* 6
(
��6 7
)
��7 8
==
��9 ;
$num
��< =
?
��> ?

��@ M
.
��M N
SDK_Release
��N Y
:
��Z [

��\ i
.
��i j
SDK_ReleaseFail
��j y
;
��y z
return
�� 
BlueSkySDKState
�� "
;
��" #
}
�� 	
public
�� 
static
�� 
void
�� 
VideoSDKRelease
�� *
(
��* +
)
��+ ,
{
�� 	"
ColundSee_SDKRelease
��  
(
��  !
)
��! "
;
��" #
Ezviz_SDKRelease
�� 
(
�� 
)
�� 
;
�� 
if
�� 
(
�� 
HuaMaiSDKState
�� 
!=
�� !

��" /
.
��/ 0
SDK_Null
��0 8
||
��9 ;
HuaMaiSDKState
��< J
!=
��K M

��N [
.
��[ \
SDK_Release
��\ g
)
��g h
{
�� 
Huamai_Release
�� 
(
�� 
)
��  
;
��  !
}
�� 
}
�� 	
}
�� 
}�� ��
iG:\Working\Maintenance\VideoPlayControl\VideoPlayControl\VideoPlayControl\VideoPlayControl\SDK_BlueSDK.cs
	namespace 	
VideoPlayControl
 
{ 
public		 

class		 

dvxSdkType		 
{

 
[ 	
StructLayout	 
( 

LayoutKind  
.  !

Sequential! +
,+ ,
CharSet- 4
=5 6
CharSet7 >
.> ?
Ansi? C
,C D
PackE I
=J K
$numL M
)M N
]N O
public 
struct 
SystemVersionInfo '
{ 	
public 
int 
product 
; 
[ 
	MarshalAs
( 

.$ %

ByValArray% /
,/ 0
	SizeConst1 :
=; <
$num= ?
)? @
]@ A
public 
Byte 
[ 
] 
model 
;  
[ 
	MarshalAs
( 

.$ %

ByValArray% /
,/ 0
	SizeConst1 :
=; <
$num= ?
)? @
]@ A
public   
Byte   
[   
]   
version   !
;  ! "
[%% 
	MarshalAs%%
(%% 

.%%$ %

ByValArray%%% /
,%%/ 0
	SizeConst%%1 :
=%%; <
$num%%= ?
)%%? @
]%%@ A
public&& 
Byte&& 
[&& 
]&& 
serial&&  
;&&  !
[++ 
	MarshalAs++
(++ 

.++$ %

ByValArray++% /
,++/ 0
	SizeConst++1 :
=++; <
$num++= >
)++> ?
]++? @
public,, 
Byte,, 
[,, 
],, 
macid,, 
;,,  
}-- 	
;--	 

[22 	
StructLayout22	 
(22 

LayoutKind22  
.22  !

Sequential22! +
,22+ ,
CharSet22- 4
=225 6
CharSet227 >
.22> ?
Ansi22? C
,22C D
Pack22E I
=22J K
$num22L M
)22M N
]22N O
public33 
struct33 
Module33 
{44 	
public88 
Byte88 
module88 
;88 
[99 
	MarshalAs99
(99 

.99$ %

ByValArray99% /
,99/ 0
	SizeConst991 :
=99; <
$num99= >
)99> ?
]99? @
public;; 
Byte;; 
[;; 
];; 
res;; 
;;; 
[@@ 
	MarshalAs@@
(@@ 

.@@$ %

ByValArray@@% /
,@@/ 0
	SizeConst@@1 :
=@@; <
$num@@= >
)@@> ?
]@@? @
publicAA 
ByteAA 
[AA 
]AA 
versionAA !
;AA! "
publicFF 
UInt32FF 
	buildTimeFF #
;FF# $
}GG 	
;GG	 

[LL 	
StructLayoutLL	 
(LL 

LayoutKindLL  
.LL  !

SequentialLL! +
,LL+ ,
CharSetLL- 4
=LL5 6
CharSetLL7 >
.LL> ?
AnsiLL? C
,LLC D
PackLLE I
=LLJ K
$numLLL M
)LLM N
]LLN O
publicMM 
structMM 

{NN 	
publicRR 
CharRR 
countRR 
;RR 
publicTT 
CharTT 
resTT 
;TT 
publicYY 
CharYY 
s_rdverYY 
;YY  
public^^ 
Char^^ 
rdver^^ 
;^^ 
[cc 
	MarshalAscc
(cc 

.cc$ %

ByValArraycc% /
,cc/ 0
	SizeConstcc1 :
=cc; <
$numcc= ?
)cc? @
]cc@ A
publicdd 
Moduledd 
[dd 
]dd 

moduleListdd &
;dd& '
}ee 	
;ee	 

[jj 	
StructLayoutjj	 
(jj 

LayoutKindjj  
.jj  !

Sequentialjj! +
,jj+ ,
CharSetjj- 4
=jj5 6
CharSetjj7 >
.jj> ?
Ansijj? C
,jjC D
PackjjE I
=jjJ K
$numjjL M
)jjM N
]jjN O
publickk 
structkk 

AVDescribekk  
{ll 	
publicpp 
Bytepp 
vcodespp 
;pp 
publicuu 
Byteuu 
acodesuu 
;uu 
publiczz 
Bytezz 
systemszz 
;zz  
public 
Byte 
	SDResolut !
;! "
public
�� 
Byte
�� 
HDResolution
�� $
;
��$ %
public
�� 
Byte
�� 

�� %
;
��% &
public
�� 
Byte
�� 
NSDres02
��  
;
��  !
public
�� 
Byte
�� 

bitstreams
�� "
;
��" #
}
�� 	
;
��	 

[
�� 	
StructLayout
��	 
(
�� 

LayoutKind
��  
.
��  !

Sequential
��! +
,
��+ ,
CharSet
��- 4
=
��5 6
CharSet
��7 >
.
��> ?
Ansi
��? C
,
��C D
Pack
��E I
=
��J K
$num
��L M
)
��M N
]
��N O
public
�� 
struct
�� !
SystemDescribleInfo
�� )
{
�� 	
public
�� 
Char
�� 
platform
��  
;
��  !
[
�� 
	MarshalAs
��
(
�� 

�� $
.
��$ %

ByValArray
��% /
,
��/ 0
	SizeConst
��1 :
=
��; <
$num
��= >
)
��> ?
]
��? @
public
�� 
Byte
�� 
[
�� 
]
�� 
res
�� 
;
�� 
public
�� 
UInt32
�� 
features
�� "
;
��" #
public
�� 
HwSpec
�� 
spec
�� 
;
�� 
public
�� 
SwLimit
�� 
limit
��  
;
��  !
}
�� 	
;
��	 

[
�� 	
StructLayout
��	 
(
�� 

LayoutKind
��  
.
��  !

Sequential
��! +
,
��+ ,
CharSet
��- 4
=
��5 6
CharSet
��7 >
.
��> ?
Ansi
��? C
,
��C D
Pack
��E I
=
��J K
$num
��L M
)
��M N
]
��N O
public
�� 
struct
�� 
HwSpec
�� 
{
�� 	
public
�� 
char
�� 
chips
�� 
;
�� 
public
�� 
char
�� 
videoInputs
�� #
;
��# $
public
�� 
char
�� 
videoOutputs
�� $
;
��$ %
public
�� 
char
�� 
audioInputs
�� #
;
��# $
public
�� 
char
�� 
audioOutputs
�� $
;
��$ %
public
�� 
char
�� 
speechInputs
�� $
;
��$ %
public
�� 
char
�� 

�� %
;
��% &
public
�� 
char
�� 
alarmInputs
�� #
;
��# $
public
�� 
char
�� 
alarmOutputs
�� $
;
��$ %
public
�� 
char
�� 
	netIfaces
�� !
;
��! "
public
�� 
char
�� 

rs232ports
�� "
;
��" #
public
�� 
char
�� 

rs485ports
�� "
;
��" #
public
�� 
char
�� 
usbports
��  
;
��  !
public
�� 
char
�� 
monitors
��  
;
��  !
public
�� 
char
�� 
shelfs
�� 
;
�� 
public
�� 
char
�� 
sensor
�� 
;
�� 
public
�� 
char
�� 
audioIntype
�� #
;
��# $
public
�� 
char
�� 
infrared
��  
;
��  !
public
�� 
char
�� 

�� %
;
��% &
public
�� 
char
�� 
with_iface2
�� #
;
��# $
public
�� 
char
�� 
sdCard
�� 
;
�� 
public
�� 
char
�� 
no_fan_alarm
�� $
;
��$ %
public
�� 
char
�� #
analog_chan_mess_flag
�� -
;
��- .
public
�� 
char
�� 
no_rtc
�� 
;
�� 
public
�� 
char
�� 
netMuiltiPorter
�� '
;
��' (
public
�� 
char
�� $
oldVersionSupportTwoIp
�� .
;
��. /
public
�� 
char
�� 

supportPIR
�� "
;
��" #
public
�� 
char
�� 
supportWifi
�� #
;
��# $
public
�� 
char
�� 
HardwareSupport
�� '
;
��' (
[
�� 
	MarshalAs
��
(
�� 

�� $
.
��$ %

ByValArray
��% /
,
��/ 0
	SizeConst
��1 :
=
��; <
$num
��= >
)
��> ?
]
��? @
public
�� 
Byte
�� 
[
�� 
]
�� 
res
�� 
;
�� 
}
�� 	
;
��	 

[
�� 	
StructLayout
��	 
(
�� 

LayoutKind
��  
.
��  !

Sequential
��! +
,
��+ ,
CharSet
��- 4
=
��5 6
CharSet
��7 >
.
��> ?
Ansi
��? C
,
��C D
Pack
��E I
=
��J K
$num
��L M
)
��M N
]
��N O
public
�� 
struct
�� 
SwLimit
�� 
{
�� 	
public
�� 
UInt16
�� 
sessions
�� "
;
��" #
public
�� 
UInt16
�� 
streams
�� !
;
��! "
public
�� 
UInt16
�� 
netplays
�� "
;
��" #
public
�� 
UInt16
�� 
dumps
�� 
;
��  
public
�� 
UInt16
�� 
speeches
�� "
;
��" #
public
�� 
UInt16
�� 
bandwith
�� "
;
��" #
public
�� 
UInt16
�� 
chanNameOsdNum
�� (
;
��( )
public
�� 
UInt16
�� 
max_frame_rate
�� (
;
��( )
public
�� 
UInt16
�� 
max_vcodec_frm
�� (
;
��( )
public
�� 
UInt16
�� 

swSpecInfo
�� $
;
��$ %
public
�� 
UInt16
�� 
masknum
�� !
;
��! "
public
�� 
Byte
�� #
max_substream_frmrate
�� -
;
��- .
public
�� 
Byte
�� 
ipc_cfg_export
�� &
;
��& '
public
�� 
UInt32
�� 
sampleResol
�� %
;
��% &
public
�� 
Byte
��  
ipc_bnc_signal_cfg
�� *
;
��* +
public
�� 
Byte
�� 
without_AiTunner
�� (
;
��( )
public
�� 
Byte
�� 

ipc_buzzer
�� "
;
��" #
public
�� 
Byte
�� 
intelligent_type
�� (
;
��( )
public
�� 
UInt32
�� 
features
�� "
;
��" #
public
�� 
Byte
�� 
	bsr_Cloud
�� !
;
��! "
public
�� 
Byte
�� 
tele_LookAf_Plat
�� (
;
��( )
[
�� 
	MarshalAs
��
(
�� 

�� $
.
��$ %

ByValArray
��% /
,
��/ 0
	SizeConst
��1 :
=
��; <
$num
��= >
)
��> ?
]
��? @
public
�� 
Byte
�� 
[
�� 
]
�� 
res2
�� 
;
�� 
public
�� 
UInt32
�� 
features_dvx
�� &
;
��& '
[
�� 
	MarshalAs
��
(
�� 

�� $
.
��$ %

ByValArray
��% /
,
��/ 0
	SizeConst
��1 :
=
��; <
$num
��= ?
)
��? @
]
��@ A
public
�� 
Byte
�� 
[
�� 
]
�� 
res3
�� 
;
�� 
}
�� 	
;
��	 

[
�� 	
StructLayout
��	 
(
�� 

LayoutKind
��  
.
��  !

Sequential
��! +
,
��+ ,
CharSet
��- 4
=
��5 6
CharSet
��7 >
.
��> ?
Ansi
��? C
,
��C D
Pack
��E I
=
��J K
$num
��L M
)
��M N
]
��N O
public
�� 
struct
�� 
SystemSerialGet
�� %
{
�� 	
[
�� 
	MarshalAs
��
(
�� 

�� $
.
��$ %

ByValArray
��% /
,
��/ 0
	SizeConst
��1 :
=
��; <
$num
��= ?
)
��? @
]
��@ A
public
�� 
Byte
�� 
[
�� 
]
�� 
serial
��  
;
��  !
[
�� 
	MarshalAs
��
(
�� 

�� $
.
��$ %

ByValArray
��% /
,
��/ 0
	SizeConst
��1 :
=
��; <
$num
��= >
)
��> ?
]
��? @
public
�� 
Byte
�� 
[
�� 
]
�� 
res1
�� 
;
�� 
public
�� 
Char
�� 
version_type
�� $
;
��$ %
public
�� 
Char
�� 
res2
�� 
;
�� 
}
�� 	
;
��	 

[
�� 	
StructLayout
��	 
(
�� 

LayoutKind
��  
.
��  !

Sequential
��! +
,
��+ ,
CharSet
��- 4
=
��5 6
CharSet
��7 >
.
��> ?
Ansi
��? C
,
��C D
Pack
��E I
=
��J K
$num
��L M
)
��M N
]
��N O
public
�� 
struct
�� 
UkeyAuthizeParam
�� &
{
�� 	
public
�� 
UInt32
�� 
authLen
�� !
;
��! "
[
�� 
	MarshalAs
��
(
�� 

�� $
.
��$ %

ByValArray
��% /
,
��/ 0
	SizeConst
��1 :
=
��; <
$num
��= ?
*
��@ A
$num
��B F
)
��F G
]
��G H
public
�� 
Byte
�� 
[
�� 
]
�� 
auth
�� 
;
�� 
}
�� 	
;
��	 

[
�� 	
StructLayout
��	 
(
�� 

LayoutKind
��  
.
��  !

Sequential
��! +
,
��+ ,
CharSet
��- 4
=
��5 6
CharSet
��7 >
.
��> ?
Ansi
��? C
,
��C D
Pack
��E I
=
��J K
$num
��L M
)
��M N
]
��N O
public
�� 
struct
�� 
RealOpenPara
�� "
{
�� 	
public
�� 
Char
�� 
channel
�� 
;
��  
public
�� 
Char
�� 
	subStream
�� !
;
��! "
public
�� 
Char
�� 
	transProc
�� !
;
��! "
public
�� 
Char
�� 
	transMode
�� !
;
��! "
public
�� 
int
�� 
ip
�� 
;
�� 
}
�� 	
;
��	 

[
�� 	
StructLayout
��	 
(
�� 

LayoutKind
��  
.
��  !

Sequential
��! +
,
��+ ,
CharSet
��- 4
=
��5 6
CharSet
��7 >
.
��> ?
Ansi
��? C
,
��C D
Pack
��E I
=
��J K
$num
��L M
)
��M N
]
��N O
public
�� 
struct
�� 
IPCPreViewPara
�� $
{
�� 	
public
�� 
bool
�� 
bImageEhnace
�� $
;
��$ %
[
�� 
	MarshalAs
��
(
�� 

�� $
.
��$ %

ByValArray
��% /
,
��/ 0
	SizeConst
��1 :
=
��; <
$num
��= >
)
��> ?
]
��? @
public
�� 
bool
�� 
[
�� 
]
�� 
bres
�� 
;
�� 
public
�� 
char
�� 
channels
��  
;
��  !
public
�� 
char
�� 
	subStream
�� !
;
��! "
public
�� 
char
�� 
	transProc
�� !
;
��! "
public
�� 
char
�� 
res
�� 
;
�� 
}
�� 	
;
��	 

[
�� 	
StructLayout
��	 
(
�� 

LayoutKind
��  
.
��  !

Sequential
��! +
,
��+ ,
CharSet
��- 4
=
��5 6
CharSet
��7 >
.
��> ?
Ansi
��? C
,
��C D
Pack
��E I
=
��J K
$num
��L M
)
��M N
]
��N O
public
�� 
struct
�� 
SpeechOpenPara
�� $
{
�� 	
public
�� 
int
�� 
channel
�� 
;
�� 
public
�� 
int
�� 
	transType
��  
;
��  !
public
�� 
int
�� 
	transMode
��  
;
��  !
public
�� 
int
�� 
ip
�� 
;
�� 
public
�� 
int
�� 
port
�� 
;
�� 
}
�� 	
;
��	 

public
�� 
enum
�� 
ReturnError
�� 
{
�� 	
DVX_ERR_NOIMPL
�� 
=
�� 
(
�� 
-
�� 
$num
��  
)
��  !
,
��! "
DVX_OK
�� 
=
�� 
(
�� 
$num
�� 
)
�� 
,
�� 
DVX_ERR_BASE
�� 
=
�� 
$num
�� %
,
��% &
DVX_ERR_ASSERT
�� 
=
�� 
(
�� 
DVX_ERR_BASE
�� *
+
��+ ,
$num
��- 0
)
��0 1
,
��1 2"
DVX_ERR_MALLOCMEMORY
��  
=
��! "
(
��# $
DVX_ERR_BASE
��$ 0
+
��1 2
$num
��3 6
)
��6 7
,
��7 8"
DVX_ERR_CREATE_EVENT
��  
=
��! "
(
��# $
DVX_ERR_BASE
��$ 0
+
��1 2
$num
��3 6
)
��6 7
,
��7 8#
DVX_ERR_CREATE_THREAD
�� !
=
��" #
(
��$ %
DVX_ERR_BASE
��% 1
+
��2 3
$num
��4 7
)
��7 8
,
��8 9
DVX_ERR_PARA
�� 
=
�� 
(
�� 
DVX_ERR_BASE
�� (
+
��) *
$num
��+ .
)
��. /
,
��/ 0!
DVX_ERR_SDK_NO_INIT
�� 
=
��  !
(
��" #
DVX_ERR_BASE
��# /
+
��0 1
$num
��2 5
)
��5 6
,
��6 7"
DVX_ERR_DVX_NO_LOGIN
��  
=
��! "
(
��# $
DVX_ERR_BASE
��$ 0
+
��1 2
$num
��3 6
)
��6 7
,
��7 8(
DVX_ERR_DVX_INVALID_HANDLE
�� &
=
��' (
(
��) *
DVX_ERR_BASE
��* 6
+
��7 8
$num
��9 <
)
��< =
,
��= >
DVX_ERR_COMMON
�� 
=
�� 
(
�� 
DVX_ERR_BASE
�� *
+
��+ ,
$num
��- 0
)
��0 1
,
��1 2$
DVX_ERR_ERR_TRANS_OPEN
�� "
=
��# $
(
��% &
DVX_ERR_BASE
��& 2
+
��3 4
$num
��5 9
)
��9 :
,
��: ;$
DVX_ERR_NET_DISCONNECT
�� "
=
��# $
(
��% &
DVX_ERR_BASE
��& 2
+
��3 4
$num
��5 9
)
��9 :
,
��: ;

�� 
=
�� 
(
�� 
DVX_ERR_BASE
�� )
+
��* +
$num
��, 0
)
��0 1
,
��1 2#
DVX_ERR_ALARM_DISABLE
�� !
=
��" #
(
��$ %
DVX_ERR_BASE
��% 1
+
��2 3
$num
��4 9
)
��9 :
,
��: ;"
DVX_ERR_ENABLE_ALARM
��  
=
��! "
(
��# $
DVX_ERR_BASE
��$ 0
+
��1 2
$num
��3 8
)
��8 9
,
��9 :"
DVX_ERR_NOMORE_ALARM
��  
=
��! "
(
��# $
DVX_ERR_BASE
��$ 0
+
��1 2
$num
��3 8
)
��8 9
,
��9 :)
DVX_ERR_REAL_INVALID_HANDLE
�� '
=
��( )
(
��* +
DVX_ERR_BASE
��+ 7
+
��8 9
$num
��: ?
)
��? @
,
��@ A+
DVX_ERR_SPEECH_INVALID_HANDLE
�� )
=
��* +
(
��, -
DVX_ERR_BASE
��- 9
+
��: ;
$num
��< A
)
��A B
,
��B C.
 DVX_ERR_LOCALPLAY_INVALID_HANDLE
�� ,
=
��- .
(
��/ 0
DVX_ERR_BASE
��0 <
+
��= >
$num
��? D
)
��D E
,
��E F-
DVX_ERR_LOCALPLAY_INVALID_FNAME
�� +
=
��, -
(
��. /
DVX_ERR_BASE
��/ ;
+
��< =
$num
��> C
)
��C D
,
��D E'
DVX_ERR_LOCALPLAY_NO_OPEN
�� %
=
��& '
(
��( )
DVX_ERR_BASE
��) 5
+
��6 7
$num
��8 =
)
��= >
,
��> ?!
DVX_ERR_CREATE_FILE
�� 
=
��  !
(
��" #
DVX_ERR_BASE
��# /
+
��0 1
$num
��2 7
)
��7 8
,
��8 9
DVX_ERR_NET
�� 
=
�� 
(
�� 
DVX_ERR_BASE
�� '
+
��( )
$num
��* /
)
��/ 0
,
��0 1

�� 
=
�� 
(
�� 
DVX_ERR_BASE
�� )
+
��* +
$num
��, 1
)
��1 2
,
��2 3
DVX_BSCP_TIMEOUT
�� 
=
�� 
(
��  
DVX_ERR_BASE
��  ,
+
��- .
$num
��/ 4
)
��4 5
,
��5 6
DVX_BSCP_NETERR
�� 
=
�� 
(
�� 
DVX_ERR_BASE
�� +
+
��, -
$num
��. 3
)
��3 4
,
��4 5
DVX_ERR_INIT
�� 
=
�� 
(
�� 
DVX_ERR_BASE
�� (
+
��) *
$num
��+ 0
)
��0 1
,
��1 2
DVX_ERR_NET_INIT
�� 
=
�� 
(
��  
DVX_ERR_BASE
��  ,
+
��- .
$num
��/ 4
)
��4 5
,
��5 6
}
�� 	
;
��	 

}
�� 
public
�� 

class
�� 
SDK_BlueSDK
�� 
{
�� 
[
�� 	
	DllImport
��	 
(
�� 

��  
.
��  !*
c_strBlueSkyVideoSDKFilePath
��! =
,
��= >
CharSet
��? F
=
��G H
CharSet
��I P
.
��P Q
Ansi
��Q U
,
��U V
CallingConvention
��W h
=
��i j
CallingConvention
��k |
.
��| }
Cdecl��} �
)��� �
]��� �
public
�� 
static
�� 
extern
�� 
int
��  

dvxSdkInit
��! +
(
��+ ,
)
��, -
;
��- .
[
�� 	
	DllImport
��	 
(
�� 

��  
.
��  !*
c_strBlueSkyVideoSDKFilePath
��! =
,
��= >
CharSet
��? F
=
��G H
CharSet
��I P
.
��P Q
Ansi
��Q U
,
��U V
CallingConvention
��W h
=
��i j
CallingConvention
��k |
.
��| }
Cdecl��} �
)��� �
]��� �
public
�� 
static
�� 
extern
�� 
int
��  
dvxSdkDeInit
��! -
(
��- .
)
��. /
;
��/ 0
[
�� 	
	DllImport
��	 
(
�� 

��  
.
��  !*
c_strBlueSkyVideoSDKFilePath
��! =
,
��= >
CharSet
��? F
=
��G H
CharSet
��I P
.
��P Q
Ansi
��Q U
,
��U V
CallingConvention
��W h
=
��i j
CallingConvention
��k |
.
��| }
Cdecl��} �
)��� �
]��� �
public
�� 
static
�� 
extern
�� 
int
��  
	dvxCreate
��! *
(
��* +
string
��+ 1
ip
��2 4
,
��4 5
ushort
��6 <
nCmdPort
��= E
,
��E F
ushort
��G M
	nDataPort
��N W
,
��W X
string
��Y _

szUserName
��` j
,
��j k
string
��l r
szPasswd
��s {
,
��{ |
ref��} �
IntPtr��� �
pDvr��� �
,��� �
bool��� �
bReceiveAlerts��� �
=��� �
true��� �
)��� �
;��� �
[
�� 	
	DllImport
��	 
(
�� 

��  
.
��  !*
c_strBlueSkyVideoSDKFilePath
��! =
,
��= >
CharSet
��? F
=
��G H
CharSet
��I P
.
��P Q
Ansi
��Q U
,
��U V
CallingConvention
��W h
=
��i j
CallingConvention
��k |
.
��| }
Cdecl��} �
)��� �
]��� �
public
�� 
static
�� 
extern
�� 
int
��  

��! .
(
��. /
IntPtr
��/ 5
hDvx
��6 :
,
��: ;
ref
��< ?

dvxSdkType
��@ J
.
��J K
SystemVersionInfo
��K \
pVersion
��] e
)
��e f
;
��f g
[
�� 	
	DllImport
��	 
(
�� 

��  
.
��  !*
c_strBlueSkyVideoSDKFilePath
��! =
,
��= >
CharSet
��? F
=
��G H
CharSet
��I P
.
��P Q
Ansi
��Q U
,
��U V
CallingConvention
��W h
=
��i j
CallingConvention
��k |
.
��| }
Cdecl��} �
)��� �
]��� �
public
�� 
static
�� 
extern
�� 
int
��  
dvxSysModulesGet
��! 1
(
��1 2
IntPtr
��2 8
hDvx
��9 =
,
��= >
ref
��? B

dvxSdkType
��C M
.
��M N

��N [
pModules
��\ d
)
��d e
;
��e f
[
�� 	
	DllImport
��	 
(
�� 

��  
.
��  !*
c_strBlueSkyVideoSDKFilePath
��! =
,
��= >
CharSet
��? F
=
��G H
CharSet
��I P
.
��P Q
Ansi
��Q U
,
��U V
CallingConvention
��W h
=
��i j
CallingConvention
��k |
.
��| }
Cdecl��} �
)��� �
]��� �
public
�� 
static
�� 
extern
�� 
int
��  
dvxSysDescribeEx
��! 1
(
��1 2
IntPtr
��2 8
hDvx
��9 =
,
��= >
ref
��? B

dvxSdkType
��C M
.
��M N!
SystemDescribleInfo
��N a
pDes
��b f
)
��f g
;
��g h
[
�� 	
	DllImport
��	 
(
�� 

��  
.
��  !*
c_strBlueSkyVideoSDKFilePath
��! =
,
��= >
CharSet
��? F
=
��G H
CharSet
��I P
.
��P Q
Ansi
��Q U
,
��U V
CallingConvention
��W h
=
��i j
CallingConvention
��k |
.
��| }
Cdecl��} �
)��� �
]��� �
public
�� 
static
�� 
extern
�� 
int
��  
dvxAVDescrible
��! /
(
��/ 0
IntPtr
��0 6
hDvx
��7 ;
,
��; <
ref
��= @

dvxSdkType
��A K
.
��K L

AVDescribe
��L V
pInfo
��W \
)
��\ ]
;
��] ^
[
�� 	
	DllImport
��	 
(
�� 

��  
.
��  !*
c_strBlueSkyVideoSDKFilePath
��! =
,
��= >
CharSet
��? F
=
��G H
CharSet
��I P
.
��P Q
Ansi
��Q U
,
��U V
CallingConvention
��W h
=
��i j
CallingConvention
��k |
.
��| }
Cdecl��} �
)��� �
]��� �
public
�� 
static
�� 
extern
�� 
int
��  
dvxSysSerialGet
��! 0
(
��0 1
IntPtr
��1 7
hDvx
��8 <
,
��< =
ref
��> A

dvxSdkType
��B L
.
��L M
SystemSerialGet
��M \
pSerial
��] d
)
��d e
;
��e f
[
�� 	
	DllImport
��	 
(
�� 

��  
.
��  !*
c_strBlueSkyVideoSDKFilePath
��! =
,
��= >
CharSet
��? F
=
��G H
CharSet
��I P
.
��P Q
Ansi
��Q U
,
��U V
CallingConvention
��W h
=
��i j
CallingConvention
��k |
.
��| }
Cdecl��} �
)��� �
]��� �
public
�� 
static
�� 
extern
�� 
bool
�� !

dvxIsLogin
��" ,
(
��, -
IntPtr
��- 3
hDvx
��4 8
)
��8 9
;
��9 :
[
�� 	
	DllImport
��	 
(
�� 

��  
.
��  !*
c_strBlueSkyVideoSDKFilePath
��! =
,
��= >
CharSet
��? F
=
��G H
CharSet
��I P
.
��P Q
Ansi
��Q U
,
��U V
CallingConvention
��W h
=
��i j
CallingConvention
��k |
.
��| }
Cdecl��} �
)��� �
]��� �
public
�� 
static
�� 
extern
�� 
int
��  
	dvxLogout
��! *
(
��* +
IntPtr
��+ 1
hDvx
��2 6
)
��6 7
;
��7 8
[
�� 	
	DllImport
��	 
(
�� 

��  
.
��  !*
c_strBlueSkyVideoSDKFilePath
��! =
,
��= >
CharSet
��? F
=
��G H
CharSet
��I P
.
��P Q
Ansi
��Q U
,
��U V
CallingConvention
��W h
=
��i j
CallingConvention
��k |
.
��| }
Cdecl��} �
)��� �
]��� �
public
�� 
static
�� 
extern
�� 
int
��  
dvxLogin
��! )
(
��) *
IntPtr
��* 0
hDvx
��1 5
,
��5 6
string
��7 =

szUserName
��> H
,
��H I
string
��J P
szPasswd
��Q Y
,
��Y Z
int
��[ ^
	msTimeout
��_ h
,
��h i
bool
��j n
bReceiveAlerts
��o }
=
��~ 
true��� �
)��� �
;��� �
[
�� 	
	DllImport
��	 
(
�� 

��  
.
��  !*
c_strBlueSkyVideoSDKFilePath
��! =
,
��= >
CharSet
��? F
=
��G H
CharSet
��I P
.
��P Q
Ansi
��Q U
,
��U V
CallingConvention
��W h
=
��i j
CallingConvention
��k |
.
��| }
Cdecl��} �
)��� �
]��� �
public
�� 
static
�� 
extern
�� 
int
��  *
dvxSecuritySessionAuthizeSet
��! =
(
��= >
IntPtr
��> D
hDvx
��E I
,
��I J
ref
��K N

dvxSdkType
��O Y
.
��Y Z
UkeyAuthizeParam
��Z j
pParam
��k q
,
��q r
ref
��s v
int
��w z
pValue��{ �
)��� �
;��� �
[
�� 	
	DllImport
��	 
(
�� 

��  
.
��  !*
c_strBlueSkyVideoSDKFilePath
��! =
,
��= >
CharSet
��? F
=
��G H
CharSet
��I P
.
��P Q
Ansi
��Q U
,
��U V
CallingConvention
��W h
=
��i j
CallingConvention
��k |
.
��| }
Cdecl��} �
)��� �
]��� �
public
�� 
static
�� 
extern
�� 
int
��  
dvxRealOpen
��! ,
(
��, -
IntPtr
��- 3
hDvx
��4 8
,
��8 9
ref
��: =

dvxSdkType
��> H
.
��H I
RealOpenPara
��I U
pPara
��V [
,
��[ \
IntPtr
��] c
hPlayWnd
��d l
,
��l m
IntPtr
��n t

hNotifyWnd
��u 
,�� �
UInt32��� �
msgId��� �
,��� �
ref��� �
IntPtr��� �
phReal��� �
)��� �
;��� �
[
�� 	
	DllImport
��	 
(
�� 

��  
.
��  !*
c_strBlueSkyVideoSDKFilePath
��! =
,
��= >
CharSet
��? F
=
��G H
CharSet
��I P
.
��P Q
Ansi
��Q U
,
��U V
CallingConvention
��W h
=
��i j
CallingConvention
��k |
.
��| }
Cdecl��} �
)��� �
]��� �
public
�� 
static
�� 
extern
�� 
int
��  !
dvxRealImageEnhance
��! 4
(
��4 5
IntPtr
��5 ;
hReal
��< A
,
��A B
bool
��C G

��H U
)
��U V
;
��V W
[
�� 	
	DllImport
��	 
(
�� 

��  
.
��  !*
c_strBlueSkyVideoSDKFilePath
��! =
,
��= >
CharSet
��? F
=
��G H
CharSet
��I P
.
��P Q
Ansi
��Q U
,
��U V
CallingConvention
��W h
=
��i j
CallingConvention
��k |
.
��| }
Cdecl��} �
)��� �
]��� �
public
�� 
static
�� 
extern
�� 
int
��  
dvxRealStart
��! -
(
��- .
IntPtr
��. 4
hReal
��5 :
)
��: ;
;
��; <
[
�� 	
	DllImport
��	 
(
�� 

��  
.
��  !*
c_strBlueSkyVideoSDKFilePath
��! =
,
��= >
CharSet
��? F
=
��G H
CharSet
��I P
.
��P Q
Ansi
��Q U
,
��U V
CallingConvention
��W h
=
��i j
CallingConvention
��k |
.
��| }
Cdecl��} �
)��� �
]��� �
public
�� 
static
�� 
extern
�� 
int
��  
dvxRealStop
��! ,
(
��, -
IntPtr
��- 3
hReal
��4 9
)
��9 :
;
��: ;
[
�� 	
	DllImport
��	 
(
�� 

��  
.
��  !*
c_strBlueSkyVideoSDKFilePath
��! =
,
��= >
CharSet
��? F
=
��G H
CharSet
��I P
.
��P Q
Ansi
��Q U
,
��U V
CallingConvention
��W h
=
��i j
CallingConvention
��k |
.
��| }
Cdecl��} �
)��� �
]��� �
public
�� 
static
�� 
extern
�� 
int
��  
dvxRealClose
��! -
(
��- .
ref
��. 1
IntPtr
��2 8
hReal
��9 >
)
��> ?
;
��? @
[
�� 	
	DllImport
��	 
(
�� 

��  
.
��  !*
c_strBlueSkyVideoSDKFilePath
��! =
,
��= >
CharSet
��? F
=
��G H
CharSet
��I P
.
��P Q
Ansi
��Q U
,
��U V
CallingConvention
��W h
=
��i j
CallingConvention
��k |
.
��| }
Cdecl��} �
)��� �
]��� �
public
�� 
static
�� 
extern
�� 
int
��  
dvxSpeechClose
��! /
(
��/ 0
ref
��0 3
IntPtr
��4 :
hSpeech
��; B
)
��B C
;
��C D
[
�� 	
	DllImport
��	 
(
�� 

��  
.
��  !*
c_strBlueSkyVideoSDKFilePath
��! =
,
��= >
CharSet
��? F
=
��G H
CharSet
��I P
.
��P Q
Ansi
��Q U
,
��U V
CallingConvention
��W h
=
��i j
CallingConvention
��k |
.
��| }
Cdecl��} �
)��� �
]��� �
public
�� 
static
�� 
extern
�� 
void
�� !
dvxPlayShowAiLang
��" 3
(
��3 4
IntPtr
��4 :
hPlay
��; @
,
��@ A
int
��B E
	nLanguage
��F O
)
��O P
;
��P Q
[
�� 	
	DllImport
��	 
(
�� 

��  
.
��  !*
c_strBlueSkyVideoSDKFilePath
��! =
,
��= >
CharSet
��? F
=
��G H
CharSet
��I P
.
��P Q
Ansi
��Q U
,
��U V
CallingConvention
��W h
=
��i j
CallingConvention
��k |
.
��| }
Cdecl��} �
)��� �
]��� �
public
�� 
static
�� 
extern
�� 
int
��  
dvxPlaySound
��! -
(
��- .
IntPtr
��. 4
hPlay
��5 :
)
��: ;
;
��; <
[
�� 	
	DllImport
��	 
(
�� 

��  
.
��  !*
c_strBlueSkyVideoSDKFilePath
��! =
,
��= >
CharSet
��? F
=
��G H
CharSet
��I P
.
��P Q
Ansi
��Q U
,
��U V
CallingConvention
��W h
=
��i j
CallingConvention
��k |
.
��| }
Cdecl��} �
)��� �
]��� �
public
�� 
static
�� 
extern
�� 
int
��  )
dvxSecuritySessionAuthClear
��! <
(
��< =
IntPtr
��= C
hDvx
��D H
)
��H I
;
��I J
[
�� 	
	DllImport
��	 
(
�� 

��  
.
��  !*
c_strBlueSkyVideoSDKFilePath
��! =
,
��= >
CharSet
��? F
=
��G H
CharSet
��I P
.
��P Q
Ansi
��Q U
,
��U V
CallingConvention
��W h
=
��i j
CallingConvention
��k |
.
��| }
Cdecl��} �
)��� �
]��� �
public
�� 
static
�� 
extern
�� 
int
��  

dvxDestory
��! +
(
��+ ,
IntPtr
��, 2
hDvx
��3 7
)
��7 8
;
��8 9
[
�� 	
	DllImport
��	 
(
�� 

��  
.
��  !*
c_strBlueSkyVideoSDKFilePath
��! =
,
��= >
CharSet
��? F
=
��G H
CharSet
��I P
.
��P Q
Ansi
��Q U
,
��U V
CallingConvention
��W h
=
��i j
CallingConvention
��k |
.
��| }
Cdecl��} �
)��� �
]��� �
public
�� 
static
�� 
extern
�� 
int
��  

��! .
(
��. /
IntPtr
��/ 5
hSpeech
��6 =
)
��= >
;
��> ?
[
�� 	
	DllImport
��	 
(
�� 

��  
.
��  !*
c_strBlueSkyVideoSDKFilePath
��! =
,
��= >
CharSet
��? F
=
��G H
CharSet
��I P
.
��P Q
Ansi
��Q U
,
��U V
CallingConvention
��W h
=
��i j
CallingConvention
��k |
.
��| }
Cdecl��} �
)��� �
]��� �
public
�� 
static
�� 
extern
�� 
int
��  
dvxStopSound
��! -
(
��- .
IntPtr
��. 4
hPlay
��5 :
)
��: ;
;
��; <
[
�� 	
	DllImport
��	 
(
�� 

��  
.
��  !*
c_strBlueSkyVideoSDKFilePath
��! =
,
��= >
CharSet
��? F
=
��G H
CharSet
��I P
.
��P Q
Ansi
��Q U
,
��U V
CallingConvention
��W h
=
��i j
CallingConvention
��k |
.
��| }
Cdecl��} �
)��� �
]��� �
public
�� 
static
�� 
extern
�� 
int
��  

��! .
(
��. /
IntPtr
��/ 5
hDvx
��6 :
,
��: ;
ref
��< ?

dvxSdkType
��@ J
.
��J K
SpeechOpenPara
��K Y
pPara
��Z _
,
��_ `
IntPtr
��a g

hNotifyWnd
��h r
,
��r s
UInt32
��t z
msgId��{ �
,��� �
ref��� �
IntPtr��� �
phSpeech��� �
)��� �
;��� �
[
�� 	
	DllImport
��	 
(
�� 

��  
.
��  !*
c_strBlueSkyVideoSDKFilePath
��! =
,
��= >
CharSet
��? F
=
��G H
CharSet
��I P
.
��P Q
Ansi
��Q U
,
��U V
CallingConvention
��W h
=
��i j
CallingConvention
��k |
.
��| }
Cdecl��} �
)��� �
]��� �
public
�� 
static
�� 
extern
�� 
int
��  
dvxSpeechStart
��! /
(
��/ 0
IntPtr
��0 6
hSpeech
��7 >
,
��> ?
bool
��@ D
bNeedEnc
��E M
=
��N O
false
��P U
)
��U V
;
��V W
[
�� 	
	DllImport
��	 
(
�� 

��  
.
��  !*
c_strBlueSkyVideoSDKFilePath
��! =
,
��= >
CharSet
��? F
=
��G H
CharSet
��I P
.
��P Q
Ansi
��Q U
,
��U V
CallingConvention
��W h
=
��i j
CallingConvention
��k |
.
��| }
Cdecl��} �
)��� �
]��� �
public
�� 
static
�� 
extern
�� 
bool
�� !
dvxRealIsSaving
��" 1
(
��1 2
IntPtr
��2 8
hReal
��9 >
)
��> ?
;
��? @
[
�� 	
	DllImport
��	 
(
�� 

��  
.
��  !*
c_strBlueSkyVideoSDKFilePath
��! =
,
��= >
CharSet
��? F
=
��G H
CharSet
��I P
.
��P Q
Ansi
��Q U
,
��U V
CallingConvention
��W h
=
��i j
CallingConvention
��k |
.
��| }
Cdecl��} �
)��� �
]��� �
public
�� 
static
�� 
extern
�� 
int
��   
dvxRealStartSaveAs
��! 3
(
��3 4
IntPtr
��4 :
hReal
��; @
,
��@ A
string
��B H
szFName
��I P
,
��P Q
int
��R U
fileType
��V ^
,
��^ _
int
��` c
openMode
��d l
)
��l m
;
��m n
[
�� 	
	DllImport
��	 
(
�� 

��  
.
��  !*
c_strBlueSkyVideoSDKFilePath
��! =
,
��= >
CharSet
��? F
=
��G H
CharSet
��I P
.
��P Q
Ansi
��Q U
,
��U V
CallingConvention
��W h
=
��i j
CallingConvention
��k |
.
��| }
Cdecl��} �
)��� �
]��� �
public
�� 
static
�� 
extern
�� 
int
��  
dvxRealStopSaveAs
��! 2
(
��2 3
IntPtr
��3 9
hReal
��: ?
)
��? @
;
��@ A
[
�� 	
	DllImport
��	 
(
�� 

��  
.
��  !*
c_strBlueSkyVideoSDKFilePath
��! =
,
��= >
CharSet
��? F
=
��G H
CharSet
��I P
.
��P Q
Ansi
��Q U
,
��U V
CallingConvention
��W h
=
��i j
CallingConvention
��k |
.
��| }
Cdecl��} �
)��� �
]��� �
public
�� 
static
�� 
extern
�� 
int
��  
dvxLocalPlayOpen
��! 1
(
��1 2
string
��2 8
szFName
��9 @
,
��@ A
IntPtr
��B H
hPlayWnd
��I Q
,
��Q R
IntPtr
��S Y

hNotifyWnd
��Z d
,
��d e
UInt32
��f l
msgId
��m r
,
��r s
ref
��t w
IntPtr
��x ~
phPlay�� �
,��� �
bool��� �$
bUeyAreaCompareOrder��� �
=��� �
false��� �
)��� �
;��� �
[
�� 	
	DllImport
��	 
(
�� 

��  
.
��  !*
c_strBlueSkyVideoSDKFilePath
��! =
,
��= >
CharSet
��? F
=
��G H
CharSet
��I P
.
��P Q
Ansi
��Q U
,
��U V
CallingConvention
��W h
=
��i j
CallingConvention
��k |
.
��| }
Cdecl��} �
)��� �
]��� �
public
�� 
static
�� 
extern
�� 
int
��  
dvxLocalPlayStop
��! 1
(
��1 2
IntPtr
��2 8
hPlay
��9 >
)
��> ?
;
��? @
[
�� 	
	DllImport
��	 
(
�� 

��  
.
��  !*
c_strBlueSkyVideoSDKFilePath
��! =
,
��= >
CharSet
��? F
=
��G H
CharSet
��I P
.
��P Q
Ansi
��Q U
,
��U V
CallingConvention
��W h
=
��i j
CallingConvention
��k |
.
��| }
Cdecl��} �
)��� �
]��� �
public
�� 
static
�� 
extern
�� 
int
��  
dvxLocalPlayClose
��! 2
(
��2 3
ref
��3 6
IntPtr
��7 =
hPlay
��> C
)
��C D
;
��D E
[
�� 	
	DllImport
��	 
(
�� 

��  
.
��  !*
c_strBlueSkyVideoSDKFilePath
��! =
,
��= >
CharSet
��? F
=
��G H
CharSet
��I P
.
��P Q
Ansi
��Q U
,
��U V
CallingConvention
��W h
=
��i j
CallingConvention
��k |
.
��| }
Cdecl��} �
)��� �
]��� �
public
�� 
static
�� 
extern
�� 
int
��  %
dvxLocalPlaySetPlayMode
��! 8
(
��8 9
IntPtr
��9 ?
hPlay
��@ E
,
��E F
int
��G J
	nPlayMode
��K T
)
��T U
;
��U V
[
�� 	
	DllImport
��	 
(
�� 

��  
.
��  !*
c_strBlueSkyVideoSDKFilePath
��! =
,
��= >
CharSet
��? F
=
��G H
CharSet
��I P
.
��P Q
Ansi
��Q U
,
��U V
CallingConvention
��W h
=
��i j
CallingConvention
��k |
.
��| }
Cdecl��} �
)��� �
]��� �
public
�� 
static
�� 
extern
�� 
int
��  
dvxLocalPlayPlay
��! 1
(
��1 2
IntPtr
��2 8
hPlay
��9 >
)
��> ?
;
��? @
[
�� 	
	DllImport
��	 
(
�� 

��  
.
��  !*
c_strBlueSkyVideoSDKFilePath
��! =
,
��= >
CharSet
��? F
=
��G H
CharSet
��I P
.
��P Q
Ansi
��Q U
,
��U V
CallingConvention
��W h
=
��i j
CallingConvention
��k |
.
��| }
Cdecl��} �
)��� �
]��� �
public
�� 
static
�� 
extern
�� 
int
��  !
dvxLocalPlayGetTime
��! 4
(
��4 5
IntPtr
��5 ;
hPlay
��< A
,
��A B
ref
��C F
Int64
��G L
msBegin
��M T
,
��T U
ref
��V Y
Int64
��Z _
msEnd
��` e
)
��e f
;
��f g
[
�� 	
	DllImport
��	 
(
�� 

��  
.
��  !*
c_strBlueSkyVideoSDKFilePath
��! =
,
��= >
CharSet
��? F
=
��G H
CharSet
��I P
.
��P Q
Ansi
��Q U
,
��U V
CallingConvention
��W h
=
��i j
CallingConvention
��k |
.
��| }
Cdecl��} �
)��� �
]��� �
public
�� 
static
�� 
extern
�� 
int
��  

��! .
(
��. /
IntPtr
��/ 5
hPlay
��6 ;
,
��; <
ref
��= @
Int64
��A F
ms
��G I
)
��I J
;
��J K
[
�� 	
	DllImport
��	 
(
�� 

��  
.
��  !*
c_strBlueSkyVideoSDKFilePath
��! =
,
��= >
CharSet
��? F
=
��G H
CharSet
��I P
.
��P Q
Ansi
��Q U
,
��U V
CallingConvention
��W h
=
��i j
CallingConvention
��k |
.
��| }
Cdecl��} �
)��� �
]��� �
public
�� 
static
�� 
extern
�� 
int
��  
dvxLocalPlaySeek
��! 1
(
��1 2
IntPtr
��2 8
hPlay
��9 >
,
��> ?
Int64
��@ E
ms
��F H
)
��H I
;
��I J
[
�� 	
	DllImport
��	 
(
�� 

��  
.
��  !*
c_strBlueSkyVideoSDKFilePath
��! =
,
��= >
CharSet
��? F
=
��G H
CharSet
��I P
.
��P Q
Ansi
��Q U
,
��U V
CallingConvention
��W h
=
��i j
CallingConvention
��k |
.
��| }
Cdecl��} �
)��� �
]��� �
public
�� 
static
�� 
extern
�� 
int
��  
dvxLocalPlayPause
��! 2
(
��2 3
IntPtr
��3 9
hPlay
��: ?
)
��? @
;
��@ A
[
�� 	
	DllImport
��	 
(
�� 

��  
.
��  !+
c_strBlueSkyVideoSDKFilePath1
��! >
)
��> ?
]
��? @
public
�� 
static
�� 
extern
�� 
int
��  %
dvxUkeyEt199ReadAllInfo
��! 8
(
��8 9
ref
��9 <
Byte
��= A
[
��A B
]
��B C
pOutBuf
��D K
,
��K L
int
��M P
	outBufLen
��Q Z
,
��Z [
ref
��\ _
int
��` c
pRealLen
��d l
)
��l m
;
��m n
}
�� 
}�� ��
jG:\Working\Maintenance\VideoPlayControl\VideoPlayControl\VideoPlayControl\VideoPlayControl\SDK_EzvizSDK.cs
	namespace		 	
VideoPlayControl		
 
{

 
public 

class 
SDK_EzvizSDK 
{ 
[ 	
	DllImport	 
( 

.  !!
c_strEzvizSDKFilePath! 6
)6 7
]7 8
public 
static 
extern 
int  
OpenSDK_InitLib! 0
(0 1
string1 7
strAuthAddr8 C
,C D
stringE K
strPlatformL W
,W X
stringY _
strAppID` h
)h i
;i j
[ 	
	DllImport	 
( 

.  !!
c_strEzvizSDKFilePath! 6
)6 7
]7 8
public 
static 
extern 
int  
OpenSDK_FiniLib! 0
(0 1
)1 2
;2 3
[(( 	
	DllImport((	 
((( 

.((  !!
c_strEzvizSDKFilePath((! 6
)((6 7
]((7 8
public)) 
static)) 
extern)) 
int))  $
OpenSDK_HttpSendWithWait))! 9
())9 :
string)): @
szUri))A F
,))F G
string))H N

,))\ ]
string))^ d
szBody))e k
,))k l
out))m p
IntPtr))q w
iMessage	))x �
,
))� �
out
))� �
int
))� �
iLength
))� �
)
))� �
;
))� �
[00 	
	DllImport00	 
(00 

.00  !!
c_strEzvizSDKFilePath00! 6
)006 7
]007 8
public11 
static11 
extern11 
int11  "
OpenSDK_SetAccessToken11! 7
(117 8
IntPtr118 >
intptrToken11? J
)11J K
;11K L
[<< 	
	DllImport<<	 
(<< 

.<<  !!
c_strEzvizSDKFilePath<<! 6
)<<6 7
]<<7 8
public== 
static== 
extern== 
int==  #
OpenSDK_Data_GetDevList==! 8
(==8 9
string==9 ?
accessToken==@ K
,==K L
int==M P

iPageStart==Q [
,==[ \
int==] `
	iPageSize==a j
,==j k
out==l o
IntPtr==p v
iMessage==w 
,	== �
out
==� �
int
==� �
iLength
==� �
)
==� �
;
==� �
[@@ 	
	DllImport@@	 
(@@ 

.@@  !!
c_strEzvizSDKFilePath@@! 6
)@@6 7
]@@7 8
publicAA 
staticAA 
externAA 
intAA  &
OpenSDK_Data_GetDeviceInfoAA! ;
(AA; <
IntPtrAA< B

,AAP Q
IntPtrAAR X
szDeviceSerialAAY g
,AAg h
outAAi l
IntPtrAAm s
pBufAAt x
,AAx y
outAAy |
int	AA} �
iLength
AA� �
)
AA� �
;
AA� �
[NN 	
	DllImportNN	 
(NN 

.NN  !!
c_strEzvizSDKFilePathNN! 6
)NN6 7
]NN7 8
publicOO 
staticOO 
externOO 
intOO   
OpenSDK_AllocSessionOO! 5
(OO5 6

MsgHandlerOO6 @
CallBackOOA I
,OOI J
IntPtrOOK Q
UserIDOOR X
,OOX Y
refOOZ ]
IntPtrOO^ d
pSIDOOe i
,OOi j
refOOk n
intOOo r
SIDLthOOs y
,OOy z
boolOO{ 
bSync
OO� �
,
OO� �
uint
OO� �
timeout
OO� �
)
OO� �
;
OO� �
[YY 	
	DllImportYY	 
(YY 

.YY  !!
c_strEzvizSDKFilePathYY! 6
)YY6 7
]YY7 8
publicZZ 
staticZZ 
externZZ 
intZZ  "
OpenSDK_AllocSessionExZZ! 7
(ZZ7 8

MsgHandlerZZ8 B
CallBackZZC K
,ZZK L
IntPtrZZM S
UserIDZZT Z
,ZZZ [
outZZ\ _
IntPtrZZ` f

strSessionZZg q
,ZZq r
outZZs v
intZZw z
	intLength	ZZ{ �
)
ZZ� �
;
ZZ� �
publicee 
delegateee 
voidee 

MsgHandleree '
(ee' (
IntPtree( .
SIDee/ 2
,ee2 3
EzvizMeesageTypeee4 D
MsgTypeeeE L
,eeL M
uinteeN R
ErroreeS X
,eeX Y
stringeeZ `
Infoeea e
,eee f
IntPtreeg m
iUsereen s
)ees t
;eet u
[ll 	
	DllImportll	 
(ll 

.ll  !!
c_strEzvizSDKFilePathll! 6
)ll6 7
]ll7 8
publicmm 
staticmm 
externmm 
intmm  
OpenSDK_FreeSessionmm! 4
(mm4 5
IntPtrmm5 ;
intptrSessionIDmm< K
)mmK L
;mmL M
[tt 	
	DllImporttt	 
(tt 

.tt  !!
c_strEzvizSDKFilePathtt! 6
)tt6 7
]tt7 8
publicuu 
staticuu 
externuu 
intuu  
OpenSDK_FreeSessionuu! 4
(uu4 5
stringuu5 ;
strSessionIDuu< H
)uuH I
;uuI J
[ 	
	DllImport	 
( 

.  !!
c_strEzvizSDKFilePath! 6
)6 7
]7 8
public
�� 
static
�� 
extern
�� 
int
��  #
OpenSDK_SetVideoLevel
��! 6
(
��6 7
IntPtr
��7 =
SID
��> A
,
��A B
int
��C F

intChannel
��G Q
,
��Q R
int
��R U

��V c
)
��c d
;
��d e
[
�� 	
	DllImport
��	 
(
�� 

��  
.
��  !#
c_strEzvizSDKFilePath
��! 6
)
��6 7
]
��7 8
public
�� 
static
�� 
extern
�� 
int
��  %
OpenSDK_SetDataCallBack
��! 8
(
��8 9
IntPtr
��9 ?
SID
��@ C
,
��C D
DataCallBack
��E Q
callback
��R Z
,
��Z [
IntPtr
��\ b

intptrUser
��c m
)
��m n
;
��n o
public
�� 
delegate
�� 
void
�� 
DataCallBack
�� )
(
��) *
DataType
��* 2
enType
��3 9
,
��9 :
IntPtr
��; A
pData
��B G
,
��G H
int
��I L
iLen
��M Q
,
��Q R
IntPtr
��S Y
pUser
��Z _
)
��_ `
;
��` a
[
�� 	
	DllImport
��	 
(
�� 

��  
.
��  !#
c_strEzvizSDKFilePath
��! 6
)
��6 7
]
��7 8
public
�� 
static
�� 
extern
�� 
int
��  #
OpenSDK_StartRealPlay
��! 6
(
��6 7
IntPtr
��7 =
SID
��> A
,
��A B
IntPtr
��C I
PlayWnd
��J Q
,
��Q R
string
��S Y
CameraId
��Z b
,
��b c
string
��d j
Token
��k p
,
��p q
int
��r u

VideoLevel��v �
,��� �
string��� �
SafeKey��� �
,��� �
string��� �
AppKey��� �
,��� �
uint��� �
pNSCBMsg��� �
)��� �
;��� �
[
�� 	
	DllImport
��	 
(
�� 

��  
.
��  !#
c_strEzvizSDKFilePath
��! 6
)
��6 7
]
��7 8
public
�� 
static
�� 
extern
�� 
int
��  '
OpenSDK_StartRealPlay_Old
��! :
(
��: ;
IntPtr
��; A
szSessionId
��B M
,
��M N
IntPtr
��O U
hPlayWnd
��V ^
,
��^ _
string
��` f

szCameraId
��g q
,
��q r
string
��s y

,��� �
int��� �
iVideoLevel��� �
,��� �
string��� �
	szSafeKey��� �
,��� �
string��� �
szAppKey��� �
)��� �
;��� �
[
�� 	
	DllImport
��	 
(
�� 

��  
.
��  !#
c_strEzvizSDKFilePath
��! 6
)
��6 7
]
��7 8
public
�� 
static
�� 
extern
�� 
int
��  "
OpenSDK_StopRealPlay
��! 5
(
��5 6
IntPtr
��6 <
SID
��= @
,
��@ A
uint
��B F
pNSCBMsg
��G O
)
��O P
;
��P Q
[
�� 	
	DllImport
��	 
(
�� 

��  
.
��  !#
c_strEzvizSDKFilePath
��! 6
)
��6 7
]
��7 8
public
�� 
static
�� 
extern
�� 
int
��  %
OpenSDK_StartRealPlayEx
��! 8
(
��8 9
IntPtr
��9 ?
intptrSessionID
��@ O
,
��O P
IntPtr
��Q W
intptrPlayWindows
��X i
,
��i j
IntPtr
��k q
strDevSerial
��r ~
,
��~ 
int��� �

intChannel��� �
,��� �
string��� �

strSafeKey��� �
)��� �
;��� �
[
�� 	
	DllImport
��	 
(
�� 

��  
.
��  !#
c_strEzvizSDKFilePath
��! 6
)
��6 7
]
��7 8
public
�� 
static
�� 
extern
�� 
int
��  $
OpenSDK_StopRealPlayEx
��! 7
(
��7 8
IntPtr
��8 >
intptrSessionID
��? N
)
��N O
;
��O P
[
�� 	
	DllImport
��	 
(
�� 

��  
.
��  !#
c_strEzvizSDKFilePath
��! 6
)
��6 7
]
��7 8
public
�� 
static
�� 
extern
�� 
int
��  
OpenSDK_PTZCtrlEx
��! 2
(
��2 3
IntPtr
��3 9
intptrSessionID
��: I
,
��I J
IntPtr
��K Q
intptrDevSerial
��R a
,
��a b
int
��c f

intChannel
��g q
,
��q r

PTZCommand
��s }
	enCommand��~ �
,��� �
	PTZAction��� �
enAction��� �
,��� �
int��� �
iSpeed��� �
)��� �
;��� �
[
�� 	
	DllImport
��	 
(
�� 

��  
.
��  !#
c_strEzvizSDKFilePath
��! 6
)
��6 7
]
��7 8
public
�� 
static
�� 
extern
�� 
int
��  &
OpenSDK_GetLastErrorCode
��! 9
(
��9 :
)
��: ;
;
��; <
[
�� 	
	DllImport
��	 
(
�� 

��  
.
��  !#
c_strEzvizSDKFilePath
��! 6
)
��6 7
]
��7 8
public
�� 
static
�� 
extern
�� 
IntPtr
�� #&
OpenSDK_GetLastErrorDesc
��$ <
(
��< =
)
��= >
;
��> ?
public
�� 
static
�� 
JsonRequestResult
�� '
GetAccessToken
��( 6
(
��6 7
)
��7 8
{
�� 	
try
�� 
{
�� 
IntPtr
�� 

�� $
;
��$ %
int
�� 
	intLenght
�� 
;
�� 
string
�� 
strUrl
�� 
=
�� 
$str
��  I
;
��I J

�� 
sbParameter
�� )
=
��* +
new
��, /

��0 =
(
��= >
)
��> ?
;
��? @
sbParameter
�� 
.
�� 
AppendFormat
�� (
(
��( )
$str
��) 6
,
��6 7

��8 E
.
��E F
strEzviz__AppID
��F U
)
��U V
;
��V W
sbParameter
�� 
.
�� 
AppendFormat
�� (
(
��( )
$str
��) 9
,
��9 :

��; H
.
��H I 
strEzviz_AppSecret
��I [
)
��[ \
;
��\ ]&
OpenSDK_HttpSendWithWait
�� (
(
��( )
strUrl
��) /
,
��/ 0
sbParameter
��1 <
.
��< =
ToString
��= E
(
��E F
)
��F G
,
��G H
$str
��I K
,
��K L
out
��M P

��Q ^
,
��^ _
out
��` c
	intLenght
��d m
)
��m n
;
��n o
string
�� 
Temp_strResult
�� %
=
��& '
Marshal
��( /
.
��/ 0
PtrToStringAnsi
��0 ?
(
��? @

��@ M
,
��M N
	intLenght
��O X
)
��X Y
;
��Y Z
JObject
�� 
Temp_jobject
�� $
=
��% &
(
��' (
JObject
��( /
)
��/ 0
JsonConvert
��0 ;
.
��; <
DeserializeObject
��< M
(
��M N
Temp_strResult
��N \
)
��\ ]
;
��] ^
JsonRequestResult
�� !

��" /
=
��0 1
(
��2 3
JsonRequestResult
��3 D
)
��D E
Convert
��E L
.
��L M
ToInt32
��M T
(
��T U
Temp_jobject
��U a
[
��a b
$str
��b h
]
��h i
)
��i j
;
��j k
if
�� 
(
�� 

�� !
==
��" $
JsonRequestResult
��% 6
.
��6 7
RequestSuccess
��7 E
)
��E F
{
�� 

�� !
.
��! ""
strEzviz_AccessToken
��" 6
=
��7 8
Convert
��9 @
.
��@ A
ToString
��A I
(
��I J
Temp_jobject
��J V
[
��V W
$str
��W ]
]
��] ^
[
��^ _
$str
��_ l
]
��l m
)
��m n
;
��n o
}
�� 
return
�� 

�� $
;
��$ %
}
�� 
catch
�� 
{
�� 
return
�� 
JsonRequestResult
�� (
.
��( )
RequestException
��) 9
;
��9 :
}
�� 
}
�� 	
public
�� 
static
�� 
int
�� 
GetDevOnlineState
�� +
(
��+ ,
string
��, 2
strDevSerial
��3 ?
,
��? @
int
��@ C

intChannel
��D N
)
��N O
{
�� 	
int
�� 
	intResult
�� 
=
�� 
-
�� 
$num
�� 
;
�� 
string
��  
Temp_strDeviceData
�� %
=
��& '
$str
��( *
;
��* +
try
�� 
{
�� 
IntPtr
�� 
intptrToken
�� "
=
��# $
Marshal
��% ,
.
��, -!
StringToHGlobalAnsi
��- @
(
��@ A

��A N
.
��N O"
strEzviz_AccessToken
��O c
)
��c d
;
��d e
IntPtr
�� 
intptrDevSerial
�� &
=
��' (
Marshal
��) 0
.
��0 1!
StringToHGlobalAnsi
��1 D
(
��D E
strDevSerial
��E Q
)
��Q R
;
��R S
IntPtr
�� 

�� $
=
��% &
IntPtr
��' -
.
��- .
Zero
��. 2
;
��2 3
int
�� 
	intLength
�� 
;
�� 
int
�� 
Temp_intResult
�� "
=
��# $
SDK_EzvizSDK
��% 1
.
��1 2(
OpenSDK_Data_GetDeviceInfo
��2 L
(
��L M
intptrToken
��M X
,
��X Y
intptrDevSerial
��Z i
,
��i j
out
��k n

��o |
,
��| }
out��~ �
	intLength��� �
)��� �
;��� �
if
�� 
(
�� 
Temp_intResult
�� "
!=
��# %
$num
��& '
)
��' (
{
�� 
	intResult
�� 
=
�� 
-
��  !
$num
��! "
;
��" #
}
�� 
else
�� 
{
�� 
string
�� 
	strResult
�� $
=
��% &
Marshal
��' .
.
��. /
PtrToStringAnsi
��/ >
(
��> ?

��? L
)
��L M
;
��M N 
Temp_strDeviceData
�� &
=
��' (
	strResult
��) 2
;
��2 3
if
�� 
(
�� 
!
�� 
string
�� 
.
��  

��  -
(
��- .
	strResult
��. 7
)
��7 8
)
��8 9
{
�� 
JObject
�� 
Temp_jobject
��  ,
=
��- .
(
��/ 0
JObject
��0 7
)
��7 8
JsonConvert
��8 C
.
��C D
DeserializeObject
��D U
(
��U V
	strResult
��V _
)
��_ `
;
��` a
JsonRequestResult
�� )

��* 7
=
��8 9
(
��: ;
JsonRequestResult
��; L
)
��L M
Convert
��M T
.
��T U
ToInt32
��U \
(
��\ ]
Temp_jobject
��] i
[
��i j
$str
��j r
]
��r s
[
��s t
$str
��t z
]
��z {
)
��{ |
;
��| }
if
�� 
(
�� 

�� )
==
��* ,
JsonRequestResult
��- >
.
��> ?
RequestSuccess
��? M
)
��M N
{
�� 
JArray
�� "
jar
��# &
=
��' (
JArray
��) /
.
��/ 0
Parse
��0 5
(
��5 6
Temp_jobject
��6 B
[
��B C
$str
��C K
]
��K L
[
��L M
$str
��M S
]
��S T
.
��T U
ToString
��U ]
(
��] ^
)
��^ _
)
��_ `
;
��` a
foreach
�� #
(
��$ %
JObject
��% ,
jo
��- /
in
��0 2
jar
��3 6
)
��6 7
{
�� 
if
��  "
(
��# $

intChannel
��$ .
.
��. /
ToString
��/ 7
(
��7 8
)
��8 9
==
��: <
jo
��= ?
[
��? @
$str
��@ J
]
��J K
.
��K L
ToString
��L T
(
��T U
)
��U V
)
��V W
{
��  !
	intResult
��$ -
=
��. /
Convert
��0 7
.
��7 8
ToInt32
��8 ?
(
��? @
jo
��@ B
[
��B C
$str
��C K
]
��K L
)
��L M
;
��M N
break
��$ )
;
��) *
}
��  !
}
�� 
}
�� 
else
�� 
if
�� 
(
��  !

��! .
==
��/ 1
JsonRequestResult
��2 C
.
��C D
NoDeviceAuthority
��D U
)
��U V
{
�� 
	intResult
�� %
=
��& '
-
��( )
$num
��) *
;
��* +
}
�� 
}
�� 
}
�� 
}
�� 
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
��  
{
�� 
CommonMethod
�� 
.
�� 
LogWrite
�� %
.
��% &
WritExceptionLog
��& 6
(
��6 7
$str
��7 J
,
��J K
ex
��L N
)
��N O
;
��O P
CommonMethod
�� 
.
�� 
LogWrite
�� %
.
��% &

��& 3
(
��3 4
$str
��4 C
,
��C D 
Temp_strDeviceData
��E W
)
��W X
;
��X Y
	intResult
�� 
=
�� 
-
�� 
$num
�� 
;
�� 
}
�� 
	intResult
�� 
=
�� 
-
�� 
$num
�� 
;
�� 
return
�� 
	intResult
�� 
;
�� 
}
�� 	
public
�� 
enum
�� 
JsonRequestResult
�� %
{
�� 	
RequestSuccess
�� 
=
�� 
$num
��  
,
��  !
RequestException
�� 
=
�� 
-
��  
$num
��  !
,
��! "
ParameterError
�� 
=
�� 
$num
�� "
,
��" #
AppKeyException
�� 
=
�� 
$num
�� #
,
��# $
AppKeyNotExist
�� 
=
�� 
$num
�� "
,
��" #
ParameterMismatch
�� 
=
�� 
$num
��  %
,
��% &
NoDeviceAuthority
�� 
=
�� 
$num
��  %
,
��% & 
InterFaceException
�� 
=
��  
$num
��! &
}
�� 	
public
�� 
enum
�� 
EzvizMeesageType
�� $
{
�� 	 
INS_PLAY_EXCEPTION
�� 
,
��  
INS_PLAY_RECONNECT
�� 
,
�� *
INS_PLAY_RECONNECT_EXCEPTION
�� (
,
��( )
INS_PLAY_START
�� 
,
�� 

�� 
,
�� "
INS_PLAY_ARCHIVE_END
��  
,
��  !!
INS_VOICETALK_START
�� 
,
��   
INS_VOICETALK_STOP
�� 
,
�� %
INS_VOICETALK_EXCEPTION
�� #
,
��# $
INS_PTZ_EXCEPTION
�� 
,
�� 
INS_RECORD_FILE
�� 
,
�� #
INS_RECORD_SEARCH_END
�� !
,
��! "&
INS_RECORD_SEARCH_FAILED
�� $
,
��$ %!
INS_DEFENSE_SUCCESS
�� 
,
��   
INS_DEFENSE_FAILED
�� 
,
�� (
INS_PLAY_ARCHIVE_EXCEPTION
�� &
,
��& '!
INS_PTZCTRL_SUCCESS
�� 
,
��   
INS_PTZCTRL_FAILED
�� 
}
�� 	
public
�� 
enum
�� 
DataType
�� 
{
�� 	
NET_DVR_SYAHEAD
�� 
,
�� !
NET_DVR_STREAMADATA
�� 
,
��  
NET_DVR_RECV_END
�� 
,
�� 
}
�� 	
public
�� 
enum
�� 
	PTZAction
�� 
{
�� 	
START
�� 
,
�� 
STOP
�� 
}
�� 	
public
�� 
enum
�� 

PTZCommand
�� 
{
�� 	
UP
�� 
,
�� 
DOWN
�� 
,
�� 
LEFT
�� 
,
�� 
RIGHT
�� 
,
�� 
UPLEFT
�� 
,
�� 
DOWNLEFT
�� 
,
�� 
UPRIGHT
�� 
,
�� 
	DOWNRIGHT
�� 
,
�� 
ZOOMMIN
�� 
,
�� 
ZOOMOUT
�� 
,
�� 
	FOCUSNEAR
�� 
,
�� 
FOCUSFAR
�� 
,
�� 
IRISSSTARTUP
�� 
,
�� 
IRISSTOPDOWN
�� 
,
�� 
LIGHT
�� 
,
�� 
WIPER
�� 
,
�� 
AUTO
�� 
}
�� 	
}
�� 
}�� �h
nG:\Working\Maintenance\VideoPlayControl\VideoPlayControl\VideoPlayControl\VideoPlayControl\SDK_EzvizSDK_Old.cs
	namespace 	
VideoPlayControl
 
{ 
public 

class 
SDK_EzvizSDK_Old !
{ 
public 
enum 
EzvizMeesageType $
{ 	
INS_PLAY_EXCEPTION 
, 
INS_PLAY_RECONNECT 
, (
INS_PLAY_RECONNECT_EXCEPTION   (
,  ( )
INS_PLAY_START%% 
,%% 

,**  
INS_PLAY_ARCHIVE_END//  
,//  !
INS_VOICETALK_START44 
,44  
INS_VOICETALK_STOP99 
,99 #
INS_VOICETALK_EXCEPTION>> #
,>># $
INS_PTZ_EXCEPTIONCC 
,CC 
INS_RECORD_FILEHH 
,HH !
INS_RECORD_SEARCH_ENDMM !
,MM! "$
INS_RECORD_SEARCH_FAILEDRR $
,RR$ %
INS_DEFENSE_SUCCESSWW 
,WW  
INS_DEFENSE_FAILED\\ 
,\\ &
INS_PLAY_ARCHIVE_EXCEPTIONaa &
,aa& '
INS_PTZCTRL_SUCCESSff 
,ff  
INS_PTZCTRL_FAILEDkk 
}ll 	
[oo 	
	DllImportoo	 
(oo 

.oo  !'
c_strEzvizSDKOldSDKFilePathoo! <
)oo< =
]oo= >
publicss 
staticss 
externss 
intss  
OpenSDK_InitLibss! 0
(ss0 1
stringss1 7

szAuthAddrss8 B
,ssB C
stringssD J

szPlatformssK U
,ssU V
stringssW ]
szAppIdss^ e
)sse f
;ssf g
[yy 	
	DllImportyy	 
(yy 

.yy  !'
c_strEzvizSDKOldSDKFilePathyy! <
)yy< =
]yy= >
publiczz 
staticzz 
externzz 
intzz  
OpenSDK_FiniLibzz! 0
(zz0 1
)zz1 2
;zz2 3
[|| 	
	DllImport||	 
(|| 

.||  !'
c_strEzvizSDKOldSDKFilePath||! <
)||< =
]||= >
public}} 
static}} 
extern}} 
int}}  #
OpenSDK_Data_GetDevList}}! 8
(}}8 9
string}}9 ?

,}}M N
int}}O R

iPageStart}}S ]
,}}] ^
int}}_ b
	iPageSize}}c l
,}}l m
out}}n q
IntPtr}}r x
pBuf}}y }
,}}} ~
out	}} �
int
}}� �
iLength
}}� �
)
}}� �
;
}}� �
public
�� 
delegate
�� 
void
�� $
OpenSDK_MessageHandler
�� 3
(
��3 4
string
��4 :
szSessionId
��; F
,
��F G
EzvizMeesageType
��H X
iMsgType
��Y a
,
��a b
uint
��c g

iErrorCode
��h r
,
��r s
string
��t z
pMessageInfo��{ �
,��� �
int��� �
pUser��� �
)��� �
;��� �
[
�� 	
	DllImport
��	 
(
�� 

��  
.
��  !)
c_strEzvizSDKOldSDKFilePath
��! <
)
��< =
]
��= >
public
�� 
static
�� 
extern
�� 
int
��  &
OpenSDK_AllocSession_Old
��! 9
(
��9 :$
OpenSDK_MessageHandler
��: P
YSMessageHanle
��Q _
,
��_ `
int
��a d
pUser
��e j
,
��j k
out
��l o
IntPtr
��p v
pSession
��w 
,�� �
out��� �
int��� �
iSessionLen��� �
)��� �
;��� �
[
�� 	
	DllImport
��	 
(
�� 

��  
.
��  !)
c_strEzvizSDKOldSDKFilePath
��! <
)
��< =
]
��= >
public
�� 
static
�� 
extern
�� 
int
��  $
OpenSDK_AllocSessionEx
��! 7
(
��7 8$
OpenSDK_MessageHandler
��8 N
YSMessageHanle
��O ]
,
��] ^
int
��_ b
pUser
��c h
,
��h i
out
��j m
IntPtr
��n t
pSession
��u }
,
��} ~
out�� �
int��� �
iSessionLen��� �
)��� �
;��� �
[
�� 	
	DllImport
��	 
(
�� 

��  
.
��  !)
c_strEzvizSDKOldSDKFilePath
��! <
)
��< =
]
��= >
public
�� 
static
�� 
extern
�� 
int
��  !
OpenSDK_FreeSession
��! 4
(
��4 5
string
��5 ;
pSession
��< D
)
��D E
;
��E F
[
�� 	
	DllImport
��	 
(
�� 

��  
.
��  !)
c_strEzvizSDKOldSDKFilePath
��! <
)
��< =
]
��= >
public
�� 
static
�� 
extern
�� 
int
��  %
OpenSDK_FreeSession_Old
��! 8
(
��8 9
string
��9 ?
pSession
��@ H
)
��H I
;
��I J
[
�� 	
	DllImport
��	 
(
�� 

��  
.
��  !)
c_strEzvizSDKOldSDKFilePath
��! <
)
��< =
]
��= >
public
�� 
static
�� 
extern
�� 
int
��  '
OpenSDK_StartRealPlay_Old
��! :
(
��: ;
string
��; A
szSessionId
��B M
,
��M N
IntPtr
��O U
hPlayWnd
��V ^
,
��^ _
string
��` f

szCameraId
��g q
,
��q r
string
��s y

,��� �
int��� �
iVideoLevel��� �
,��� �
string��� �
	szSafeKey��� �
,��� �
string��� �
szAppKey��� �
)��� �
;��� �
[
�� 	
	DllImport
��	 
(
�� 

��  
.
��  !)
c_strEzvizSDKOldSDKFilePath
��! <
)
��< =
]
��= >
public
�� 
static
�� 
extern
�� 
int
��  %
OpenSDK_StartRealPlayEx
��! 8
(
��8 9
string
��9 ?
szSessionId
��@ K
,
��K L
IntPtr
��M S
hPlayWnd
��T \
,
��\ ]
string
��^ d
	szVideoId
��e n
,
��n o
int
��p s

szCameraId
��t ~
,
��~ 
string��� �
	szSafeKey��� �
)��� �
;��� �
[
�� 	
	DllImport
��	 
(
�� 

��  
.
��  !)
c_strEzvizSDKOldSDKFilePath
��! <
)
��< =
]
��= >
public
�� 
static
�� 
extern
�� 
int
��  #
OpenSDK_StartRealPlay
��! 6
(
��6 7
IntPtr
��7 =
SID
��> A
,
��A B
IntPtr
��C I
PlayWnd
��J Q
,
��Q R
string
��S Y
CameraId
��Z b
,
��b c
string
��d j
Token
��k p
,
��p q
int
��r u

VideoLevel��v �
,��� �
string��� �
SafeKey��� �
,��� �
string��� �
AppKey��� �
,��� �
uint��� �
pNSCBMsg��� �
)��� �
;��� �
[
�� 	
	DllImport
��	 
(
�� 

��  
.
��  !)
c_strEzvizSDKOldSDKFilePath
��! <
)
��< =
]
��= >
public
�� 
static
�� 
extern
�� 
int
��  #
OpenSDK_SetVideoLevel
��! 6
(
��6 7
string
��7 =
szDevSerial
��> I
,
��I J
int
��K N

iChannelNo
��O Y
,
��Y Z
int
��[ ^
iVideoLevel
��_ j
)
��j k
;
��k l
[
�� 	
	DllImport
��	 
(
�� 

��  
.
��  !)
c_strEzvizSDKOldSDKFilePath
��! <
)
��< =
]
��= >
public
�� 
static
�� 
extern
�� 
int
��  &
OpenSDK_StopRealPlay_Old
��! 9
(
��9 :
string
��: @
szSessionId
��A L
)
��L M
;
��M N
[
�� 	
	DllImport
��	 
(
�� 

��  
.
��  !)
c_strEzvizSDKOldSDKFilePath
��! <
)
��< =
]
��= >
public
�� 
static
�� 
extern
�� 
int
��  "
OpenSDK_StopRealPlay
��! 5
(
��5 6
IntPtr
��6 <
SID
��= @
,
��@ A
uint
��B F
pNSCBMsg
��G O
)
��O P
;
��P Q
[
�� 	
	DllImport
��	 
(
�� 

��  
.
��  !)
c_strEzvizSDKOldSDKFilePath
��! <
)
��< =
]
��= >
public
�� 
static
�� 
extern
�� 
int
��  !
OpenSDK_StartSearch
��! 4
(
��4 5
string
��5 ;
szSessionId
��< G
,
��G H
string
��I O

szCameraId
��P Z
,
��Z [
string
��\ b

��c p
,
��p q
string
��r x
szStartTime��y �
,��� �
string��� �

szStopTime��� �
)��� �
;��� �
[
�� 	
	DllImport
��	 
(
�� 

��  
.
��  !)
c_strEzvizSDKOldSDKFilePath
��! <
)
��< =
]
��= >
public
�� 
static
�� 
extern
�� 
int
��  '
OpenSDK_StartPlayBack_Old
��! :
(
��: ;
string
��; A
szSessionId
��B M
,
��M N
IntPtr
��O U
hPlayWnd
��V ^
,
��^ _
string
��` f

szCameraId
��g q
,
��q r
string
��s y

,��� �
string��� �
	szSafeKey��� �
,��� �
string��� �
szStartTime��� �
,��� �
string��� �

szStopTime��� �
,��� �
string��� �
szAppKey��� �
)��� �
;��� �
[
�� 	
	DllImport
��	 
(
�� 

��  
.
��  !)
c_strEzvizSDKOldSDKFilePath
��! <
)
��< =
]
��= >
public
�� 
static
�� 
extern
�� 
int
��  $
OpenSDK_CapturePicture
��! 7
(
��7 8
IntPtr
��8 >
SID
��? B
,
��B C
string
��D J

szFileName
��K U
)
��U V
;
��V W
[
�� 	
	DllImport
��	 
(
�� 

��  
.
��  !)
c_strEzvizSDKOldSDKFilePath
��! <
)
��< =
]
��= >
public
�� 
static
�� 
extern
�� 
int
��  &
OpenSDK_GetLastErrorCode
��! 9
(
��9 :
)
��: ;
;
��; <
[
�� 	
	DllImport
��	 
(
�� 

��  
.
��  !)
c_strEzvizSDKOldSDKFilePath
��! <
,
��< =

EntryPoint
��> H
=
��I J
$str
��K d
,
��d e
SetLastError
��f r
=
��s t
true
��u y
,
��y z

=��� �
true��� �
,��� �!
CallingConvention��� �
=��� �!
CallingConvention��� �
.��� �
StdCall��� �
,��� �
CharSet��� �
=��� �
CharSet��� �
.��� �
Ansi��� �
)��� �
]��� �
public
�� 
static
�� 
extern
�� 
int
��  %
OpenSDK_SetDataCallBack
��! 8
(
��8 9
string
��9 ?
	sessionId
��@ I
,
��I J"
OpenSDK_DataCallBack
��K _

��` m
,
��m n
string
��o u
pUser
��v {
)
��{ |
;
��| }
[
�� 	&
UnmanagedFunctionPointer
��	 !
(
��! "
CallingConvention
��" 3
.
��3 4
StdCall
��4 ;
)
��; <
]
��< =
public
�� 
delegate
�� 
void
�� "
OpenSDK_DataCallBack
�� 1
(
��1 2
CallBackDateType
��2 B
dateType
��C K
,
��K L
IntPtr
��M S
dateContent
��T _
,
��_ `
int
��a d
dataLen
��e l
,
��l m
string
��n t
pUser
��u z
)
��z {
;
��{ |
public
�� 
enum
�� 
CallBackDateType
�� $
{
�� 	
NET_DVR_SYSHEAD
�� 
=
�� 
$num
�� 
,
��   
NET_DVR_STREAMDATA
�� 
=
��  
$num
��! "
,
��" #
NET_DVR_RECV_END
�� 
=
�� 
$num
��  
,
��  !
}
�� 	
;
��	 

}
�� 
}�� ��j
nG:\Working\Maintenance\VideoPlayControl\VideoPlayControl\VideoPlayControl\VideoPlayControl\SDK_HikClientSDK.cs
	namespace 	
VideoPlayControl
 
{ 
public		 

class		 
SDK_HikClientSDK		 !
{

 
public
const
int
NET_DVR_GET_CCDPARAMCFG
=
$num
;
public 
const 
int #
NET_DVR_SET_CCDPARAMCFG 0
=1 2
$num3 7
;7 8
public 
const 
int #
NET_DVR_GET_IMAGEREGION 0
=1 2
$num3 7
;7 8
public 
const 
int #
NET_DVR_SET_IMAGEREGION 0
=1 2
$num3 7
;7 8
public 
const 
int "
NET_DVR_GET_IMAGEPARAM /
=0 1
$num2 6
;6 7
public 
const 
int "
NET_DVR_SET_IMAGEPARAM /
=0 1
$num2 6
;6 7
public 
const 
int 
PLATE_INFO_LEN '
=( )
$num* .
;. /
public 
const 
int 

=' (
$num) +
;+ ,
public 
const 
int 

=' (
$num) ,
;, -
public 
const 
int 

=' (
$num) *
;* +
public 
const 
int 
SDK_HCNETSDK %
=& '
$num( )
;) *
public 
const 
int 
NAME_LEN !
=" #
$num$ &
;& '
public 
const 
int 

PASSWD_LEN #
=$ %
$num& (
;( )
public 
const 
int 
GUID_LEN !
=" #
$num$ &
;& '
public 
const 
int 
DEV_TYPE_NAME_LEN *
=+ ,
$num- /
;/ 0
public 
const 
int 
MAX_NAMELEN $
=% &
$num' )
;) *
public 
const 
int 
	MAX_RIGHT "
=# $
$num% '
;' (
public   
const   
int   
SERIALNO_LEN   %
=  & '
$num  ( *
;  * +
public!! 
const!! 
int!! 
MACADDR_LEN!! $
=!!% &
$num!!' (
;!!( )
public"" 
const"" 
int"" 
MAX_ETHERNET"" %
=""& '
$num""( )
;"") *
public## 
const## 
int## 
MAX_NETWORK_CARD## )
=##* +
$num##, -
;##- .
public$$ 
const$$ 
int$$ 
PATHNAME_LEN$$ %
=$$& '
$num$$( +
;$$+ ,
public&& 
const&& 
int&& 
MAX_NUMBER_LEN&& '
=&&( )
$num&&* ,
;&&, -
public'' 
const'' 
int'' 
MAX_NAME_LEN'' %
=''& '
$num''( +
;''+ ,
public)) 
const)) 
int)) 
MAX_TIMESEGMENT_V30)) ,
=))- .
$num))/ 0
;))0 1
public** 
const** 
int** 
MAX_TIMESEGMENT** (
=**) *
$num**+ ,
;**, -
public++ 
const++ 
int++ 
MAX_ICR_NUM++ $
=++% &
$num++' (
;++( )
public-- 
const-- 
int-- 
MAX_SHELTERNUM-- '
=--( )
$num--* +
;--+ ,
public.. 
const.. 
int.. 
PHONENUMBER_LEN.. (
=..) *
$num..+ -
;..- .
public00 
const00 
int00 
MAX_DISKNUM00 $
=00% &
$num00' )
;00) *
public11 
const11 
int11 
MAX_DISKNUM_V1011 (
=11) *
$num11+ ,
;11, -
public33 
const33 
int33 
MAX_WINDOW_V3033 '
=33( )
$num33* ,
;33, -
public44 
const44 
int44 

MAX_WINDOW44 #
=44$ %
$num44& (
;44( )
public55 
const55 
int55 
MAX_VGA_V3055 $
=55% &
$num55' (
;55( )
public66 
const66 
int66 
MAX_VGA66  
=66! "
$num66# $
;66$ %
public88 
const88 
int88 
MAX_USERNUM_V3088 (
=88) *
$num88+ -
;88- .
public99 
const99 
int99 
MAX_USERNUM99 $
=99% &
$num99' )
;99) *
public:: 
const:: 
int::  
MAX_EXCEPTIONNUM_V30:: -
=::. /
$num::0 2
;::2 3
public;; 
const;; 
int;; 
MAX_EXCEPTIONNUM;; )
=;;* +
$num;;, .
;;;. /
public<< 
const<< 
int<< 
MAX_LINK<< !
=<<" #
$num<<$ %
;<<% &
public== 
const== 
int==  
MAX_ITC_EXCEPTIONOUT== -
===. /
$num==0 2
;==2 3
public?? 
const?? 
int?? 
MAX_DECPOOLNUM?? '
=??( )
$num??* +
;??+ ,
public@@ 
const@@ 
int@@ 

MAX_DECNUM@@ #
=@@$ %
$num@@& '
;@@' (
publicAA 
constAA 
intAA 
MAX_TRANSPARENTNUMAA +
=AA, -
$numAA. /
;AA/ 0
publicBB 
constBB 
intBB 
MAX_CYCLE_CHANBB '
=BB( )
$numBB* ,
;BB, -
publicCC 
constCC 
intCC 
MAX_CYCLE_CHAN_V30CC +
=CC, -
$numCC. 0
;CC0 1
publicDD 
constDD 
intDD 
MAX_DIRNAME_LENGTHDD +
=DD, -
$numDD. 0
;DD0 1
publicFF 
constFF 
intFF 
MAX_STRINGNUM_V30FF *
=FF+ ,
$numFF- .
;FF. /
publicGG 
constGG 
intGG 

=GG' (
$numGG) *
;GG* +
publicHH 
constHH 
intHH 
MAX_STRINGNUM_EXHH )
=HH* +
$numHH, -
;HH- .
publicII 
constII 
intII 
MAX_AUXOUT_V30II '
=II( )
$numII* ,
;II, -
publicJJ 
constJJ 
intJJ 

MAX_AUXOUTJJ #
=JJ$ %
$numJJ& '
;JJ' (
publicKK 
constKK 
intKK 
MAX_HD_GROUPKK %
=KK& '
$numKK( *
;KK* +
publicLL 
constLL 
intLL 
MAX_NFS_DISKLL %
=LL& '
$numLL( )
;LL) *
publicNN 
constNN 
intNN 
IW_ESSID_MAX_SIZENN *
=NN+ ,
$numNN- /
;NN/ 0
publicOO 
constOO 
intOO !
IW_ENCODING_TOKEN_MAXOO .
=OO/ 0
$numOO1 3
;OO3 4
publicPP 
constPP 
intPP "
WIFI_WEP_MAX_KEY_COUNTPP /
=PP0 1
$numPP2 3
;PP3 4
publicQQ 
constQQ 
intQQ #
WIFI_WEP_MAX_KEY_LENGTHQQ 0
=QQ1 2
$numQQ3 5
;QQ5 6
publicRR 
constRR 
intRR '
WIFI_WPA_PSK_MAX_KEY_LENGTHRR 4
=RR5 6
$numRR7 9
;RR9 :
publicSS 
constSS 
intSS '
WIFI_WPA_PSK_MIN_KEY_LENGTHSS 4
=SS5 6
$numSS7 8
;SS8 9
publicTT 
constTT 
intTT 
WIFI_MAX_AP_COUNTTT *
=TT+ ,
$numTT- /
;TT/ 0
publicUU 
constUU 
intUU 
MAX_SERIAL_NUMUU '
=UU( )
$numUU* ,
;UU, -
publicVV 
constVV 
intVV 

=VV' (
$numVV) +
;VV+ ,
publicWW 
constWW 
intWW 
MAX_EMAIL_ADDR_LENWW +
=WW, -
$numWW. 0
;WW0 1
publicXX 
constXX 
intXX 
MAX_EMAIL_PWD_LENXX *
=XX+ ,
$numXX- /
;XX/ 0
publicZZ 
constZZ 
intZZ 
MAXPROGRESSZZ $
=ZZ% &
$numZZ' *
;ZZ* +
public[[ 
const[[ 
int[[ 

=[[' (
$num[[) *
;[[* +
public\\ 
const\\ 
int\\ 
CARDNUM_LEN\\ $
=\\% &
$num\\' )
;\\) *
public]] 
const]] 
int]] 
CARDNUM_LEN_OUT]] (
=]]) *
$num]]+ -
;]]- .
public^^ 
const^^ 
int^^ 
MAX_VIDEOOUT_V30^^ )
=^^* +
$num^^, -
;^^- .
public__ 
const__ 
int__ 
MAX_VIDEOOUT__ %
=__& '
$num__( )
;__) *
publicaa 
constaa 
intaa 
MAX_PRESET_V30aa '
=aa( )
$numaa* -
;aa- .
publicbb 
constbb 
intbb 

=bb' (
$numbb) ,
;bb, -
publiccc 
constcc 
intcc 
MAX_CRUISE_V30cc '
=cc( )
$numcc* -
;cc- .
publicdd 
constdd 
intdd 

MAX_PRESETdd #
=dd$ %
$numdd& )
;dd) *
publicee 
constee 
intee 
	MAX_TRACKee "
=ee# $
$numee% (
;ee( )
publicff 
constff 
intff 

MAX_CRUISEff #
=ff$ %
$numff& )
;ff) *
publichh 
consthh 
inthh "
CRUISE_MAX_PRESET_NUMShh /
=hh0 1
$numhh2 4
;hh4 5
publicjj 
constjj 
intjj 
MAX_SERIAL_PORTjj (
=jj) *
$numjj+ ,
;jj, -
publickk 
constkk 
intkk 
MAX_PREVIEW_MODEkk )
=kk* +
$numkk, -
;kk- .
publicll 
constll 
intll 

=ll' (
$numll) +
;ll+ ,
publicmm 
constmm 
intmm 
LOG_INFO_LENmm %
=mm& '
$nummm( -
;mm- .
publicnn 
constnn 
intnn 
DESC_LENnn !
=nn" #
$numnn$ &
;nn& '
publicoo 
constoo 
intoo 
PTZ_PROTOCOL_NUMoo )
=oo* +
$numoo, /
;oo/ 0
publicqq 
constqq 
intqq 
	MAX_AUDIOqq "
=qq# $
$numqq% &
;qq& '
publicrr 
constrr 
intrr 

=rr' (
$numrr) *
;rr* +
publicss 
constss 
intss 
MAX_CHANNUMss $
=ss% &
$numss' )
;ss) *
publictt 
consttt 
inttt 
MAX_ALARMINtt $
=tt% &
$numtt' )
;tt) *
publicuu 
constuu 
intuu 
MAX_ALARMOUTuu %
=uu& '
$numuu( )
;uu) *
publicww 
constww 
intww 
MAX_ANALOG_CHANNUMww +
=ww, -
$numww. 0
;ww0 1
publicxx 
constxx 
intxx 
MAX_ANALOG_ALARMOUTxx ,
=xx- .
$numxx/ 1
;xx1 2
publicyy 
constyy 
intyy 
MAX_ANALOG_ALARMINyy +
=yy, -
$numyy. 0
;yy0 1
public{{ 
const{{ 
int{{ 

={{' (
$num{{) +
;{{+ ,
public|| 
const|| 
int|| 
MAX_IP_DEVICE_V40|| *
=||+ ,
$num||- /
;||/ 0
public}} 
const}} 
int}} 
MAX_IP_CHANNEL}} '
=}}( )
$num}}* ,
;}}, -
public~~ 
const~~ 
int~~ 
MAX_IP_ALARMIN~~ '
=~~( )
$num~~* -
;~~- .
public 
const 
int 
MAX_IP_ALARMOUT (
=) *
$num+ -
;- .
public
�� 
const
�� 
int
��  
MAX_IP_ALARMIN_V40
�� +
=
��, -
$num
��. 2
;
��2 3
public
�� 
const
�� 
int
�� !
MAX_IP_ALARMOUT_V40
�� ,
=
��- .
$num
��/ 3
;
��3 4
public
�� 
const
�� 
int
�� !
MAX_RECORD_FILE_NUM
�� ,
=
��- .
$num
��/ 1
;
��1 2
public
�� 
const
�� 
int
�� 
MAX_ATM_NUM
�� $
=
��% &
$num
��' (
;
��( )
public
�� 
const
�� 
int
�� 
MAX_ACTION_TYPE
�� (
=
��) *
$num
��+ -
;
��- .
public
�� 
const
�� 
int
�� 
ATM_FRAMETYPE_NUM
�� *
=
��+ ,
$num
��- .
;
��. /
public
�� 
const
�� 
int
�� "
MAX_ATM_PROTOCOL_NUM
�� -
=
��. /
$num
��0 4
;
��4 5
public
�� 
const
�� 
int
�� 
ATM_PROTOCOL_SORT
�� *
=
��+ ,
$num
��- .
;
��. /
public
�� 
const
�� 
int
�� 
ATM_DESC_LEN
�� %
=
��& '
$num
��( *
;
��* +
public
�� 
const
�� 
int
�� 
MAX_CHANNUM_V30
�� (
=
��) * 
MAX_ANALOG_CHANNUM
��+ =
+
��> ?
MAX_IP_CHANNEL
��@ N
;
��N O
public
�� 
const
�� 
int
�� 
MAX_ALARMOUT_V30
�� )
=
��* +!
MAX_ANALOG_ALARMOUT
��, ?
+
��@ A
MAX_IP_ALARMOUT
��B Q
;
��Q R
public
�� 
const
�� 
int
�� 
MAX_ALARMIN_V30
�� (
=
��) * 
MAX_ANALOG_ALARMIN
��+ =
+
��> ?
MAX_IP_ALARMIN
��@ N
;
��N O
public
�� 
const
�� 
int
�� 
MAX_CHANNUM_V40
�� (
=
��) *
$num
��+ .
;
��. /
public
�� 
const
�� 
int
�� 
MAX_ALARMOUT_V40
�� )
=
��* +!
MAX_IP_ALARMOUT_V40
��, ?
+
��@ A!
MAX_ANALOG_ALARMOUT
��B U
;
��U V
public
�� 
const
�� 
int
�� 
MAX_ALARMIN_V40
�� (
=
��) * 
MAX_IP_ALARMIN_V40
��+ =
+
��> ?!
MAX_ANALOG_ALARMOUT
��@ S
;
��S T
public
�� 
const
�� 
int
�� #
MAX_HUMAN_PICTURE_NUM
�� .
=
��/ 0
$num
��1 3
;
��3 4
public
�� 
const
�� 
int
�� %
MAX_HUMAN_BIRTHDATE_LEN
�� 0
=
��1 2
$num
��3 5
;
��5 6
public
�� 
const
�� 
int
�� 

�� &
=
��' (
$num
��) +
;
��+ ,
public
�� 
const
�� 
int
�� 
MAX_ROIDETECT_NUM
�� *
=
��+ ,
$num
��- .
;
��. /
public
�� 
const
�� 
int
�� 
MAX_LANERECT_NUM
�� )
=
��* +
$num
��, -
;
��- .
public
�� 
const
�� 
int
�� 
MAX_FORTIFY_NUM
�� (
=
��) *
$num
��+ -
;
��- .
public
�� 
const
�� 
int
�� 
MAX_INTERVAL_NUM
�� )
=
��* +
$num
��, -
;
��- .
public
�� 
const
�� 
int
�� 
MAX_CHJC_NUM
�� %
=
��& '
$num
��( )
;
��) *
public
�� 
const
�� 
int
�� 

MAX_VL_NUM
�� #
=
��$ %
$num
��& '
;
��' (
public
�� 
const
�� 
int
�� 
MAX_DRIVECHAN_NUM
�� *
=
��+ ,
$num
��- /
;
��/ 0
public
�� 
const
�� 
int
�� 
MAX_COIL_NUM
�� %
=
��& '
$num
��( )
;
��) *
public
�� 
const
�� 
int
�� !
MAX_SIGNALLIGHT_NUM
�� ,
=
��- .
$num
��/ 0
;
��0 1
public
�� 
const
�� 
int
�� 
LEN_32
�� 
=
��  !
$num
��" $
;
��$ %
public
�� 
const
�� 
int
�� 
LEN_31
�� 
=
��  !
$num
��" $
;
��$ %
public
�� 
const
�� 
int
�� 
MAX_CABINET_COUNT
�� *
=
��+ ,
$num
��- .
;
��. /
public
�� 
const
�� 
int
�� 

MAX_ID_LEN
�� #
=
��$ %
$num
��& (
;
��( )
public
�� 
const
�� 
int
�� 
MAX_PARKNO_LEN
�� '
=
��( )
$num
��* ,
;
��, -
public
�� 
const
�� 
int
�� !
MAX_ALARMREASON_LEN
�� ,
=
��- .
$num
��/ 1
;
��1 2
public
�� 
const
�� 
int
�� "
MAX_UPGRADE_INFO_LEN
�� -
=
��. /
$num
��0 2
;
��2 3
public
�� 
const
�� 
int
�� 
MAX_CUSTOMDIR_LEN
�� *
=
��+ ,
$num
��- /
;
��/ 0
public
�� 
const
�� 
int
�� &
MAX_TRANSPARENT_CHAN_NUM
�� 1
=
��2 3
$num
��4 5
;
��5 6
public
�� 
const
�� 
int
�� (
MAX_TRANSPARENT_ACCESS_NUM
�� 3
=
��4 5
$num
��6 7
;
��7 8
public
�� 
const
�� 
int
��  
MAX_PARKING_STATUS
�� +
=
��, -
$num
��. /
;
��/ 0
public
�� 
const
�� 
int
�� 
MAX_PARKING_NUM
�� (
=
��) *
$num
��+ ,
;
��, -
public
�� 
const
�� 
int
�� 
MAX_ITS_SCENE_NUM
�� *
=
��+ ,
$num
��- /
;
��/ 0
public
�� 
const
�� 
int
�� #
MAX_SCENE_TIMESEG_NUM
�� .
=
��/ 0
$num
��1 3
;
��3 4
public
�� 
const
�� 
int
�� !
MAX_IVMS_IP_CHANNEL
�� ,
=
��- .
$num
��/ 2
;
��2 3
public
�� 
const
�� 
int
�� 

�� &
=
��' (
$num
��) +
;
��+ ,
public
�� 
const
�� 
int
��  
MONITORSITE_ID_LEN
�� +
=
��, -
$num
��. 0
;
��0 1
public
�� 
const
�� 
int
�� 
MAX_AUXAREA_NUM
�� (
=
��) *
$num
��+ -
;
��- .
public
�� 
const
�� 
int
�� #
MAX_SLAVE_CHANNEL_NUM
�� .
=
��/ 0
$num
��1 3
;
��3 4
public
�� 
const
�� 
int
�� 
MAX_SCH_TASKS_NUM
�� *
=
��+ ,
$num
��- /
;
��/ 0
public
�� 
const
�� 
int
�� 
MAX_SERVERID_LEN
�� )
=
��* +
$num
��, .
;
��. /
public
�� 
const
�� 
int
�� "
MAX_SERVERDOMAIN_LEN
�� -
=
��. /
$num
��0 3
;
��3 4
public
�� 
const
�� 
int
�� $
MAX_AUTHENTICATEID_LEN
�� /
=
��0 1
$num
��2 4
;
��4 5
public
�� 
const
�� 
int
�� (
MAX_AUTHENTICATEPASSWD_LEN
�� 3
=
��4 5
$num
��6 8
;
��8 9
public
�� 
const
�� 
int
��  
MAX_SERVERNAME_LEN
�� +
=
��, -
$num
��. 0
;
��0 1
public
�� 
const
�� 
int
�� #
MAX_COMPRESSIONID_LEN
�� .
=
��/ 0
$num
��1 3
;
��3 4
public
�� 
const
�� 
int
�� '
MAX_SIPSERVER_ADDRESS_LEN
�� 2
=
��3 4
$num
��5 8
;
��8 9
public
�� 
const
�� 
int
�� 
MAX_PlATE_NO_LEN
�� )
=
��* +
$num
��, .
;
��. /
public
�� 
const
�� 
int
�� 

�� &
=
��' (
$num
��) +
;
��+ ,
public
�� 
const
�� 
int
��  
MAX_LOCAL_ADDR_LEN
�� +
=
��, -
$num
��. 0
;
��0 1
public
�� 
const
�� 
int
�� "
MAX_COUNTRY_NAME_LEN
�� -
=
��. /
$num
��0 1
;
��1 2
public
�� 
const
�� 
int
�� 

�� &
=
��' (
$num
��) *
;
��* +
public
�� 
const
�� 
int
�� 
MEDIACONNECT
�� %
=
��& '
$num
��( )
;
��) *
public
�� 
const
�� 
int
�� 
HCDVR
�� 
=
��  
$num
��! "
;
��" #
public
�� 
const
�� 
int
�� 
MEDVR
�� 
=
��  
$num
��! "
;
��" #
public
�� 
const
�� 
int
�� 
PCDVR
�� 
=
��  
$num
��! "
;
��" #
public
�� 
const
�� 
int
�� 
HC_9000
��  
=
��! "
$num
��# $
;
��$ %
public
�� 
const
�� 
int
�� 
HF_I
�� 
=
�� 
$num
��  !
;
��! "
public
�� 
const
�� 
int
�� 
PCNVR
�� 
=
��  
$num
��! "
;
��" #
public
�� 
const
�� 
int
�� 
HC_76NVR
�� !
=
��" #
$num
��$ %
;
��% &
public
�� 
const
�� 
int
�� 
DS8000HC_NVR
�� %
=
��& '
$num
��( )
;
��) *
public
�� 
const
�� 
int
�� 
DS9000HC_NVR
�� %
=
��& '
$num
��( )
;
��) *
public
�� 
const
�� 
int
�� 
DS8000ME_NVR
�� %
=
��& '
$num
��( )
;
��) *
public
�� 
const
�� 
int
�� 
NET_DVR_NOERROR
�� (
=
��) *
$num
��+ ,
;
��, -
public
�� 
const
�� 
int
�� $
NET_DVR_PASSWORD_ERROR
�� /
=
��0 1
$num
��2 3
;
��3 4
public
�� 
const
�� 
int
�� !
NET_DVR_NOENOUGHPRI
�� ,
=
��- .
$num
��/ 0
;
��0 1
public
�� 
const
�� 
int
�� 
NET_DVR_NOINIT
�� '
=
��( )
$num
��* +
;
��+ ,
public
�� 
const
�� 
int
�� #
NET_DVR_CHANNEL_ERROR
�� .
=
��/ 0
$num
��1 2
;
��2 3
public
�� 
const
�� 
int
�� "
NET_DVR_OVER_MAXLINK
�� -
=
��. /
$num
��0 1
;
��1 2
public
�� 
const
�� 
int
�� $
NET_DVR_VERSIONNOMATCH
�� /
=
��0 1
$num
��2 3
;
��3 4
public
�� 
const
�� 
int
�� *
NET_DVR_NETWORK_FAIL_CONNECT
�� 5
=
��6 7
$num
��8 9
;
��9 :
public
�� 
const
�� 
int
�� (
NET_DVR_NETWORK_SEND_ERROR
�� 3
=
��4 5
$num
��6 7
;
��7 8
public
�� 
const
�� 
int
�� (
NET_DVR_NETWORK_RECV_ERROR
�� 3
=
��4 5
$num
��6 7
;
��7 8
public
�� 
const
�� 
int
�� *
NET_DVR_NETWORK_RECV_TIMEOUT
�� 5
=
��6 7
$num
��8 :
;
��: ;
public
�� 
const
�� 
int
�� '
NET_DVR_NETWORK_ERRORDATA
�� 2
=
��3 4
$num
��5 7
;
��7 8
public
�� 
const
�� 
int
�� !
NET_DVR_ORDER_ERROR
�� ,
=
��- .
$num
��/ 1
;
��1 2
public
�� 
const
�� 
int
�� "
NET_DVR_OPERNOPERMIT
�� -
=
��. /
$num
��0 2
;
��2 3
public
�� 
const
�� 
int
�� $
NET_DVR_COMMANDTIMEOUT
�� /
=
��0 1
$num
��2 4
;
��4 5
public
�� 
const
�� 
int
�� %
NET_DVR_ERRORSERIALPORT
�� 0
=
��1 2
$num
��3 5
;
��5 6
public
�� 
const
�� 
int
�� $
NET_DVR_ERRORALARMPORT
�� /
=
��0 1
$num
��2 4
;
��4 5
public
�� 
const
�� 
int
�� %
NET_DVR_PARAMETER_ERROR
�� 0
=
��1 2
$num
��3 5
;
��5 6
public
�� 
const
�� 
int
�� $
NET_DVR_CHAN_EXCEPTION
�� /
=
��0 1
$num
��2 4
;
��4 5
public
�� 
const
�� 
int
�� 
NET_DVR_NODISK
�� '
=
��( )
$num
��* ,
;
��, -
public
�� 
const
�� 
int
�� "
NET_DVR_ERRORDISKNUM
�� -
=
��. /
$num
��0 2
;
��2 3
public
�� 
const
�� 
int
�� 
NET_DVR_DISK_FULL
�� *
=
��+ ,
$num
��- /
;
��/ 0
public
�� 
const
�� 
int
��  
NET_DVR_DISK_ERROR
�� +
=
��, -
$num
��. 0
;
��0 1
public
�� 
const
�� 
int
�� 
NET_DVR_NOSUPPORT
�� *
=
��+ ,
$num
��- /
;
��/ 0
public
�� 
const
�� 
int
�� 
NET_DVR_BUSY
�� %
=
��& '
$num
��( *
;
��* +
public
�� 
const
�� 
int
�� !
NET_DVR_MODIFY_FAIL
�� ,
=
��- .
$num
��/ 1
;
��1 2
public
�� 
const
�� 
int
�� +
NET_DVR_PASSWORD_FORMAT_ERROR
�� 6
=
��7 8
$num
��9 ;
;
��; <
public
�� 
const
�� 
int
�� $
NET_DVR_DISK_FORMATING
�� /
=
��0 1
$num
��2 4
;
��4 5
public
�� 
const
�� 
int
�� #
NET_DVR_DVRNORESOURCE
�� .
=
��/ 0
$num
��1 3
;
��3 4
public
�� 
const
�� 
int
�� %
NET_DVR_DVROPRATEFAILED
�� 0
=
��1 2
$num
��3 5
;
��5 6
public
�� 
const
�� 
int
�� (
NET_DVR_OPENHOSTSOUND_FAIL
�� 3
=
��4 5
$num
��6 8
;
��8 9
public
�� 
const
�� 
int
�� $
NET_DVR_DVRVOICEOPENED
�� /
=
��0 1
$num
��2 4
;
��4 5
public
�� 
const
�� 
int
�� $
NET_DVR_TIMEINPUTERROR
�� /
=
��0 1
$num
��2 4
;
��4 5
public
�� 
const
�� 
int
��  
NET_DVR_NOSPECFILE
�� +
=
��, -
$num
��. 0
;
��0 1
public
�� 
const
�� 
int
�� &
NET_DVR_CREATEFILE_ERROR
�� 1
=
��2 3
$num
��4 6
;
��6 7
public
�� 
const
�� 
int
�� "
NET_DVR_FILEOPENFAIL
�� -
=
��. /
$num
��0 2
;
��2 3
public
�� 
const
�� 
int
�� #
NET_DVR_OPERNOTFINISH
�� .
=
��/ 0
$num
��1 3
;
��3 4
public
�� 
const
�� 
int
�� %
NET_DVR_GETPLAYTIMEFAIL
�� 0
=
��1 2
$num
��3 5
;
��5 6
public
�� 
const
�� 
int
�� 
NET_DVR_PLAYFAIL
�� )
=
��* +
$num
��, .
;
��. /
public
�� 
const
�� 
int
�� &
NET_DVR_FILEFORMAT_ERROR
�� 1
=
��2 3
$num
��4 6
;
��6 7
public
�� 
const
�� 
int
�� 
NET_DVR_DIR_ERROR
�� *
=
��+ ,
$num
��- /
;
��/ 0
public
�� 
const
�� 
int
�� *
NET_DVR_ALLOC_RESOURCE_ERROR
�� 5
=
��6 7
$num
��8 :
;
��: ;
public
�� 
const
�� 
int
�� &
NET_DVR_AUDIO_MODE_ERROR
�� 1
=
��2 3
$num
��4 6
;
��6 7
public
�� 
const
�� 
int
�� "
NET_DVR_NOENOUGH_BUF
�� -
=
��. /
$num
��0 2
;
��2 3
public
�� 
const
�� 
int
�� (
NET_DVR_CREATESOCKET_ERROR
�� 3
=
��4 5
$num
��6 8
;
��8 9
public
�� 
const
�� 
int
�� %
NET_DVR_SETSOCKET_ERROR
�� 0
=
��1 2
$num
��3 5
;
��5 6
public
�� 
const
�� 
int
�� 
NET_DVR_MAX_NUM
�� (
=
��) *
$num
��+ -
;
��- .
public
�� 
const
�� 
int
�� "
NET_DVR_USERNOTEXIST
�� -
=
��. /
$num
��0 2
;
��2 3
public
�� 
const
�� 
int
�� %
NET_DVR_WRITEFLASHERROR
�� 0
=
��1 2
$num
��3 5
;
��5 6
public
�� 
const
�� 
int
�� !
NET_DVR_UPGRADEFAIL
�� ,
=
��- .
$num
��/ 1
;
��1 2
public
�� 
const
�� 
int
�� "
NET_DVR_CARDHAVEINIT
�� -
=
��. /
$num
��0 2
;
��2 3
public
�� 
const
�� 
int
�� "
NET_DVR_PLAYERFAILED
�� -
=
��. /
$num
��0 2
;
��2 3
public
�� 
const
�� 
int
�� !
NET_DVR_MAX_USERNUM
�� ,
=
��- .
$num
��/ 1
;
��1 2
public
�� 
const
�� 
int
�� *
NET_DVR_GETLOCALIPANDMACFAIL
�� 5
=
��6 7
$num
��8 :
;
��: ;
public
�� 
const
�� 
int
�� !
NET_DVR_NOENCODEING
�� ,
=
��- .
$num
��/ 1
;
��1 2
public
�� 
const
�� 
int
��  
NET_DVR_IPMISMATCH
�� +
=
��, -
$num
��. 0
;
��0 1
public
�� 
const
�� 
int
�� !
NET_DVR_MACMISMATCH
�� ,
=
��- .
$num
��/ 1
;
��1 2
public
�� 
const
�� 
int
�� )
NET_DVR_UPGRADELANGMISMATCH
�� 4
=
��5 6
$num
��7 9
;
��9 :
public
�� 
const
�� 
int
�� $
NET_DVR_MAX_PLAYERPORT
�� /
=
��0 1
$num
��2 4
;
��4 5
public
�� 
const
�� 
int
�� #
NET_DVR_NOSPACEBACKUP
�� .
=
��/ 0
$num
��1 3
;
��3 4
public
�� 
const
�� 
int
�� $
NET_DVR_NODEVICEBACKUP
�� /
=
��0 1
$num
��2 4
;
��4 5
public
�� 
const
�� 
int
�� (
NET_DVR_PICTURE_BITS_ERROR
�� 3
=
��4 5
$num
��6 8
;
��8 9
public
�� 
const
�� 
int
�� -
NET_DVR_PICTURE_DIMENSION_ERROR
�� 8
=
��9 :
$num
��; =
;
��= >
public
�� 
const
�� 
int
�� '
NET_DVR_PICTURE_SIZ_ERROR
�� 2
=
��3 4
$num
��5 7
;
��7 8
public
�� 
const
�� 
int
�� )
NET_DVR_LOADPLAYERSDKFAILED
�� 4
=
��5 6
$num
��7 9
;
��9 :
public
�� 
const
�� 
int
�� -
NET_DVR_LOADPLAYERSDKPROC_ERROR
�� 8
=
��9 :
$num
��; =
;
��= >
public
�� 
const
�� 
int
�� %
NET_DVR_LOADDSSDKFAILED
�� 0
=
��1 2
$num
��3 5
;
��5 6
public
�� 
const
�� 
int
�� )
NET_DVR_LOADDSSDKPROC_ERROR
�� 4
=
��5 6
$num
��7 9
;
��9 :
public
�� 
const
�� 
int
�� !
NET_DVR_DSSDK_ERROR
�� ,
=
��- .
$num
��/ 1
;
��1 2
public
�� 
const
�� 
int
�� %
NET_DVR_VOICEMONOPOLIZE
�� 0
=
��1 2
$num
��3 5
;
��5 6
public
�� 
const
�� 
int
�� )
NET_DVR_JOINMULTICASTFAILED
�� 4
=
��5 6
$num
��7 9
;
��9 :
public
�� 
const
�� 
int
�� %
NET_DVR_CREATEDIR_ERROR
�� 0
=
��1 2
$num
��3 5
;
��5 6
public
�� 
const
�� 
int
�� &
NET_DVR_BINDSOCKET_ERROR
�� 1
=
��2 3
$num
��4 6
;
��6 7
public
�� 
const
�� 
int
�� '
NET_DVR_SOCKETCLOSE_ERROR
�� 2
=
��3 4
$num
��5 7
;
��7 8
public
�� 
const
�� 
int
�� $
NET_DVR_USERID_ISUSING
�� /
=
��0 1
$num
��2 4
;
��4 5
public
�� 
const
�� 
int
�� (
NET_DVR_SOCKETLISTEN_ERROR
�� 3
=
��4 5
$num
��6 8
;
��8 9
public
�� 
const
�� 
int
�� '
NET_DVR_PROGRAM_EXCEPTION
�� 2
=
��3 4
$num
��5 7
;
��7 8
public
�� 
const
�� 
int
�� &
NET_DVR_WRITEFILE_FAILED
�� 1
=
��2 3
$num
��4 6
;
��6 7
public
�� 
const
�� 
int
�� %
NET_DVR_FORMAT_READONLY
�� 0
=
��1 2
$num
��3 5
;
��5 6
public
�� 
const
�� 
int
�� &
NET_DVR_WITHSAMEUSERNAME
�� 1
=
��2 3
$num
��4 6
;
��6 7
public
�� 
const
�� 
int
�� &
NET_DVR_DEVICETYPE_ERROR
�� 1
=
��2 3
$num
��4 6
;
��6 7
public
�� 
const
�� 
int
�� $
NET_DVR_LANGUAGE_ERROR
�� /
=
��0 1
$num
��2 4
;
��4 5
public
�� 
const
�� 
int
�� '
NET_DVR_PARAVERSION_ERROR
�� 2
=
��3 4
$num
��5 7
;
��7 8
public
�� 
const
�� 
int
�� %
NET_DVR_IPCHAN_NOTALIVE
�� 0
=
��1 2
$num
��3 5
;
��5 6
public
�� 
const
�� 
int
�� $
NET_DVR_RTSP_SDK_ERROR
�� /
=
��0 1
$num
��2 4
;
��4 5
public
�� 
const
�� 
int
�� '
NET_DVR_CONVERT_SDK_ERROR
�� 2
=
��3 4
$num
��5 7
;
��7 8
public
�� 
const
�� 
int
�� (
NET_DVR_IPC_COUNT_OVERFLOW
�� 3
=
��4 5
$num
��6 8
;
��8 9
public
�� 
const
�� 
int
��  
NET_PLAYM4_NOERROR
�� +
=
��, -
$num
��. 1
;
��1 2
public
�� 
const
�� 
int
�� "
NET_PLAYM4_PARA_OVER
�� -
=
��. /
$num
��0 3
;
��3 4
public
�� 
const
�� 
int
�� $
NET_PLAYM4_ORDER_ERROR
�� /
=
��0 1
$num
��2 5
;
��5 6
public
�� 
const
�� 
int
�� $
NET_PLAYM4_TIMER_ERROR
�� /
=
��0 1
$num
��2 5
;
��5 6
public
�� 
const
�� 
int
�� (
NET_PLAYM4_DEC_VIDEO_ERROR
�� 3
=
��4 5
$num
��6 9
;
��9 :
public
�� 
const
�� 
int
�� (
NET_PLAYM4_DEC_AUDIO_ERROR
�� 3
=
��4 5
$num
��6 9
;
��9 :
public
�� 
const
�� 
int
�� +
NET_PLAYM4_ALLOC_MEMORY_ERROR
�� 6
=
��7 8
$num
��9 <
;
��< =
public
�� 
const
�� 
int
�� (
NET_PLAYM4_OPEN_FILE_ERROR
�� 3
=
��4 5
$num
��6 9
;
��9 :
public
�� 
const
�� 
int
�� )
NET_PLAYM4_CREATE_OBJ_ERROR
�� 4
=
��5 6
$num
��7 :
;
��: ;
public
�� 
const
�� 
int
�� +
NET_PLAYM4_CREATE_DDRAW_ERROR
�� 6
=
��7 8
$num
��9 <
;
��< =
public
�� 
const
�� 
int
�� /
!NET_PLAYM4_CREATE_OFFSCREEN_ERROR
�� :
=
��; <
$num
��= @
;
��@ A
public
�� 
const
�� 
int
�� !
NET_PLAYM4_BUF_OVER
�� ,
=
��- .
$num
��/ 2
;
��2 3
public
�� 
const
�� 
int
�� +
NET_PLAYM4_CREATE_SOUND_ERROR
�� 6
=
��7 8
$num
��9 <
;
��< =
public
�� 
const
�� 
int
�� )
NET_PLAYM4_SET_VOLUME_ERROR
�� 4
=
��5 6
$num
��7 :
;
��: ;
public
�� 
const
�� 
int
�� *
NET_PLAYM4_SUPPORT_FILE_ONLY
�� 5
=
��6 7
$num
��8 ;
;
��; <
public
�� 
const
�� 
int
�� ,
NET_PLAYM4_SUPPORT_STREAM_ONLY
�� 7
=
��8 9
$num
��: =
;
��= >
public
�� 
const
�� 
int
�� (
NET_PLAYM4_SYS_NOT_SUPPORT
�� 3
=
��4 5
$num
��6 9
;
��9 :
public
�� 
const
�� 
int
�� +
NET_PLAYM4_FILEHEADER_UNKNOWN
�� 6
=
��7 8
$num
��9 <
;
��< =
public
�� 
const
�� 
int
�� *
NET_PLAYM4_VERSION_INCORRECT
�� 5
=
��6 7
$num
��8 ;
;
��; <
public
�� 
const
�� 
int
�� +
NET_PALYM4_INIT_DECODER_ERROR
�� 6
=
��7 8
$num
��9 <
;
��< =
public
�� 
const
�� 
int
�� )
NET_PLAYM4_CHECK_FILE_ERROR
�� 4
=
��5 6
$num
��7 :
;
��: ;
public
�� 
const
�� 
int
�� )
NET_PLAYM4_INIT_TIMER_ERROR
�� 4
=
��5 6
$num
��7 :
;
��: ;
public
�� 
const
�� 
int
�� "
NET_PLAYM4_BLT_ERROR
�� -
=
��. /
$num
��0 3
;
��3 4
public
�� 
const
�� 
int
�� %
NET_PLAYM4_UPDATE_ERROR
�� 0
=
��1 2
$num
��3 6
;
��6 7
public
�� 
const
�� 
int
�� .
 NET_PLAYM4_OPEN_FILE_ERROR_MULTI
�� 9
=
��: ;
$num
��< ?
;
��? @
public
�� 
const
�� 
int
�� .
 NET_PLAYM4_OPEN_FILE_ERROR_VIDEO
�� 9
=
��: ;
$num
��< ?
;
��? @
public
�� 
const
�� 
int
�� ,
NET_PLAYM4_JPEG_COMPRESS_ERROR
�� 7
=
��8 9
$num
��: =
;
��= >
public
�� 
const
�� 
int
�� ,
NET_PLAYM4_EXTRACT_NOT_SUPPORT
�� 7
=
��8 9
$num
��: =
;
��= >
public
�� 
const
�� 
int
�� +
NET_PLAYM4_EXTRACT_DATA_ERROR
�� 6
=
��7 8
$num
��9 <
;
��< =
public
�� 
const
�� 
int
�� #
NET_DVR_SUPPORT_DDRAW
�� .
=
��/ 0
$num
��1 2
;
��2 3
public
�� 
const
�� 
int
�� !
NET_DVR_SUPPORT_BLT
�� ,
=
��- .
$num
��/ 0
;
��0 1
public
�� 
const
�� 
int
�� '
NET_DVR_SUPPORT_BLTFOURCC
�� 2
=
��3 4
$num
��5 6
;
��6 7
public
�� 
const
�� 
int
�� (
NET_DVR_SUPPORT_BLTSHRINKX
�� 3
=
��4 5
$num
��6 7
;
��7 8
public
�� 
const
�� 
int
�� (
NET_DVR_SUPPORT_BLTSHRINKY
�� 3
=
��4 5
$num
��6 8
;
��8 9
public
�� 
const
�� 
int
�� )
NET_DVR_SUPPORT_BLTSTRETCHX
�� 4
=
��5 6
$num
��7 9
;
��9 :
public
�� 
const
�� 
int
�� )
NET_DVR_SUPPORT_BLTSTRETCHY
�� 4
=
��5 6
$num
��7 9
;
��9 :
public
�� 
const
�� 
int
�� !
NET_DVR_SUPPORT_SSE
�� ,
=
��- .
$num
��/ 2
;
��2 3
public
�� 
const
�� 
int
�� !
NET_DVR_SUPPORT_MMX
�� ,
=
��- .
$num
��/ 2
;
��2 3
public
�� 
const
�� 
int
�� 
LIGHT_PWRON
�� $
=
��% &
$num
��' (
;
��( )
public
�� 
const
�� 
int
�� 
WIPER_PWRON
�� $
=
��% &
$num
��' (
;
��( )
public
�� 
const
�� 
int
�� 
	FAN_PWRON
�� "
=
��# $
$num
��% &
;
��& '
public
�� 
const
�� 
int
�� 
HEATER_PWRON
�� %
=
��& '
$num
��( )
;
��) *
public
�� 
const
�� 
int
�� 

AUX_PWRON1
�� #
=
��$ %
$num
��& '
;
��' (
public
�� 
const
�� 
int
�� 

AUX_PWRON2
�� #
=
��$ %
$num
��& '
;
��' (
public
�� 
const
�� 
int
�� 

SET_PRESET
�� #
=
��$ %
$num
��& '
;
��' (
public
�� 
const
�� 
int
�� 

CLE_PRESET
�� #
=
��$ %
$num
��& '
;
��' (
public
�� 
const
�� 
int
�� 
ZOOM_IN
��  
=
��! "
$num
��# %
;
��% &
public
�� 
const
�� 
int
�� 
ZOOM_OUT
�� !
=
��" #
$num
��$ &
;
��& '
public
�� 
const
�� 
int
�� 

FOCUS_NEAR
�� #
=
��$ %
$num
��& (
;
��( )
public
�� 
const
�� 
int
�� 
	FOCUS_FAR
�� "
=
��# $
$num
��% '
;
��' (
public
�� 
const
�� 
int
�� 
	IRIS_OPEN
�� "
=
��# $
$num
��% '
;
��' (
public
�� 
const
�� 
int
�� 

IRIS_CLOSE
�� #
=
��$ %
$num
��& (
;
��( )
public
�� 
const
�� 
int
�� 
TILT_UP
��  
=
��! "
$num
��# %
;
��% &
public
�� 
const
�� 
int
�� 
	TILT_DOWN
�� "
=
��# $
$num
��% '
;
��' (
public
�� 
const
�� 
int
�� 
PAN_LEFT
�� !
=
��" #
$num
��$ &
;
��& '
public
�� 
const
�� 
int
�� 
	PAN_RIGHT
�� "
=
��# $
$num
��% '
;
��' (
public
�� 
const
�� 
int
�� 
UP_LEFT
��  
=
��! "
$num
��# %
;
��% &
public
�� 
const
�� 
int
�� 
UP_RIGHT
�� !
=
��" #
$num
��$ &
;
��& '
public
�� 
const
�� 
int
�� 
	DOWN_LEFT
�� "
=
��# $
$num
��% '
;
��' (
public
�� 
const
�� 
int
�� 

DOWN_RIGHT
�� #
=
��$ %
$num
��& (
;
��( )
public
�� 
const
�� 
int
�� 
PAN_AUTO
�� !
=
��" #
$num
��$ &
;
��& '
public
�� 
const
�� 
int
�� 
FILL_PRE_SEQ
�� %
=
��& '
$num
��( *
;
��* +
public
�� 
const
�� 
int
�� 

�� &
=
��' (
$num
��) +
;
��+ ,
public
�� 
const
�� 
int
�� 

�� &
=
��' (
$num
��) +
;
��+ ,
public
�� 
const
�� 
int
�� 
CLE_PRE_SEQ
�� $
=
��% &
$num
��' )
;
��) *
public
�� 
const
�� 
int
�� 
STA_MEM_CRUISE
�� '
=
��( )
$num
��* ,
;
��, -
public
�� 
const
�� 
int
�� 
STO_MEM_CRUISE
�� '
=
��( )
$num
��* ,
;
��, -
public
�� 
const
�� 
int
�� 

RUN_CRUISE
�� #
=
��$ %
$num
��& (
;
��( )
public
�� 
const
�� 
int
�� 
RUN_SEQ
��  
=
��! "
$num
��# %
;
��% &
public
�� 
const
�� 
int
�� 
STOP_SEQ
�� !
=
��" #
$num
��$ &
;
��& '
public
�� 
const
�� 
int
�� 
GOTO_PRESET
�� $
=
��% &
$num
��' )
;
��) *
public
�� 
const
�� 
int
�� 
NET_DVR_PLAYSTART
�� *
=
��+ ,
$num
��- .
;
��. /
public
�� 
const
�� 
int
�� 
NET_DVR_PLAYSTOP
�� )
=
��* +
$num
��, -
;
��- .
public
�� 
const
�� 
int
�� 
NET_DVR_PLAYPAUSE
�� *
=
��+ ,
$num
��- .
;
��. /
public
�� 
const
�� 
int
�� !
NET_DVR_PLAYRESTART
�� ,
=
��- .
$num
��/ 0
;
��0 1
public
�� 
const
�� 
int
�� 
NET_DVR_PLAYFAST
�� )
=
��* +
$num
��, -
;
��- .
public
�� 
const
�� 
int
�� 
NET_DVR_PLAYSLOW
�� )
=
��* +
$num
��, -
;
��- .
public
�� 
const
�� 
int
��  
NET_DVR_PLAYNORMAL
�� +
=
��, -
$num
��. /
;
��/ 0
public
�� 
const
�� 
int
�� 
NET_DVR_PLAYFRAME
�� *
=
��+ ,
$num
��- .
;
��. /
public
�� 
const
�� 
int
�� $
NET_DVR_PLAYSTARTAUDIO
�� /
=
��0 1
$num
��2 3
;
��3 4
public
�� 
const
�� 
int
�� #
NET_DVR_PLAYSTOPAUDIO
�� .
=
��/ 0
$num
��1 3
;
��3 4
public
�� 
const
�� 
int
�� %
NET_DVR_PLAYAUDIOVOLUME
�� 0
=
��1 2
$num
��3 5
;
��5 6
public
�� 
const
�� 
int
��  
NET_DVR_PLAYSETPOS
�� +
=
��, -
$num
��. 0
;
��0 1
public
�� 
const
�� 
int
��  
NET_DVR_PLAYGETPOS
�� +
=
��, -
$num
��. 0
;
��0 1
public
�� 
const
�� 
int
�� !
NET_DVR_PLAYGETTIME
�� ,
=
��- .
$num
��/ 1
;
��1 2
public
�� 
const
�� 
int
�� "
NET_DVR_PLAYGETFRAME
�� -
=
��. /
$num
��0 2
;
��2 3
public
�� 
const
�� 
int
�� $
NET_DVR_GETTOTALFRAMES
�� /
=
��0 1
$num
��2 4
;
��4 5
public
�� 
const
�� 
int
�� "
NET_DVR_GETTOTALTIME
�� -
=
��. /
$num
��0 2
;
��2 3
public
�� 
const
�� 
int
�� !
NET_DVR_THROWBFRAME
�� ,
=
��- .
$num
��/ 1
;
��1 2
public
�� 
const
�� 
int
�� 
NET_DVR_SETSPEED
�� )
=
��* +
$num
��, .
;
��. /
public
�� 
const
�� 
int
�� 
NET_DVR_KEEPALIVE
�� *
=
��+ ,
$num
��- /
;
��/ 0
public
�� 
const
�� 
int
�� !
NET_DVR_PLAYSETTIME
�� ,
=
��- .
$num
��/ 1
;
��1 2
public
�� 
const
�� 
int
�� %
NET_DVR_PLAYGETTOTALLEN
�� 0
=
��1 2
$num
��3 5
;
��5 6
public
�� 
const
�� 
int
�� "
NET_DVR_PLAY_FORWARD
�� -
=
��. /
$num
��0 2
;
��2 3
public
�� 
const
�� 
int
�� "
NET_DVR_PLAY_REVERSE
�� -
=
��. /
$num
��0 2
;
��2 3
public
�� 
const
�� 
int
�� $
NET_DVR_SET_TRANS_TYPE
�� /
=
��0 1
$num
��2 4
;
��4 5
public
�� 
const
�� 
int
�� "
NET_DVR_PLAY_CONVERT
�� -
=
��. /
$num
��0 2
;
��2 3
public
�� 
const
�� 
int
�� 

KEY_CODE_1
�� #
=
��$ %
$num
��& '
;
��' (
public
�� 
const
�� 
int
�� 

KEY_CODE_2
�� #
=
��$ %
$num
��& '
;
��' (
public
�� 
const
�� 
int
�� 

KEY_CODE_3
�� #
=
��$ %
$num
��& '
;
��' (
public
�� 
const
�� 
int
�� 

KEY_CODE_4
�� #
=
��$ %
$num
��& '
;
��' (
public
�� 
const
�� 
int
�� 

KEY_CODE_5
�� #
=
��$ %
$num
��& '
;
��' (
public
�� 
const
�� 
int
�� 

KEY_CODE_6
�� #
=
��$ %
$num
��& '
;
��' (
public
�� 
const
�� 
int
�� 

KEY_CODE_7
�� #
=
��$ %
$num
��& '
;
��' (
public
�� 
const
�� 
int
�� 

KEY_CODE_8
�� #
=
��$ %
$num
��& '
;
��' (
public
�� 
const
�� 
int
�� 

KEY_CODE_9
�� #
=
��$ %
$num
��& '
;
��' (
public
�� 
const
�� 
int
�� 

KEY_CODE_0
�� #
=
��$ %
$num
��& (
;
��( )
public
�� 
const
�� 
int
�� 
KEY_CODE_POWER
�� '
=
��( )
$num
��* ,
;
��, -
public
�� 
const
�� 
int
�� 

�� &
=
��' (
$num
��) +
;
��+ ,
public
�� 
const
�� 
int
�� 
KEY_CODE_ENTER
�� '
=
��( )
$num
��* ,
;
��, -
public
�� 
const
�� 
int
�� 
KEY_CODE_CANCEL
�� (
=
��) *
$num
��+ -
;
��- .
public
�� 
const
�� 
int
�� 
KEY_CODE_UP
�� $
=
��% &
$num
��' )
;
��) *
public
�� 
const
�� 
int
�� 

�� &
=
��' (
$num
��) +
;
��+ ,
public
�� 
const
�� 
int
�� 

�� &
=
��' (
$num
��) +
;
��+ ,
public
�� 
const
�� 
int
�� 
KEY_CODE_RIGHT
�� '
=
��( )
$num
��* ,
;
��, -
public
�� 
const
�� 
int
�� 

�� &
=
��' (
$num
��) +
;
��+ ,
public
�� 
const
�� 
int
�� 
KEY_CODE_ADD
�� %
=
��& '
$num
��( *
;
��* +
public
�� 
const
�� 
int
�� 
KEY_CODE_MINUS
�� '
=
��( )
$num
��* ,
;
��, -
public
�� 
const
�� 
int
�� 

�� &
=
��' (
$num
��) +
;
��+ ,
public
�� 
const
�� 
int
�� 
KEY_CODE_REC
�� %
=
��& '
$num
��( *
;
��* +
public
�� 
const
�� 
int
�� 
KEY_CODE_PAN
�� %
=
��& '
$num
��( *
;
��* +
public
�� 
const
�� 
int
�� 

KEY_CODE_M
�� #
=
��$ %
$num
��& (
;
��( )
public
�� 
const
�� 
int
�� 

KEY_CODE_A
�� #
=
��$ %
$num
��& (
;
��( )
public
�� 
const
�� 
int
�� 
KEY_CODE_F1
�� $
=
��% &
$num
��' )
;
��) *
public
�� 
const
�� 
int
�� 
KEY_CODE_F2
�� $
=
��% &
$num
��' )
;
��) *
public
�� 
const
�� 
int
�� 
KEY_PTZ_UP_START
�� )
=
��* +
KEY_CODE_UP
��, 7
;
��7 8
public
�� 
const
�� 
int
�� 
KEY_PTZ_UP_STOP
�� (
=
��) *
$num
��+ -
;
��- .
public
�� 
const
�� 
int
��  
KEY_PTZ_DOWN_START
�� +
=
��, -

��. ;
;
��; <
public
�� 
const
�� 
int
�� 
KEY_PTZ_DOWN_STOP
�� *
=
��+ ,
$num
��- /
;
��/ 0
public
�� 
const
�� 
int
��  
KEY_PTZ_LEFT_START
�� +
=
��, -

��. ;
;
��; <
public
�� 
const
�� 
int
�� 
KEY_PTZ_LEFT_STOP
�� *
=
��+ ,
$num
��- /
;
��/ 0
public
�� 
const
�� 
int
�� !
KEY_PTZ_RIGHT_START
�� ,
=
��- .
KEY_CODE_RIGHT
��/ =
;
��= >
public
�� 
const
�� 
int
��  
KEY_PTZ_RIGHT_STOP
�� +
=
��, -
$num
��. 0
;
��0 1
public
�� 
const
�� 
int
�� 
KEY_PTZ_AP1_START
�� *
=
��+ ,

��- :
;
��: ;
public
�� 
const
�� 
int
�� 
KEY_PTZ_AP1_STOP
�� )
=
��* +
$num
��, .
;
��. /
public
�� 
const
�� 
int
�� 
KEY_PTZ_AP2_START
�� *
=
��+ ,
KEY_CODE_PAN
��- 9
;
��9 :
public
�� 
const
�� 
int
�� 
KEY_PTZ_AP2_STOP
�� )
=
��* +
$num
��, .
;
��. /
public
�� 
const
�� 
int
�� "
KEY_PTZ_FOCUS1_START
�� -
=
��. /

KEY_CODE_A
��0 :
;
��: ;
public
�� 
const
�� 
int
�� !
KEY_PTZ_FOCUS1_STOP
�� ,
=
��- .
$num
��/ 1
;
��1 2
public
�� 
const
�� 
int
�� "
KEY_PTZ_FOCUS2_START
�� -
=
��. /

KEY_CODE_M
��0 :
;
��: ;
public
�� 
const
�� 
int
�� !
KEY_PTZ_FOCUS2_STOP
�� ,
=
��- .
$num
��/ 1
;
��1 2
public
�� 
const
�� 
int
�� 
KEY_PTZ_B1_START
�� )
=
��* +
$num
��, .
;
��. /
public
�� 
const
�� 
int
�� 
KEY_PTZ_B1_STOP
�� (
=
��) *
$num
��+ -
;
��- .
public
�� 
const
�� 
int
�� 
KEY_PTZ_B2_START
�� )
=
��* +
$num
��, .
;
��. /
public
�� 
const
�� 
int
�� 
KEY_PTZ_B2_STOP
�� (
=
��) *
$num
��+ -
;
��- .
public
�� 
const
�� 
int
�� 
KEY_CODE_11
�� $
=
��% &
$num
��' )
;
��) *
public
�� 
const
�� 
int
�� 
KEY_CODE_12
�� $
=
��% &
$num
��' )
;
��) *
public
�� 
const
�� 
int
�� 
KEY_CODE_13
�� $
=
��% &
$num
��' )
;
��) *
public
�� 
const
�� 
int
�� 
KEY_CODE_14
�� $
=
��% &
$num
��' )
;
��) *
public
�� 
const
�� 
int
�� 
KEY_CODE_15
�� $
=
��% &
$num
��' )
;
��) *
public
�� 
const
�� 
int
�� 
KEY_CODE_16
�� $
=
��% &
$num
��' )
;
��) *
public
�� 
const
�� 
int
�� #
NET_DVR_GET_DEVICECFG
�� .
=
��/ 0
$num
��1 4
;
��4 5
public
�� 
const
�� 
int
�� #
NET_DVR_SET_DEVICECFG
�� .
=
��/ 0
$num
��1 4
;
��4 5
public
�� 
const
�� 
int
��  
NET_DVR_GET_NETCFG
�� +
=
��, -
$num
��. 1
;
��1 2
public
�� 
const
�� 
int
��  
NET_DVR_SET_NETCFG
�� +
=
��, -
$num
��. 1
;
��1 2
public
�� 
const
�� 
int
��  
NET_DVR_GET_PICCFG
�� +
=
��, -
$num
��. 1
;
��1 2
public
�� 
const
�� 
int
��  
NET_DVR_SET_PICCFG
�� +
=
��, -
$num
��. 1
;
��1 2
public
�� 
const
�� 
int
�� %
NET_DVR_GET_COMPRESSCFG
�� 0
=
��1 2
$num
��3 6
;
��6 7
public
�� 
const
�� 
int
�� %
NET_DVR_SET_COMPRESSCFG
�� 0
=
��1 2
$num
��3 6
;
��6 7
public
�� 
const
�� 
int
�� #
NET_DVR_GET_RECORDCFG
�� .
=
��/ 0
$num
��1 4
;
��4 5
public
�� 
const
�� 
int
�� #
NET_DVR_SET_RECORDCFG
�� .
=
��/ 0
$num
��1 4
;
��4 5
public
�� 
const
�� 
int
�� $
NET_DVR_GET_DECODERCFG
�� /
=
��0 1
$num
��2 5
;
��5 6
public
�� 
const
�� 
int
�� $
NET_DVR_SET_DECODERCFG
�� /
=
��0 1
$num
��2 5
;
��5 6
public
�� 
const
�� 
int
�� "
NET_DVR_GET_RS232CFG
�� -
=
��. /
$num
��0 3
;
��3 4
public
�� 
const
�� 
int
�� "
NET_DVR_SET_RS232CFG
�� -
=
��. /
$num
��0 3
;
��3 4
public
�� 
const
�� 
int
�� $
NET_DVR_GET_ALARMINCFG
�� /
=
��0 1
$num
��2 5
;
��5 6
public
�� 
const
�� 
int
�� $
NET_DVR_SET_ALARMINCFG
�� /
=
��0 1
$num
��2 5
;
��5 6
public
�� 
const
�� 
int
�� %
NET_DVR_GET_ALARMOUTCFG
�� 0
=
��1 2
$num
��3 6
;
��6 7
public
�� 
const
�� 
int
�� %
NET_DVR_SET_ALARMOUTCFG
�� 0
=
��1 2
$num
��3 6
;
��6 7
public
�� 
const
�� 
int
�� !
NET_DVR_GET_TIMECFG
�� ,
=
��- .
$num
��/ 2
;
��2 3
public
�� 
const
�� 
int
�� !
NET_DVR_SET_TIMECFG
�� ,
=
��- .
$num
��/ 2
;
��2 3
public
�� 
const
�� 
int
�� $
NET_DVR_GET_PREVIEWCFG
�� /
=
��0 1
$num
��2 5
;
��5 6
public
�� 
const
�� 
int
�� $
NET_DVR_SET_PREVIEWCFG
�� /
=
��0 1
$num
��2 5
;
��5 6
public
�� 
const
�� 
int
�� %
NET_DVR_GET_VIDEOOUTCFG
�� 0
=
��1 2
$num
��3 6
;
��6 7
public
�� 
const
�� 
int
�� %
NET_DVR_SET_VIDEOOUTCFG
�� 0
=
��1 2
$num
��3 6
;
��6 7
public
�� 
const
�� 
int
�� !
NET_DVR_GET_USERCFG
�� ,
=
��- .
$num
��/ 2
;
��2 3
public
�� 
const
�� 
int
�� !
NET_DVR_SET_USERCFG
�� ,
=
��- .
$num
��/ 2
;
��2 3
public
�� 
const
�� 
int
�� &
NET_DVR_GET_EXCEPTIONCFG
�� 1
=
��2 3
$num
��4 7
;
��7 8
public
�� 
const
�� 
int
�� &
NET_DVR_SET_EXCEPTIONCFG
�� 1
=
��2 3
$num
��4 7
;
��7 8
public
�� 
const
�� 
int
�� $
NET_DVR_GET_ZONEANDDST
�� /
=
��0 1
$num
��2 5
;
��5 6
public
�� 
const
�� 
int
�� $
NET_DVR_SET_ZONEANDDST
�� /
=
��0 1
$num
��2 5
;
��5 6
public
�� 
const
�� 
int
�� $
NET_DVR_GET_SHOWSTRING
�� /
=
��0 1
$num
��2 5
;
��5 6
public
�� 
const
�� 
int
�� $
NET_DVR_SET_SHOWSTRING
�� /
=
��0 1
$num
��2 5
;
��5 6
public
�� 
const
�� 
int
�� &
NET_DVR_GET_EVENTCOMPCFG
�� 1
=
��2 3
$num
��4 7
;
��7 8
public
�� 
const
�� 
int
�� &
NET_DVR_SET_EVENTCOMPCFG
�� 1
=
��2 3
$num
��4 7
;
��7 8
public
�� 
const
�� 
int
�� #
NET_DVR_GET_AUXOUTCFG
�� .
=
��/ 0
$num
��1 4
;
��4 5
public
�� 
const
�� 
int
�� #
NET_DVR_SET_AUXOUTCFG
�� .
=
��/ 0
$num
��1 4
;
��4 5
public
�� 
const
�� 
int
�� (
NET_DVR_GET_PREVIEWCFG_AUX
�� 3
=
��4 5
$num
��6 9
;
��9 :
public
�� 
const
�� 
int
�� (
NET_DVR_SET_PREVIEWCFG_AUX
�� 3
=
��4 5
$num
��6 9
;
��9 :
public
�� 
const
�� 
int
�� #
NET_DVR_GET_PICCFG_EX
�� .
=
��/ 0
$num
��1 4
;
��4 5
public
�� 
const
�� 
int
�� #
NET_DVR_SET_PICCFG_EX
�� .
=
��/ 0
$num
��1 4
;
��4 5
public
�� 
const
�� 
int
�� $
NET_DVR_GET_USERCFG_EX
�� /
=
��0 1
$num
��2 5
;
��5 6
public
�� 
const
�� 
int
�� $
NET_DVR_SET_USERCFG_EX
�� /
=
��0 1
$num
��2 5
;
��5 6
public
�� 
const
�� 
int
�� (
NET_DVR_GET_COMPRESSCFG_EX
�� 3
=
��4 5
$num
��6 9
;
��9 :
public
�� 
const
�� 
int
�� (
NET_DVR_SET_COMPRESSCFG_EX
�� 3
=
��4 5
$num
��6 9
;
��9 :
public
�� 
const
�� 
int
�� #
NET_DVR_GET_NETAPPCFG
�� .
=
��/ 0
$num
��1 4
;
��4 5
public
�� 
const
�� 
int
�� #
NET_DVR_SET_NETAPPCFG
�� .
=
��/ 0
$num
��1 4
;
��4 5
public
�� 
const
�� 
int
��  
NET_DVR_GET_NTPCFG
�� +
=
��, -
$num
��. 1
;
��1 2
public
�� 
const
�� 
int
��  
NET_DVR_SET_NTPCFG
�� +
=
��, -
$num
��. 1
;
��1 2
public
�� 
const
�� 
int
�� !
NET_DVR_GET_DDNSCFG
�� ,
=
��- .
$num
��/ 2
;
��2 3
public
�� 
const
�� 
int
�� !
NET_DVR_SET_DDNSCFG
�� ,
=
��- .
$num
��/ 2
;
��2 3
public
�� 
const
�� 
int
�� "
NET_DVR_GET_EMAILCFG
�� -
=
��. /
$num
��0 3
;
��3 4
public
�� 
const
�� 
int
�� "
NET_DVR_SET_EMAILCFG
�� -
=
��. /
$num
��0 3
;
��3 4
public
�� 
const
�� 
int
��  
NET_DVR_GET_NFSCFG
�� +
=
��, -
$num
��. 1
;
��1 2
public
�� 
const
�� 
int
��  
NET_DVR_SET_NFSCFG
�� +
=
��, -
$num
��. 1
;
��1 2
public
�� 
const
�� 
int
�� '
NET_DVR_GET_SHOWSTRING_EX
�� 2
=
��3 4
$num
��5 8
;
��8 9
public
�� 
const
�� 
int
�� '
NET_DVR_SET_SHOWSTRING_EX
�� 2
=
��3 4
$num
��5 8
;
��8 9
public
�� 
const
�� 
int
�� &
NET_DVR_GET_NETCFG_OTHER
�� 1
=
��2 3
$num
��4 7
;
��7 8
public
�� 
const
�� 
int
�� &
NET_DVR_SET_NETCFG_OTHER
�� 1
=
��2 3
$num
��4 7
;
��7 8
public
�� 
const
�� 
int
�� &
NET_DVR_GET_EMAILPARACFG
�� 1
=
��2 3
$num
��4 7
;
��7 8
public
�� 
const
�� 
int
�� &
NET_DVR_SET_EMAILPARACFG
�� 1
=
��2 3
$num
��4 7
;
��7 8
public
�� 
const
�� 
int
�� $
NET_DVR_GET_DDNSCFG_EX
�� /
=
��0 1
$num
��2 5
;
��5 6
public
�� 
const
�� 
int
�� $
NET_DVR_SET_DDNSCFG_EX
�� /
=
��0 1
$num
��2 5
;
��5 6
public
�� 
const
�� 
int
��  
NET_DVR_SET_PTZPOS
�� +
=
��, -
$num
��. 1
;
��1 2
public
�� 
const
�� 
int
��  
NET_DVR_GET_PTZPOS
�� +
=
��, -
$num
��. 1
;
��1 2
public
�� 
const
�� 
int
�� "
NET_DVR_GET_PTZSCOPE
�� -
=
��. /
$num
��0 3
;
��3 4
public
�� 
const
�� 
int
�� &
NET_DVR_GET_AP_INFO_LIST
�� 1
=
��2 3
$num
��4 7
;
��7 8
public
�� 
const
�� 
int
�� "
NET_DVR_SET_WIFI_CFG
�� -
=
��. /
$num
��0 3
;
��3 4
public
�� 
const
�� 
int
�� "
NET_DVR_GET_WIFI_CFG
�� -
=
��. /
$num
��0 3
;
��3 4
public
�� 
const
�� 
int
�� '
NET_DVR_SET_WIFI_WORKMODE
�� 2
=
��3 4
$num
��5 8
;
��8 9
public
�� 
const
�� 
int
�� '
NET_DVR_GET_WIFI_WORKMODE
�� 2
=
��3 4
$num
��5 8
;
��8 9
public
�� 
const
�� 
int
�� %
NET_DVR_GET_WIFI_STATUS
�� 0
=
��1 2
$num
��3 6
;
��6 7
public
�� 
const
�� 
int
�� $
NET_DVR_GET_NETCFG_V30
�� /
=
��0 1
$num
��2 6
;
��6 7
public
�� 
const
�� 
int
�� $
NET_DVR_SET_NETCFG_V30
�� /
=
��0 1
$num
��2 6
;
��6 7
public
�� 
const
�� 
int
�� $
NET_DVR_GET_PICCFG_V30
�� /
=
��0 1
$num
��2 6
;
��6 7
public
�� 
const
�� 
int
�� $
NET_DVR_SET_PICCFG_V30
�� /
=
��0 1
$num
��2 6
;
��6 7
public
�� 
const
�� 
int
�� '
NET_DVR_GET_RECORDCFG_V30
�� 2
=
��3 4
$num
��5 9
;
��9 :
public
�� 
const
�� 
int
�� '
NET_DVR_SET_RECORDCFG_V30
�� 2
=
��3 4
$num
��5 9
;
��9 :
public
�� 
const
�� 
int
�� %
NET_DVR_GET_USERCFG_V30
�� 0
=
��1 2
$num
��3 7
;
��7 8
public
�� 
const
�� 
int
�� %
NET_DVR_SET_USERCFG_V30
�� 0
=
��1 2
$num
��3 7
;
��7 8
public
�� 
const
�� 
int
�� %
NET_DVR_GET_DDNSCFG_V30
�� 0
=
��1 2
$num
��3 7
;
��7 8
public
�� 
const
�� 
int
�� %
NET_DVR_SET_DDNSCFG_V30
�� 0
=
��1 2
$num
��3 7
;
��7 8
public
�� 
const
�� 
int
�� &
NET_DVR_GET_EMAILCFG_V30
�� 1
=
��2 3
$num
��4 8
;
��8 9
public
�� 
const
�� 
int
�� &
NET_DVR_SET_EMAILCFG_V30
�� 1
=
��2 3
$num
��4 8
;
��8 9
public
�� 
const
�� 
int
��  
NET_DVR_GET_CRUISE
�� +
=
��, -
$num
��. 2
;
��2 3
public
�� 
const
�� 
int
��  
NET_DVR_SET_CRUISE
�� +
=
��, -
$num
��. 2
;
��2 3
public
�� 
const
�� 
int
�� (
NET_DVR_GET_ALARMINCFG_V30
�� 3
=
��4 5
$num
��6 :
;
��: ;
public
�� 
const
�� 
int
�� (
NET_DVR_SET_ALARMINCFG_V30
�� 3
=
��4 5
$num
��6 :
;
��: ;
public
�� 
const
�� 
int
�� )
NET_DVR_GET_ALARMOUTCFG_V30
�� 4
=
��5 6
$num
��7 ;
;
��; <
public
�� 
const
�� 
int
�� )
NET_DVR_SET_ALARMOUTCFG_V30
�� 4
=
��5 6
$num
��7 ;
;
��; <
public
�� 
const
�� 
int
�� )
NET_DVR_GET_VIDEOOUTCFG_V30
�� 4
=
��5 6
$num
��7 ;
;
��; <
public
�� 
const
�� 
int
�� )
NET_DVR_SET_VIDEOOUTCFG_V30
�� 4
=
��5 6
$num
��7 ;
;
��; <
public
�� 
const
�� 
int
�� (
NET_DVR_GET_SHOWSTRING_V30
�� 3
=
��4 5
$num
��6 :
;
��: ;
public
�� 
const
�� 
int
�� (
NET_DVR_SET_SHOWSTRING_V30
�� 3
=
��4 5
$num
��6 :
;
��: ;
public
�� 
const
�� 
int
�� *
NET_DVR_GET_EXCEPTIONCFG_V30
�� 5
=
��6 7
$num
��8 <
;
��< =
public
�� 
const
�� 
int
�� *
NET_DVR_SET_EXCEPTIONCFG_V30
�� 5
=
��6 7
$num
��8 <
;
��< =
public
�� 
const
�� 
int
�� &
NET_DVR_GET_RS232CFG_V30
�� 1
=
��2 3
$num
��4 8
;
��8 9
public
�� 
const
�� 
int
�� &
NET_DVR_SET_RS232CFG_V30
�� 1
=
��2 3
$num
��4 8
;
��8 9
public
�� 
const
�� 
int
�� %
NET_DVR_GET_NET_DISKCFG
�� 0
=
��1 2
$num
��3 7
;
��7 8
public
�� 
const
�� 
int
�� %
NET_DVR_SET_NET_DISKCFG
�� 0
=
��1 2
$num
��3 7
;
��7 8
public
�� 
const
�� 
int
�� )
NET_DVR_GET_COMPRESSCFG_V30
�� 4
=
��5 6
$num
��7 ;
;
��; <
public
�� 
const
�� 
int
�� )
NET_DVR_SET_COMPRESSCFG_V30
�� 4
=
��5 6
$num
��7 ;
;
��; <
public
�� 
const
�� 
int
�� (
NET_DVR_GET_DECODERCFG_V30
�� 3
=
��4 5
$num
��6 :
;
��: ;
public
�� 
const
�� 
int
�� (
NET_DVR_SET_DECODERCFG_V30
�� 3
=
��4 5
$num
��6 :
;
��: ;
public
�� 
const
�� 
int
�� (
NET_DVR_GET_PREVIEWCFG_V30
�� 3
=
��4 5
$num
��6 :
;
��: ;
public
�� 
const
�� 
int
�� (
NET_DVR_SET_PREVIEWCFG_V30
�� 3
=
��4 5
$num
��6 :
;
��: ;
public
�� 
const
�� 
int
�� ,
NET_DVR_GET_PREVIEWCFG_AUX_V30
�� 7
=
��8 9
$num
��: >
;
��> ?
public
�� 
const
�� 
int
�� ,
NET_DVR_SET_PREVIEWCFG_AUX_V30
�� 7
=
��8 9
$num
��: >
;
��> ?
public
�� 
const
�� 
int
�� #
NET_DVR_GET_IPPARACFG
�� .
=
��/ 0
$num
��1 5
;
��5 6
public
�� 
const
�� 
int
�� #
NET_DVR_SET_IPPARACFG
�� .
=
��/ 0
$num
��1 5
;
��5 6
public
�� 
const
�� 
int
�� '
NET_DVR_GET_IPPARACFG_V40
�� 2
=
��3 4
$num
��5 9
;
��9 :
public
�� 
const
�� 
int
�� '
NET_DVR_SET_IPPARACFG_V40
�� 2
=
��3 4
$num
��5 9
;
��9 :
public
�� 
const
�� 
int
�� &
NET_DVR_GET_IPALARMINCFG
�� 1
=
��2 3
$num
��4 8
;
��8 9
public
�� 
const
�� 
int
�� &
NET_DVR_SET_IPALARMINCFG
�� 1
=
��2 3
$num
��4 8
;
��8 9
public
�� 
const
�� 
int
�� '
NET_DVR_GET_IPALARMOUTCFG
�� 2
=
��3 4
$num
��5 9
;
��9 :
public
�� 
const
�� 
int
�� '
NET_DVR_SET_IPALARMOUTCFG
�� 2
=
��3 4
$num
��5 9
;
��9 :
public
�� 
const
�� 
int
�� 
NET_DVR_GET_HDCFG
�� *
=
��+ ,
$num
��- 1
;
��1 2
public
�� 
const
�� 
int
�� 
NET_DVR_SET_HDCFG
�� *
=
��+ ,
$num
��- 1
;
��1 2
public
�� 
const
�� 
int
�� %
NET_DVR_GET_HDGROUP_CFG
�� 0
=
��1 2
$num
��3 7
;
��7 8
public
�� 
const
�� 
int
�� %
NET_DVR_SET_HDGROUP_CFG
�� 0
=
��1 2
$num
��3 7
;
��7 8
public
�� 
const
�� 
int
�� )
NET_DVR_GET_COMPRESSCFG_AUD
�� 4
=
��5 6
$num
��7 ;
;
��; <
public
�� 
const
�� 
int
�� )
NET_DVR_SET_COMPRESSCFG_AUD
�� 4
=
��5 6
$num
��7 ;
;
��; <
public
�� 
const
�� 
int
�� '
NET_DVR_GET_IPPARACFG_V31
�� 2
=
��3 4
$num
��5 9
;
��9 :
public
�� 
const
�� 
int
�� '
NET_DVR_SET_IPPARACFG_V31
�� 2
=
��3 4
$num
��5 9
;
��9 :
public
�� 
const
�� 
int
�� '
NET_DVR_GET_DEVICECFG_V40
�� 2
=
��3 4
$num
��5 9
;
��9 :
public
�� 
const
�� 
int
�� '
NET_DVR_SET_DEVICECFG_V40
�� 2
=
��3 4
$num
��5 9
;
��9 :
public
�� 
const
�� 
int
�� &
NET_DVR_GET_NETCFG_MULTI
�� 1
=
��2 3
$num
��4 8
;
��8 9
public
�� 
const
�� 
int
�� &
NET_DVR_SET_NETCFG_MULTI
�� 1
=
��2 3
$num
��4 8
;
��8 9
public
�� 
const
�� 
int
�� )
NET_DVR_GET_NETWORK_BONDING
�� 4
=
��5 6
$num
��7 ;
;
��; <
public
�� 
const
�� 
int
�� )
NET_DVR_SET_NETWORK_BONDING
�� 4
=
��5 6
$num
��7 ;
;
��; <
public
�� 
const
�� 
int
�� !
NET_DVR_GET_NAT_CFG
�� ,
=
��- .
$num
��/ 3
;
��3 4
public
�� 
const
�� 
int
�� !
NET_DVR_SET_NAT_CFG
�� ,
=
��- .
$num
��/ 3
;
��3 4
public
�� 
const
�� 
int
�� 
MAJOR_ALARM
�� $
=
��% &
$num
��' (
;
��( )
public
�� 
const
�� 
int
�� 
MINOR_ALARM_IN
�� '
=
��( )
$num
��* +
;
��+ ,
public
�� 
const
�� 
int
�� 
MINOR_ALARM_OUT
�� (
=
��) *
$num
��+ ,
;
��, -
public
�� 
const
�� 
int
��  
MINOR_MOTDET_START
�� +
=
��, -
$num
��. /
;
��/ 0
public
�� 
const
�� 
int
�� 
MINOR_MOTDET_STOP
�� *
=
��+ ,
$num
��- .
;
��. /
public
�� 
const
�� 
int
�� $
MINOR_HIDE_ALARM_START
�� /
=
��0 1
$num
��2 3
;
��3 4
public
�� 
const
�� 
int
�� #
MINOR_HIDE_ALARM_STOP
�� .
=
��/ 0
$num
��1 2
;
��2 3
public
�� 
const
�� 
int
�� #
MINOR_VCA_ALARM_START
�� .
=
��/ 0
$num
��1 2
;
��2 3
public
�� 
const
�� 
int
�� "
MINOR_VCA_ALARM_STOP
�� -
=
��. /
$num
��0 1
;
��1 2
public
�� 
const
�� 
int
�� 
MAJOR_EXCEPTION
�� (
=
��) *
$num
��+ ,
;
��, -
public
�� 
const
�� 
int
�� 

�� &
=
��' (
$num
��) +
;
��+ ,
public
�� 
const
�� 
int
�� "
MINOR_ILLEGAL_ACCESS
�� -
=
��. /
$num
��0 2
;
��2 3
public
�� 
const
�� 
int
�� 

�� &
=
��' (
$num
��) +
;
��+ ,
public
�� 
const
�� 
int
�� 
MINOR_HD_ERROR
�� '
=
��( )
$num
��* ,
;
��, -
public
�� 
const
�� 
int
�� 
MINOR_DCD_LOST
�� '
=
��( )
$num
��* ,
;
��, -
public
�� 
const
�� 
int
�� 
MINOR_IP_CONFLICT
�� *
=
��+ ,
$num
��- /
;
��/ 0
public
�� 
const
�� 
int
�� 
MINOR_NET_BROKEN
�� )
=
��* +
$num
��, .
;
��. /
public
�� 
const
�� 
int
�� 
MINOR_REC_ERROR
�� (
=
��) *
$num
��+ -
;
��- .
public
�� 
const
�� 
int
�� 
MINOR_IPC_NO_LINK
�� *
=
��+ ,
$num
��- /
;
��/ 0
public
�� 
const
�� 
int
��  
MINOR_VI_EXCEPTION
�� +
=
��, -
$num
��. 0
;
��0 1
public
�� 
const
�� 
int
�� #
MINOR_IPC_IP_CONFLICT
�� .
=
��/ 0
$num
��1 3
;
��3 4
public
�� 
const
�� 
int
�� 
MINOR_FANABNORMAL
�� *
=
��+ ,
$num
��- /
;
��/ 0
public
�� 
const
�� 
int
�� 
MINOR_FANRESUME
�� (
=
��) *
$num
��+ -
;
��- .
public
�� 
const
�� 
int
�� ,
MINOR_SUBSYSTEM_ABNORMALREBOOT
�� 7
=
��8 9
$num
��: <
;
��< =
public
�� 
const
�� 
int
�� &
MINOR_MATRIX_STARTBUZZER
�� 1
=
��2 3
$num
��4 6
;
��6 7
public
�� 
const
�� 
int
�� 
MAJOR_OPERATION
�� (
=
��) *
$num
��+ ,
;
��, -
public
�� 
const
�� 
int
�� 
MINOR_START_DVR
�� (
=
��) *
$num
��+ -
;
��- .
public
�� 
const
�� 
int
�� 
MINOR_STOP_DVR
�� '
=
��( )
$num
��* ,
;
��, -
public
�� 
const
�� 
int
�� !
MINOR_STOP_ABNORMAL
�� ,
=
��- .
$num
��/ 1
;
��1 2
public
�� 
const
�� 
int
�� 
MINOR_REBOOT_DVR
�� )
=
��* +
$num
��, .
;
��. /
public
�� 
const
�� 
int
�� 
MINOR_LOCAL_LOGIN
�� *
=
��+ ,
$num
��- /
;
��/ 0
public
�� 
const
�� 
int
��  
MINOR_LOCAL_LOGOUT
�� +
=
��, -
$num
��. 0
;
��0 1
public
�� 
const
�� 
int
�� "
MINOR_LOCAL_CFG_PARM
�� -
=
��. /
$num
��0 2
;
��2 3
public
�� 
const
�� 
int
�� $
MINOR_LOCAL_PLAYBYFILE
�� /
=
��0 1
$num
��2 4
;
��4 5
public
�� 
const
�� 
int
�� $
MINOR_LOCAL_PLAYBYTIME
�� /
=
��0 1
$num
��2 4
;
��4 5
public
�� 
const
�� 
int
�� #
MINOR_LOCAL_START_REC
�� .
=
��/ 0
$num
��1 3
;
��3 4
public
�� 
const
�� 
int
�� "
MINOR_LOCAL_STOP_REC
�� -
=
��. /
$num
��0 2
;
��2 3
public
�� 
const
�� 
int
�� !
MINOR_LOCAL_PTZCTRL
�� ,
=
��- .
$num
��/ 1
;
��1 2
public
�� 
const
�� 
int
�� !
MINOR_LOCAL_PREVIEW
�� ,
=
��- .
$num
��/ 1
;
��1 2
public
�� 
const
�� 
int
�� %
MINOR_LOCAL_MODIFY_TIME
�� 0
=
��1 2
$num
��3 5
;
��5 6
public
�� 
const
�� 
int
�� !
MINOR_LOCAL_UPGRADE
�� ,
=
��- .
$num
��/ 1
;
��1 2
public
�� 
const
�� 
int
�� (
MINOR_LOCAL_RECFILE_OUTPUT
�� 3
=
��4 5
$num
��6 8
;
��8 9
public
�� 
const
�� 
int
�� $
MINOR_LOCAL_FORMAT_HDD
�� /
=
��0 1
$num
��2 4
;
��4 5
public
�� 
const
�� 
int
�� (
MINOR_LOCAL_CFGFILE_OUTPUT
�� 3
=
��4 5
$num
��6 8
;
��8 9
public
�� 
const
�� 
int
�� '
MINOR_LOCAL_CFGFILE_INPUT
�� 2
=
��3 4
$num
��5 7
;
��7 8
public
�� 
const
�� 
int
�� "
MINOR_LOCAL_COPYFILE
�� -
=
��. /
$num
��0 2
;
��2 3
public
�� 
const
�� 
int
�� "
MINOR_LOCAL_LOCKFILE
�� -
=
��. /
$num
��0 2
;
��2 3
public
�� 
const
�� 
int
�� $
MINOR_LOCAL_UNLOCKFILE
�� /
=
��0 1
$num
��2 4
;
��4 5
public
�� 
const
�� 
int
�� #
MINOR_LOCAL_DVR_ALARM
�� .
=
��/ 0
$num
��1 3
;
��3 4
public
�� 
const
�� 
int
�� 

�� &
=
��' (
$num
��) +
;
��+ ,
public
�� 
const
�� 
int
�� 

�� &
=
��' (
$num
��) ,
;
��, -
public
�� 
const
�� 
int
�� 

�� &
=
��' (
$num
��) ,
;
��, -
public
�� 
const
�� 
int
�� &
MINOR_LOCAL_START_BACKUP
�� 1
=
��2 3
$num
��4 7
;
��7 8
public
�� 
const
�� 
int
�� %
MINOR_LOCAL_STOP_BACKUP
�� 0
=
��1 2
$num
��3 6
;
��6 7
public
�� 
const
�� 
int
�� -
MINOR_LOCAL_COPYFILE_START_TIME
�� 8
=
��9 :
$num
��; >
;
��> ?
public
�� 
const
�� 
int
�� +
MINOR_LOCAL_COPYFILE_END_TIME
�� 6
=
��7 8
$num
��9 <
;
��< =
public
�� 
const
�� 
int
�� !
MINOR_LOCAL_ADD_NAS
�� ,
=
��- .
$num
��/ 2
;
��2 3
public
�� 
const
�� 
int
�� !
MINOR_LOCAL_DEL_NAS
�� ,
=
��- .
$num
��/ 2
;
��2 3
public
�� 
const
�� 
int
�� !
MINOR_LOCAL_SET_NAS
�� ,
=
��- .
$num
��/ 2
;
��2 3
public
�� 
const
�� 
int
��  
MINOR_REMOTE_LOGIN
�� +
=
��, -
$num
��. 1
;
��1 2
public
�� 
const
�� 
int
�� !
MINOR_REMOTE_LOGOUT
�� ,
=
��- .
$num
��/ 2
;
��2 3
public
�� 
const
�� 
int
�� $
MINOR_REMOTE_START_REC
�� /
=
��0 1
$num
��2 5
;
��5 6
public
�� 
const
�� 
int
�� #
MINOR_REMOTE_STOP_REC
�� .
=
��/ 0
$num
��1 4
;
��4 5
public
�� 
const
�� 
int
�� $
MINOR_START_TRANS_CHAN
�� /
=
��0 1
$num
��2 5
;
��5 6
public
�� 
const
�� 
int
�� #
MINOR_STOP_TRANS_CHAN
�� .
=
��/ 0
$num
��1 4
;
��4 5
public
�� 
const
�� 
int
�� #
MINOR_REMOTE_GET_PARM
�� .
=
��/ 0
$num
��1 4
;
��4 5
public
�� 
const
�� 
int
�� #
MINOR_REMOTE_CFG_PARM
�� .
=
��/ 0
$num
��1 4
;
��4 5
public
�� 
const
�� 
int
�� %
MINOR_REMOTE_GET_STATUS
�� 0
=
��1 2
$num
��3 6
;
��6 7
public
�� 
const
�� 
int
�� 
MINOR_REMOTE_ARM
�� )
=
��* +
$num
��, /
;
��/ 0
public
�� 
const
�� 
int
�� !
MINOR_REMOTE_DISARM
�� ,
=
��- .
$num
��/ 2
;
��2 3
public
�� 
const
�� 
int
�� !
MINOR_REMOTE_REBOOT
�� ,
=
��- .
$num
��/ 2
;
��2 3
public
�� 
const
�� 
int
�� 
MINOR_START_VT
�� '
=
��( )
$num
��* -
;
��- .
public
�� 
const
�� 
int
�� 

�� &
=
��' (
$num
��) ,
;
��, -
public
�� 
const
�� 
int
�� "
MINOR_REMOTE_UPGRADE
�� -
=
��. /
$num
��0 3
;
��3 4
public
�� 
const
�� 
int
�� %
MINOR_REMOTE_PLAYBYFILE
�� 0
=
��1 2
$num
��3 6
;
��6 7
public
�� 
const
�� 
int
�� %
MINOR_REMOTE_PLAYBYTIME
�� 0
=
��1 2
$num
��3 6
;
��6 7
public
�� 
const
�� 
int
�� "
MINOR_REMOTE_PTZCTRL
�� -
=
��. /
$num
��0 3
;
��3 4
public
�� 
const
�� 
int
�� %
MINOR_REMOTE_FORMAT_HDD
�� 0
=
��1 2
$num
��3 6
;
��6 7
public
�� 
const
�� 
int
�� 
MINOR_REMOTE_STOP
�� *
=
��+ ,
$num
��- 0
;
��0 1
public
�� 
const
�� 
int
�� #
MINOR_REMOTE_LOCKFILE
�� .
=
��/ 0
$num
��1 4
;
��4 5
public
�� 
const
�� 
int
�� %
MINOR_REMOTE_UNLOCKFILE
�� 0
=
��1 2
$num
��3 6
;
��6 7
public
�� 
const
�� 
int
�� )
MINOR_REMOTE_CFGFILE_OUTPUT
�� 4
=
��5 6
$num
��7 :
;
��: ;
public
�� 
const
�� 
int
�� )
MINOR_REMOTE_CFGFILE_INTPUT
�� 4
=
��5 6
$num
��7 :
;
��: ;
public
�� 
const
�� 
int
�� )
MINOR_REMOTE_RECFILE_OUTPUT
�� 4
=
��5 6
$num
��7 :
;
��: ;
public
�� 
const
�� 
int
�� $
MINOR_REMOTE_DVR_ALARM
�� /
=
��0 1
$num
��2 5
;
��5 6
public
�� 
const
�� 
int
�� "
MINOR_REMOTE_IPC_ADD
�� -
=
��. /
$num
��0 3
;
��3 4
public
�� 
const
�� 
int
�� "
MINOR_REMOTE_IPC_DEL
�� -
=
��. /
$num
��0 3
;
��3 4
public
�� 
const
�� 
int
�� "
MINOR_REMOTE_IPC_SET
�� -
=
��. /
$num
��0 3
;
��3 4
public
�� 
const
�� 
int
�� "
MINOR_REBOOT_VCA_LIB
�� -
=
��. /
$num
��0 3
;
��3 4
public
�� 
const
�� 
int
�� "
MINOR_REMOTE_ADD_NAS
�� -
=
��. /
$num
��0 3
;
��3 4
public
�� 
const
�� 
int
�� "
MINOR_REMOTE_DEL_NAS
�� -
=
��. /
$num
��0 3
;
��3 4
public
�� 
const
�� 
int
�� "
MINOR_REMOTE_SET_NAS
�� -
=
��. /
$num
��0 3
;
��3 4
public
�� 
const
�� 
int
�� #
MINOR_SUBSYSTEMREBOOT
�� .
=
��/ 0
$num
��1 4
;
��4 5
public
�� 
const
�� 
int
�� -
MINOR_MATRIX_STARTTRANSFERVIDEO
�� 8
=
��9 :
$num
��; >
;
��> ?
public
�� 
const
�� 
int
�� ,
MINOR_MATRIX_STOPTRANSFERVIDEO
�� 7
=
��8 9
$num
��: =
;
��= >
public
�� 
const
�� 
int
�� +
MINOR_REMOTE_SET_ALLSUBSYSTEM
�� 6
=
��7 8
$num
��9 <
;
��< =
public
�� 
const
�� 
int
�� +
MINOR_REMOTE_GET_ALLSUBSYSTEM
�� 6
=
��7 8
$num
��9 <
;
��< =
public
�� 
const
�� 
int
�� (
MINOR_REMOTE_SET_PLANARRAY
�� 3
=
��4 5
$num
��6 9
;
��9 :
public
�� 
const
�� 
int
�� (
MINOR_REMOTE_GET_PLANARRAY
�� 3
=
��4 5
$num
��6 9
;
��9 :
public
�� 
const
�� 
int
�� -
MINOR_MATRIX_STARTTRANSFERAUDIO
�� 8
=
��9 :
$num
��; >
;
��> ?
public
�� 
const
�� 
int
�� +
MINOR_MATRIX_STOPRANSFERAUDIO
�� 6
=
��7 8
$num
��9 <
;
��< =
public
�� 
const
�� 
int
�� %
MINOR_LOGON_CODESPITTER
�� 0
=
��1 2
$num
��3 6
;
��6 7
public
�� 
const
�� 
int
�� &
MINOR_LOGOFF_CODESPITTER
�� 1
=
��2 3
$num
��4 7
;
��7 8
public
�� 
const
�� 
int
�� 
MAJOR_INFORMATION
�� *
=
��+ ,
$num
��- .
;
��. /
public
�� 
const
�� 
int
�� 
MINOR_HDD_INFO
�� '
=
��( )
$num
��* -
;
��- .
public
�� 
const
�� 
int
�� 
MINOR_SMART_INFO
�� )
=
��* +
$num
��, /
;
��/ 0
public
�� 
const
�� 
int
�� 
MINOR_REC_START
�� (
=
��) *
$num
��+ .
;
��. /
public
�� 
const
�� 
int
�� 
MINOR_REC_STOP
�� '
=
��( )
$num
��* -
;
��- .
public
�� 
const
�� 
int
�� 
MINOR_REC_OVERDUE
�� *
=
��+ ,
$num
��- 0
;
��0 1
public
�� 
const
�� 
int
�� 
MINOR_LINK_START
�� )
=
��* +
$num
��, /
;
��/ 0
public
�� 
const
�� 
int
�� 
MINOR_LINK_STOP
�� (
=
��) *
$num
��+ .
;
��. /
public
�� 
const
�� 
int
�� !
MINOR_NET_DISK_INFO
�� ,
=
��- .
$num
��/ 2
;
��2 3
public
�� 
const
�� 
int
�� 

�� &
=
��' (
$num
��) *
;
��* +
public
�� 
const
�� 
int
�� 

PARA_IMAGE
�� #
=
��$ %
$num
��& '
;
��' (
public
�� 
const
�� 
int
�� 
PARA_ENCODE
�� $
=
��% &
$num
��' (
;
��( )
public
�� 
const
�� 
int
�� 
PARA_NETWORK
�� %
=
��& '
$num
��( )
;
��) *
public
�� 
const
�� 
int
�� 

PARA_ALARM
�� #
=
��$ %
$num
��& (
;
��( )
public
�� 
const
�� 
int
�� 
PARA_EXCEPTION
�� '
=
��( )
$num
��* ,
;
��, -
public
�� 
const
�� 
int
�� 
PARA_DECODER
�� %
=
��& '
$num
��( *
;
��* +
public
�� 
const
�� 
int
�� 

PARA_RS232
�� #
=
��$ %
$num
��& )
;
��) *
public
�� 
const
�� 
int
�� 
PARA_PREVIEW
�� %
=
��& '
$num
��( +
;
��+ ,
public
�� 
const
�� 
int
�� 

�� &
=
��' (
$num
��) ,
;
��, -
public
�� 
const
�� 
int
�� 

�� &
=
��' (
$num
��) -
;
��- .
public
�� 
const
�� 
int
�� 
PARA_FRAMETYPE
�� '
=
��( )
$num
��* .
;
��. /
public
�� 
const
�� 
int
�� 

�� &
=
��' (
$num
��) -
;
��- .
public
�� 
const
�� 
int
�� "
NET_DVR_FILE_SUCCESS
�� -
=
��. /
$num
��0 4
;
��4 5
public
�� 
const
�� 
int
�� !
NET_DVR_FILE_NOFIND
�� ,
=
��- .
$num
��/ 3
;
��3 4
public
�� 
const
�� 
int
�� 
NET_DVR_ISFINDING
�� *
=
��+ ,
$num
��- 1
;
��1 2
public
�� 
const
�� 
int
��  
NET_DVR_NOMOREFILE
�� +
=
��, -
$num
��. 2
;
��2 3
public
�� 
const
�� 
int
�� $
NET_DVR_FILE_EXCEPTION
�� /
=
��0 1
$num
��2 6
;
��6 7
public
�� 
const
�� 
int
�� 

COMM_ALARM
�� #
=
��$ %
$num
��& ,
;
��, -
public
�� 
const
�� 
int
�� 
COMM_ALARM_RULE
�� (
=
��) *
$num
��+ 1
;
��1 2
public
�� 
const
�� 
int
�� 
COMM_ALARM_PDC
�� '
=
��( )
$num
��* 0
;
��0 1
public
�� 
const
�� 
int
�� "
COMM_ALARM_ALARMHOST
�� -
=
��. /
$num
��0 6
;
��6 7
public
�� 
const
�� 
int
�� 
COMM_ALARM_FACE
�� (
=
��) *
$num
��+ 1
;
��1 2
public
�� 
const
�� 
int
�� #
COMM_RULE_INFO_UPLOAD
�� .
=
��/ 0
$num
��1 7
;
��7 8
public
�� 
const
�� 
int
�� 
COMM_ALARM_AID
�� '
=
��( )
$num
��* 0
;
��0 1
public
�� 
const
�� 
int
�� 
COMM_ALARM_TPS
�� '
=
��( )
$num
��* 0
;
��0 1
public
�� 
const
�� 
int
�� )
COMM_UPLOAD_FACESNAP_RESULT
�� 4
=
��5 6
$num
��7 =
;
��= >
public
�� 
const
�� 
int
�� 
COMM_ALARM_TFS
�� '
=
��( )
$num
��* 0
;
��0 1
public
�� 
const
�� 
int
��  
COMM_ALARM_TPS_V41
�� +
=
��, -
$num
��. 4
;
��4 5
public
�� 
const
�� 
int
��  
COMM_ALARM_AID_V41
�� +
=
��, -
$num
��. 4
;
��4 5
public
�� 
const
�� 
int
�� 
COMM_ALARM_VQD_EX
�� *
=
��+ ,
$num
��- 3
;
��3 4
public
�� 
const
�� 
int
�� &
COMM_SENSOR_VALUE_UPLOAD
�� 1
=
��2 3
$num
��4 :
;
��: ;
public
�� 
const
�� 
int
�� 
COMM_SENSOR_ALARM
�� *
=
��+ ,
$num
��- 3
;
��3 4
public
�� 
const
�� 
int
�� 
COMM_SWITCH_ALARM
�� *
=
��+ ,
$num
��- 3
;
��3 4
public
�� 
const
�� 
int
�� &
COMM_ALARMHOST_EXCEPTION
�� 1
=
��2 3
$num
��4 :
;
��: ;
public
�� 
const
�� 
int
�� /
!COMM_ALARMHOST_OPERATEEVENT_ALARM
�� :
=
��; <
$num
��= C
;
��C D
public
�� 
const
�� 
int
�� -
COMM_ALARMHOST_SAFETYCABINSTATE
�� 8
=
��9 :
$num
��; A
;
��A B
public
�� 
const
�� 
int
�� +
COMM_ALARMHOST_ALARMOUTSTATUS
�� 6
=
��7 8
$num
��9 ?
;
��? @
public
�� 
const
�� 
int
�� &
COMM_ALARMHOST_CID_ALARM
�� 1
=
��2 3
$num
��4 :
;
��: ;
public
�� 
const
�� 
int
�� 2
$COMM_ALARMHOST_EXTERNAL_DEVICE_ALARM
�� =
=
��> ?
$num
��@ F
;
��F G
public
�� 
const
�� 
int
�� (
COMM_ALARMHOST_DATA_UPLOAD
�� 3
=
��4 5
$num
��6 <
;
��< =
public
�� 
const
�� 
int
�� '
COMM_ALARM_AUDIOEXCEPTION
�� 2
=
��3 4
$num
��5 ;
;
��; <
public
�� 
const
�� 
int
��  
COMM_ALARM_DEFOCUS
�� +
=
��, -
$num
��. 4
;
��4 5
public
�� 
const
�� 
int
�� .
 COMM_ALARM_BUTTON_DOWN_EXCEPTION
�� 9
=
��: ;
$num
��< B
;
��B C
public
�� 
const
�� 
int
�� !
COMM_ALARM_ALARMGPS
�� ,
=
��- .
$num
��/ 5
;
��5 6
public
�� 
const
�� 
int
�� 
COMM_TRADEINFO
�� '
=
��( )
$num
��* 0
;
��0 1
public
�� 
const
�� 
int
�� &
COMM_UPLOAD_PLATE_RESULT
�� 1
=
��2 3
$num
��4 :
;
��: ;
public
�� 
const
�� 
int
�� +
COMM_ITC_STATUS_DETECT_RESULT
�� 6
=
��7 8
$num
��9 ?
;
��? @
public
�� 
const
�� 
int
�� &
COMM_IPC_AUXALARM_RESULT
�� 1
=
��2 3
$num
��4 :
;
��: ;
public
�� 
const
�� 
int
�� %
COMM_UPLOAD_PICTUREINFO
�� 0
=
��1 2
$num
��3 9
;
��9 :
public
�� 
const
�� 
int
�� #
COMM_SNAP_MATCH_ALARM
�� .
=
��/ 0
$num
��1 7
;
��7 8
public
�� 
const
�� 
int
�� #
COMM_ITS_PLATE_RESULT
�� .
=
��/ 0
$num
��1 7
;
��7 8
public
�� 
const
�� 
int
�� &
COMM_ITS_TRAFFIC_COLLECT
�� 1
=
��2 3
$num
��4 :
;
��: ;
public
�� 
const
�� 
int
�� #
COMM_ITS_GATE_VEHICLE
�� .
=
��/ 0
$num
��1 7
;
��7 8
public
�� 
const
�� 
int
��  
COMM_ITS_GATE_FACE
�� +
=
��, -
$num
��. 4
;
��4 5
public
�� 
const
�� 
int
�� $
COMM_ITS_GATE_COSTITEM
�� /
=
��0 1
$num
��2 8
;
��8 9
public
�� 
const
�� 
int
�� $
COMM_ITS_GATE_HANDOVER
�� /
=
��0 1
$num
��2 8
;
��8 9
public
�� 
const
�� 
int
�� #
COMM_ITS_PARK_VEHICLE
�� .
=
��/ 0
$num
��1 7
;
��7 8
public
�� 
const
�� 
int
�� &
COMM_ITS_BLACKLIST_ALARM
�� 1
=
��2 3
$num
��4 :
;
��: ;
public
�� 
const
�� 
int
�� 
COMM_ALARM_V30
�� '
=
��( )
$num
��* 0
;
��0 1
public
�� 
const
�� 
int
�� 
COMM_IPCCFG
�� $
=
��% &
$num
��' -
;
��- .
public
�� 
const
�� 
int
�� 
COMM_IPCCFG_V31
�� (
=
��) *
$num
��+ 1
;
��1 2
public
�� 
const
�� 
int
�� 
COMM_IPCCFG_V40
�� (
=
��) *
$num
��+ 1
;
��1 2
public
�� 
const
�� 
int
�� 
COMM_ALARM_DEVICE
�� *
=
��+ ,
$num
��- 3
;
��3 4
public
�� 
const
�� 
int
�� 
COMM_ALARM_CVR
�� '
=
��( )
$num
��* 0
;
��0 1
public
�� 
const
�� 
int
�� "
COMM_ALARM_HOT_SPARE
�� -
=
��. /
$num
��0 6
;
��6 7
public
�� 
const
�� 
int
�� 
COMM_ALARM_V40
�� '
=
��( )
$num
��* 0
;
��0 1
public
�� 
const
�� 
int
�� %
COMM_ITS_ROAD_EXCEPTION
�� 0
=
��1 2
$num
��3 9
;
��9 :
public
�� 
const
�� 
int
�� -
COMM_ITS_EXTERNAL_CONTROL_ALARM
�� 8
=
��9 :
$num
��; A
;
��A B
public
�� 
const
�� 
int
�� 
COMM_SCREEN_ALARM
�� *
=
��+ ,
$num
��- 3
;
��3 4
public
�� 
const
�� 
int
�� #
COMM_DVCS_STATE_ALARM
�� .
=
��/ 0
$num
��1 7
;
��7 8
public
�� 
const
�� 
int
�� 
COMM_ALARM_VQD
�� '
=
��( )
$num
��* 0
;
��0 1
public
�� 
const
�� 
int
�� *
COMM_PUSH_UPDATE_RECORD_INFO
�� 5
=
��6 7
$num
��8 >
;
��> ?
public
�� 
const
�� 
int
�� #
COMM_DIAGNOSIS_UPLOAD
�� .
=
��/ 0
$num
��1 7
;
��7 8
public
�� 
const
�� 
int
��  
EXCEPTION_EXCHANGE
�� +
=
��, -
$num
��. 3
;
��3 4
public
�� 
const
�� 
int
�� %
EXCEPTION_AUDIOEXCHANGE
�� 0
=
��1 2
$num
��3 8
;
��8 9
public
�� 
const
�� 
int
�� 
EXCEPTION_ALARM
�� (
=
��) *
$num
��+ 0
;
��0 1
public
�� 
const
�� 
int
�� 
EXCEPTION_PREVIEW
�� *
=
��+ ,
$num
��- 2
;
��2 3
public
�� 
const
�� 
int
�� 
EXCEPTION_SERIAL
�� )
=
��* +
$num
��, 1
;
��1 2
public
�� 
const
�� 
int
�� !
EXCEPTION_RECONNECT
�� ,
=
��- .
$num
��/ 4
;
��4 5
public
�� 
const
�� 
int
�� &
EXCEPTION_ALARMRECONNECT
�� 1
=
��2 3
$num
��4 9
;
��9 :
public
�� 
const
�� 
int
�� '
EXCEPTION_SERIALRECONNECT
�� 2
=
��3 4
$num
��5 :
;
��: ;
public
�� 
const
�� 
int
��  
EXCEPTION_PLAYBACK
�� +
=
��, -
$num
��. 3
;
��3 4
public
�� 
const
�� 
int
�� 
EXCEPTION_DISKFMT
�� *
=
��+ ,
$num
��- 2
;
��2 3
public
�� 
const
�� 
int
�� 
NET_DVR_SYSHEAD
�� (
=
��) *
$num
��+ ,
;
��, -
public
�� 
const
�� 
int
��  
NET_DVR_STREAMDATA
�� +
=
��, -
$num
��. /
;
��/ 0
public
�� 
const
�� 
int
�� %
NET_DVR_AUDIOSTREAMDATA
�� 0
=
��1 2
$num
��3 4
;
��4 5
public
�� 
const
�� 
int
�� #
NET_DVR_STD_VIDEODATA
�� .
=
��/ 0
$num
��1 2
;
��2 3
public
�� 
const
�� 
int
�� #
NET_DVR_STD_AUDIODATA
�� .
=
��/ 0
$num
��1 2
;
��2 3
public
�� 
const
�� 
int
�� '
NET_DVR_REALPLAYEXCEPTION
�� 2
=
��3 4
$num
��5 8
;
��8 9
public
�� 
const
�� 
int
�� &
NET_DVR_REALPLAYNETCLOSE
�� 1
=
��2 3
$num
��4 7
;
��7 8
public
�� 
const
�� 
int
�� &
NET_DVR_REALPLAY5SNODATA
�� 1
=
��2 3
$num
��4 7
;
��7 8
public
�� 
const
�� 
int
�� '
NET_DVR_REALPLAYRECONNECT
�� 2
=
��3 4
$num
��5 8
;
��8 9
public
�� 
const
�� 
int
�� "
NET_DVR_PLAYBACKOVER
�� -
=
��. /
$num
��0 3
;
��3 4
public
�� 
const
�� 
int
�� '
NET_DVR_PLAYBACKEXCEPTION
�� 2
=
��3 4
$num
��5 8
;
��8 9
public
�� 
const
�� 
int
�� &
NET_DVR_PLAYBACKNETCLOSE
�� 1
=
��2 3
$num
��4 7
;
��7 8
public
�� 
const
�� 
int
�� &
NET_DVR_PLAYBACK5SNODATA
�� 1
=
��2 3
$num
��4 7
;
��7 8
public
�� 
const
�� 
int
�� 
DVR
�� 
=
�� 
$num
��  
;
��  !
public
�� 
const
�� 
int
�� 
ATMDVR
�� 
=
��  !
$num
��" #
;
��# $
public
�� 
const
�� 
int
�� 
DVS
�� 
=
�� 
$num
��  
;
��  !
public
�� 
const
�� 
int
�� 
DEC
�� 
=
�� 
$num
��  
;
��  !
public
�� 
const
�� 
int
�� 
ENC_DEC
��  
=
��! "
$num
��# $
;
��$ %
public
�� 
const
�� 
int
�� 
DVR_HC
�� 
=
��  !
$num
��" #
;
��# $
public
�� 
const
�� 
int
�� 
DVR_HT
�� 
=
��  !
$num
��" #
;
��# $
public
�� 
const
�� 
int
�� 
DVR_HF
�� 
=
��  !
$num
��" #
;
��# $
public
�� 
const
�� 
int
�� 
DVR_HS
�� 
=
��  !
$num
��" #
;
��# $
public
�� 
const
�� 
int
�� 
DVR_HTS
��  
=
��! "
$num
��# %
;
��% &
public
�� 
const
�� 
int
�� 
DVR_HB
�� 
=
��  !
$num
��" $
;
��$ %
public
�� 
const
�� 
int
�� 
DVR_HCS
��  
=
��! "
$num
��# %
;
��% &
public
�� 
const
�� 
int
�� 
DVS_A
�� 
=
��  
$num
��! #
;
��# $
public
�� 
const
�� 
int
�� 
DVR_HC_S
�� !
=
��" #
$num
��$ &
;
��& '
public
�� 
const
�� 
int
�� 
DVR_HT_S
�� !
=
��" #
$num
��$ &
;
��& '
public
�� 
const
�� 
int
�� 
DVR_HF_S
�� !
=
��" #
$num
��$ &
;
��& '
public
�� 
const
�� 
int
�� 
DVR_HS_S
�� !
=
��" #
$num
��$ &
;
��& '
public
�� 
const
�� 
int
�� 
ATMDVR_S
�� !
=
��" #
$num
��$ &
;
��& '
public
�� 
const
�� 
int
�� 
LOWCOST_DVR
�� $
=
��% &
$num
��' )
;
��) *
public
�� 
const
�� 
int
�� 
DEC_MAT
��  
=
��! "
$num
��# %
;
��% &
public
�� 
const
�� 
int
�� 

DVR_MOBILE
�� #
=
��$ %
$num
��& (
;
��( )
public
�� 
const
�� 
int
�� 
DVR_HD_S
�� !
=
��" #
$num
��$ &
;
��& '
public
�� 
const
�� 
int
�� 
	DVR_HD_SL
�� "
=
��# $
$num
��% '
;
��' (
public
�� 
const
�� 
int
�� 
	DVR_HC_SL
�� "
=
��# $
$num
��% '
;
��' (
public
�� 
const
�� 
int
�� 
	DVR_HS_ST
�� "
=
��# $
$num
��% '
;
��' (
public
�� 
const
�� 
int
�� 
DVS_HW
�� 
=
��  !
$num
��" $
;
��$ %
public
�� 
const
�� 
int
�� 
DS630X_D
�� !
=
��" #
$num
��$ &
;
��& '
public
�� 
const
�� 
int
�� 
IPCAM
�� 
=
��  
$num
��! #
;
��# $
public
�� 
const
�� 
int
�� 

MEGA_IPCAM
�� #
=
��$ %
$num
��& (
;
��( )
public
�� 
const
�� 
int
�� 
IPCAM_X62MF
�� $
=
��% &
$num
��' )
;
��) *
public
�� 
const
�� 
int
�� 
IPDOME
�� 
=
��  !
$num
��" $
;
��$ %
public
�� 
const
�� 
int
�� 
IPDOME_MEGA200
�� '
=
��( )
$num
��* ,
;
��, -
public
�� 
const
�� 
int
�� 
IPDOME_MEGA130
�� '
=
��( )
$num
��* ,
;
��, -
public
�� 
const
�� 
int
�� 
IPMOD
�� 
=
��  
$num
��! #
;
��# $
public
�� 
const
�� 
int
�� 
DS71XX_H
�� !
=
��" #
$num
��$ &
;
��& '
public
�� 
const
�� 
int
�� 

DS72XX_H_S
�� #
=
��$ %
$num
��& (
;
��( )
public
�� 
const
�� 
int
�� 

DS73XX_H_S
�� #
=
��$ %
$num
��& (
;
��( )
public
�� 
const
�� 
int
�� 

DS76XX_H_S
�� #
=
��$ %
$num
��& (
;
��( )
public
�� 
const
�� 
int
�� 
DS81XX_HS_S
�� $
=
��% &
$num
��' )
;
��) *
public
�� 
const
�� 
int
�� 
DS81XX_HL_S
�� $
=
��% &
$num
��' )
;
��) *
public
�� 
const
�� 
int
�� 
DS81XX_HC_S
�� $
=
��% &
$num
��' )
;
��) *
public
�� 
const
�� 
int
�� 
DS81XX_HD_S
�� $
=
��% &
$num
��' )
;
��) *
public
�� 
const
�� 
int
�� 
DS81XX_HE_S
�� $
=
��% &
$num
��' )
;
��) *
public
�� 
const
�� 
int
�� 
DS81XX_HF_S
�� $
=
��% &
$num
��' )
;
��) *
public
�� 
const
�� 
int
�� 
DS81XX_AH_S
�� $
=
��% &
$num
��' )
;
��) *
public
�� 
const
�� 
int
�� 
DS81XX_AHF_S
�� %
=
��& '
$num
��( *
;
��* +
public
�� 
const
�� 
int
�� 
DS90XX_HF_S
�� $
=
��% &
$num
��' )
;
��) *
public
�� 
const
�� 
int
�� 
DS91XX_HF_S
�� $
=
��% &
$num
��' )
;
��) *
public
�� 
const
�� 
int
�� 
DS91XX_HD_S
�� $
=
��% &
$num
��' )
;
��) *
public
�� 
const
�� 
int
�� 
DS6001_HF_B
�� $
=
��% &
$num
��' )
;
��) *
public
�� 
const
�� 
int
�� 
DS6001_HF_P
�� $
=
��% &
$num
��' )
;
��) *
public
�� 
const
�� 
int
�� 
DS6002_HF_B
�� $
=
��% &
$num
��' )
;
��) *
public
�� 
const
�� 
int
�� 
DS6101_HF_B
�� $
=
��% &
$num
��' )
;
��) *
public
�� 
const
�� 
int
�� 
IDS52XX
��  
=
��! "
$num
��# %
;
��% &
public
�� 
const
�� 
int
�� 

DS9000_IVS
�� #
=
��$ %
$num
��& (
;
��( )
public
�� 
const
�� 
int
�� 
DS8004_AHL_A
�� %
=
��& '
$num
��( *
;
��* +
public
�� 
const
�� 
int
�� 
DS6101_HF_P
�� $
=
��% &
$num
��' )
;
��) *
public
�� 
const
�� 
int
�� 
VCA_DEV_ABILITY
�� (
=
��) *
$num
��+ .
;
��. /
public
�� 
const
�� 
int
�� 
VCA_CHAN_ABILITY
�� )
=
��* +
$num
��, /
;
��/ 0
public
�� 
const
�� 
int
�� #
MATRIXDECODER_ABILITY
�� .
=
��/ 0
$num
��1 4
;
��4 5
public
�� 
const
�� 
int
�� "
NET_DVR_SET_PLATECFG
�� -
=
��. /
$num
��0 3
;
��3 4
public
�� 
const
�� 
int
�� "
NET_DVR_GET_PLATECFG
�� -
=
��. /
$num
��0 3
;
��3 4
public
�� 
const
�� 
int
�� !
NET_DVR_SET_RULECFG
�� ,
=
��- .
$num
��/ 2
;
��2 3
public
�� 
const
�� 
int
�� !
NET_DVR_GET_RULECFG
�� ,
=
��- .
$num
��/ 2
;
��2 3
public
�� 
const
�� 
int
��  
NET_DVR_SET_LF_CFG
�� +
=
��, -
$num
��. 1
;
��1 2
public
�� 
const
�� 
int
��  
NET_DVR_GET_LF_CFG
�� +
=
��, -
$num
��. 1
;
��1 2
public
�� 
const
�� 
int
�� (
NET_DVR_SET_IVMS_STREAMCFG
�� 3
=
��4 5
$num
��6 9
;
��9 :
public
�� 
const
�� 
int
�� (
NET_DVR_GET_IVMS_STREAMCFG
�� 3
=
��4 5
$num
��6 9
;
��9 :
public
�� 
const
�� 
int
�� %
NET_DVR_SET_VCA_CTRLCFG
�� 0
=
��1 2
$num
��3 6
;
��6 7
public
�� 
const
�� 
int
�� %
NET_DVR_GET_VCA_CTRLCFG
�� 0
=
��1 2
$num
��3 6
;
��6 7
public
�� 
const
�� 
int
�� )
NET_DVR_SET_VCA_MASK_REGION
�� 4
=
��5 6
$num
��7 :
;
��: ;
public
�� 
const
�� 
int
�� )
NET_DVR_GET_VCA_MASK_REGION
�� 4
=
��5 6
$num
��7 :
;
��: ;
public
�� 
const
�� 
int
�� *
NET_DVR_SET_VCA_ENTER_REGION
�� 5
=
��6 7
$num
��8 ;
;
��; <
public
�� 
const
�� 
int
�� *
NET_DVR_GET_VCA_ENTER_REGION
�� 5
=
��6 7
$num
��8 ;
;
��; <
public
�� 
const
�� 
int
�� *
NET_DVR_SET_VCA_LINE_SEGMENT
�� 5
=
��6 7
$num
��8 ;
;
��; <
public
�� 
const
�� 
int
�� *
NET_DVR_GET_VCA_LINE_SEGMENT
�� 5
=
��6 7
$num
��8 ;
;
��; <
public
�� 
const
�� 
int
�� *
NET_DVR_SET_IVMS_MASK_REGION
�� 5
=
��6 7
$num
��8 ;
;
��; <
public
�� 
const
�� 
int
�� *
NET_DVR_GET_IVMS_MASK_REGION
�� 5
=
��6 7
$num
��8 ;
;
��; <
public
�� 
const
�� 
int
�� +
NET_DVR_SET_IVMS_ENTER_REGION
�� 6
=
��7 8
$num
��9 <
;
��< =
public
�� 
const
�� 
int
�� +
NET_DVR_GET_IVMS_ENTER_REGION
�� 6
=
��7 8
$num
��9 <
;
��< =
public
�� 
const
�� 
int
�� *
NET_DVR_SET_IVMS_BEHAVIORCFG
�� 5
=
��6 7
$num
��8 ;
;
��; <
public
�� 
const
�� 
int
�� *
NET_DVR_GET_IVMS_BEHAVIORCFG
�� 5
=
��6 7
$num
��8 ;
;
��; <
public
�� 
const
�� 
int
�� (
NET_DVR_IVMS_SET_SEARCHCFG
�� 3
=
��4 5
$num
��6 9
;
��9 :
public
�� 
const
�� 
int
�� (
NET_DVR_IVMS_GET_SEARCHCFG
�� 3
=
��4 5
$num
��6 9
;
��9 :
public
�� 
const
�� 
int
�� '
VCA_MAX_POLYGON_POINT_NUM
�� 2
=
��3 4
$num
��5 7
;
��7 8
public
�� 
const
�� 
int
�� 
MAX_RULE_NUM
�� %
=
��& '
$num
��( )
;
��) *
public
�� 
const
�� 
int
�� 
MAX_TARGET_NUM
�� '
=
��( )
$num
��* ,
;
��, -
public
�� 
const
�� 
int
�� 
MAX_CALIB_PT
�� %
=
��& '
$num
��( )
;
��) *
public
�� 
const
�� 
int
�� 
MIN_CALIB_PT
�� %
=
��& '
$num
��( )
;
��) *
public
�� 
const
�� 
int
�� 
MAX_TIMESEGMENT_2
�� *
=
��+ ,
$num
��- .
;
��. /
public
�� 
const
�� 
int
�� 
MAX_LICENSE_LEN
�� (
=
��) *
$num
��+ -
;
��- .
public
�� 
const
�� 
int
�� 

�� &
=
��' (
$num
��) *
;
��* +
public
�� 
const
�� 
int
�� !
MAX_MASK_REGION_NUM
�� ,
=
��- .
$num
��/ 0
;
��0 1
public
�� 
const
�� 
int
�� 
MAX_SEGMENT_NUM
�� (
=
��) *
$num
��+ ,
;
��, -
public
�� 
const
�� 
int
�� 
MIN_SEGMENT_NUM
�� (
=
��) *
$num
��+ ,
;
��, -
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� 
NET_DVR_PLATE_RET
�� '
{
�� 	
public
�� 
uint
�� 
dwSize
�� 
;
�� 
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E

��F S
,
��S T
ArraySubType
��U a
=
��b c

��d q
.
��q r
I1
��r t
)
��t u
]
��u v
public
�� 
byte
�� 
[
�� 
]
�� 

byPlateNum
�� $
;
��$ %
public
�� 
byte
�� 

�� %
;
��% &
public
�� 
byte
�� 
byTrafficLight
�� &
;
��& '
public
�� 
byte
�� 
byPlateColor
�� $
;
��$ %
public
�� 
byte
�� 
byDriveChan
�� #
;
��# $
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F H
,
��H I
ArraySubType
��J V
=
��W X

��Y f
.
��f g
I1
��g i
)
��i j
]
��j k
public
�� 
byte
�� 
[
�� 
]
�� 

byTimeInfo
�� $
;
��$ %
public
�� 
byte
�� 

byCarSpeed
�� "
;
��" #
public
�� 
byte
�� 
byCarSpeedH
�� #
;
��# $
public
�� 
byte
�� 
byCarSpeedL
�� #
;
��# $
public
�� 
byte
�� 
byRes
�� 
;
�� 
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
PLATE_INFO_LEN
��F T
-
��U V
$num
��W Y
,
��Y Z
ArraySubType
��[ g
=
��h i

��j w
.
��w x
I1
��x z
)
��z {
]
��{ |
public
�� 
byte
�� 
[
�� 
]
�� 
byInfo
��  
;
��  !
public
�� 
uint
�� 
dwPicLen
��  
;
��  !
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� 
NET_DVR_CCD_CFG
�� %
{
�� 	
public
�� 
uint
�� 
dwSize
�� 
;
�� 
public
�� 
byte
�� 
byBlc
�� 
;
�� 
public
�� 
byte
�� 
	byBlcMode
�� !
;
��! "
public
�� 
byte
�� 
byAwb
�� 
;
�� 
public
�� 
byte
�� 
byAgc
�� 
;
�� 
public
�� 
byte
�� 

byDayNight
�� "
;
��" #
public
�� 
byte
�� 
byMirror
��  
;
��  !
public
�� 
byte
�� 
	byShutter
�� !
;
��! "
public
�� 
byte
�� 
byIrCutTime
�� #
;
��# $
public
�� 
byte
�� 

byLensType
�� "
;
��" #
public
�� 
byte
�� 

�� %
;
��% &
public
�� 
byte
�� 
byCapShutter
�� $
;
��$ %
public
�� 
byte
�� 

�� %
;
��% &
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� 
tagCAMERAPARAMCFG
�� '
{
�� 	
public
�� 
uint
�� 
dwSize
�� 
;
�� 
public
�� 
uint
�� &
dwPowerLineFrequencyMode
�� 0
;
��0 1
public
�� 
uint
��  
dwWhiteBalanceMode
�� *
;
��* +
public
�� 
uint
�� %
dwWhiteBalanceModeRGain
�� /
;
��/ 0
public
�� 
uint
�� %
dwWhiteBalanceModeBGain
�� /
;
��/ 0
public
�� 
uint
�� 
dwExposureMode
�� &
;
��& '
public
�� 
uint
�� 

�� %
;
��% &
public
�� 
uint
�� 
dwExposureUserSet
�� )
;
��) *
public
�� 
uint
�� 
dwExposureTarget
�� (
;
��( )
public
�� 
uint
�� 

dwIrisMode
�� "
;
��" #
public
�� 
uint
�� 
dwGainLevel
�� #
;
��# $
public
�� 
uint
�� 
dwBrightnessLevel
�� )
;
��) *
public
�� 
uint
�� 
dwContrastLevel
�� '
;
��' (
public
�� 
uint
�� 
dwSharpnessLevel
�� (
;
��( )
public
�� 
uint
�� 
dwSaturationLevel
�� )
;
��) *
public
�� 
uint
�� 

dwHueLevel
�� "
;
��" #
public
�� 
uint
�� &
dwGammaCorrectionEnabled
�� 0
;
��0 1
public
�	�	 
uint
�	�	 $
dwGammaCorrectionLevel
�	�	 .
;
�	�	. /
public
�	�	 
uint
�	�	 
dwWDREnabled
�	�	 $
;
�	�	$ %
public
�	�	 
uint
�	�	 
dwWDRLevel1
�	�	 #
;
�	�	# $
public
�	�	 
uint
�	�	 
dwWDRLevel2
�	�	 #
;
�	�	# $
public
�	�	 
uint
�	�	  
dwWDRContrastLevel
�	�	 *
;
�	�	* +
public
�	�	 
uint
�	�	 "
dwDayNightFilterType
�	�	 ,
;
�	�	, -
public
�	�	 
uint
�	�	 %
dwSwitchScheduleEnabled
�	�	 /
;
�	�	/ 0
public
�	�	 
uint
�	�	 
dwBeginTime
�	�	 #
;
�	�	# $
public
�	�	 
uint
�	�	 
	dwEndTime
�	�	 !
;
�	�	! "
public
�	�	 
uint
�	�	 %
dwDayToNightFilterLevel
�	�	 /
;
�	�	/ 0
public
�	�	 
uint
�	�	 %
dwNightToDayFilterLevel
�	�	 /
;
�	�	/ 0
public
�	�	 
uint
�	�	 "
dwDayNightFilterTime
�	�	 ,
;
�	�	, -
public
�	�	 
uint
�	�	 
dwBacklightMode
�	�	 '
;
�	�	' (
public
�	�	 
uint
�	�	 
dwPositionX1
�	�	 $
;
�	�	$ %
public
�	�	 
uint
�	�	 
dwPositionY1
�	�	 $
;
�	�	$ %
public
�	�	 
uint
�	�	 
dwPositionX2
�	�	 $
;
�	�	$ %
public
�	�	 
uint
�	�	 
dwPositionY2
�	�	 $
;
�	�	$ %
public
�	�	 
uint
�	�	 
dwBacklightLevel
�	�	 (
;
�	�	( )
public
�	�	 
uint
�	�	 (
dwDigitalNoiseRemoveEnable
�	�	 2
;
�	�	2 3
public
�	�	 
uint
�	�	 '
dwDigitalNoiseRemoveLevel
�	�	 1
;
�	�	1 2
public
�	�	 
uint
�	�	 
dwMirror
�	�	  
;
�	�	  !
public
�	�	 
uint
�	�	 

�	�	 %
;
�	�	% &
public
�	�	 
uint
�	�	 
dwDeadPixelDetect
�	�	 )
;
�	�	) *
[
�	�	 
MarshalAsAttribute
�	�	
(
�	�	  

�	�	  -
.
�	�	- .

ByValArray
�	�	. 8
,
�	�	8 9
	SizeConst
�	�	: C
=
�	�	D E
$num
�	�	F H
,
�	�	H I
ArraySubType
�	�	J V
=
�	�	W X

�	�	Y f
.
�	�	f g
U4
�	�	g i
)
�	�	i j
]
�	�	j k
public
�	�	 
uint
�	�	 
[
�	�	 
]
�	�	 
dwRes
�	�	 
;
�	�	  
}
�	�	 	
[
�	�	 	#
StructLayoutAttribute
�	�		 
(
�	�	 

LayoutKind
�	�	 )
.
�	�	) *

Sequential
�	�	* 4
)
�	�	4 5
]
�	�	5 6
public
�	�	 
struct
�	�	 
tagIMAGEREGION
�	�	 $
{
�	�	 	
public
�	�	 
uint
�	�	 
dwSize
�	�	 
;
�	�	 
public
�	�	 
ushort
�	�	 "
wImageRegionTopLeftX
�	�	 .
;
�	�	. /
public
�	�	 
ushort
�	�	 "
wImageRegionTopLeftY
�	�	 .
;
�	�	. /
public
�	�	 
ushort
�	�	 
wImageRegionWidth
�	�	 +
;
�	�	+ ,
public
�	�	 
ushort
�	�	  
wImageRegionHeight
�	�	 ,
;
�	�	, -
[
�	�	 
MarshalAsAttribute
�	�	
(
�	�	  

�	�	  -
.
�	�	- .

ByValArray
�	�	. 8
,
�	�	8 9
	SizeConst
�	�	: C
=
�	�	D E
$num
�	�	F H
,
�	�	H I
ArraySubType
�	�	J V
=
�	�	W X

�	�	Y f
.
�	�	f g
I1
�	�	g i
)
�	�	i j
]
�	�	j k
public
�	�	 
byte
�	�	 
[
�	�	 
]
�	�	 
byRes
�	�	 
;
�	�	  
}
�	�	 	
[
�	�	 	#
StructLayoutAttribute
�	�		 
(
�	�	 

LayoutKind
�	�	 )
.
�	�	) *

Sequential
�	�	* 4
)
�	�	4 5
]
�	�	5 6
public
�	�	 
struct
�	�	 
tagIMAGESUBPARAM
�	�	 &
{
�	�	 	
public
�	�	 
NET_DVR_SCHEDTIME
�	�	 $!
struImageStatusTime
�	�	% 8
;
�	�	8 9
public
�	�	 
byte
�	�	 %
byImageEnhancementLevel
�	�	 /
;
�	�	/ 0
public
�	�	 
byte
�	�	 !
byImageDenoiseLevel
�	�	 +
;
�	�	+ ,
public
�	�	 
byte
�	�	 !
byImageStableEnable
�	�	 +
;
�	�	+ ,
[
�	�	 
MarshalAsAttribute
�	�	
(
�	�	  

�	�	  -
.
�	�	- .

ByValArray
�	�	. 8
,
�	�	8 9
	SizeConst
�	�	: C
=
�	�	D E
$num
�	�	F G
,
�	�	G H
ArraySubType
�	�	I U
=
�	�	V W

�	�	X e
.
�	�	e f
I1
�	�	f h
)
�	�	h i
]
�	�	i j
public
�	�	 
byte
�	�	 
[
�	�	 
]
�	�	 
byRes
�	�	 
;
�	�	  
}
�	�	 	
[
�	�	 	#
StructLayoutAttribute
�	�		 
(
�	�	 

LayoutKind
�	�	 )
.
�	�	) *

Sequential
�	�	* 4
)
�	�	4 5
]
�	�	5 6
public
�	�	 
struct
�	�	 

�	�	 #
{
�	�	 	
public
�	�	 
uint
�	�	 
dwSize
�	�	 
;
�	�	 
[
�	�	 
MarshalAsAttribute
�	�	
(
�	�	  

�	�	  -
.
�	�	- .

ByValArray
�	�	. 8
,
�	�	8 9
	SizeConst
�	�	: C
=
�	�	D E
MAX_DAYS
�	�	F N
*
�	�	O P
MAX_TIMESEGMENT
�	�	Q `
,
�	�	` a
ArraySubType
�	�	b n
=
�	�	o p

�	�	q ~
.
�	�	~ 
Struct�	�	 �
)�	�	� �
]�	�	� �
public
�	�	 
tagIMAGESUBPARAM
�	�	 #
[
�	�	# $
]
�	�	$ %!
struImageParamSched
�	�	& 9
;
�	�	9 :
[
�	�	 
MarshalAsAttribute
�	�	
(
�	�	  

�	�	  -
.
�	�	- .

ByValArray
�	�	. 8
,
�	�	8 9
	SizeConst
�	�	: C
=
�	�	D E
$num
�	�	F H
,
�	�	H I
ArraySubType
�	�	J V
=
�	�	W X

�	�	Y f
.
�	�	f g
I1
�	�	g i
)
�	�	i j
]
�	�	j k
public
�	�	 
byte
�	�	 
[
�	�	 
]
�	�	 
byRes
�	�	 
;
�	�	  
}
�	�	 	
[
�	�	 	#
StructLayoutAttribute
�	�		 
(
�	�	 

LayoutKind
�	�	 )
.
�	�	) *

Sequential
�	�	* 4
)
�	�	4 5
]
�	�	5 6
public
�	�	 
struct
�	�	 
NET_DVR_TIME
�	�	 "
{
�	�	 	
public
�	�	 
uint
�	�	 
dwYear
�	�	 
;
�	�	 
public
�	�	 
uint
�	�	 
dwMonth
�	�	 
;
�	�	  
public
�	�	 
uint
�	�	 
dwDay
�	�	 
;
�	�	 
public
�	�	 
uint
�	�	 
dwHour
�	�	 
;
�	�	 
public
�	�	 
uint
�	�	 
dwMinute
�	�	  
;
�	�	  !
public
�	�	 
uint
�	�	 
dwSecond
�	�	  
;
�	�	  !
}
�	�	 	
[
�	�	 	#
StructLayoutAttribute
�	�		 
(
�	�	 

LayoutKind
�	�	 )
.
�	�	) *

Sequential
�	�	* 4
)
�	�	4 5
]
�	�	5 6
public
�	�	 
struct
�	�	 
NET_DVR_TIME_V30
�	�	 &
{
�	�	 	
public
�	�	 
ushort
�	�	 
wYear
�	�	 
;
�	�	  
public
�	�	 
byte
�	�	 
byMonth
�	�	 
;
�	�	  
public
�	�	 
byte
�	�	 
byDay
�	�	 
;
�	�	 
public
�	�	 
byte
�	�	 
byHour
�	�	 
;
�	�	 
public
�	�	 
byte
�	�	 
byMinute
�	�	  
;
�	�	  !
public
�	�	 
byte
�	�	 
bySecond
�	�	  
;
�	�	  !
public
�	�	 
byte
�	�	 
byRes
�	�	 
;
�	�	 
public
�	�	 
ushort
�	�	 
	wMilliSec
�	�	 #
;
�	�	# $
[
�	�	 
MarshalAsAttribute
�	�	
(
�	�	  

�	�	  -
.
�	�	- .

ByValArray
�	�	. 8
,
�	�	8 9
	SizeConst
�	�	: C
=
�	�	D E
$num
�	�	F G
,
�	�	G H
ArraySubType
�	�	I U
=
�	�	V W

�	�	X e
.
�	�	e f
I1
�	�	f h
)
�	�	h i
]
�	�	i j
public
�	�	 
byte
�	�	 
[
�	�	 
]
�	�	 
byRes1
�	�	  
;
�	�	  !
}
�	�	 	
[
�	�	 	#
StructLayoutAttribute
�	�		 
(
�	�	 

LayoutKind
�	�	 )
.
�	�	) *

Sequential
�	�	* 4
)
�	�	4 5
]
�	�	5 6
public
�	�	 
struct
�	�	 
NET_DVR_TIME_EX
�	�	 %
{
�	�	 	
public
�	�	 
ushort
�	�	 
wYear
�	�	 
;
�	�	  
public
�	�	 
byte
�	�	 
byMonth
�	�	 
;
�	�	  
public
�	�	 
byte
�	�	 
byDay
�	�	 
;
�	�	 
public
�	�	 
byte
�	�	 
byHour
�	�	 
;
�	�	 
public
�	�	 
byte
�	�	 
byMinute
�	�	  
;
�	�	  !
public
�	�	 
byte
�	�	 
bySecond
�	�	  
;
�	�	  !
public
�	�	 
byte
�	�	 
byRes
�	�	 
;
�	�	 
}
�	�	 	
[
�	�	 	#
StructLayoutAttribute
�	�		 
(
�	�	 

LayoutKind
�	�	 )
.
�	�	) *

Sequential
�	�	* 4
)
�	�	4 5
]
�	�	5 6
public
�	�	 
struct
�	�	 
NET_DVR_SCHEDTIME
�	�	 '
{
�	�	 	
public
�	�	 
byte
�	�	 
byStartHour
�	�	 #
;
�	�	# $
public
�	�	 
byte
�	�	 

byStartMin
�	�	 "
;
�	�	" #
public
�	�	 
byte
�	�	 

byStopHour
�	�	 "
;
�	�	" #
public
�	�	 
byte
�	�	 
	byStopMin
�	�	 !
;
�	�	! "
}
�	�	 	
public
�	�	 
const
�	�	 
int
�	�	 
NOACTION
�	�	 !
=
�	�	" #
$num
�	�	$ '
;
�	�	' (
public
�	�	 
const
�	�	 
int
�	�	 

�	�	 &
=
�	�	' (
$num
�	�	) ,
;
�	�	, -
public
�	�	 
const
�	�	 
int
�	�	 
WARNONAUDIOOUT
�	�	 '
=
�	�	( )
$num
�	�	* -
;
�	�	- .
public
�	�	 
const
�	�	 
int
�	�	 

UPTOCENTER
�	�	 #
=
�	�	$ %
$num
�	�	& )
;
�	�	) *
public
�	�	 
const
�	�	 
int
�	�	 
TRIGGERALARMOUT
�	�	 (
=
�	�	) *
$num
�	�	+ .
;
�	�	. /
public
�	�	 
const
�	�	 
int
�	�	 

�	�	 &
=
�	�	' (
$num
�	�	) -
;
�	�	- .
public
�	�	 
const
�	�	 
int
�	�	 
SEND_PIC_FTP
�	�	 %
=
�	�	& '
$num
�	�	( -
;
�	�	- .
[
�	�	 	#
StructLayoutAttribute
�	�		 
(
�	�	 

LayoutKind
�	�	 )
.
�	�	) *

Sequential
�	�	* 4
)
�	�	4 5
]
�	�	5 6
public
�	�	 
struct
�	�	  
NET_DVR_STRUCTHEAD
�	�	 (
{
�	�	 	
public
�
�
 
ushort
�
�
 
wLength
�
�
 !
;
�
�
! "
public
�
�
 
byte
�
�
 
	byVersion
�
�
 !
;
�
�
! "
public
�
�
 
byte
�
�
 
byRes
�
�
 
;
�
�
 
}
�
�
 	
[
�
�
 	#
StructLayoutAttribute
�
�
	 
(
�
�
 

LayoutKind
�
�
 )
.
�
�
) *

Sequential
�
�
* 4
)
�
�
4 5
]
�
�
5 6
public
�
�
 
struct
�
�
 )
NET_DVR_HANDLEEXCEPTION_V41
�
�
 1
{
�
�
 	
public
�
�
 
uint
�
�
 
dwHandleType
�
�
 $
;
�
�
$ %
public
�
�
 
uint
�
�
 %
dwMaxRelAlarmOutChanNum
�
�
 /
;
�
�
/ 0
[
�
�
 
MarshalAsAttribute
�
�

(
�
�
  

�
�
  -
.
�
�
- .

ByValArray
�
�
. 8
,
�
�
8 9
	SizeConst
�
�
: C
=
�
�
D E
MAX_ALARMOUT_V40
�
�
F V
,
�
�
V W
ArraySubType
�
�
X d
=
�
�
e f

�
�
g t
.
�
�
t u
U4
�
�
u w
)
�
�
w x
]
�
�
x y
public
�
�
 
uint
�
�
 
[
�
�
 
]
�
�
 

�
�
 '
;
�
�
' (
[
�
�
 
MarshalAsAttribute
�
�

(
�
�
  

�
�
  -
.
�
�
- .

ByValArray
�
�
. 8
,
�
�
8 9
	SizeConst
�
�
: C
=
�
�
D E
$num
�
�
F H
,
�
�
H I
ArraySubType
�
�
J V
=
�
�
W X

�
�
Y f
.
�
�
f g
I1
�
�
g i
)
�
�
i j
]
�
�
j k
public
�
�
 
byte
�
�
 
[
�
�
 
]
�
�
 
byRes
�
�
 
;
�
�
  
}
�
�
 	
[
�
�
 	#
StructLayoutAttribute
�
�
	 
(
�
�
 

LayoutKind
�
�
 )
.
�
�
) *

Sequential
�
�
* 4
)
�
�
4 5
]
�
�
5 6
public
�
�
 
struct
�
�
 )
NET_DVR_HANDLEEXCEPTION_V40
�
�
 1
{
�
�
 	
public
�
�
 
uint
�
�
 
dwHandleType
�
�
 $
;
�
�
$ %
public
�
�
 
uint
�
�
 %
dwMaxRelAlarmOutChanNum
�
�
 /
;
�
�
/ 0
public
�
�
 
uint
�
�
 "
dwRelAlarmOutChanNum
�
�
 ,
;
�
�
, -
[
�
�
 
MarshalAsAttribute
�
�

(
�
�
  

�
�
  -
.
�
�
- .

ByValArray
�
�
. 8
,
�
�
8 9
	SizeConst
�
�
: C
=
�
�
D E
MAX_CHANNUM_V30
�
�
F U
,
�
�
U V
ArraySubType
�
�
W c
=
�
�
d e

�
�
f s
.
�
�
s t
U4
�
�
t v
)
�
�
v w
]
�
�
w x
public
�
�
 
uint
�
�
 
[
�
�
 
]
�
�
 

�
�
 '
;
�
�
' (
[
�
�
 
MarshalAsAttribute
�
�

(
�
�
  

�
�
  -
.
�
�
- .

ByValArray
�
�
. 8
,
�
�
8 9
	SizeConst
�
�
: C
=
�
�
D E
$num
�
�
F H
,
�
�
H I
ArraySubType
�
�
J V
=
�
�
W X

�
�
Y f
.
�
�
f g
I1
�
�
g i
)
�
�
i j
]
�
�
j k
public
�
�
 
byte
�
�
 
[
�
�
 
]
�
�
 
byRes
�
�
 
;
�
�
  
}
�
�
 	
[
�
�
 	#
StructLayoutAttribute
�
�
	 
(
�
�
 

LayoutKind
�
�
 )
.
�
�
) *

Sequential
�
�
* 4
)
�
�
4 5
]
�
�
5 6
public
�
�
 
struct
�
�
 )
NET_DVR_HANDLEEXCEPTION_V30
�
�
 1
{
�
�
 	
public
�
�
 
uint
�
�
 
dwHandleType
�
�
 $
;
�
�
$ %
[
�
�
 
MarshalAsAttribute
�
�

(
�
�
  

�
�
  -
.
�
�
- .

ByValArray
�
�
. 8
,
�
�
8 9
	SizeConst
�
�
: C
=
�
�
D E
MAX_ALARMOUT_V30
�
�
F V
,
�
�
V W
ArraySubType
�
�
X d
=
�
�
e f

�
�
g t
.
�
�
t u
I1
�
�
u w
)
�
�
w x
]
�
�
x y
public
�
�
 
byte
�
�
 
[
�
�
 
]
�
�
 

�
�
 '
;
�
�
' (
}
�
�
 	
[
�
�
 	#
StructLayoutAttribute
�
�
	 
(
�
�
 

LayoutKind
�
�
 )
.
�
�
) *

Sequential
�
�
* 4
)
�
�
4 5
]
�
�
5 6
public
�
�
 
struct
�
�
 %
NET_DVR_HANDLEEXCEPTION
�
�
 -
{
�
�
 	
public
�
�
 
uint
�
�
 
dwHandleType
�
�
 $
;
�
�
$ %
[
�
�
 
MarshalAsAttribute
�
�

(
�
�
  

�
�
  -
.
�
�
- .

ByValArray
�
�
. 8
,
�
�
8 9
	SizeConst
�
�
: C
=
�
�
D E
MAX_ALARMOUT
�
�
F R
,
�
�
R S
ArraySubType
�
�
T `
=
�
�
a b

�
�
c p
.
�
�
p q
I1
�
�
q s
)
�
�
s t
]
�
�
t u
public
�
�
 
byte
�
�
 
[
�
�
 
]
�
�
 

�
�
 '
;
�
�
' (
}
�
�
 	
[
�
�
 	#
StructLayoutAttribute
�
�
	 
(
�
�
 

LayoutKind
�
�
 )
.
�
�
) *

Sequential
�
�
* 4
)
�
�
4 5
]
�
�
5 6
public
�
�
 
struct
�
�
 
NET_DVR_DEVICECFG
�
�
 '
{
�
�
 	
public
�
�
 
uint
�
�
 
dwSize
�
�
 
;
�
�
 
[
�
�
 
MarshalAsAttribute
�
�

(
�
�
  

�
�
  -
.
�
�
- .

ByValArray
�
�
. 8
,
�
�
8 9
	SizeConst
�
�
: C
=
�
�
D E
NAME_LEN
�
�
F N
,
�
�
N O
ArraySubType
�
�
P \
=
�
�
] ^

�
�
_ l
.
�
�
l m
I1
�
�
m o
)
�
�
o p
]
�
�
p q
public
�
�
 
byte
�
�
 
[
�
�
 
]
�
�
 
sDVRName
�
�
 "
;
�
�
" #
public
�
�
 
uint
�
�
 
dwDVRID
�
�
 
;
�
�
  
public
�
�
 
uint
�
�
 
dwRecycleRecord
�
�
 '
;
�
�
' (
[
�
�
 
MarshalAsAttribute
�
�

(
�
�
  

�
�
  -
.
�
�
- .

ByValArray
�
�
. 8
,
�
�
8 9
	SizeConst
�
�
: C
=
�
�
D E
SERIALNO_LEN
�
�
F R
,
�
�
R S
ArraySubType
�
�
T `
=
�
�
a b

�
�
c p
.
�
�
p q
I1
�
�
q s
)
�
�
s t
]
�
�
t u
public
�
�
 
byte
�
�
 
[
�
�
 
]
�
�
 

�
�
 '
;
�
�
' (
public
�
�
 
uint
�
�
 
dwSoftwareVersion
�
�
 )
;
�
�
) *
public
�
�
 
uint
�
�
 !
dwSoftwareBuildDate
�
�
 +
;
�
�
+ ,
public
�
�
 
uint
�
�
 "
dwDSPSoftwareVersion
�
�
 ,
;
�
�
, -
public
�
�
 
uint
�
�
 $
dwDSPSoftwareBuildDate
�
�
 .
;
�
�
. /
public
�
�
 
uint
�
�
 
dwPanelVersion
�
�
 &
;
�
�
& '
public
�
�
 
uint
�
�
 
dwHardwareVersion
�
�
 )
;
�
�
) *
public
�
�
 
byte
�
�
 
byAlarmInPortNum
�
�
 (
;
�
�
( )
public
�
�
 
byte
�
�
 
byAlarmOutPortNum
�
�
 )
;
�
�
) *
public
�
�
 
byte
�
�
 

byRS232Num
�
�
 "
;
�
�
" #
public
�
�
 
byte
�
�
 

byRS485Num
�
�
 "
;
�
�
" #
public
�
�
 
byte
�
�
 
byNetworkPortNum
�
�
 (
;
�
�
( )
public
�
�
 
byte
�
�
 

�
�
 %
;
�
�
% &
public
�
�
 
byte
�
�
 
	byDiskNum
�
�
 !
;
�
�
! "
public
�
�
 
byte
�
�
 
	byDVRType
�
�
 !
;
�
�
! "
public
�
�
 
byte
�
�
 
	byChanNum
�
�
 !
;
�
�
! "
public
�
�
 
byte
�
�
 
byStartChan
�
�
 #
;
�
�
# $
public
�
�
 
byte
�
�
 

�
�
 %
;
�
�
% &
public
�
�
 
byte
�
�
 
byVGANum
�
�
  
;
�
�
  !
public
�
�
 
byte
�
�
 
byUSBNum
�
�
  
;
�
�
  !
public
�
�
 
byte
�
�
 
byAuxoutNum
�
�
 #
;
�
�
# $
public
�
�
 
byte
�
�
 

byAudioNum
�
�
 "
;
�
�
" #
public
�
�
 
byte
�
�
 
byIPChanNum
�
�
 #
;
�
�
# $
}
�
�
 	
[
�
�
 	#
StructLayoutAttribute
�
�
	 
(
�
�
 

LayoutKind
�
�
 )
.
�
�
) *

Sequential
�
�
* 4
,
�
�
4 5
CharSet
�
�
6 =
=
�
�
> ?
CharSet
�
�
@ G
.
�
�
G H
Ansi
�
�
H L
)
�
�
L M
]
�
�
M N
public
�
�
 
struct
�
�
 
NET_DVR_IPADDR
�
�
 $
{
�
�
 	
[
�
�
 
MarshalAsAttribute
�
�

(
�
�
  

�
�
  -
.
�
�
- .
	ByValTStr
�
�
. 7
,
�
�
7 8
	SizeConst
�
�
9 B
=
�
�
C D
$num
�
�
E G
)
�
�
G H
]
�
�
H I
public
�
�
 
string
�
�
 
sIpV4
�
�
 
;
�
�
  
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F I
,
��I J
ArraySubType
��K W
=
��X Y

��Z g
.
��g h
I1
��h j
)
��j k
]
��k l
public
�� 
byte
�� 
[
�� 
]
�� 
byRes
�� 
;
��  
public
�� 
void
�� 
Init
�� 
(
�� 
)
�� 
{
�� 
byRes
�� 
=
�� 
new
�� 
byte
��  
[
��  !
$num
��! $
]
��$ %
;
��% &
}
�� 
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� "
NET_DVR_ETHERNET_V30
�� *
{
�� 	
public
�� 
NET_DVR_IPADDR
�� !
	struDVRIP
��" +
;
��+ ,
public
�� 
NET_DVR_IPADDR
�� !

��" /
;
��/ 0
public
�� 
uint
�� 
dwNetInterface
�� &
;
��& '
public
�� 
ushort
�� 
wDVRPort
�� "
;
��" #
public
�� 
ushort
�� 
wMTU
�� 
;
�� 
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MACADDR_LEN
��F Q
,
��Q R
ArraySubType
��S _
=
��` a

��b o
.
��o p
I1
��p r
)
��r s
]
��s t
public
�� 
byte
�� 
[
�� 
]
�� 
	byMACAddr
�� #
;
��# $
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F G
,
��G H
ArraySubType
��I U
=
��V W

��X e
.
��e f
I1
��f h
)
��h i
]
��i j
public
�� 
byte
�� 
[
�� 
]
�� 
byRes
�� 
;
��  
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
,
��4 5
CharSet
��6 =
=
��> ?
CharSet
��@ G
.
��G H
Ansi
��H L
)
��L M
]
��M N
public
�� 
struct
�� 
NET_DVR_ETHERNET
�� &
{
�� 	
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .
	ByValTStr
��. 7
,
��7 8
	SizeConst
��9 B
=
��C D
$num
��E G
)
��G H
]
��H I
public
�� 
string
�� 
sDVRIP
��  
;
��  !
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .
	ByValTStr
��. 7
,
��7 8
	SizeConst
��9 B
=
��C D
$num
��E G
)
��G H
]
��H I
public
�� 
string
�� 

sDVRIPMask
�� $
;
��$ %
public
�� 
uint
�� 
dwNetInterface
�� &
;
��& '
public
�� 
ushort
�� 
wDVRPort
�� "
;
��" #
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MACADDR_LEN
��F Q
,
��Q R
ArraySubType
��S _
=
��` a

��b o
.
��o p
I1
��p r
)
��r s
]
��s t
public
�� 
byte
�� 
[
�� 
]
�� 
	byMACAddr
�� #
;
��# $
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
,
��4 5
CharSet
��6 =
=
��> ?
CharSet
��@ G
.
��G H
Ansi
��H L
)
��L M
]
��M N
public
�� 
struct
�� 
NET_DVR_PPPOECFG
�� &
{
�� 	
public
�� 
uint
�� 
dwPPPOE
�� 
;
��  
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
NAME_LEN
��F N
,
��N O
ArraySubType
��P \
=
��] ^

��_ l
.
��l m
I1
��m o
)
��o p
]
��p q
public
�� 
byte
�� 
[
�� 
]
�� 

sPPPoEUser
�� $
;
��$ %
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .
	ByValTStr
��. 7
,
��7 8
	SizeConst
��9 B
=
��C D

PASSWD_LEN
��E O
)
��O P
]
��P Q
public
�� 
string
�� 
sPPPoEPassword
�� (
;
��( )
public
�� 
NET_DVR_IPADDR
�� !
struPPPoEIP
��" -
;
��- .
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
��  
NET_DVR_NETCFG_V30
�� (
{
�� 	
public
�� 
uint
�� 
dwSize
�� 
;
�� 
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_ETHERNET
��F R
,
��R S
ArraySubType
��T `
=
��a b

��c p
.
��p q
Struct
��q w
)
��w x
]
��x y
public
�� "
NET_DVR_ETHERNET_V30
�� '
[
��' (
]
��( )
struEtherNet
��* 6
;
��6 7
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F G
,
��G H
ArraySubType
��I U
=
��V W

��X e
.
��e f
Struct
��f l
)
��l m
]
��m n
public
�� 
NET_DVR_IPADDR
�� !
[
��! "
]
��" #
struRes1
��$ ,
;
��, -
public
�� 
NET_DVR_IPADDR
�� !!
struAlarmHostIpAddr
��" 5
;
��5 6
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F G
,
��G H
ArraySubType
��I U
=
��V W

��X e
.
��e f
I1
��f h
)
��h i
]
��i j
public
�� 
byte
�� 
[
�� 
]
�� 
byRes2
��  
;
��  !
public
�� 
ushort
�� 
wAlarmHostIpPort
�� *
;
��* +
public
�� 
byte
�� 
	byUseDhcp
�� !
;
��! "
public
�� 
byte
�� 
byRes3
�� 
;
�� 
public
�� 
NET_DVR_IPADDR
�� !"
struDnsServer1IpAddr
��" 6
;
��6 7
public
�� 
NET_DVR_IPADDR
�� !"
struDnsServer2IpAddr
��" 6
;
��6 7
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_DOMAIN_NAME
��F U
,
��U V
ArraySubType
��W c
=
��d e

��f s
.
��s t
I1
��t v
)
��v w
]
��w x
public
�� 
byte
�� 
[
�� 
]
�� 
byIpResolver
�� &
;
��& '
public
�� 
ushort
�� 
wIpResolverPort
�� )
;
��) *
public
�� 
ushort
�� 
wHttpPortNo
�� %
;
��% &
public
�� 
NET_DVR_IPADDR
�� !!
struMulticastIpAddr
��" 5
;
��5 6
public
�� 
NET_DVR_IPADDR
�� !
struGatewayIpAddr
��" 3
;
��3 4
public
�� 
NET_DVR_PPPOECFG
�� #
	struPPPoE
��$ -
;
��- .
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F H
,
��H I
ArraySubType
��J V
=
��W X

��Y f
.
��f g
I1
��g i
)
��i j
]
��j k
public
�� 
byte
�� 
[
�� 
]
�� 
byRes
�� 
;
��  
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� $
NET_DVR_ETHERNET_MULTI
�� ,
{
�� 	
public
�� 
NET_DVR_IPADDR
�� !
	struDVRIP
��" +
;
��+ ,
public
�� 
NET_DVR_IPADDR
�� !

��" /
;
��/ 0
public
�� 
uint
�� 
dwNetInterface
�� &
;
��& '
public
�� 
byte
�� 

byCardType
�� "
;
��" #
public
�� 
byte
�� 
byRes1
�� 
;
�� 
public
�� 
ushort
�� 
wMTU
�� 
;
�� 
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MACADDR_LEN
��F Q
,
��Q R
ArraySubType
��S _
=
��` a

��b o
.
��o p
I1
��p r
)
��r s
]
��s t
public
�� 
byte
�� 
[
�� 
]
�� 
	byMACAddr
�� #
;
��# $
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F G
,
��G H
ArraySubType
��I U
=
��V W

��X e
.
��e f
I1
��f h
)
��h i
]
��i j
public
�� 
byte
�� 
[
�� 
]
�� 
byRes2
��  
;
��  !
public
�� 
byte
�� 
	byUseDhcp
�� !
;
��! "
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F G
,
��G H
ArraySubType
��I U
=
��V W

��X e
.
��e f
I1
��f h
)
��h i
]
��i j
public
�� 
byte
�� 
[
�� 
]
�� 
byRes3
��  
;
��  !
public
�� 
NET_DVR_IPADDR
�� !
struGatewayIpAddr
��" 3
;
��3 4
public
�� 
NET_DVR_IPADDR
�� !"
struDnsServer1IpAddr
��" 6
;
��6 7
public
�� 
NET_DVR_IPADDR
�� !"
struDnsServer2IpAddr
��" 6
;
��6 7
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� "
NET_DVR_NETCFG_MULTI
�� *
{
�� 	
public
�� 
uint
�� 
dwSize
�� 
;
�� 
public
�� 
byte
�� 
byDefaultRoute
�� &
;
��& '
public
�� 
byte
�� 
byNetworkCardNum
�� (
;
��( )
public
�� 
byte
�� 

byWorkMode
�� "
;
��" #
public
�� 
byte
�� 
byRes
�� 
;
�� 
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_NETWORK_CARD
��F V
,
��V W
ArraySubType
��X d
=
��e f

��g t
.
��t u
Struct
��u {
)
��{ |
]
��| }
public
�� $
NET_DVR_ETHERNET_MULTI
�� )
[
��) *
]
��* +
struEtherNet
��, 8
;
��8 9
public
�� 
NET_DVR_IPADDR
�� !#
struManageHost1IpAddr
��" 7
;
��7 8
public
�� 
NET_DVR_IPADDR
�� !#
struManageHost2IpAddr
��" 7
;
��7 8
public
�� 
NET_DVR_IPADDR
�� !!
struAlarmHostIpAddr
��" 5
;
��5 6
public
�� 
ushort
�� 
wManageHost1Port
�� *
;
��* +
public
�� 
ushort
�� 
wManageHost2Port
�� *
;
��* +
public
�� 
ushort
�� 
wAlarmHostIpPort
�� *
;
��* +
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_DOMAIN_NAME
��F U
,
��U V
ArraySubType
��W c
=
��d e

��f s
.
��s t
I1
��t v
)
��v w
]
��w x
public
�� 
byte
�� 
[
�� 
]
�� 
byIpResolver
�� &
;
��& '
public
�� 
ushort
�� 
wIpResolverPort
�� )
;
��) *
public
�� 
ushort
�� 
wDvrPort
�� "
;
��" #
public
�� 
ushort
�� 
wHttpPortNo
�� %
;
��% &
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F G
,
��G H
ArraySubType
��I U
=
��V W

��X e
.
��e f
I1
��f h
)
��h i
]
��i j
public
�� 
byte
�� 
[
�� 
]
�� 
byRes2
��  
;
��  !
public
�� 
NET_DVR_IPADDR
�� !!
struMulticastIpAddr
��" 5
;
��5 6
public
�� 
NET_DVR_PPPOECFG
�� #
	struPPPoE
��$ -
;
��- .
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F H
,
��H I
ArraySubType
��J V
=
��W X

��Y f
.
��f g
I1
��g i
)
��i j
]
��j k
public
�� 
byte
�� 
[
�� 
]
�� 
byRes3
��  
;
��  !
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
,
��4 5
CharSet
��6 =
=
��> ?
CharSet
��@ G
.
��G H
Ansi
��H L
)
��L M
]
��M N
public
�� 
struct
�� 
NET_DVR_NETCFG
�� $
{
�� 	
public
�� 
uint
�� 
dwSize
�� 
;
�� 
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_ETHERNET
��F R
,
��R S
ArraySubType
��T `
=
��a b

��c p
.
��p q
Struct
��q w
)
��w x
]
��x y
public
�� 
NET_DVR_ETHERNET
�� #
[
��# $
]
��$ %
struEtherNet
��& 2
;
��2 3
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .
	ByValTStr
��. 7
,
��7 8
	SizeConst
��9 B
=
��C D
$num
��E G
)
��G H
]
��H I
public
�� 
string
�� 

�� '
;
��' (
public
�� 
ushort
�� 
wManageHostPort
�� )
;
��) *
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .
	ByValTStr
��. 7
,
��7 8
	SizeConst
��9 B
=
��C D
$num
��E G
)
��G H
]
��H I
public
�� 
string
�� 
sIPServerIP
�� %
;
��% &
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .
	ByValTStr
��. 7
,
��7 8
	SizeConst
��9 B
=
��C D
$num
��E G
)
��G H
]
��H I
public
�� 
string
�� 
sMultiCastIP
�� &
;
��& '
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .
	ByValTStr
��. 7
,
��7 8
	SizeConst
��9 B
=
��C D
$num
��E G
)
��G H
]
��H I
public
�� 
string
�� 

sGatewayIP
�� $
;
��$ %
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .
	ByValTStr
��. 7
,
��7 8
	SizeConst
��9 B
=
��C D
$num
��E G
)
��G H
]
��H I
public
�� 
string
�� 
sNFSIP
��  
;
��  !
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
PATHNAME_LEN
��F R
,
��R S
ArraySubType
��T `
=
��a b

��c p
.
��p q
I1
��q s
)
��s t
]
��t u
public
�� 
byte
�� 
[
�� 
]
�� 

�� '
;
��' (
public
�� 
uint
�� 
dwPPPOE
�� 
;
��  
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
NAME_LEN
��F N
,
��N O
ArraySubType
��P \
=
��] ^

��_ l
.
��l m
I1
��m o
)
��o p
]
��p q
public
�� 
byte
�� 
[
�� 
]
�� 

sPPPoEUser
�� $
;
��$ %
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .
	ByValTStr
��. 7
,
��7 8
	SizeConst
��9 B
=
��C D

PASSWD_LEN
��E O
)
��O P
]
��P Q
public
�� 
string
�� 
sPPPoEPassword
�� (
;
��( )
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .
	ByValTStr
��. 7
,
��7 8
	SizeConst
��9 B
=
��C D
$num
��E G
)
��G H
]
��H I
public
�� 
string
�� 
sPPPoEIP
�� "
;
��" #
public
�� 
ushort
�� 
	wHttpPort
�� #
;
��# $
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
,
��4 5
CharSet
��6 =
=
��> ?
CharSet
��@ G
.
��G H
Ansi
��H L
)
��L M
]
��M N
public
�� 
struct
�� 
NET_DVR_SIP_CFG
�� %
{
�� 	
public
�� 
uint
�� 
dwSize
�� 
;
�� 
public
�� 
byte
�� 
byEnableAutoLogin
�� )
;
��) *
public
�� 
byte
�� 

�� %
;
��% &
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F G
,
��G H
ArraySubType
��I U
=
��V W

��X e
.
��e f
I1
��f h
)
��h i
]
��i j
public
�� 
byte
�� 
[
�� 
]
�� 
byRes1
��  
;
��  !
public
�� 
NET_DVR_IPADDR
�� !
stuServerIP
��" -
;
��- .
public
�� 
ushort
�� 
wServerPort
�� %
;
��% &
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F G
,
��G H
ArraySubType
��I U
=
��V W

��X e
.
��e f
I1
��f h
)
��h i
]
��i j
public
�� 
byte
�� 
[
�� 
]
�� 
byRes2
��  
;
��  !
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
NAME_LEN
��F N
,
��N O
ArraySubType
��P \
=
��] ^

��_ l
.
��l m
I1
��m o
)
��o p
]
��p q
public
�� 
byte
�� 
[
�� 
]
�� 

byUserName
�� $
;
��$ %
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E

PASSWD_LEN
��F P
,
��P Q
ArraySubType
��R ^
=
��_ `

��a n
.
��n o
I1
��o q
)
��q r
]
��r s
public
�� 
byte
�� 
[
�� 
]
�� 

byPassWord
�� $
;
��$ %
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_NUMBER_LEN
��F T
,
��T U
ArraySubType
��V b
=
��c d

��e r
.
��r s
I1
��s u
)
��u v
]
��v w
public
�� 
byte
�� 
[
�� 
]
�� 
	byLocalNo
�� #
;
��# $
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_NAME_LEN
��F R
,
��R S
ArraySubType
��T `
=
��a b

��c p
.
��p q
I1
��q s
)
��s t
]
��t u
public
�� 
byte
�� 
[
�� 
]
�� 

�� '
;
��' (
public
�� 
ushort
�� 

wLocalPort
�� $
;
��$ %
public
�� 
byte
�� 
byLoginCycle
�� $
;
��$ %
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F I
,
��I J
ArraySubType
��K W
=
��X Y

��Z g
.
��g h
I1
��h j
)
��j k
]
��k l
public
�� 
byte
�� 
[
�� 
]
�� 
byRes
�� 
;
��  
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
,
��4 5
CharSet
��6 =
=
��> ?
CharSet
��@ G
.
��G H
Ansi
��H L
)
��L M
]
��M N
public
�� 
struct
�� $
NET_DVR_IP_VIEW_DEVCFG
�� ,
{
�� 	
public
�� 
uint
�� 
dwSize
�� 
;
�� 
public
�� 
byte
�� 

�� %
;
��% &
public
�� 
byte
�� 
byRingVolume
�� $
;
��$ %
public
�� 
byte
�� 

�� %
;
��% &
public
�� 
byte
�� 
byOutputVolume
�� &
;
��& '
public
�� 
ushort
�� 
wRtpPort
�� "
;
��" #
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F G
,
��G H
ArraySubType
��I U
=
��V W

��X e
.
��e f
I1
��f h
)
��h i
]
��i j
public
�� 
byte
�� 
[
�� 
]
�� 
byRes1
��  
;
��  !
public
�� 
uint
��  
dwPreviewDelayTime
�� *
;
��* +
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F H
,
��H I
ArraySubType
��J V
=
��W X

��Y f
.
��f g
I1
��g i
)
��i j
]
��j k
public
�� 
byte
�� 
[
�� 
]
�� 
byRes2
��  
;
��  !
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
,
��4 5
CharSet
��6 =
=
��> ?
CharSet
��@ G
.
��G H
Ansi
��H L
)
��L M
]
��M N
public
�� 
struct
�� '
NET_DVR_IP_VIEW_AUDIO_CFG
�� /
{
�� 	
public
�� 
uint
�� 
dwSize
�� 
;
�� 
public
�� 
byte
�� 
byAudioEncPri1
�� &
;
��& '
public
�� 
byte
�� 
byAudioEncPri2
�� &
;
��& '
public
�� 
ushort
�� 
wAudioPacketLen1
�� *
;
��* +
public
�� 
ushort
�� 
wAudioPacketLen2
�� *
;
��* +
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F H
,
��H I
ArraySubType
��J V
=
��W X

��Y f
.
��f g
I1
��g i
)
��i j
]
��j k
public
�� 
byte
�� 
[
�� 
]
�� 
byRes
�� 
;
��  
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
,
��4 5
CharSet
��6 =
=
��> ?
CharSet
��@ G
.
��G H
Ansi
��H L
)
��L M
]
��M N
public
�� 
struct
�� &
NET_DVR_IP_VIEW_CALL_CFG
�� .
{
�� 	
public
�� 
uint
�� 
dwSize
�� 
;
�� 
public
�� 
byte
�� "
byEnableAutoResponse
�� ,
;
��, -
public
�� 
byte
��  
byAudoResponseTime
�� *
;
��* +
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F G
,
��G H
ArraySubType
��I U
=
��V W

��X e
.
��e f
I1
��f h
)
��h i
]
��i j
public
�� 
byte
�� 
[
�� 
]
�� 
byRes1
��  
;
��  !
public
�� 
byte
�� "
byEnableAlarmNumber1
�� ,
;
��, -
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F G
,
��G H
ArraySubType
��I U
=
��V W

��X e
.
��e f
I1
��f h
)
��h i
]
��i j
public
�� 
byte
�� 
[
�� 
]
�� 
byRes
�� 
;
��  
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_NUMBER_LEN
��F T
,
��T U
ArraySubType
��V b
=
��c d

��e r
.
��r s
I1
��s u
)
��u v
]
��v w
public
�� 
byte
�� 
[
�� 
]
�� 
byAlarmNumber1
�� (
;
��( )
public
�� 
byte
�� "
byEnableAlarmNumber2
�� ,
;
��, -
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F G
,
��G H
ArraySubType
��I U
=
��V W

��X e
.
��e f
I1
��f h
)
��h i
]
��i j
public
�� 
byte
�� 
[
�� 
]
�� 
byRes3
��  
;
��  !
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_NUMBER_LEN
��F T
,
��T U
ArraySubType
��V b
=
��c d

��e r
.
��r s
I1
��s u
)
��u v
]
��v w
public
�� 
byte
�� 
[
�� 
]
�� 
byAlarmNumber2
�� (
;
��( )
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F H
,
��H I
ArraySubType
��J V
=
��W X

��Y f
.
��f g
I1
��g i
)
��i j
]
��j k
public
�� 
byte
�� 
[
�� 
]
�� 
byRes4
��  
;
��  !
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
,
��4 5
CharSet
��6 =
=
��> ?
CharSet
��@ G
.
��G H
Ansi
��H L
)
��L M
]
��M N
public
�� 
struct
��  
NET_DVR_RECORDCHAN
�� (
{
�� 	
public
�� 
uint
��  
dwMaxRecordChanNum
�� *
;
��* +
public
�� 
uint
��  
dwCurRecordChanNum
�� *
;
��* +
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_CHANNUM_V30
��F U
,
��U V
ArraySubType
��W c
=
��d e

��f s
.
��s t
U4
��t v
)
��v w
]
��w x
public
�� 
uint
�� 
dwRelRecordChan
�� '
;
��' (
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F H
,
��H I
ArraySubType
��J V
=
��W X

��Y f
.
��f g
I1
��g i
)
��i j
]
��j k
public
�� 
byte
�� 
[
�� 
]
�� 
byRes
�� 
;
��  
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
��  
NET_DVR_MOTION_V30
�� (
{
�
[
�
MarshalAsAttribute
�
(
�

�
.
�

ByValArray
�
,
�
	SizeConst
�
=
�
$num
�
*
�
$num
�
,
�
ArraySubType
�
=
�

�
.
�
I1
�
)
�
]
�
public
�
byte
�
[
�
]
�

�
;
�
public
�
byte
�
byMotionSensitive
�
;
�
public
�
byte
�
byEnableHandleMotion
�
;
�
public
�
byte
�
byEnableDisplay
�
;
�
public
�
byte
�
reservedData
�
;
�
public
�
NET_DVR_HANDLEEXCEPTION_V30
�
struMotionHandleType
�
;
�
[
�
MarshalAsAttribute
�
(
�

�
.
�

ByValArray
�
,
�
	SizeConst
�
=
�
MAX_DAYS
�
*
�
MAX_TIMESEGMENT_V30
�
,
�
ArraySubType
�
=
�

.�
Struct�
)�
]�
public
�
NET_DVR_SCHEDTIME
�
[
�
]
�

�
;
�
[
�
MarshalAsAttribute
�
(
�

�
.
�

ByValArray
�
,
�
	SizeConst
�
=
�
MAX_CHANNUM_V30
�
,
�
ArraySubType
�
=
�

�
.
�
I1
�
)
�
]
�
public
�
byte
�
[
�
]
�
byRelRecordChan
�
;
�
}
�
[
�
StructLayoutAttribute
�
(
�

LayoutKind
�
.
�

Sequential
�
,
�
CharSet
�
=
�
CharSet
�
.
�
Ansi
�
)
�
]
�
public
�
struct
�
NET_DVR_MOTION
�
{
�
[
�
MarshalAsAttribute
�
(
�

�
.
�

ByValArray
�
,
�
	SizeConst
�
=
�
$num
�
,
�
ArraySubType
�
=
�

�
.
�
I1
�
)
�
]
�
public
�
byte
�
[
�
]
�

�
;
�
public
�
byte
�
byMotionSensitive
�
;
�
public
�
byte
�
byEnableHandleMotion
�
;
�
[
�
MarshalAsAttribute
�
(
�

�
.
�
	ByValTStr
�
,
�
	SizeConst
�
=
�
$num
�
)
�
]
�
public
�
string
�
reservedData
�
;
�
public
�
NET_DVR_HANDLEEXCEPTION
�
strMotionHandleType
�
;
�
[
�
MarshalAsAttribute
�
(
�

�
.
�

ByValArray
�
,
�
	SizeConst
�
=
�
MAX_DAYS
�
*
�
MAX_TIMESEGMENT
�
,
�
ArraySubType
�
=
�

�
.
�
Struct�
)�
]�
public
�
NET_DVR_SCHEDTIME
�
[
�
]
�

�
;
�
[
�
MarshalAsAttribute
�
(
�

�
.
�

ByValArray
�
,
�
	SizeConst
�
=
�
MAX_CHANNUM
�
,
�
ArraySubType
�
=
�

�
.
�
I1
�
)
�
]
�
public
�
byte
�
[
�
]
�
byRelRecordChan
�
;
�
}
�
[
�
StructLayoutAttribute
�
(
�

LayoutKind
�
.
�

Sequential
�
)
�
]
�
public
�
struct
�
NET_DVR_HIDEALARM_V30
�
{
�
public
�
uint
�
dwEnableHideAlarm
�
;
�
public
�
ushort
�
wHideAlarmAreaTopLeftX
�
;
�
public
�
ushort
�
wHideAlarmAreaTopLeftY
�
;
�
public
�
ushort
�
wHideAlarmAreaWidth
�
;
�
public
�
ushort
�
wHideAlarmAreaHeight
�
;
�
public
�
NET_DVR_HANDLEEXCEPTION_V30
�
strHideAlarmHandleType
�
;
�
[
�
MarshalAsAttribute
�
(
�

�
.
�

ByValArray
�
,
�
	SizeConst
�
=
�
MAX_DAYS
�
*
�
MAX_TIMESEGMENT_V30
�
,
�
ArraySubType
�
=
�

.�
Struct�
)�
]�
public
�
NET_DVR_SCHEDTIME
�
[
�
]
�

�
;
�
}
�
[
�
StructLayoutAttribute
�
(
�

LayoutKind
�
.
�

Sequential
�
)
�
]
�
public
�
struct
�
NET_DVR_HIDEALARM
�
{
�
public
�
uint
�
dwEnableHideAlarm
�
;
�
public
�
ushort
�
wHideAlarmAreaTopLeftX
�
;
�
public
�
ushort
�
wHideAlarmAreaTopLeftY
�
;
�
public
�
ushort
�
wHideAlarmAreaWidth
�
;
�
public
�
ushort
�
wHideAlarmAreaHeight
�
;
�
public
�
NET_DVR_HANDLEEXCEPTION
�
strHideAlarmHandleType
�
;
�
[
�
MarshalAsAttribute
�
(
�

�
.
�

ByValArray
�
,
�
	SizeConst
�
=
�
MAX_DAYS
�
*
�
MAX_TIMESEGMENT
�
,
�
ArraySubType
�
=
�

�
.
�
Struct�
)�
]�
public
�
NET_DVR_SCHEDTIME
�
[
�
]
�

�
;
�
}
�
[
�
StructLayoutAttribute
�
(
�

LayoutKind
�
.
�

Sequential
�
)
�
]
�
public
�
struct
�
NET_DVR_VILOST_V30
�
{
�
public
�
byte
�
byEnableHandleVILost
�
;
�
public
�
NET_DVR_HANDLEEXCEPTION_V30
�
strVILostHandleType
�
;
�
[
�
MarshalAsAttribute
�
(
�

�
.
�

ByValArray
�
,
�
	SizeConst
�
=
�
$num
�
,
�
ArraySubType
�
=
�

�
.
�
Struct
�
)
�
]
�
public
�
NET_DVR_SCHEDTIME
�
[
�
]
�

�
;
�
}
�
[
�
StructLayoutAttribute
�
(
�

LayoutKind
�
.
�

Sequential
�
)
�
]
�
public
�
struct
�
NET_DVR_VILOST
�
{
�
public
�
byte
�
byEnableHandleVILost
�
;
�
public
�
NET_DVR_HANDLEEXCEPTION
�
strVILostHandleType
�
;
�
[
�
MarshalAsAttribute
�
(
�

�
.
�

ByValArray
�
,
�
	SizeConst
�
=
�
MAX_DAYS
�
*
�
MAX_TIMESEGMENT_V30
�
,
�
ArraySubType
�
=
�

.�
Struct�
)�
]�
public
�
NET_DVR_SCHEDTIME
�
[
�
]
�

�
;
�
}
�
[
�
System
�
.
�
Runtime
�
.
�
InteropServices
�
.
�
StructLayoutAttribute
�
(
�
System
�
.
�
Runtime
�
.
�
InteropServices
�
.
�

LayoutKind
�
.
�

Sequential
�
)
�
]
�
public
�
struct
�
NET_DVR_SHELTER
�
{
�
public
�
ushort
�
wHideAreaTopLeftX
�
;
�
public
�
ushort
�
wHideAreaTopLeftY
�
;
�
public
�
ushort
�
wHideAreaWidth
�
;
�
public
�
ushort
�
wHideAreaHeight
�
;
�
}
�
[
�
StructLayoutAttribute
�
(
�

LayoutKind
�
.
�

Sequential
�
)
�
]
�
public
�
struct
�

�
{
�
public
�
byte
�
byBrightness
�
;
�
public
�
byte
�

byContrast
�
;
�
public
�
byte
�
bySaturation
�
;
�
public
�
byte
�
byHue
�
;
�
}
�
[
�
StructLayoutAttribute
�
(
�

LayoutKind
�
.
�

Sequential
�
,
�
CharSet
�
=
�
CharSet
�
.
�
Ansi
�
)
�
]
�
public
�
struct
�
NET_DVR_PICCFG_V30
�
{
�
public
�
uint
�
dwSize
�
;
�
[
�
MarshalAsAttribute
�
(
�

�
.
�

ByValArray
�
,
�
	SizeConst
�
=
�
NAME_LEN
�
,
�
ArraySubType
�
=
�

�
.
�
I1
�
)
�
]
�
public
�
byte
�
[
�
]
�
	sChanName
�
;
�
public
�
uint
�

�
;
�
[
�
MarshalAsAttribute
�
(
�

�
.
�

ByValArray
�
,
�
	SizeConst
�
=
�
$num
�
,
�
ArraySubType
�
=
�

�
.
�
I1
�
)
�
]
�
public
�
byte
�
[
�
]
�
byReservedData
�
;
�
public
�
uint
�
dwShowChanName
�
;
�
public
�
ushort
�
wShowNameTopLeftX
�
;
�
public
�
ushort
�
wShowNameTopLeftY
�
;
�
public
�
NET_DVR_VILOST_V30
�

struVILost
�
;
�
public
�
NET_DVR_VILOST_V30
�
struRes
�
;
�
public
�
NET_DVR_MOTION_V30
�

struMotion
�
;
�
public
�
NET_DVR_HIDEALARM_V30
�

�
;
�
public
�
uint
�
dwEnableHide
�
;
�
[
�
MarshalAsAttribute
�
(
�

�
.
�

ByValArray
�
,
�
	SizeConst
�
=
�
MAX_SHELTERNUM
�
,
�
ArraySubType
�
=
�

�
.
�
Struct
�
)
�
]
�
public
�
NET_DVR_SHELTER
�
[
�
]
�
struShelter
�
;
�
public
�
uint
�
	dwShowOsd
�
;
�
public
�
ushort
�
wOSDTopLeftX
�
;
�
public
�
ushort
�
wOSDTopLeftY
�
;
�
public
�
byte
�
	byOSDType
�
;
�
public
�� 
byte
�� 

byDispWeek
�� "
;
��" #
public
�� 
byte
�� 
byOSDAttrib
�� #
;
��# $
public
�� 
byte
�� 

�� %
;
��% &
public
�� 
byte
�� 

byFontSize
�� "
;
��" #
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F H
,
��H I
ArraySubType
��J V
=
��W X

��Y f
.
��f g
I1
��g i
)
��i j
]
��j k
public
�� 
byte
�� 
[
�� 
]
�� 
byRes
�� 
;
��  
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� 
NET_DVR_PICCFG_EX
�� '
{
�� 	
public
�� 
uint
�� 
dwSize
�� 
;
�� 
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
NAME_LEN
��F N
,
��N O
ArraySubType
��P \
=
��] ^

��_ l
.
��l m
I1
��m o
)
��o p
]
��p q
public
�� 
byte
�� 
[
�� 
]
�� 
	sChanName
�� #
;
��# $
public
�� 
uint
�� 

�� %
;
��% &
public
�� 
byte
�� 
byBrightness
�� $
;
��$ %
public
�� 
byte
�� 

byContrast
�� "
;
��" #
public
�� 
byte
�� 
bySaturation
�� $
;
��$ %
public
�� 
byte
�� 
byHue
�� 
;
�� 
public
�� 
uint
�� 
dwShowChanName
�� &
;
��& '
public
�� 
ushort
�� 
wShowNameTopLeftX
�� +
;
��+ ,
public
�� 
ushort
�� 
wShowNameTopLeftY
�� +
;
��+ ,
public
�� 
NET_DVR_VILOST
�� !

struVILost
��" ,
;
��, -
public
�� 
NET_DVR_MOTION
�� !

struMotion
��" ,
;
��, -
public
�� 
NET_DVR_HIDEALARM
�� $

��% 2
;
��2 3
public
�� 
uint
�� 
dwEnableHide
�� $
;
��$ %
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_SHELTERNUM
��F T
,
��T U
ArraySubType
��V b
=
��c d

��e r
.
��r s
Struct
��s y
)
��y z
]
��z {
public
�� 
NET_DVR_SHELTER
�� "
[
��" #
]
��# $
struShelter
��% 0
;
��0 1
public
�� 
uint
�� 
	dwShowOsd
�� !
;
��! "
public
�� 
ushort
�� 
wOSDTopLeftX
�� &
;
��& '
public
�� 
ushort
�� 
wOSDTopLeftY
�� &
;
��& '
public
�� 
byte
�� 
	byOSDType
�� !
;
��! "
public
�� 
byte
�� 

byDispWeek
�� "
;
��" #
public
�� 
byte
�� 
byOSDAttrib
�� #
;
��# $
public
�� 
byte
�� 

�� %
;
��% &
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� 
NET_DVR_PICCFG
�� $
{
�� 	
public
�� 
uint
�� 
dwSize
�� 
;
�� 
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
NAME_LEN
��F N
,
��N O
ArraySubType
��P \
=
��] ^

��_ l
.
��l m
I1
��m o
)
��o p
]
��p q
public
�� 
byte
�� 
[
�� 
]
�� 
	sChanName
�� #
;
��# $
public
�� 
uint
�� 

�� %
;
��% &
public
�� 
byte
�� 
byBrightness
�� $
;
��$ %
public
�� 
byte
�� 

byContrast
�� "
;
��" #
public
�� 
byte
�� 
bySaturation
�� $
;
��$ %
public
�� 
byte
�� 
byHue
�� 
;
�� 
public
�� 
uint
�� 
dwShowChanName
�� &
;
��& '
public
�� 
ushort
�� 
wShowNameTopLeftX
�� +
;
��+ ,
public
�� 
ushort
�� 
wShowNameTopLeftY
�� +
;
��+ ,
public
�� 
NET_DVR_VILOST
�� !

struVILost
��" ,
;
��, -
public
�� 
NET_DVR_MOTION
�� !

struMotion
��" ,
;
��, -
public
�� 
NET_DVR_HIDEALARM
�� $

��% 2
;
��2 3
public
�� 
uint
�� 
dwEnableHide
�� $
;
��$ %
public
�� 
ushort
�� 
wHideAreaTopLeftX
�� +
;
��+ ,
public
�� 
ushort
�� 
wHideAreaTopLeftY
�� +
;
��+ ,
public
�� 
ushort
�� 
wHideAreaWidth
�� (
;
��( )
public
�� 
ushort
�� 
wHideAreaHeight
�� )
;
��) *
public
�� 
uint
�� 
	dwShowOsd
�� !
;
��! "
public
�� 
ushort
�� 
wOSDTopLeftX
�� &
;
��& '
public
�� 
ushort
�� 
wOSDTopLeftY
�� &
;
��& '
public
�� 
byte
�� 
	byOSDType
�� !
;
��! "
public
�� 
byte
�� 

byDispWeek
�� "
;
��" #
public
�� 
byte
�� 
byOSDAttrib
�� #
;
��# $
public
�� 
byte
�� 

�� %
;
��% &
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� *
NET_DVR_COMPRESSION_INFO_V30
�� 2
{
�� 	
public
�� 
byte
�� 
byStreamType
�� $
;
��$ %
public
�� 
byte
�� 
byResolution
�� $
;
��$ %
public
�� 
byte
�� 

�� %
;
��% &
public
�� 
byte
�� 
byPicQuality
�� $
;
��$ %
public
�� 
uint
�� 
dwVideoBitrate
�� &
;
��& '
public
�� 
uint
�� 
dwVideoFrameRate
�� (
;
��( )
public
�� 
ushort
�� 
wIntervalFrameI
�� )
;
��) *
public
�� 
byte
�� 
byIntervalBPFrame
�� )
;
��) *
public
�� 
byte
�� 
byres1
�� 
;
�� 
public
�� 
byte
�� 
byVideoEncType
�� &
;
��& '
public
�� 
byte
�� 
byAudioEncType
�� &
;
��& '
public
�� 
byte
�� "
byVideoEncComplexity
�� ,
;
��, -
public
�� 
byte
�� 
byEnableSvc
�� #
;
��# $
public
�� 
byte
�� 
byFormatType
�� $
;
��$ %
public
�� 
byte
�� 
byAudioBitRate
�� &
;
��& '
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F G
,
��G H
ArraySubType
��I U
=
��V W

��X e
.
��e f
I1
��f h
)
��h i
]
��i j
public
�� 
byte
�� 
[
�� 
]
�� 
byres
�� 
;
��  
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� (
NET_DVR_COMPRESSIONCFG_V30
�� 0
{
�� 	
public
�� 
uint
�� 
dwSize
�� 
;
�� 
public
�� *
NET_DVR_COMPRESSION_INFO_V30
�� /$
struNormHighRecordPara
��0 F
;
��F G
public
�� *
NET_DVR_COMPRESSION_INFO_V30
�� /
struRes
��0 7
;
��7 8
public
�� *
NET_DVR_COMPRESSION_INFO_V30
�� /!
struEventRecordPara
��0 C
;
��C D
public
�� *
NET_DVR_COMPRESSION_INFO_V30
�� /
struNetPara
��0 ;
;
��; <
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� &
NET_DVR_COMPRESSION_INFO
�� .
{
�� 	
public
�� 
byte
�� 
byStreamType
�� $
;
��$ %
public
�� 
byte
�� 
byResolution
�� $
;
��$ %
public
�� 
byte
�� 

�� %
;
��% &
public
�� 
byte
�� 
byPicQuality
�� $
;
��$ %
public
�� 
uint
�� 
dwVideoBitrate
�� &
;
��& '
public
�� 
uint
�� 
dwVideoFrameRate
�� (
;
��( )
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� $
NET_DVR_COMPRESSIONCFG
�� ,
{
�� 	
public
�� 
uint
�� 
dwSize
�� 
;
�� 
public
�� &
NET_DVR_COMPRESSION_INFO
�� +
struRecordPara
��, :
;
��: ;
public
�� &
NET_DVR_COMPRESSION_INFO
�� +
struNetPara
��, 7
;
��7 8
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� )
NET_DVR_COMPRESSION_INFO_EX
�� 1
{
�� 	
public
�� 
byte
�� 
byStreamType
�� $
;
��$ %
public
�� 
byte
�� 
byResolution
�� $
;
��$ %
public
�� 
byte
�� 

�� %
;
��% &
public
�� 
byte
�� 
byPicQuality
�� $
;
��$ %
public
�� 
uint
�� 
dwVideoBitrate
�� &
;
��& '
public
�� 
uint
�� 
dwVideoFrameRate
�� (
;
��( )
public
�� 
ushort
�� 
wIntervalFrameI
�� )
;
��) *
public
�� 
byte
�� 
byIntervalBPFrame
�� )
;
��) *
public
�� 
byte
�� 
byRes
�� 
;
�� 
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� '
NET_DVR_COMPRESSIONCFG_EX
�� /
{
�� 	
public
�� 
uint
�� 
dwSize
�� 
;
�� 
public
�� )
NET_DVR_COMPRESSION_INFO_EX
�� .
struRecordPara
��/ =
;
��= >
public
�� )
NET_DVR_COMPRESSION_INFO_EX
�� .
struNetPara
��/ :
;
��: ;
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
,
��4 5
CharSet
��6 =
=
��> ?
CharSet
��@ G
.
��G H
Ansi
��H L
)
��L M
]
��M N
public
�� 
struct
�� !
NET_DVR_RECORDSCHED
�� )
{
�� 	
public
�� 
NET_DVR_SCHEDTIME
�� $
struRecordTime
��% 3
;
��3 4
public
�� 
byte
�� 
byRecordType
�� $
;
��$ %
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .
	ByValTStr
��. 7
,
��7 8
	SizeConst
��9 B
=
��C D
$num
��E F
)
��F G
]
��G H
public
�� 
string
�� 
reservedData
�� &
;
��& '
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� 
NET_DVR_RECORDDAY
�� '
{
�� 	
public
�� 
ushort
�� 

�� '
;
��' (
public
�� 
byte
�� 
byRecordType
�� $
;
��$ %
public
�� 
byte
�� 
reservedData
�� $
;
��$ %
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
��  
NET_DVR_RECORD_V30
�� (
{
�� 	
public
�� 
uint
�� 
dwSize
�� 
;
�� 
public
�� 
uint
�� 
dwRecord
��  
;
��  !
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_DAYS
��F N
,
��N O
ArraySubType
��P \
=
��] ^

��_ l
.
��l m
Struct
��m s
)
��s t
]
��t u
public
�� 
NET_DVR_RECORDDAY
�� $
[
��$ %
]
��% &

��' 4
;
��4 5
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_DAYS
��F N
*
��O P!
MAX_TIMESEGMENT_V30
��Q d
,
��d e
ArraySubType
��f r
=
��s t

.��� �
Struct��� �
)��� �
]��� �
public
�� !
NET_DVR_RECORDSCHED
�� &
[
��& '
]
��' (
struRecordSched
��) 8
;
��8 9
public
�� 
uint
�� 
dwRecordTime
�� $
;
��$ %
public
�� 
uint
�� 
dwPreRecordTime
�� '
;
��' (
public
�� 
uint
��  
dwRecorderDuration
�� *
;
��* +
public
�� 
byte
�� 
byRedundancyRec
�� '
;
��' (
public
�� 
byte
�� 

byAudioRec
�� "
;
��" #
public
�� 
byte
�� 
byStreamType
�� $
;
��$ %
public
�� 
byte
�� 
byPassbackRecord
�� (
;
��( )
public
�� 
ushort
�� 

�� '
;
��' (
public
�� 
byte
�� 
byRecordBackup
�� &
;
��& '
public
�� 
byte
�� 

bySVCLevel
�� "
;
��" #
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F G
,
��G H
ArraySubType
��I U
=
��V W

��X e
.
��e f
I1
��f h
)
��h i
]
��i j
public
�� 
byte
�� 
[
�� 
]
�� 
	byReserve
�� #
;
��# $
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� 
NET_DVR_RECORD
�� $
{
�� 	
public
�� 
uint
�� 
dwSize
�� 
;
�� 
public
�� 
uint
�� 
dwRecord
��  
;
��  !
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_DAYS
��F N
,
��N O
ArraySubType
��P \
=
��] ^

��_ l
.
��l m
Struct
��m s
)
��s t
]
��t u
public
�� 
NET_DVR_RECORDDAY
�� $
[
��$ %
]
��% &

��' 4
;
��4 5
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_DAYS
��F N
*
��O P
MAX_TIMESEGMENT
��Q `
,
��` a
ArraySubType
��b n
=
��o p

��q ~
.
��~ 
Struct�� �
)��� �
]��� �
public
�� !
NET_DVR_RECORDSCHED
�� &
[
��& '
]
��' (
struRecordSched
��) 8
;
��8 9
public
�� 
uint
�� 
dwRecordTime
�� $
;
��$ %
public
�� 
uint
�� 
dwPreRecordTime
�� '
;
��' (
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� "
NET_DVR_PTZ_PROTOCOL
�� *
{
�� 	
public
�� 
uint
�� 
dwType
�� 
;
�� 
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
DESC_LEN
��F N
,
��N O
ArraySubType
��P \
=
��] ^

��_ l
.
��l m
I1
��m o
)
��o p
]
��p q
public
�� 
byte
�� 
[
�� 
]
�� 

byDescribe
�� $
;
��$ %
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� 
NET_DVR_PTZCFG
�� $
{
�� 	
public
�� 
uint
�� 
dwSize
�� 
;
�� 
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
PTZ_PROTOCOL_NUM
��F V
,
��V W
ArraySubType
��X d
=
��e f

��g t
.
��t u
Struct
��u {
)
��{ |
]
��| }
public
�� "
NET_DVR_PTZ_PROTOCOL
�� '
[
��' (
]
��( )
struPtz
��* 1
;
��1 2
public
�� 
uint
�� 
dwPtzNum
��  
;
��  !
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F G
,
��G H
ArraySubType
��I U
=
��V W

��X e
.
��e f
I1
��f h
)
��h i
]
��i j
public
�� 
byte
�� 
[
�� 
]
�� 
byRes
�� 
;
��  
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� $
NET_DVR_DECODERCFG_V30
�� ,
{
�� 	
public
�� 
uint
�� 
dwSize
�� 
;
�� 
public
�� 
uint
�� 

dwBaudRate
�� "
;
��" #
public
�� 
byte
�� 
	byDataBit
�� !
;
��! "
public
�� 
byte
�� 
	byStopBit
�� !
;
��! "
public
�� 
byte
�� 
byParity
��  
;
��  !
public
�� 
byte
�� 

�� %
;
��% &
public
�� 
ushort
�� 
wDecoderType
�� &
;
��& '
public
�� 
ushort
�� 
wDecoderAddress
�� )
;
��) *
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_PRESET_V30
��F T
,
��T U
ArraySubType
��V b
=
��c d

��e r
.
��r s
I1
��s u
)
��u v
]
��v w
public
�� 
byte
�� 
[
�� 
]
�� 
bySetPreset
�� %
;
��% &
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_CRUISE_V30
��F T
,
��T U
ArraySubType
��V b
=
��c d

��e r
.
��r s
I1
��s u
)
��u v
]
��v w
public
�� 
byte
�� 
[
�� 
]
�� 
bySetCruise
�� %
;
��% &
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E

��F S
,
��S T
ArraySubType
��U a
=
��b c

��d q
.
��q r
I1
��r t
)
��t u
]
��u v
public
�� 
byte
�� 
[
�� 
]
�� 

bySetTrack
�� $
;
��$ %
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
��  
NET_DVR_DECODERCFG
�� (
{
�� 	
public
�� 
uint
�� 
dwSize
�� 
;
�� 
public
�� 
uint
�� 

dwBaudRate
�� "
;
��" #
public
�� 
byte
�� 
	byDataBit
�� !
;
��! "
public
�� 
byte
�� 
	byStopBit
�� !
;
��! "
public
�� 
byte
�� 
byParity
��  
;
��  !
public
�� 
byte
�� 

�� %
;
��% &
public
�� 
ushort
�� 
wDecoderType
�� &
;
��& '
public
�� 
ushort
�� 
wDecoderAddress
�� )
;
��) *
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E

MAX_PRESET
��F P
,
��P Q
ArraySubType
��R ^
=
��_ `

��a n
.
��n o
I1
��o q
)
��q r
]
��r s
public
�� 
byte
�� 
[
�� 
]
�� 
bySetPreset
�� %
;
��% &
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E

MAX_CRUISE
��F P
,
��P Q
ArraySubType
��R ^
=
��_ `

��a n
.
��n o
I1
��o q
)
��q r
]
��r s
public
�� 
byte
�� 
[
�� 
]
�� 
bySetCruise
�� %
;
��% &
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
	MAX_TRACK
��F O
,
��O P
ArraySubType
��Q ]
=
��^ _

��` m
.
��m n
I1
��n p
)
��p q
]
��q r
public
�� 
byte
�� 
[
�� 
]
�� 

bySetTrack
�� $
;
��$ %
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
,
��4 5
CharSet
��6 =
=
��> ?
CharSet
��@ G
.
��G H
Ansi
��H L
)
��L M
]
��M N
public
�� 
struct
��  
NET_DVR_PPPCFG_V30
�� (
{
�� 	
public
�� 
NET_DVR_IPADDR
�� !
struRemoteIP
��" .
;
��. /
public
�� 
NET_DVR_IPADDR
�� !
struLocalIP
��" -
;
��- .
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .
	ByValTStr
��. 7
,
��7 8
	SizeConst
��9 B
=
��C D
$num
��E G
)
��G H
]
��H I
public
�� 
string
�� 
sLocalIPMask
�� &
;
��& '
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
NAME_LEN
��F N
,
��N O
ArraySubType
��P \
=
��] ^

��_ l
.
��l m
I1
��m o
)
��o p
]
��p q
public
�� 
byte
�� 
[
�� 
]
�� 
	sUsername
�� #
;
��# $
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E

PASSWD_LEN
��F P
,
��P Q
ArraySubType
��R ^
=
��_ `

��a n
.
��n o
I1
��o q
)
��q r
]
��r s
public
�� 
byte
�� 
[
�� 
]
�� 
	sPassword
�� #
;
��# $
public
�� 
byte
�� 
	byPPPMode
�� !
;
��! "
public
�� 
byte
�� 
byRedial
��  
;
��  !
public
�� 
byte
�� 
byRedialMode
�� $
;
��$ %
public
�� 
byte
�� 

�� %
;
��% &
public
�� 
uint
�� 
dwMTU
�� 
;
�� 
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .
	ByValTStr
��. 7
,
��7 8
	SizeConst
��9 B
=
��C D
PHONENUMBER_LEN
��E T
)
��T U
]
��U V
public
�� 
string
�� 
sTelephoneNumber
�� *
;
��* +
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
,
��4 5
CharSet
��6 =
=
��> ?
CharSet
��@ G
.
��G H
Ansi
��H L
)
��L M
]
��M N
public
�� 
struct
�� 
NET_DVR_PPPCFG
�� $
{
�� 	
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .
	ByValTStr
��. 7
,
��7 8
	SizeConst
��9 B
=
��C D
$num
��E G
)
��G H
]
��H I
public
�� 
string
�� 
	sRemoteIP
�� #
;
��# $
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .
	ByValTStr
��. 7
,
��7 8
	SizeConst
��9 B
=
��C D
$num
��E G
)
��G H
]
��H I
public
�� 
string
�� 
sLocalIP
�� "
;
��" #
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .
	ByValTStr
��. 7
,
��7 8
	SizeConst
��9 B
=
��C D
$num
��E G
)
��G H
]
��H I
public
�� 
string
�� 
sLocalIPMask
�� &
;
��& '
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
NAME_LEN
��F N
,
��N O
ArraySubType
��P \
=
��] ^

��_ l
.
��l m
I1
��m o
)
��o p
]
��p q
public
�� 
byte
�� 
[
�� 
]
�� 
	sUsername
�� #
;
��# $
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E

PASSWD_LEN
��F P
,
��P Q
ArraySubType
��R ^
=
��_ `

��a n
.
��n o
I1
��o q
)
��q r
]
��r s
public
�� 
byte
�� 
[
�� 
]
�� 
	sPassword
�� #
;
��# $
public
�� 
byte
�� 
	byPPPMode
�� !
;
��! "
public
�� 
byte
�� 
byRedial
��  
;
��  !
public
�� 
byte
�� 
byRedialMode
�� $
;
��$ %
public
�� 
byte
�� 

�� %
;
��% &
public
�� 
uint
�� 
dwMTU
�� 
;
�� 
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .
	ByValTStr
��. 7
,
��7 8
	SizeConst
��9 B
=
��C D
PHONENUMBER_LEN
��E T
)
��T U
]
��U V
public
�� 
string
�� 
sTelephoneNumber
�� *
;
��* +
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� "
NET_DVR_SINGLE_RS232
�� *
{
�� 	
public
�� 
uint
�� 

dwBaudRate
�� "
;
��" #
public
�� 
byte
�� 
	byDataBit
�� !
;
��! "
public
�� 
byte
�� 
	byStopBit
�� !
;
��! "
public
�� 
byte
�� 
byParity
��  
;
��  !
public
�� 
byte
�� 

�� %
;
��% &
public
�� 
uint
�� 

dwWorkMode
�� "
;
��" #
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� "
NET_DVR_RS232CFG_V30
�� *
{
�� 	
public
�� 
uint
�� 
dwSize
�� 
;
�� 
public
�� "
NET_DVR_SINGLE_RS232
�� '
	struRs232
��( 1
;
��1 2
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F H
,
��H I
ArraySubType
��J V
=
��W X

��Y f
.
��f g
I1
��g i
)
��i j
]
��j k
public
�� 
byte
�� 
[
�� 
]
�� 
byRes
�� 
;
��  
public
��  
NET_DVR_PPPCFG_V30
�� %

��& 3
;
��3 4
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� 
NET_DVR_RS232CFG
�� &
{
�� 	
public
�� 
uint
�� 
dwSize
�� 
;
�� 
public
�� 
uint
�� 

dwBaudRate
�� "
;
��" #
public
�� 
byte
�� 
	byDataBit
�� !
;
��! "
public
�� 
byte
�� 
	byStopBit
�� !
;
��! "
public
�� 
byte
�� 
byParity
��  
;
��  !
public
�� 
byte
�� 

�� %
;
��% &
public
�� 
uint
�� 

dwWorkMode
�� "
;
��" #
public
�� 
NET_DVR_PPPCFG
�� !

��" /
;
��/ 0
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� %
NET_DVR_PRESETCHAN_INFO
�� -
{
�� 	
public
�� 
uint
��  
dwEnablePresetChan
�� *
;
��* +
public
�� 
uint
�� 
dwPresetPointNo
�� '
;
��' (
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� %
NET_DVR_CRUISECHAN_INFO
�� -
{
�� 	
public
�� 
uint
��  
dwEnableCruiseChan
�� *
;
��* +
public
�� 
uint
�� 

dwCruiseNo
�� "
;
��" #
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� '
NET_DVR_PTZTRACKCHAN_INFO
�� /
{
�� 	
public
�� 
uint
�� "
dwEnablePtzTrackChan
�� ,
;
��, -
public
�� 
uint
�� 
dwPtzTrackNo
�� $
;
��$ %
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� $
NET_DVR_ALARMINCFG_V40
�� ,
{
�� 	
public
�� 
uint
�� 
dwSize
�� 
;
�� 
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
NAME_LEN
��F N
,
��N O
ArraySubType
��P \
=
��] ^

��_ l
.
��l m
I1
��m o
)
��o p
]
��p q
public
�� 
byte
�� 
[
�� 
]
�� 
sAlarmInName
�� &
;
��& '
public
�� 
byte
�� 
byAlarmType
�� #
;
��# $
public
�� 
byte
�� 
byAlarmInHandle
�� '
;
��' (
public
�� 
byte
�� 
	byChannel
�� !
;
��! "
public
�� 
byte
�� 
byRes1
�� 
;
�� 
public
�� 
uint
�� 
dwHandleType
�� $
;
��$ %
public
�� 
uint
�� %
dwMaxRelAlarmOutChanNum
�� /
;
��/ 0
public
�� 
uint
�� "
dwRelAlarmOutChanNum
�� ,
;
��, -
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_ALARMOUT_V40
��F V
,
��V W
ArraySubType
��X d
=
��e f

��g t
.
��t u
U4
��u w
)
��w x
]
��x y
public
�� 
uint
�� 
[
�� 
]
�� 

�� '
;
��' (
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_DAYS
��F N
*
��O P!
MAX_TIMESEGMENT_V30
��Q d
,
��d e
ArraySubType
��f r
=
��s t

.��� �
Struct��� �
)��� �
]��� �
public
�� 
NET_DVR_SCHEDTIME
�� $
[
��$ %
]
��% &

��' 4
;
��4 5
public
�� 
uint
��  
dwMaxRecordChanNum
�� *
;
��* +
public
�� 
uint
��  
dwCurRecordChanNum
�� *
;
��* +
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_CHANNUM_V40
��F U
,
��U V
ArraySubType
��W c
=
��d e

��f s
.
��s t
U4
��t v
)
��v w
]
��w x
public
�� 
uint
�� 
[
�� 
]
�� 
dwRelRecordChan
�� )
;
��) *
public
�� 
uint
�� #
dwMaxEnablePtzCtrlNun
�� -
;
��- .
public
�� 
uint
�� #
dwEnablePresetChanNum
�� -
;
��- .
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_CHANNUM_V40
��F U
,
��U V
ArraySubType
��W c
=
��d e

��f s
.
��s t
Struct
��t z
)
��z {
]
��{ |
public
�� %
NET_DVR_PRESETCHAN_INFO
�� *
[
��* +
]
��+ , 
struPresetChanInfo
��- ?
;
��? @
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F I
,
��I J
ArraySubType
��K W
=
��X Y

��Z g
.
��g h
I1
��h j
)
��j k
]
��k l
public
�� 
byte
�� 
[
�� 
]
�� 
byRes2
��  
;
��  !
public
�� 
uint
�� #
dwEnableCruiseChanNum
�� -
;
��- .
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_CHANNUM_V40
��F U
,
��U V
ArraySubType
��W c
=
��d e

��f s
.
��s t
Struct
��t z
)
��z {
]
��{ |
public
�� %
NET_DVR_CRUISECHAN_INFO
�� *
[
��* +
]
��+ , 
struCruiseChanInfo
��- ?
;
��? @
public
�� 
uint
�� %
dwEnablePtzTrackChanNum
�� /
;
��/ 0
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_CHANNUM_V40
��F U
,
��U V
ArraySubType
��W c
=
��d e

��f s
.
��s t
Struct
��t z
)
��z {
]
��{ |
public
�� '
NET_DVR_PTZTRACKCHAN_INFO
�� ,
[
��, -
]
��- .
struPtzTrackInfo
��/ ?
;
��? @
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F I
,
��I J
ArraySubType
��K W
=
��X Y

��Z g
.
��g h
I1
��h j
)
��j k
]
��k l
public
�� 
byte
�� 
[
�� 
]
�� 
byRes
�� 
;
��  
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� $
NET_DVR_ALARMINCFG_V30
�� ,
{
�� 	
public
�� 
uint
�� 
dwSize
�� 
;
�� 
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
NAME_LEN
��F N
,
��N O
ArraySubType
��P \
=
��] ^

��_ l
.
��l m
I1
��m o
)
��o p
]
��p q
public
�� 
byte
�� 
[
�� 
]
�� 
sAlarmInName
�� &
;
��& '
public
�� 
byte
�� 
byAlarmType
�� #
;
��# $
public
�� 
byte
�� 
byAlarmInHandle
�� '
;
��' (
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F G
,
��G H
ArraySubType
��I U
=
��V W

��X e
.
��e f
I1
��f h
)
��h i
]
��i j
public
�� 
byte
�� 
[
�� 
]
�� 
byRes1
��  
;
��  !
public
�� )
NET_DVR_HANDLEEXCEPTION_V30
�� .!
struAlarmHandleType
��/ B
;
��B C
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_DAYS
��F N
*
��O P!
MAX_TIMESEGMENT_V30
��Q d
,
��d e
ArraySubType
��f r
=
��s t

.��� �
Struct��� �
)��� �
]��� �
public
�� 
NET_DVR_SCHEDTIME
�� $
[
��$ %
]
��% &

��' 4
;
��4 5
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_CHANNUM_V30
��F U
,
��U V
ArraySubType
��W c
=
��d e

��f s
.
��s t
I1
��t v
)
��v w
]
��w x
public
�� 
byte
�� 
[
�� 
]
�� 
byRelRecordChan
�� )
;
��) *
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_CHANNUM_V30
��F U
,
��U V
ArraySubType
��W c
=
��d e

��f s
.
��s t
I1
��t v
)
��v w
]
��w x
public
�� 
byte
�� 
[
�� 
]
�� 
byEnablePreset
�� (
;
��( )
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_CHANNUM_V30
��F U
,
��U V
ArraySubType
��W c
=
��d e

��f s
.
��s t
I1
��t v
)
��v w
]
��w x
public
�� 
byte
�� 
[
�� 
]
�� 

byPresetNo
�� $
;
��$ %
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F I
,
��I J
ArraySubType
��K W
=
��X Y

��Z g
.
��g h
I1
��h j
)
��j k
]
��k l
public
�� 
byte
�� 
[
�� 
]
�� 
byRes2
��  
;
��  !
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_CHANNUM_V30
��F U
,
��U V
ArraySubType
��W c
=
��d e

��f s
.
��s t
I1
��t v
)
��v w
]
��w x
public
�� 
byte
�� 
[
�� 
]
�� 
byEnableCruise
�� (
;
��( )
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_CHANNUM_V30
��F U
,
��U V
ArraySubType
��W c
=
��d e

��f s
.
��s t
I1
��t v
)
��v w
]
��w x
public
�� 
byte
�� 
[
�� 
]
�� 

byCruiseNo
�� $
;
��$ %
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_CHANNUM_V30
��F U
,
��U V
ArraySubType
��W c
=
��d e

��f s
.
��s t
I1
��t v
)
��v w
]
��w x
public
�� 
byte
�� 
[
�� 
]
�� 
byEnablePtzTrack
�� *
;
��* +
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_CHANNUM_V30
��F U
,
��U V
ArraySubType
��W c
=
��d e

��f s
.
��s t
I1
��t v
)
��v w
]
��w x
public
�� 
byte
�� 
[
�� 
]
�� 

byPTZTrack
�� $
;
��$ %
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F H
,
��H I
ArraySubType
��J V
=
��W X

��Y f
.
��f g
I1
��g i
)
��i j
]
��j k
public
�� 
byte
�� 
[
�� 
]
�� 
byRes3
��  
;
��  !
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� 
STRUCT_IO_ALARM
�� %
{
�� 	
public
�� 
uint
�� 
dwAlarmInputNo
�� &
;
��& '
public
�� 
uint
�� !
dwTrigerAlarmOutNum
�� +
;
��+ ,
public
�� 
uint
�� #
dwTrigerRecordChanNum
�� -
;
��- .
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F I
,
��I J
ArraySubType
��K W
=
��X Y

��Z g
.
��g h
I1
��h j
)
��j k
]
��k l
public
�� 
byte
�� 
[
�� 
]
�� 
byRes
�� 
;
��  
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� "
STRUCT_ALARM_CHANNEL
�� *
{
�� 	
public
�� 
uint
�� 
dwAlarmChanNum
�� &
;
��& '
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F I
,
��I J
ArraySubType
��K W
=
��X Y

��Z g
.
��g h
I1
��h j
)
��j k
]
��k l
public
�� 
byte
�� 
[
�� 
]
�� 
byRes
�� 
;
��  
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� 
STRUCT_ALARM_HD
�� %
{
�� 	
public
�� 
uint
��  
dwAlarmHardDiskNum
�� *
;
��* +
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F I
,
��I J
ArraySubType
��K W
=
��X Y

��Z g
.
��g h
I1
��h j
)
��j k
]
��k l
public
�� 
byte
�� 
[
�� 
]
�� 
byRes
�� 
;
��  
}
�� 	
[
�� 	
StructLayout
��	 
(
�� 

LayoutKind
��  
.
��  !
Explicit
��! )
)
��) *
]
��* +
public
�� 
struct
�� #
UNION_ALARMINFO_FIXED
�� +
{
�� 	
[
�� 
FieldOffset
��
(
�� 
$num
�� 
)
�� 
]
�� 
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F I
,
��I J
ArraySubType
��K W
=
��X Y

��Z g
.
��g h
I1
��h j
)
��j k
]
��k l
public
�� 
byte
�� 
[
�� 
]
�� 

byUnionLen
�� $
;
��$ %
[
�� 
FieldOffset
��
(
�� 
$num
�� 
)
�� 
]
�� 
public
�� 
STRUCT_IO_ALARM
�� "
struIOAlarm
��# .
;
��. /
[
�� 
FieldOffset
��
(
�� 
$num
�� 
)
�� 
]
�� 
public
�� "
STRUCT_ALARM_CHANNEL
�� '
struAlarmChannel
��( 8
;
��8 9
[
�� 
FieldOffset
��
(
�� 
$num
�� 
)
�� 
]
�� 
public
�� 
STRUCT_ALARM_HD
�� "
struAlarmHardDisk
��# 4
;
��4 5
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� (
NET_DVR_ALRAM_FIXED_HEADER
�� 0
{
�� 	
public
�� 
uint
�� 
dwAlarmType
�� #
;
��# $
public
�� 
NET_DVR_TIME_EX
�� "

��# 0
;
��0 1
public
�� #
UNION_ALARMINFO_FIXED
�� (

uStruAlarm
��) 3
;
��3 4
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� #
NET_DVR_ALARMINFO_V40
�� +
{
�� 	
public
�� (
NET_DVR_ALRAM_FIXED_HEADER
�� -"
struAlarmFixedHeader
��. B
;
��B C
public
�� 
IntPtr
�� 

pAlarmData
�� $
;
��$ %
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
��  
NET_DVR_ALARMINCFG
�� (
{
�� 	
public
�� 
uint
�� 
dwSize
�� 
;
�� 
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
NAME_LEN
��F N
,
��N O
ArraySubType
��P \
=
��] ^

��_ l
.
��l m
I1
��m o
)
��o p
]
��p q
public
�� 
byte
�� 
[
�� 
]
�� 
sAlarmInName
�� &
;
��& '
public
�� 
byte
�� 
byAlarmType
�� #
;
��# $
public
�� 
byte
�� 
byAlarmInHandle
�� '
;
��' (
public
�� 
byte
�� 
	byChannel
�� !
;
��! "
public
�� 
byte
�� 
byRes
�� 
;
�� 
public
�� %
NET_DVR_HANDLEEXCEPTION
�� *!
struAlarmHandleType
��+ >
;
��> ?
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_DAYS
��F N
*
��O P
MAX_TIMESEGMENT
��Q `
,
��` a
ArraySubType
��b n
=
��o p

��q ~
.
��~ 
Struct�� �
)��� �
]��� �
public
�� 
NET_DVR_SCHEDTIME
�� $
[
��$ %
]
��% &

��' 4
;
��4 5
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_CHANNUM
��F Q
,
��Q R
ArraySubType
��S _
=
��` a

��b o
.
��o p
I1
��p r
)
��r s
]
��s t
public
�� 
byte
�� 
[
�� 
]
�� 
byRelRecordChan
�� )
;
��) *
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_CHANNUM
��F Q
,
��Q R
ArraySubType
��S _
=
��` a

��b o
.
��o p
I1
��p r
)
��r s
]
��s t
public
�� 
byte
�� 
[
�� 
]
�� 
byEnablePreset
�� (
;
��( )
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_CHANNUM
��F Q
,
��Q R
ArraySubType
��S _
=
��` a

��b o
.
��o p
I1
��p r
)
��r s
]
��s t
public
�� 
byte
�� 
[
�� 
]
�� 

byPresetNo
�� $
;
��$ %
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_CHANNUM
��F Q
,
��Q R
ArraySubType
��S _
=
��` a

��b o
.
��o p
I1
��p r
)
��r s
]
��s t
public
�� 
byte
�� 
[
�� 
]
�� 
byEnableCruise
�� (
;
��( )
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_CHANNUM
��F Q
,
��Q R
ArraySubType
��S _
=
��` a

��b o
.
��o p
I1
��p r
)
��r s
]
��s t
public
�� 
byte
�� 
[
�� 
]
�� 

byCruiseNo
�� $
;
��$ %
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_CHANNUM
��F Q
,
��Q R
ArraySubType
��S _
=
��` a

��b o
.
��o p
I1
��p r
)
��r s
]
��s t
public
�� 
byte
�� 
[
�� 
]
�� 
byEnablePtzTrack
�� *
;
��* +
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_CHANNUM
��F Q
,
��Q R
ArraySubType
��S _
=
��` a

��b o
.
��o p
I1
��p r
)
��r s
]
��s t
public
�� 
byte
�� 
[
�� 
]
�� 

byPTZTrack
�� $
;
��$ %
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� '
NET_DVR_ANALOG_ALARMINCFG
�� /
{
�� 	
public
�� 
uint
�� 
dwSize
�� 
;
�� 
public
�� 
byte
�� !
byEnableAlarmHandle
�� +
;
��+ ,
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F G
,
��G H
ArraySubType
��I U
=
��V W

��X e
.
��e f
I1
��f h
)
��h i
]
��i j
public
�� 
byte
�� 
[
�� 
]
�� 
byRes1
��  
;
��  !
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
NAME_LEN
��F N
,
��N O
ArraySubType
��P \
=
��] ^

��_ l
.
��l m
I1
��m o
)
��o p
]
��p q
public
�� 
byte
�� 
[
�� 
]
�� 

�� '
;
��' (
public
�� 
ushort
�� 

�� '
;
��' (
public
�� 
ushort
�� 

�� '
;
��' (
public
�� )
NET_DVR_HANDLEEXCEPTION_V30
�� .!
struAlarmHandleType
��/ B
;
��B C
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_DAYS
��F N
*
��O P!
MAX_TIMESEGMENT_V30
��Q d
,
��d e
ArraySubType
��f r
=
��s t

.��� �
Struct��� �
)��� �
]��� �
public
�� 
NET_DVR_SCHEDTIME
�� $
[
��$ %
]
��% &

��' 4
;
��4 5
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_CHANNUM_V30
��F U
,
��U V
ArraySubType
��W c
=
��d e

��f s
.
��s t
I1
��t v
)
��v w
]
��w x
public
�� 
byte
�� 
[
�� 
]
�� 
byRelRecordChan
�� )
;
��) *
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F I
,
��I J
ArraySubType
��K W
=
��X Y

��Z g
.
��g h
I1
��h j
)
��j k
]
��k l
public
�� 
byte
�� 
[
�� 
]
�� 
byRes2
��  
;
��  !
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� #
NET_DVR_ALARMINFO_V30
�� +
{
�� 	
public
�� 
uint
�� 
dwAlarmType
�� #
;
��# $
public
�� 
uint
��  
dwAlarmInputNumber
�� *
;
��* +
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_ALARMOUT_V30
��F V
,
��V W
ArraySubType
��X d
=
��e f

��g t
.
��t u
I1
��u w
)
��w x
]
��x y
public
�� 
byte
�� 
[
�� 
]
�� !
byAlarmOutputNumber
�� -
;
��- .
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_CHANNUM_V30
��F U
,
��U V
ArraySubType
��W c
=
��d e

��f s
.
��s t
I1
��t v
)
��v w
]
��w x
public
�� 
byte
�� 
[
�� 
]
�� "
byAlarmRelateChannel
�� .
;
��. /
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_CHANNUM_V30
��F U
,
��U V
ArraySubType
��W c
=
��d e

��f s
.
��s t
I1
��t v
)
��v w
]
��w x
public
�� 
byte
�� 
[
�� 
]
�� 
	byChannel
�� #
;
��# $
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_DISKNUM_V30
��F U
,
��U V
ArraySubType
��W c
=
��d e

��f s
.
��s t
I1
��t v
)
��v w
]
��w x
public
�� 
byte
�� 
[
�� 
]
�� 
byDiskNumber
�� &
;
��& '
public
�� 
void
�� 
Init
�� 
(
�� 
)
�� 
{
�� 
dwAlarmType
�� 
=
�� 
$num
�� 
;
��   
dwAlarmInputNumber
�� "
=
��# $
$num
��% &
;
��& '"
byAlarmRelateChannel
�� $
=
��% &
new
��' *
byte
��+ /
[
��/ 0
MAX_CHANNUM_V30
��0 ?
]
��? @
;
��@ A
	byChannel
�� 
=
�� 
new
�� 
byte
��  $
[
��$ %
MAX_CHANNUM_V30
��% 4
]
��4 5
;
��5 6!
byAlarmOutputNumber
�� #
=
��$ %
new
��& )
byte
��* .
[
��. /
MAX_ALARMOUT_V30
��/ ?
]
��? @
;
��@ A
byDiskNumber
�� 
=
�� 
new
�� "
byte
��# '
[
��' (
MAX_DISKNUM_V30
��( 7
]
��7 8
;
��8 9
for
�� 
(
�� 
int
�� 
i
�� 
=
�� 
$num
�� 
;
�� 
i
��  !
<
��" #
MAX_CHANNUM_V30
��$ 3
;
��3 4
i
��5 6
++
��6 8
)
��8 9
{
�� "
byAlarmRelateChannel
�� (
[
��( )
i
��) *
]
��* +
=
��, -
Convert
��. 5
.
��5 6
ToByte
��6 <
(
��< =
$num
��= >
)
��> ?
;
��? @
	byChannel
�� 
[
�� 
i
�� 
]
��  
=
��! "
Convert
��# *
.
��* +
ToByte
��+ 1
(
��1 2
$num
��2 3
)
��3 4
;
��4 5
}
�� 
for
�� 
(
�� 
int
�� 
i
�� 
=
�� 
$num
�� 
;
�� 
i
��  !
<
��" #
MAX_ALARMOUT_V30
��$ 4
;
��4 5
i
��6 7
++
��7 9
)
��9 :
{
�� !
byAlarmOutputNumber
�� '
[
��' (
i
��( )
]
��) *
=
��+ ,
Convert
��- 4
.
��4 5
ToByte
��5 ;
(
��; <
$num
��< =
)
��= >
;
��> ?
}
�� 
for
�� 
(
�� 
int
�� 
i
�� 
=
�� 
$num
�� 
;
�� 
i
��  !
<
��" #
MAX_DISKNUM_V30
��$ 3
;
��3 4
i
��5 6
++
��6 8
)
��8 9
{
�� 
byDiskNumber
��  
[
��  !
i
��! "
]
��" #
=
��$ %
Convert
��& -
.
��- .
ToByte
��. 4
(
��4 5
$num
��5 6
)
��6 7
;
��7 8
}
�� 
}
�� 
public
�� 
void
�� 
Reset
�� 
(
�� 
)
�� 
{
�� 
dwAlarmType
�� 
=
�� 
$num
�� 
;
��   
dwAlarmInputNumber
�� "
=
��# $
$num
��% &
;
��& '
for
�� 
(
�� 
int
�� 
i
�� 
=
�� 
$num
�� 
;
�� 
i
��  !
<
��" #
MAX_CHANNUM_V30
��$ 3
;
��3 4
i
��5 6
++
��6 8
)
��8 9
{
�� "
byAlarmRelateChannel
�� (
[
��( )
i
��) *
]
��* +
=
��, -
Convert
��. 5
.
��5 6
ToByte
��6 <
(
��< =
$num
��= >
)
��> ?
;
��? @
	byChannel
�� 
[
�� 
i
�� 
]
��  
=
��! "
Convert
��# *
.
��* +
ToByte
��+ 1
(
��1 2
$num
��2 3
)
��3 4
;
��4 5
}
�� 
for
�� 
(
�� 
int
�� 
i
�� 
=
�� 
$num
�� 
;
�� 
i
��  !
<
��" #
MAX_ALARMOUT_V30
��$ 4
;
��4 5
i
��6 7
++
��7 9
)
��9 :
{
�� !
byAlarmOutputNumber
�� '
[
��' (
i
��( )
]
��) *
=
��+ ,
Convert
��- 4
.
��4 5
ToByte
��5 ;
(
��; <
$num
��< =
)
��= >
;
��> ?
}
�� 
for
�� 
(
�� 
int
�� 
i
�� 
=
�� 
$num
�� 
;
�� 
i
��  !
<
��" #
MAX_DISKNUM_V30
��$ 3
;
��3 4
i
��5 6
++
��6 8
)
��8 9
{
�� 
byDiskNumber
��  
[
��  !
i
��! "
]
��" #
=
��$ %
Convert
��& -
.
��- .
ToByte
��. 4
(
��4 5
$num
��5 6
)
��6 7
;
��7 8
}
�� 
}
�� 
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� %
NET_DVR_ALARM_HOT_SPARE
�� -
{
�� 	
public
�� 
uint
�� 
dwSize
�� 
;
�� 
public
�� 
uint
�� 
dwExceptionCase
�� '
;
��' (
public
�� 
NET_DVR_IPADDR
�� !
struDeviceIP
��" .
;
��. /
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F I
,
��I J
ArraySubType
��K W
=
��X Y

��Z g
.
��g h
I1
��h j
)
��j k
]
��k l
public
�� 
byte
�� 
[
�� 
]
�� 
byRes
�� 
;
��  
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� 
NET_DVR_ALARMINFO
�� '
{
�� 	
public
�� 
int
�� 
dwAlarmType
�� "
;
��" #
public
�� 
int
��  
dwAlarmInputNumber
�� )
;
��) *
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_ALARMOUT
��F R
,
��R S
ArraySubType
��T `
=
��a b

��c p
.
��p q
U4
��q s
)
��s t
]
��t u
public
�� 
int
�� 
[
�� 
]
�� !
dwAlarmOutputNumber
�� ,
;
��, -
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_CHANNUM
��F Q
,
��Q R
ArraySubType
��S _
=
��` a

��b o
.
��o p
U4
��p r
)
��r s
]
��s t
public
�� 
int
�� 
[
�� 
]
�� "
dwAlarmRelateChannel
�� -
;
��- .
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_CHANNUM
��F Q
,
��Q R
ArraySubType
��S _
=
��` a

��b o
.
��o p
U4
��p r
)
��r s
]
��s t
public
�� 
int
�� 
[
�� 
]
�� 
	dwChannel
�� "
;
��" #
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_DISKNUM
��F Q
,
��Q R
ArraySubType
��S _
=
��` a

��b o
.
��o p
U4
��p r
)
��r s
]
��s t
public
�� 
int
�� 
[
�� 
]
�� 
dwDiskNumber
�� %
;
��% &
public
�� 
void
�� 
Init
�� 
(
�� 
)
�� 
{
�� 
dwAlarmType
�� 
=
�� 
$num
�� 
;
��   
dwAlarmInputNumber
�� "
=
��# $
$num
��% &
;
��& '!
dwAlarmOutputNumber
�� #
=
��$ %
new
��& )
int
��* -
[
��- .
MAX_ALARMOUT
��. :
]
��: ;
;
��; <"
dwAlarmRelateChannel
�� $
=
��% &
new
��' *
int
��+ .
[
��. /
MAX_CHANNUM
��/ :
]
��: ;
;
��; <
	dwChannel
�� 
=
�� 
new
�� 
int
��  #
[
��# $
MAX_CHANNUM
��$ /
]
��/ 0
;
��0 1
dwDiskNumber
�� 
=
�� 
new
�� "
int
��# &
[
��& '
MAX_DISKNUM
��' 2
]
��2 3
;
��3 4
for
�� 
(
�� 
int
�� 
i
�� 
=
�� 
$num
�� 
;
�� 
i
��  !
<
��" #
MAX_ALARMOUT
��$ 0
;
��0 1
i
��2 3
++
��3 5
)
��5 6
{
�� !
dwAlarmOutputNumber
�� '
[
��' (
i
��( )
]
��) *
=
��+ ,
$num
��- .
;
��. /
}
�� 
for
�� 
(
�� 
int
�� 
i
�� 
=
�� 
$num
�� 
;
�� 
i
��  !
<
��" #
MAX_CHANNUM
��$ /
;
��/ 0
i
��1 2
++
��2 4
)
��4 5
{
�� "
dwAlarmRelateChannel
�� (
[
��( )
i
��) *
]
��* +
=
��, -
$num
��. /
;
��/ 0
	dwChannel
�� 
[
�� 
i
�� 
]
��  
=
��! "
$num
��# $
;
��$ %
}
�� 
for
�� 
(
�� 
int
�� 
i
�� 
=
�� 
$num
�� 
;
�� 
i
��  !
<
��" #
MAX_DISKNUM
��$ /
;
��/ 0
i
��1 2
++
��2 4
)
��4 5
{
�� 
dwDiskNumber
��  
[
��  !
i
��! "
]
��" #
=
��$ %
$num
��& '
;
��' (
}
�� 
}
�� 
public
�� 
void
�� 
Reset
�� 
(
�� 
)
�� 
{
�� 
dwAlarmType
�� 
=
�� 
$num
�� 
;
��   
dwAlarmInputNumber
�� "
=
��# $
$num
��% &
;
��& '
for
�� 
(
�� 
int
�� 
i
�� 
=
�� 
$num
�� 
;
�� 
i
��  !
<
��" #
MAX_ALARMOUT
��$ 0
;
��0 1
i
��2 3
++
��3 5
)
��5 6
{
�� !
dwAlarmOutputNumber
�� '
[
��' (
i
��( )
]
��) *
=
��+ ,
$num
��- .
;
��. /
}
�� 
for
�� 
(
�� 
int
�� 
i
�� 
=
�� 
$num
�� 
;
�� 
i
��  !
<
��" #
MAX_CHANNUM
��$ /
;
��/ 0
i
��1 2
++
��2 4
)
��4 5
{
�� "
dwAlarmRelateChannel
�� (
[
��( )
i
��) *
]
��* +
=
��, -
$num
��. /
;
��/ 0
	dwChannel
�� 
[
�� 
i
�� 
]
��  
=
��! "
$num
��# $
;
��$ %
}
�� 
for
�� 
(
�� 
int
�� 
i
�� 
=
�� 
$num
�� 
;
�� 
i
��  !
<
��" #
MAX_DISKNUM
��$ /
;
��/ 0
i
��1 2
++
��2 4
)
��4 5
{
�� 
dwDiskNumber
��  
[
��  !
i
��! "
]
��" #
=
��$ %
$num
��& '
;
��' (
}
�� 
}
�� 
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� 
NET_DVR_IPDEVINFO
�� '
{
�� 	
public
�� 
uint
�� 
dwEnable
��  
;
��  !
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
NAME_LEN
��F N
,
��N O
ArraySubType
��P \
=
��] ^

��_ l
.
��l m
I1
��m o
)
��o p
]
��p q
public
�� 
byte
�� 
[
�� 
]
�� 
	sUserName
�� #
;
��# $
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E

PASSWD_LEN
��F P
,
��P Q
ArraySubType
��R ^
=
��_ `

��a n
.
��n o
I1
��o q
)
��q r
]
��r s
public
�� 
byte
�� 
[
�� 
]
�� 
	sPassword
�� #
;
��# $
public
�� 
NET_DVR_IPADDR
�� !
struIP
��" (
;
��( )
public
�� 
ushort
�� 
wDVRPort
�� "
;
��" #
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F H
,
��H I
ArraySubType
��J V
=
��W X

��Y f
.
��f g
I1
��g i
)
��i j
]
��j k
public
�� 
byte
�� 
[
�� 
]
�� 
byRes
�� 
;
��  
public
�� 
void
�� 
Init
�� 
(
�� 
)
�� 
{
�� 
	sUserName
�� 
=
�� 
new
�� 
byte
��  $
[
��$ %
NAME_LEN
��% -
]
��- .
;
��. /
	sPassword
�� 
=
�� 
new
�� 
byte
��  $
[
��$ %

PASSWD_LEN
��% /
]
��/ 0
;
��0 1
byRes
�� 
=
�� 
new
�� 
byte
��  
[
��  !
$num
��! #
]
��# $
;
��$ %
}
�� 
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� #
NET_DVR_IPDEVINFO_V31
�� +
{
�� 	
public
�� 
byte
�� 
byEnable
��  
;
��  !
public
�� 
byte
�� 
	byProType
�� !
;
��! "
public
�� 
byte
�� 
byEnableQuickAdd
�� (
;
��( )
public
�� 
byte
�� 
byRes1
�� 
;
�� 
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
NAME_LEN
��F N
,
��N O
ArraySubType
��P \
=
��] ^

��_ l
.
��l m
I1
��m o
)
��o p
]
��p q
public
�� 
byte
�� 
[
�� 
]
�� 
	sUserName
�� #
;
��# $
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E

PASSWD_LEN
��F P
,
��P Q
ArraySubType
��R ^
=
��_ `

��a n
.
��n o
I1
��o q
)
��q r
]
��r s
public
�� 
byte
�� 
[
�� 
]
�� 
	sPassword
�� #
;
��# $
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_DOMAIN_NAME
��F U
,
��U V
ArraySubType
��W c
=
��d e

��f s
.
��s t
I1
��t v
)
��v w
]
��w x
public
�� 
byte
�� 
[
�� 
]
�� 
byDomain
�� "
;
��" #
public
�� 
NET_DVR_IPADDR
�� !
struIP
��" (
;
��( )
public
�� 
ushort
�� 
wDVRPort
�� "
;
��" #
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F H
,
��H I
ArraySubType
��J V
=
��W X

��Y f
.
��f g
I1
��g i
)
��i j
]
��j k
public
�� 
byte
�� 
[
�� 
]
�� 
byRes2
��  
;
��  !
public
�� 
void
�� 
Init
�� 
(
�� 
)
�� 
{
�� 
	sUserName
�� 
=
�� 
new
�� 
byte
��  $
[
��$ %
NAME_LEN
��% -
]
��- .
;
��. /
	sPassword
�� 
=
�� 
new
�� 
byte
��  $
[
��$ %

PASSWD_LEN
��% /
]
��/ 0
;
��0 1
byDomain
�� 
=
�� 
new
�� 
byte
�� #
[
��# $
MAX_DOMAIN_NAME
��$ 3
]
��3 4
;
��4 5
byRes2
�� 
=
�� 
new
�� 
byte
�� !
[
��! "
$num
��" $
]
��$ %
;
��% &
}
�� 
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
��  
NET_DVR_IPCHANINFO
�� (
{
�� 	
public
�� 
byte
�� 
byEnable
��  
;
��  !
public
�� 
byte
�� 
byIPID
�� 
;
�� 
public
�� 
byte
�� 
	byChannel
�� !
;
��! "
public
�� 
byte
�� 

byIPIDHigh
�� "
;
��" #
public
�� 
byte
�� 
byTransProtocol
�� '
;
��' (
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F H
,
��H I
ArraySubType
��J V
=
��W X

��Y f
.
��f g
I1
��g i
)
��i j
]
��j k
public
�� 
byte
�� 
[
�� 
]
�� 
byRes
�� 
;
��  
public
�� 
void
�� 
Init
�� 
(
�� 
)
�� 
{
�� 
byRes
�� 
=
�� 
new
�� 
byte
��  
[
��  !
$num
��! #
]
��# $
;
��$ %
}
�� 
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� 
NET_DVR_IPPARACFG
�� '
{
�� 	
public
�� 
uint
�� 
dwSize
�� 
;
�� 
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E

��F S
,
��S T
ArraySubType
��U a
=
��b c

��d q
.
��q r
Struct
��r x
)
��x y
]
��y z
public
�� 
NET_DVR_IPDEVINFO
�� $
[
��$ %
]
��% &

��' 4
;
��4 5
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E 
MAX_ANALOG_CHANNUM
��F X
,
��X Y
ArraySubType
��Z f
=
��g h

��i v
.
��v w
I1
��w y
)
��y z
]
��z {
public
�� 
byte
�� 
[
�� 
]
��  
byAnalogChanEnable
�� ,
;
��, -
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_IP_CHANNEL
��F T
,
��T U
ArraySubType
��V b
=
��c d

��e r
.
��r s
Struct
��s y
)
��y z
]
��z {
public
��  
NET_DVR_IPCHANINFO
�� %
[
��% &
]
��& '
struIPChanInfo
��( 6
;
��6 7
public
�� 
void
�� 
Init
�� 
(
�� 
)
�� 
{
�� 
int
�� 
i
�� 
=
�� 
$num
�� 
;
�� 

�� 
=
�� 
new
��  #
NET_DVR_IPDEVINFO
��$ 5
[
��5 6

��6 C
]
��C D
;
��D E
for
�� 
(
�� 
i
�� 
=
�� 
$num
�� 
;
�� 
i
�� 
<
�� 

��  -
;
��- .
i
��/ 0
++
��0 2
)
��2 3
{
�� 

�� !
[
��! "
i
��" #
]
��# $
.
��$ %
Init
��% )
(
��) *
)
��* +
;
��+ ,
}
��  
byAnalogChanEnable
�� "
=
��# $
new
��% (
byte
��) -
[
��- . 
MAX_ANALOG_CHANNUM
��. @
]
��@ A
;
��A B
struIPChanInfo
�� 
=
��  
new
��! $ 
NET_DVR_IPCHANINFO
��% 7
[
��7 8
MAX_IP_CHANNEL
��8 F
]
��F G
;
��G H
for
�� 
(
�� 
i
�� 
=
�� 
$num
�� 
;
�� 
i
�� 
<
�� 
MAX_IP_CHANNEL
��  .
;
��. /
i
��0 1
++
��1 3
)
��3 4
{
�� 
struIPChanInfo
�� "
[
��" #
i
��# $
]
��$ %
.
��% &
Init
��& *
(
��* +
)
��+ ,
;
��, -
}
�� 
}
�� 
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� #
NET_DVR_IPPARACFG_V31
�� +
{
�� 	
public
�� 
uint
�� 
dwSize
�� 
;
�� 
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E

��F S
,
��S T
ArraySubType
��U a
=
��b c

��d q
.
��q r
Struct
��r x
)
��x y
]
��y z
public
�� #
NET_DVR_IPDEVINFO_V31
�� (
[
��( )
]
��) *

��+ 8
;
��8 9
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E 
MAX_ANALOG_CHANNUM
��F X
,
��X Y
ArraySubType
��Z f
=
��g h

��i v
.
��v w
I1
��w y
)
��y z
]
��z {
public
�� 
byte
�� 
[
�� 
]
��  
byAnalogChanEnable
�� ,
;
��, -
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_IP_CHANNEL
��F T
,
��T U
ArraySubType
��V b
=
��c d

��e r
.
��r s
Struct
��s y
)
��y z
]
��z {
public
��  
NET_DVR_IPCHANINFO
�� %
[
��% &
]
��& '
struIPChanInfo
��( 6
;
��6 7
public
�� 
void
�� 
Init
�� 
(
�� 
)
�� 
{
�� 
int
�� 
i
�� 
=
�� 
$num
�� 
;
�� 

�� 
=
�� 
new
��  ##
NET_DVR_IPDEVINFO_V31
��$ 9
[
��9 :

��: G
]
��G H
;
��H I
for
�� 
(
�� 
i
�� 
=
�� 
$num
�� 
;
�� 
i
�� 
<
�� 

��  -
;
��- .
i
��/ 0
++
��0 2
)
��2 3
{
�� 

�� !
[
��! "
i
��" #
]
��# $
.
��$ %
Init
��% )
(
��) *
)
��* +
;
��+ ,
}
��  
byAnalogChanEnable
�� "
=
��# $
new
��% (
byte
��) -
[
��- . 
MAX_ANALOG_CHANNUM
��. @
]
��@ A
;
��A B
struIPChanInfo
�� 
=
��  
new
��! $ 
NET_DVR_IPCHANINFO
��% 7
[
��7 8
MAX_IP_CHANNEL
��8 F
]
��F G
;
��G H
for
�� 
(
�� 
i
�� 
=
�� 
$num
�� 
;
�� 
i
�� 
<
�� 
MAX_IP_CHANNEL
��  .
;
��. /
i
��0 1
++
��1 3
)
��3 4
{
�� 
struIPChanInfo
�� "
[
��" #
i
��# $
]
��$ %
.
��% &
Init
��& *
(
��* +
)
��+ ,
;
��, -
}
�� 
}
�� 
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� %
NET_DVR_IPSERVER_STREAM
�� -
{
�� 	
public
�� 
byte
�� 
byEnable
��  
;
��  !
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F G
,
��G H
ArraySubType
��I U
=
��V W

��X e
.
��e f
I1
��f h
)
��h i
]
��i j
public
�� 
byte
�� 
[
�� 
]
�� 
byRes
�� 
;
��  
public
�� 
NET_DVR_IPADDR
�� !
struIPServer
��" .
;
��. /
public
�� 
ushort
�� 
wPort
�� 
;
��  
public
�� 
ushort
�� 
wDvrNameLen
�� %
;
��% &
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
NAME_LEN
��F N
,
��N O
ArraySubType
��P \
=
��] ^

��_ l
.
��l m
I1
��m o
)
��o p
]
��p q
public
�� 
byte
�� 
[
�� 
]
�� 
	byDVRName
�� #
;
��# $
public
�� 
ushort
�� 

�� '
;
��' (
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F G
,
��G H
ArraySubType
��I U
=
��V W

��X e
.
��e f
U2
��f h
)
��h i
]
��i j
public
�� 
ushort
�� 
[
�� 
]
�� 
byRes1
�� "
;
��" #
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
SERIALNO_LEN
��F R
,
��R S
ArraySubType
��T `
=
��a b

��c p
.
��p q
I1
��q s
)
��s t
]
��t u
public
�� 
byte
�� 
[
�� 
]
�� 
byDVRSerialNumber
�� +
;
��+ ,
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
NAME_LEN
��F N
,
��N O
ArraySubType
��P \
=
��] ^

��_ l
.
��l m
I1
��m o
)
��o p
]
��p q
public
�� 
byte
�� 
[
�� 
]
�� 

byUserName
�� $
;
��$ %
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E

PASSWD_LEN
��F P
,
��P Q
ArraySubType
��R ^
=
��_ `

��a n
.
��n o
I1
��o q
)
��q r
]
��r s
public
�� 
byte
�� 
[
�� 
]
�� 

byPassWord
�� $
;
��$ %
public
�� 
byte
�� 
	byChannel
�� !
;
��! "
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F H
,
��H I
ArraySubType
��J V
=
��W X

��Y f
.
��f g
I1
��g i
)
��i j
]
��j k
public
�� 
byte
�� 
[
�� 
]
�� 
byRes2
��  
;
��  !
public
�� 
void
�� 
Init
�� 
(
�� 
)
�� 
{
�� 
byRes
�� 
=
�� 
new
�� 
byte
��  
[
��  !
$num
��! "
]
��" #
;
��# $
	byDVRName
�� 
=
�� 
new
�� 
byte
��  $
[
��$ %
NAME_LEN
��% -
]
��- .
;
��. /
byRes1
�� 
=
�� 
new
�� 
ushort
�� #
[
��# $
$num
��$ %
]
��% &
;
��& '
byDVRSerialNumber
�� !
=
��" #
new
��$ '
byte
��( ,
[
��, -
SERIALNO_LEN
��- 9
]
��9 :
;
��: ;

byUserName
�� 
=
�� 
new
��  
byte
��! %
[
��% &
NAME_LEN
��& .
]
��. /
;
��/ 0

byPassWord
�� 
=
�� 
new
��  
byte
��! %
[
��% &

PASSWD_LEN
��& 0
]
��0 1
;
��1 2
byRes2
�� 
=
�� 
new
�� 
byte
�� !
[
��! "
$num
��" $
]
��$ %
;
��% &
}
�� 
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� -
NET_DVR_STREAM_MEDIA_SERVER_CFG
�� 5
{
�� 	
public
�� 
byte
�� 
byValid
�� 
;
��  
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F G
,
��G H
ArraySubType
��I U
=
��V W

��X e
.
��e f
I1
��f h
)
��h i
]
��i j
public
�� 
byte
�� 
[
�� 
]
�� 
byRes1
��  
;
��  !
public
�� 
NET_DVR_IPADDR
�� !
	struDevIP
��" +
;
��+ ,
public
�� 
ushort
�� 
wDevPort
�� "
;
��" #
public
�� 
byte
�� 
byTransmitType
�� &
;
��& '
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F H
,
��H I
ArraySubType
��J V
=
��W X

��Y f
.
��f g
I1
��g i
)
��i j
]
��j k
public
�� 
byte
�� 
[
�� 
]
�� 
byRes2
��  
;
��  !
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� #
NET_DVR_DEV_CHAN_INFO
�� +
{
�� 	
public
�� 
NET_DVR_IPADDR
�� !
struIP
��" (
;
��( )
public
�� 
ushort
�� 
wDVRPort
�� "
;
��" #
public
�� 
byte
�� 
	byChannel
�� !
;
��! "
public
�� 
byte
�� 
byTransProtocol
�� '
;
��' (
public
�� 
byte
�� 
byTransMode
�� #
;
��# $
public
�� 
byte
�� 

�� %
;
��% &
public
�� 
byte
�� 
byDeviceType
�� $
;
��$ %
public
�� 
byte
�� 

byDispChan
�� "
;
��" #
public
�� 
byte
�� 

�� %
;
��% &
public
�� 
byte
�� 
byResolution
�� $
;
��$ %
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F G
,
��G H
ArraySubType
��I U
=
��V W

��X e
.
��e f
I1
��f h
)
��h i
]
��i j
public
�� 
byte
�� 
[
�� 
]
�� 
byRes
�� 
;
��  
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_DOMAIN_NAME
��F U
,
��U V
ArraySubType
��W c
=
��d e

��f s
.
��s t
I1
��t v
)
��v w
]
��w x
public
�� 
byte
�� 
[
�� 
]
�� 
byDomain
�� "
;
��" #
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
NAME_LEN
��F N
,
��N O
ArraySubType
��P \
=
��] ^

��_ l
.
��l m
I1
��m o
)
��o p
]
��p q
public
�� 
byte
�� 
[
�� 
]
�� 
	sUserName
�� #
;
��# $
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E

PASSWD_LEN
��F P
,
��P Q
ArraySubType
��R ^
=
��_ `

��a n
.
��n o
I1
��o q
)
��q r
]
��r s
public
�� 
byte
�� 
[
�� 
]
�� 
	sPassword
�� #
;
��# $
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� #
NET_DVR_PU_STREAM_CFG
�� +
{
�� 	
public
�� 
uint
�� 
dwSize
�� 
;
�� 
public
�� -
NET_DVR_STREAM_MEDIA_SERVER_CFG
�� 2#
struStreamMediaSvrCfg
��3 H
;
��H I
public
�� #
NET_DVR_DEV_CHAN_INFO
�� (
struDevChanInfo
��) 8
;
��8 9
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� %
NET_DVR_DDNS_STREAM_CFG
�� -
{
�� 	
public
�� 
byte
�� 
byEnable
��  
;
��  !
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F G
,
��G H
ArraySubType
��I U
=
��V W

��X e
.
��e f
I1
��f h
)
��h i
]
��i j
public
�� 
byte
�� 
[
�� 
]
�� 
byRes1
��  
;
��  !
public
�� 
NET_DVR_IPADDR
�� !
struStreamServer
��" 2
;
��2 3
public
�� 
ushort
�� 
wStreamServerPort
�� +
;
��+ ,
public
�� 
byte
�� (
byStreamServerTransmitType
�� 2
;
��2 3
public
�� 
byte
�� 
byRes2
�� 
;
�� 
public
�� 
NET_DVR_IPADDR
�� !
struIPServer
��" .
;
��. /
public
�� 
ushort
�� 

�� '
;
��' (
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F G
,
��G H
ArraySubType
��I U
=
��V W

��X e
.
��e f
I1
��f h
)
��h i
]
��i j
public
�� 
byte
�� 
[
�� 
]
�� 
byRes3
��  
;
��  !
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
NAME_LEN
��F N
,
��N O
ArraySubType
��P \
=
��] ^

��_ l
.
��l m
I1
��m o
)
��o p
]
��p q
public
�� 
byte
�� 
[
�� 
]
�� 
sDVRName
�� "
;
��" #
public
�� 
ushort
�� 
wDVRNameLen
�� %
;
��% &
public
�� 
ushort
�� 

�� '
;
��' (
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
SERIALNO_LEN
��F R
,
��R S
ArraySubType
��T `
=
��a b

��c p
.
��p q
I1
��q s
)
��s t
]
��t u
public
�� 
byte
�� 
[
�� 
]
�� 
sDVRSerialNumber
�� *
;
��* +
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
NAME_LEN
��F N
,
��N O
ArraySubType
��P \
=
��] ^

��_ l
.
��l m
I1
��m o
)
��o p
]
��p q
public
�� 
byte
�� 
[
�� 
]
�� 
	sUserName
�� #
;
��# $
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E

PASSWD_LEN
��F P
,
��P Q
ArraySubType
��R ^
=
��_ `

��a n
.
��n o
I1
��o q
)
��q r
]
��r s
public
�� 
byte
�� 
[
�� 
]
�� 
	sPassWord
�� #
;
��# $
public
�� 
ushort
�� 
wDVRPort
�� "
;
��" #
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F G
,
��G H
ArraySubType
��I U
=
��V W

��X e
.
��e f
I1
��f h
)
��h i
]
��i j
public
�� 
byte
�� 
[
�� 
]
�� 
byRes4
��  
;
��  !
public
�� 
byte
�� 
	byChannel
�� !
;
��! "
public
�� 
byte
�� 
byTransProtocol
�� '
;
��' (
public
�� 
byte
�� 
byTransMode
�� #
;
��# $
public
�� 
byte
�� 

�� %
;
��% &
public
�� 
void
�� 
Init
�� 
(
�� 
)
�� 
{
�� 
byRes1
�� 
=
�� 
new
�� 
byte
�� !
[
��! "
$num
��" #
]
��# $
;
��$ %
byRes3
�� 
=
�� 
new
�� 
byte
�� !
[
��! "
$num
��" #
]
��# $
;
��$ %
sDVRName
�� 
=
�� 
new
�� 
byte
�� #
[
��# $
NAME_LEN
��$ ,
]
��, -
;
��- .
sDVRSerialNumber
��  
=
��! "
new
��# &
byte
��' +
[
��+ ,
SERIALNO_LEN
��, 8
]
��8 9
;
��9 :
	sUserName
�� 
=
�� 
new
�� 
byte
��  $
[
��$ %
NAME_LEN
��% -
]
��- .
;
��. /
	sPassWord
�� 
=
�� 
new
�� 
byte
��  $
[
��$ %

PASSWD_LEN
��% /
]
��/ 0
;
��0 1
byRes4
�� 
=
�� 
new
�� 
byte
�� !
[
��! "
$num
��" #
]
��# $
;
��$ %
}
�� 
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� #
NET_DVR_PU_STREAM_URL
�� +
{
�� 	
public
�� 
byte
�� 
byEnable
��  
;
��  !
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F I
,
��I J
ArraySubType
��K W
=
��X Y

��Z g
.
��g h
I1
��h j
)
��j k
]
��k l
public
�� 
byte
�� 
[
�� 
]
�� 
strURL
��  
;
��  !
public
�� 
byte
�� 
byTransPortocol
�� '
;
��' (
public
�� 
ushort
�� 
wIPID
�� 
;
��  
public
�� 
byte
�� 
	byChannel
�� !
;
��! "
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F G
,
��G H
ArraySubType
��I U
=
��V W

��X e
.
��e f
I1
��f h
)
��h i
]
��i j
public
�� 
byte
�� 
[
�� 
]
�� 
byRes
�� 
;
��  
public
�� 
void
�� 
Init
�� 
(
�� 
)
�� 
{
�� 
strURL
�� 
=
�� 
new
�� 
byte
�� !
[
��! "
$num
��" %
]
��% &
;
��& '
byRes
�� 
=
�� 
new
�� 
byte
��  
[
��  !
$num
��! "
]
��" #
;
��# $
}
�� 
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� #
NET_DVR_HKDDNS_STREAM
�� +
{
�� 	
public
�� 
byte
�� 
byEnable
��  
;
��  !
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F G
,
��G H
ArraySubType
��I U
=
��V W

��X e
.
��e f
I1
��f h
)
��h i
]
��i j
public
�� 
byte
�� 
[
�� 
]
�� 
byRes
�� 
;
��  
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F H
,
��H I
ArraySubType
��J V
=
��W X

��Y f
.
��f g
I1
��g i
)
��i j
]
��j k
public
�� 
byte
�� 
[
�� 
]
�� 
byDDNSDomain
�� &
;
��& '
public
�� 
ushort
�� 
wPort
�� 
;
��  
public
�� 
ushort
�� 
	wAliasLen
�� #
;
��# $
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
NAME_LEN
��F N
,
��N O
ArraySubType
��P \
=
��] ^

��_ l
.
��l m
I1
��m o
)
��o p
]
��p q
public
�� 
byte
�� 
[
�� 
]
�� 
byAlias
�� !
;
��! "
public
�� 
ushort
�� 

�� '
;
��' (
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F G
,
��G H
ArraySubType
��I U
=
��V W

��X e
.
��e f
I1
��f h
)
��h i
]
��i j
public
�� 
byte
�� 
[
�� 
]
�� 
byRes1
��  
;
��  !
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
SERIALNO_LEN
��F R
,
��R S
ArraySubType
��T `
=
��a b

��c p
.
��p q
I1
��q s
)
��s t
]
��t u
public
�� 
byte
�� 
[
�� 
]
�� 
byDVRSerialNumber
�� +
;
��+ ,
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
NAME_LEN
��F N
,
��N O
ArraySubType
��P \
=
��] ^

��_ l
.
��l m
I1
��m o
)
��o p
]
��p q
public
�� 
byte
�� 
[
�� 
]
�� 

byUserName
�� $
;
��$ %
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E

PASSWD_LEN
��F P
,
��P Q
ArraySubType
��R ^
=
��_ `

��a n
.
��n o
I1
��o q
)
��q r
]
��r s
public
�� 
byte
�� 
[
�� 
]
�� 

byPassWord
�� $
;
��$ %
public
�� 
byte
�� 
	byChannel
�� !
;
��! "
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F H
,
��H I
ArraySubType
��J V
=
��W X

��Y f
.
��f g
I1
��g i
)
��i j
]
��j k
public
�� 
byte
�� 
[
�� 
]
�� 
byRes2
��  
;
��  !
public
�� 
void
�� 
Init
�� 
(
�� 
)
�� 
{
�� 
byRes
�� 
=
�� 
new
�� 
byte
��  
[
��  !
$num
��! "
]
��" #
;
��# $
byDDNSDomain
�� 
=
�� 
new
�� "
byte
��# '
[
��' (
$num
��( *
]
��* +
;
��+ ,
byAlias
�� 
=
�� 
new
�� 
byte
�� "
[
��" #
NAME_LEN
��# +
]
��+ ,
;
��, -
byRes1
�� 
=
�� 
new
�� 
byte
�� !
[
��! "
$num
��" #
]
��# $
;
��$ %
byDVRSerialNumber
�� !
=
��" #
new
��$ '
byte
��( ,
[
��, -
SERIALNO_LEN
��- 9
]
��9 :
;
��: ;

byUserName
�� 
=
�� 
new
��  
byte
��! %
[
��% &
NAME_LEN
��& .
]
��. /
;
��/ 0

byPassWord
�� 
=
�� 
new
��  
byte
��! %
[
��% &

PASSWD_LEN
��& 0
]
��0 1
;
��1 2
byRes2
�� 
=
�� 
new
�� 
byte
�� !
[
��! "
$num
��" $
]
��$ %
;
��% &
}
�� 
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� $
NET_DVR_IPCHANINFO_V40
�� ,
{
�� 	
public
�� 
byte
�� 
byEnable
��  
;
��  !
public
�� 
byte
�� 
byRes1
�� 
;
�� 
public
�� 
ushort
�� 
wIPID
�� 
;
��  
public
�� 
uint
�� 
	dwChannel
�� !
;
��! "
public
�� 
byte
�� 
byTransProtocol
�� '
;
��' (
public
�� 
byte
�� 
byTransMode
�� #
;
��# $
public
�� 
byte
�� 

�� %
;
��% &
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F I
,
��I J
ArraySubType
��K W
=
��X Y

��Z g
.
��g h
I1
��h j
)
��j k
]
��k l
public
�� 
byte
�� 
[
�� 
]
�� 
byRes
�� 
;
��  
}
�� 	
[
�� 	
StructLayout
��	 
(
�� 

LayoutKind
��  
.
��  !
Explicit
��! )
)
��) *
]
��* +
public
�� 
struct
�� &
NET_DVR_GET_STREAM_UNION
�� .
{
�� 	
[
�� 
FieldOffset
��
(
�� 
$num
�� 
)
�� 
]
�� 
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F I
,
��I J
ArraySubType
��K W
=
��X Y

��Z g
.
��g h
I1
��h j
)
��j k
]
��k l
public
�� 
byte
�� 
[
�� 
]
�� 
byUnion
�� !
;
��! "
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� !
NET_DVR_STREAM_MODE
�� )
{
�� 	
public
�� 
byte
�� 
byGetStreamType
�� '
;
��' (
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F G
,
��G H
ArraySubType
��I U
=
��V W

��X e
.
��e f
I1
��f h
)
��h i
]
��i j
public
�� 
byte
�� 
[
�� 
]
�� 
byRes
�� 
;
��  
public
�� &
NET_DVR_GET_STREAM_UNION
�� +

uGetStream
��, 6
;
��6 7
public
�� 
void
�� 
Init
�� 
(
�� 
)
�� 
{
�� 
byGetStreamType
�� 
=
��  !
$num
��" #
;
��# $
byRes
�� 
=
�� 
new
�� 
byte
��  
[
��  !
$num
��! "
]
��" #
;
��# $
}
�� 
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� #
NET_DVR_IPPARACFG_V40
�� +
{
�� 	
public
�� 
uint
�� 
dwSize
�� 
;
�� 
public
�� 
uint
�� 

dwGroupNum
�� "
;
��" #
public
�� 
uint
�� 

dwAChanNum
�� "
;
��" #
public
�� 
uint
�� 

dwDChanNum
�� "
;
��" #
public
�� 
uint
�� 
dwStartDChan
�� $
;
��$ %
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_CHANNUM_V30
��F U
,
��U V
ArraySubType
��W c
=
��d e

��f s
.
��s t
I1
��t v
)
��v w
]
��w x
public
�� 
byte
�� 
[
�� 
]
��  
byAnalogChanEnable
�� ,
;
��, -
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_IP_DEVICE_V40
��F W
,
��W X
ArraySubType
��Y e
=
��f g

��h u
.
��u v
Struct
��v |
)
��| }
]
��} ~
public
�� #
NET_DVR_IPDEVINFO_V31
�� (
[
��( )
]
��) *

��+ 8
;
��8 9
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_CHANNUM_V30
��F U
,
��U V
ArraySubType
��W c
=
��d e

��f s
.
��s t
Struct
��t z
)
��z {
]
��{ |
public
�� !
NET_DVR_STREAM_MODE
�� &
[
��& '
]
��' (
struStreamMode
��) 7
;
��7 8
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F H
,
��H I
ArraySubType
��J V
=
��W X

��Y f
.
��f g
I1
��g i
)
��i j
]
��j k
public
�� 
byte
�� 
[
�� 
]
�� 
byRes2
��  
;
��  !
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� #
NET_DVR_ALARMINFO_DEV
�� +
{
�� 	
public
�� 
uint
�� 
dwAlarmType
�� #
;
��# $
public
�� 
NET_DVR_TIME
�� 
struTime
��  (
;
��( )
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F H
,
��H I
ArraySubType
��J V
=
��W X

��Y f
.
��f g
I1
��g i
)
��i j
]
��j k
public
�� 
byte
�� 
[
�� 
]
�� 
byRes
�� 
;
��  
public
�� 
uint
�� 
dwNumber
��  
;
��  !
public
�� 
IntPtr
�� 
pNO
�� 
;
�� 
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� $
NET_DVR_IPALARMOUTINFO
�� ,
{
�� 	
public
�� 
byte
�� 
byIPID
�� 
;
�� 
public
�� 
byte
�� 

byAlarmOut
�� "
;
��" #
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F H
,
��H I
ArraySubType
��J V
=
��W X

��Y f
.
��f g
I1
��g i
)
��i j
]
��j k
public
�� 
byte
�� 
[
�� 
]
�� 
byRes
�� 
;
��  
public
�� 
void
�� 
Init
�� 
(
�� 
)
�� 
{
�� 
byRes
�� 
=
�� 
new
�� 
byte
��  
[
��  !
$num
��! #
]
��# $
;
��$ %
}
�� 
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� #
NET_DVR_IPALARMOUTCFG
�� +
{
�� 	
public
�� 
uint
�� 
dwSize
�� 
;
�� 
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_IP_ALARMOUT
��F U
,
��U V
ArraySubType
��W c
=
��d e

��f s
.
��s t
Struct
��t z
)
��z {
]
��{ |
public
�� $
NET_DVR_IPALARMOUTINFO
�� )
[
��) *
]
��* + 
struIPAlarmOutInfo
��, >
;
��> ?
public
�� 
void
�� 
Init
�� 
(
�� 
)
�� 
{
�� 
struIPAlarmOutInfo
�� "
=
��# $
new
��% ($
NET_DVR_IPALARMOUTINFO
��) ?
[
��? @
MAX_IP_ALARMOUT
��@ O
]
��O P
;
��P Q
for
�� 
(
�� 
int
�� 
i
�� 
=
�� 
$num
�� 
;
�� 
i
��  !
<
��" #
MAX_IP_ALARMOUT
��$ 3
;
��3 4
i
��5 6
++
��6 8
)
��8 9
{
��  
struIPAlarmOutInfo
�� &
[
��& '
i
��' (
]
��( )
.
��) *
Init
��* .
(
��. /
)
��/ 0
;
��0 1
}
�� 
}
�� 
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� (
NET_DVR_IPALARMOUTINFO_V40
�� 0
{
�� 	
public
�� 
uint
�� 
dwIPID
�� 
;
�� 
public
�� 
uint
�� 

dwAlarmOut
�� "
;
��" #
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F H
,
��H I
ArraySubType
��J V
=
��W X

��Y f
.
��f g
I1
��g i
)
��i j
]
��j k
public
�� 
byte
�� 
[
�� 
]
�� 
byRes
�� 
;
��  
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� '
NET_DVR_IPALARMOUTCFG_V40
�� /
{
�� 	
public
�� 
uint
�� 
dwSize
�� 
;
�� 
public
�� 
uint
��  
dwCurIPAlarmOutNum
�� *
;
��* +
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E!
MAX_IP_ALARMOUT_V40
��F Y
,
��Y Z
ArraySubType
��[ g
=
��h i

��j w
.
��w x
Struct
��x ~
)
��~ 
]�� �
public
�� (
NET_DVR_IPALARMOUTINFO_V40
�� -
[
��- .
]
��. / 
struIPAlarmOutInfo
��0 B
;
��B C
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F I
,
��I J
ArraySubType
��K W
=
��X Y

��Z g
.
��g h
I1
��h j
)
��j k
]
��k l
public
�� 
byte
�� 
[
�� 
]
�� 
byRes
�� 
;
��  
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� #
NET_DVR_IPALARMININFO
�� +
{
�� 	
public
�� 
byte
�� 
byIPID
�� 
;
�� 
public
�� 
byte
�� 
	byAlarmIn
�� !
;
��! "
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F H
,
��H I
ArraySubType
��J V
=
��W X

��Y f
.
��f g
I1
��g i
)
��i j
]
��j k
public
�� 
byte
�� 
[
�� 
]
�� 
byRes
�� 
;
��  
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� "
NET_DVR_IPALARMINCFG
�� *
{
�� 	
public
�� 
uint
�� 
dwSize
�� 
;
�� 
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_IP_ALARMIN
��F T
,
��T U
ArraySubType
��V b
=
��c d

��e r
.
��r s
Struct
��s y
)
��y z
]
��z {
public
�� #
NET_DVR_IPALARMININFO
�� (
[
��( )
]
��) *
struIPAlarmInInfo
��+ <
;
��< =
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� '
NET_DVR_IPALARMININFO_V40
�� /
{
�� 	
public
�� 
uint
�� 
dwIPID
�� 
;
�� 
public
�� 
uint
�� 
	dwAlarmIn
�� !
;
��! "
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F H
,
��H I
ArraySubType
��J V
=
��W X

��Y f
.
��f g
I1
��g i
)
��i j
]
��j k
public
�� 
byte
�� 
[
�� 
]
�� 
byRes
�� 
;
��  
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� &
NET_DVR_IPALARMINCFG_V40
�� .
{
�� 	
public
�� 
uint
�� 
dwSize
�� 
;
�� 
public
�� 
uint
�� 
dwCurIPAlarmInNum
�� )
;
��) *
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E 
MAX_IP_ALARMIN_V40
��F X
,
��X Y
ArraySubType
��Z f
=
��g h

��i v
.
��v w
I1
��w y
)
��y z
]
��z {
public
�� '
NET_DVR_IPALARMININFO_V40
�� ,
[
��, -
]
��- .
struIPAlarmInInfo
��/ @
;
��@ A
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F I
,
��I J
ArraySubType
��K W
=
��X Y

��Z g
.
��g h
I1
��h j
)
��j k
]
��k l
public
�� 
byte
�� 
[
�� 
]
�� 
byRes
�� 
;
��  
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� !
NET_DVR_IPALARMINFO
�� )
{
�� 	
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E

��F S
,
��S T
ArraySubType
��U a
=
��b c

��d q
.
��q r
Struct
��r x
)
��x y
]
��y z
public
�� 
NET_DVR_IPDEVINFO
�� $
[
��$ %
]
��% &

��' 4
;
��4 5
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E 
MAX_ANALOG_CHANNUM
��F X
,
��X Y
ArraySubType
��Z f
=
��g h

��i v
.
��v w
I1
��w y
)
��y z
]
��z {
public
�� 
byte
�� 
[
�� 
]
��  
byAnalogChanEnable
�� ,
;
��, -
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_IP_CHANNEL
��F T
,
��T U
ArraySubType
��V b
=
��c d

��e r
.
��r s
Struct
��s y
)
��y z
]
��z {
public
��  
NET_DVR_IPCHANINFO
�� %
[
��% &
]
��& '
struIPChanInfo
��( 6
;
��6 7
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_IP_ALARMIN
��F T
,
��T U
ArraySubType
��V b
=
��c d

��e r
.
��r s
Struct
��s y
)
��y z
]
��z {
public
�� #
NET_DVR_IPALARMININFO
�� (
[
��( )
]
��) *
struIPAlarmInInfo
��+ <
;
��< =
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_IP_ALARMOUT
��F U
,
��U V
ArraySubType
��W c
=
��d e

��f s
.
��s t
Struct
��t z
)
��z {
]
��{ |
public
�� $
NET_DVR_IPALARMOUTINFO
�� )
[
��) *
]
��* + 
struIPAlarmOutInfo
��, >
;
��> ?
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� %
NET_DVR_IPALARMINFO_V31
�� -
{
�� 	
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E

��F S
,
��S T
ArraySubType
��U a
=
��b c

��d q
.
��q r
Struct
��r x
)
��x y
]
��y z
public
�� #
NET_DVR_IPDEVINFO_V31
�� (
[
��( )
]
��) *

��+ 8
;
��8 9
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E 
MAX_ANALOG_CHANNUM
��F X
,
��X Y
ArraySubType
��Z f
=
��g h

��i v
.
��v w
I1
��w y
)
��y z
]
��z {
public
�� 
byte
�� 
[
�� 
]
��  
byAnalogChanEnable
�� ,
;
��, -
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_IP_CHANNEL
��F T
,
��T U
ArraySubType
��V b
=
��c d

��e r
.
��r s
Struct
��s y
)
��y z
]
��z {
public
��  
NET_DVR_IPCHANINFO
�� %
[
��% &
]
��& '
struIPChanInfo
��( 6
;
��6 7
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_IP_ALARMIN
��F T
,
��T U
ArraySubType
��V b
=
��c d

��e r
.
��r s
Struct
��s y
)
��y z
]
��z {
public
�� #
NET_DVR_IPALARMININFO
�� (
[
��( )
]
��) *
struIPAlarmInInfo
��+ <
;
��< =
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_IP_ALARMOUT
��F U
,
��U V
ArraySubType
��W c
=
��d e

��f s
.
��s t
Struct
��t z
)
��z {
]
��{ |
public
�� $
NET_DVR_IPALARMOUTINFO
�� )
[
��) *
]
��* + 
struIPAlarmOutInfo
��, >
;
��> ?
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� %
NET_DVR_IPALARMINFO_V40
�� -
{
�� 	
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_IP_DEVICE_V40
��F W
,
��W X
ArraySubType
��Y e
=
��f g

��h u
.
��u v
Struct
��v |
)
��| }
]
��} ~
public
�� #
NET_DVR_IPDEVINFO_V31
�� (
[
��( )
]
��) *

��+ 8
;
��8 9
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_CHANNUM_V30
��F U
,
��U V
ArraySubType
��W c
=
��d e

��f s
.
��s t
I1
��t v
)
��v w
]
��w x
public
�� 
byte
�� 
[
�� 
]
��  
byAnalogChanEnable
�� ,
;
��, -
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_CHANNUM_V30
��F U
,
��U V
ArraySubType
��W c
=
��d e

��f s
.
��s t
Struct
��t z
)
��z {
]
��{ |
public
��  
NET_DVR_IPCHANINFO
�� %
[
��% &
]
��& '
struIPChanInfo
��( 6
;
��6 7
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_IP_ALARMIN
��F T
,
��T U
ArraySubType
��V b
=
��c d

��e r
.
��r s
Struct
��s y
)
��y z
]
��z {
public
�� #
NET_DVR_IPALARMININFO
�� (
[
��( )
]
��) *
struIPAlarmInInfo
��+ <
;
��< =
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_IP_ALARMOUT
��F U
,
��U V
ArraySubType
��W c
=
��d e

��f s
.
��s t
Struct
��t z
)
��z {
]
��{ |
public
�� $
NET_DVR_IPALARMOUTINFO
�� )
[
��) *
]
��* + 
struIPAlarmOutInfo
��, >
;
��> ?
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F H
,
��H I
ArraySubType
��J V
=
��W X

��Y f
.
��f g
I1
��g i
)
��i j
]
��j k
public
�� 
byte
�� 
[
�� 
]
�� 
byRes
�� 
;
��  
}
�� 	
public
�� 
enum
�� 
HD_STAT
�� 
{
�� 	

HD_STAT_OK
�� 
=
�� 
$num
�� 
,
�� !
HD_STAT_UNFORMATTED
�� 
=
��  !
$num
��" #
,
��# $

�� 
=
�� 
$num
�� 
,
�� "
HD_STAT_SMART_FAILED
��  
=
��! "
$num
��# $
,
��$ %
HD_STAT_MISMATCH
�� 
=
�� 
$num
��  
,
��  !
HD_STAT_IDLE
�� 
=
�� 
$num
�� 
,
�� !
NET_HD_STAT_OFFLINE
�� 
=
��  !
$num
��" #
,
��# $
HD_RIADVD_EXPAND
�� 
=
�� 
$num
��  
,
��  !
HD_STAT_REPARING
�� 
=
�� 
$num
�� !
,
��! "
HD_STAT_FORMATING
�� 
=
�� 
$num
��  "
,
��" #
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� 
NET_DVR_SINGLE_HD
�� '
{
�� 	
public
�� 
uint
�� 
dwHDNo
�� 
;
�� 
public
�� 
uint
�� 

dwCapacity
�� "
;
��" #
public
�� 
uint
�� 
dwFreeSpace
�� #
;
��# $
public
�� 
uint
�� 

dwHdStatus
�� "
;
��" #
public
�� 
byte
�� 
byHDAttr
��  
;
��  !
public
�� 
byte
�� 
byHDType
��  
;
��  !
public
�� 
byte
�� 
byDiskDriver
�� $
;
��$ %
public
�� 
byte
�� 
byRes1
�� 
;
�� 
public
�� 
uint
�� 
	dwHdGroup
�� !
;
��! "
public
�� 
byte
�� 
byRecycling
�� #
;
��# $
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F G
,
��G H
ArraySubType
��I U
=
��V W

��X e
.
��e f
I1
��f h
)
��h i
]
��i j
public
�� 
byte
�� 
[
�� 
]
�� 
byRes2
��  
;
��  !
public
�� 
uint
�� 

�� %
;
��% &
public
�� 
uint
�� 
dwPictureCapacity
�� )
;
��) *
public
�� 
uint
��  
dwFreePictureSpace
�� *
;
��* +
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F I
,
��I J
ArraySubType
��K W
=
��X Y

��Z g
.
��g h
I1
��h j
)
��j k
]
��k l
public
�� 
byte
�� 
[
�� 
]
�� 
byRes3
��  
;
��  !
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� 

�� #
{
�� 	
public
�� 
uint
�� 
dwSize
�� 
;
�� 
public
�� 
uint
�� 
	dwHDCount
�� !
;
��! "
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_DISKNUM_V30
��F U
,
��U V
ArraySubType
��W c
=
��d e

��f s
.
��s t
Struct
��t z
)
��z {
]
��{ |
public
�� 
NET_DVR_SINGLE_HD
�� $
[
��$ %
]
��% &

struHDInfo
��' 1
;
��1 2
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� (
NET_DVR_SINGLE_HDGROUP_V40
�� 0
{
�� 	
public
�� 
uint
�� 
dwHDGroupNo
�� #
;
��# $
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_CHANNUM_V40
��F U
,
��U V
ArraySubType
��W c
=
��d e

��f s
.
��s t
U4
��t v
)
��v w
]
��w x
public
�� 
uint
�� 
[
�� 
]
�� 
dwRelRecordChan
�� )
;
��) *
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F H
,
��H I
ArraySubType
��J V
=
��W X

��Y f
.
��f g
I1
��g i
)
��i j
]
��j k
public
�� 
byte
�� 
[
�� 
]
�� 
byRes
�� 
;
��  
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� %
NET_DVR_HDGROUP_CFG_V40
�� -
{
�� 	
public
�� 
uint
�� 
dwSize
�� 
;
�� 
public
�� 
uint
�� 
dwMaxHDGroupNum
�� '
;
��' (
public
�� 
uint
�� 
dwCurHDGroupNum
�� '
;
��' (
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_HD_GROUP
��F R
,
��R S
ArraySubType
��T `
=
��a b

��c p
.
��p q
Struct
��q w
)
��w x
]
��x y
public
�� (
NET_DVR_SINGLE_HDGROUP_V40
�� -
[
��- .
]
��. /
struHDGroupAttr
��0 ?
;
��? @
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F I
,
��I J
ArraySubType
��K W
=
��X Y

��Z g
.
��g h
I1
��h j
)
��j k
]
��k l
public
�� 
byte
�� 
[
�� 
]
�� 
byRes
�� 
;
��  
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� $
NET_DVR_SINGLE_HDGROUP
�� ,
{
�� 	
public
�� 
uint
�� 
dwHDGroupNo
�� #
;
��# $
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F H
,
��H I
ArraySubType
��J V
=
��W X

��Y f
.
��f g
I1
��g i
)
��i j
]
��j k
public
�� 
byte
�� 
[
�� 
]
�� 
byHDGroupChans
�� (
;
��( )
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F G
,
��G H
ArraySubType
��I U
=
��V W

��X e
.
��e f
I1
��f h
)
��h i
]
��i j
public
�� 
byte
�� 
[
�� 
]
�� 
byRes
�� 
;
��  
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� !
NET_DVR_HDGROUP_CFG
�� )
{
�� 	
public
�� 
uint
�� 
dwSize
�� 
;
�� 
public
�� 
uint
�� 
dwHDGroupCount
�� &
;
��& '
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_HD_GROUP
��F R
,
��R S
ArraySubType
��T `
=
��a b

��c p
.
��p q
Struct
��q w
)
��w x
]
��x y
public
�� $
NET_DVR_SINGLE_HDGROUP
�� )
[
��) *
]
��* +
struHDGroupAttr
��, ;
;
��; <
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� 
NET_DVR_SCALECFG
�� &
{
�� 	
public
�� 
uint
�� 
dwSize
�� 
;
�� 
public
�� 
uint
�� 
dwMajorScale
�� $
;
��$ %
public
�� 
uint
�� 
dwMinorScale
�� $
;
��$ %
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F G
,
��G H
ArraySubType
��I U
=
��V W

��X e
.
��e f
U4
��f h
)
��h i
]
��i j
public
�� 
uint
�� 
[
�� 
]
�� 
dwRes
�� 
;
��  
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� %
NET_DVR_ALARMOUTCFG_V30
�� -
{
�� 	
public
�� 
uint
�� 
dwSize
�� 
;
�� 
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
NAME_LEN
��F N
,
��N O
ArraySubType
��P \
=
��] ^

��_ l
.
��l m
I1
��m o
)
��o p
]
��p q
public
�� 
byte
�� 
[
�� 
]
�� 

�� '
;
��' (
public
�� 
uint
�� 
dwAlarmOutDelay
�� '
;
��' (
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_DAYS
��F N
*
��O P!
MAX_TIMESEGMENT_V30
��Q d
,
��d e
ArraySubType
��f r
=
��s t

.��� �
Struct��� �
)��� �
]��� �
public
�� 
NET_DVR_SCHEDTIME
�� $
[
��$ %
]
��% &
struAlarmOutTime
��' 7
;
��7 8
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F H
,
��H I
ArraySubType
��J V
=
��W X

��Y f
.
��f g
I1
��g i
)
��i j
]
��j k
public
�� 
byte
�� 
[
�� 
]
�� 
byRes
�� 
;
��  
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� !
NET_DVR_ALARMOUTCFG
�� )
{
�� 	
public
�� 
uint
�� 
dwSize
�� 
;
�� 
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
NAME_LEN
��F N
,
��N O
ArraySubType
��P \
=
��] ^

��_ l
.
��l m
I1
��m o
)
��o p
]
��p q
public
�� 
byte
�� 
[
�� 
]
�� 

�� '
;
��' (
public
�� 
uint
�� 
dwAlarmOutDelay
�� '
;
��' (
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_DAYS
��F N
*
��O P
MAX_TIMESEGMENT
��Q `
,
��` a
ArraySubType
��b n
=
��o p

��q ~
.
��~ 
Struct�� �
)��� �
]��� �
public
�� 
NET_DVR_SCHEDTIME
�� $
[
��$ %
]
��% &
struAlarmOutTime
��' 7
;
��7 8
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� $
NET_DVR_PREVIEWCFG_V30
�� ,
{
�� 	
public
�� 
uint
�� 
dwSize
�� 
;
�� 
public
�� 
byte
�� 
byPreviewNumber
�� '
;
��' (
public
�� 
byte
�� 

�� %
;
��% &
public
�� 
ushort
�� 
wSwitchTime
�� %
;
��% &
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_PREVIEW_MODE
��F V
*
��W X
MAX_WINDOW_V30
��Y g
,
��g h
ArraySubType
��i u
=
��v w

.��� �
I1��� �
)��� �
]��� �
public
�� 
byte
�� 
[
�� 
]
�� 
bySwitchSeq
�� %
;
��% &
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F H
,
��H I
ArraySubType
��J V
=
��W X

��Y f
.
��f g
I1
��g i
)
��i j
]
��j k
public
�� 
byte
�� 
[
�� 
]
�� 
byRes
�� 
;
��  
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
��  
NET_DVR_PREVIEWCFG
�� (
{
�� 	
public
�� 
uint
�� 
dwSize
�� 
;
�� 
public
�� 
byte
�� 
byPreviewNumber
�� '
;
��' (
public
�� 
byte
�� 

�� %
;
��% &
public
�� 
ushort
�� 
wSwitchTime
�� %
;
��% &
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E

MAX_WINDOW
��F P
,
��P Q
ArraySubType
��R ^
=
��_ `

��a n
.
��n o
I1
��o q
)
��q r
]
��r s
public
�� 
byte
�� 
[
�� 
]
�� 
bySwitchSeq
�� %
;
��% &
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� 
NET_DVR_VGAPARA
�� %
{
�� 	
public
�� 
ushort
�� 
wResolution
�� %
;
��% &
public
�� 
ushort
�� 
wFreq
�� 
;
��  
public
�� 
uint
�� 
dwBrightness
�� $
;
��$ %
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� $
NET_DVR_MATRIXPARA_V30
�� ,
{
�� 	
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E 
MAX_ANALOG_CHANNUM
��F X
,
��X Y
ArraySubType
��Z f
=
��g h

��i v
.
��v w
U2
��w y
)
��y z
]
��z {
public
�� 
ushort
�� 
[
�� 
]
�� 
wOrder
�� "
;
��" #
public
�� 
ushort
�� 
wSwitchTime
�� %
;
��% &
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F H
,
��H I
ArraySubType
��J V
=
��W X

��Y f
.
��f g
I1
��g i
)
��i j
]
��j k
public
�� 
byte
�� 
[
�� 
]
�� 
res
�� 
;
�� 
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
��  
NET_DVR_MATRIXPARA
�� (
{
�� 	
public
�� 
ushort
�� 
wDisplayLogo
�� &
;
��& '
public
�� 
ushort
�� 
wDisplayOsd
�� %
;
��% &
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� 

�� #
{
�� 	
public
�� 
byte
�� 

�� %
;
��% &
public
�� 
byte
�� 
byMenuAlphaValue
�� (
;
��( )
public
�� 
ushort
�� 
wScreenSaveTime
�� )
;
��) *
public
�� 
ushort
�� 
wVOffset
�� "
;
��" #
public
�� 
ushort
�� 
wBrightness
�� %
;
��% &
public
�� 
byte
�� 
byStartMode
�� #
;
��# $
public
�� 
byte
�� 
byEnableScaler
�� &
;
��& '
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� "
NET_DVR_VIDEOOUT_V30
�� *
{
�� 	
public
�� 
uint
�� 
dwSize
�� 
;
�� 
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_VIDEOOUT_V30
��F V
,
��V W
ArraySubType
��X d
=
��e f

��g t
.
��t u
Struct
��u {
)
��{ |
]
��| }
public
�� 

��  
[
��  !
]
��! "
	struVOOut
��# ,
;
��, -
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_VGA_V30
��F Q
,
��Q R
ArraySubType
��S _
=
��` a

��b o
.
��o p
Struct
��p v
)
��v w
]
��w x
public
�� 
NET_DVR_VGAPARA
�� "
[
��" #
]
��# $
struVGAPara
��% 0
;
��0 1
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E

��F S
,
��S T
ArraySubType
��U a
=
��b c

��d q
.
��q r
Struct
��r x
)
��x y
]
��y z
public
�� $
NET_DVR_MATRIXPARA_V30
�� )
[
��) *
]
��* +
struMatrixPara
��, :
;
��: ;
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F H
,
��H I
ArraySubType
��J V
=
��W X

��Y f
.
��f g
I1
��g i
)
��i j
]
��j k
public
�� 
byte
�� 
[
�� 
]
�� 
byRes
�� 
;
��  
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� 
NET_DVR_VIDEOOUT
�� &
{
�� 	
public
�� 
uint
�� 
dwSize
�� 
;
�� 
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_VIDEOOUT
��F R
,
��R S
ArraySubType
��T `
=
��a b

��c p
.
��p q
Struct
��q w
)
��w x
]
��x y
public
�� 

��  
[
��  !
]
��! "
	struVOOut
��# ,
;
��, -
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_VGA
��F M
,
��M N
ArraySubType
��O [
=
��\ ]

��^ k
.
��k l
Struct
��l r
)
��r s
]
��s t
public
�� 
NET_DVR_VGAPARA
�� "
[
��" #
]
��# $
struVGAPara
��% 0
;
��0 1
public
��  
NET_DVR_MATRIXPARA
�� %
struMatrixPara
��& 4
;
��4 5
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� #
NET_DVR_USER_INFO_V40
�� +
{
�� 	
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
NAME_LEN
��F N
,
��N O
ArraySubType
��P \
=
��] ^

��_ l
.
��l m
I1
��m o
)
��o p
]
��p q
public
�� 
byte
�� 
[
�� 
]
�� 
	sUserName
�� #
;
��# $
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E

PASSWD_LEN
��F P
,
��P Q
ArraySubType
��R ^
=
��_ `

��a n
.
��n o
I1
��o q
)
��q r
]
��r s
public
�� 
byte
�� 
[
�� 
]
�� 
	sPassword
�� #
;
��# $
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
	MAX_RIGHT
��F O
,
��O P
ArraySubType
��Q ]
=
��^ _

��` m
.
��m n
I1
��n p
)
��p q
]
��q r
public
�� 
byte
�� 
[
�� 
]
�� 
byLocalRight
�� &
;
��& '
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
	MAX_RIGHT
��F O
,
��O P
ArraySubType
��Q ]
=
��^ _

��` m
.
��m n
I1
��n p
)
��p q
]
��q r
public
�� 
byte
�� 
[
�� 
]
�� 

�� '
;
��' (
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_CHANNUM_V40
��F U
,
��U V
ArraySubType
��W c
=
��d e

��f s
.
��s t
U4
��t v
)
��v w
]
��w x
public
�� 
uint
�� 
[
�� 
]
�� 
dwNetPreviewRight
�� +
;
��+ ,
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_CHANNUM_V40
��F U
,
��U V
ArraySubType
��W c
=
��d e

��f s
.
��s t
U4
��t v
)
��v w
]
��w x
public
�� 
uint
�� 
[
�� 
]
��  
dwLocalRecordRight
�� ,
;
��, -
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_CHANNUM_V40
��F U
,
��U V
ArraySubType
��W c
=
��d e

��f s
.
��s t
U4
��t v
)
��v w
]
��w x
public
�� 
uint
�� 
[
�� 
]
�� 
dwNetRecordRight
�� *
;
��* +
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_CHANNUM_V40
��F U
,
��U V
ArraySubType
��W c
=
��d e

��f s
.
��s t
U4
��t v
)
��v w
]
��w x
public
�� 
uint
�� 
[
�� 
]
�� "
dwLocalPlaybackRight
�� .
;
��. /
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_CHANNUM_V40
��F U
,
��U V
ArraySubType
��W c
=
��d e

��f s
.
��s t
U4
��t v
)
��v w
]
��w x
public
�� 
uint
�� 
[
�� 
]
��  
dwNetPlaybackRight
�� ,
;
��, -
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_CHANNUM_V40
��F U
,
��U V
ArraySubType
��W c
=
��d e

��f s
.
��s t
U4
��t v
)
��v w
]
��w x
public
�� 
uint
�� 
[
�� 
]
�� 
dwLocalPTZRight
�� )
;
��) *
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_CHANNUM_V40
��F U
,
��U V
ArraySubType
��W c
=
��d e

��f s
.
��s t
U4
��t v
)
��v w
]
��w x
public
�� 
uint
�� 
[
�� 
]
�� 

�� '
;
��' (
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_CHANNUM_V40
��F U
,
��U V
ArraySubType
��W c
=
��d e

��f s
.
��s t
U4
��t v
)
��v w
]
��w x
public
�� 
uint
�� 
[
�� 
]
��  
dwLocalBackupRight
�� ,
;
��, -
public
�� 
NET_DVR_IPADDR
�� !

struUserIP
��" ,
;
��, -
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MACADDR_LEN
��F Q
,
��Q R
ArraySubType
��S _
=
��` a

��b o
.
��o p
I1
��p r
)
��r s
]
��s t
public
�� 
byte
�� 
[
�� 
]
�� 
	byMACAddr
�� #
;
��# $
public
�� 
byte
�� 

byPriority
�� "
;
��" #
public
�� 
byte
�� 
byAlarmOnRight
�� &
;
��& '
public
�� 
byte
�� 
byAlarmOffRight
�� '
;
��' (
public
�� 
byte
�� 

�� %
;
��% &
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F I
,
��I J
ArraySubType
��K W
=
��X Y

��Z g
.
��g h
I1
��h j
)
��j k
]
��k l
public
�� 
byte
�� 
[
�� 
]
�� 
byRes
�� 
;
��  
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� #
NET_DVR_USER_INFO_V30
�� +
{
�� 	
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
NAME_LEN
��F N
,
��N O
ArraySubType
��P \
=
��] ^

��_ l
.
��l m
I1
��m o
)
��o p
]
��p q
public
�� 
byte
�� 
[
�� 
]
�� 
	sUserName
�� #
;
��# $
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E

PASSWD_LEN
��F P
,
��P Q
ArraySubType
��R ^
=
��_ `

��a n
.
��n o
I1
��o q
)
��q r
]
��r s
public
�� 
byte
�� 
[
�� 
]
�� 
	sPassword
�� #
;
��# $
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
	MAX_RIGHT
��F O
,
��O P
ArraySubType
��Q ]
=
��^ _

��` m
.
��m n
I1
��n p
)
��p q
]
��q r
public
�� 
byte
�� 
[
�� 
]
�� 
byLocalRight
�� &
;
��& '
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
	MAX_RIGHT
��F O
,
��O P
ArraySubType
��Q ]
=
��^ _

��` m
.
��m n
I1
��n p
)
��p q
]
��q r
public
�� 
byte
�� 
[
�� 
]
�� 

�� '
;
��' (
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_CHANNUM_V30
��F U
,
��U V
ArraySubType
��W c
=
��d e

��f s
.
��s t
I1
��t v
)
��v w
]
��w x
public
�� 
byte
�� 
[
�� 
]
�� 
byNetPreviewRight
�� +
;
��+ ,
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_CHANNUM_V30
��F U
,
��U V
ArraySubType
��W c
=
��d e

��f s
.
��s t
I1
��t v
)
��v w
]
��w x
public
�� 
byte
�� 
[
�� 
]
�� "
byLocalPlaybackRight
�� .
;
��. /
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_CHANNUM_V30
��F U
,
��U V
ArraySubType
��W c
=
��d e

��f s
.
��s t
I1
��t v
)
��v w
]
��w x
public
�� 
byte
�� 
[
�� 
]
��  
byNetPlaybackRight
�� ,
;
��, -
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_CHANNUM_V30
��F U
,
��U V
ArraySubType
��W c
=
��d e

��f s
.
��s t
I1
��t v
)
��v w
]
��w x
public
�� 
byte
�� 
[
�� 
]
��  
byLocalRecordRight
�� ,
;
��, -
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_CHANNUM_V30
��F U
,
��U V
ArraySubType
��W c
=
��d e

��f s
.
��s t
I1
��t v
)
��v w
]
��w x
public
�� 
byte
�� 
[
�� 
]
�� 
byNetRecordRight
�� *
;
��* +
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_CHANNUM_V30
��F U
,
��U V
ArraySubType
��W c
=
��d e

��f s
.
��s t
I1
��t v
)
��v w
]
��w x
public
�� 
byte
�� 
[
�� 
]
�� 
byLocalPTZRight
�� )
;
��) *
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_CHANNUM_V30
��F U
,
��U V
ArraySubType
��W c
=
��d e

��f s
.
��s t
I1
��t v
)
��v w
]
��w x
public
�� 
byte
�� 
[
�� 
]
�� 

�� '
;
��' (
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_CHANNUM_V30
��F U
,
��U V
ArraySubType
��W c
=
��d e

��f s
.
��s t
I1
��t v
)
��v w
]
��w x
public
�� 
byte
�� 
[
�� 
]
��  
byLocalBackupRight
�� ,
;
��, -
public
�� 
NET_DVR_IPADDR
�� !

struUserIP
��" ,
;
��, -
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MACADDR_LEN
��F Q
,
��Q R
ArraySubType
��S _
=
��` a

��b o
.
��o p
I1
��p r
)
��r s
]
��s t
public
�� 
byte
�� 
[
�� 
]
�� 
	byMACAddr
�� #
;
��# $
public
�� 
byte
�� 

byPriority
�� "
;
��" #
public
�� 
byte
�� 
byAlarmOnRight
�� &
;
��& '
public
�� 
byte
�� 
byAlarmOffRight
�� '
;
��' (
public
�� 
byte
�� 

�� %
;
��% &
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F H
,
��H I
ArraySubType
��J V
=
��W X

��Y f
.
��f g
I1
��g i
)
��i j
]
��j k
public
�� 
byte
�� 
[
�� 
]
�� 
byRes
�� 
;
��  
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
,
��4 5
CharSet
��6 =
=
��> ?
CharSet
��@ G
.
��G H
Ansi
��H L
)
��L M
]
��M N
public
�� 
struct
�� "
NET_DVR_USER_INFO_EX
�� *
{
�� 	
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
NAME_LEN
��F N
,
��N O
ArraySubType
��P \
=
��] ^

��_ l
.
��l m
I1
��m o
)
��o p
]
��p q
public
�� 
byte
�� 
[
�� 
]
�� 
	sUserName
�� #
;
��# $
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E

PASSWD_LEN
��F P
,
��P Q
ArraySubType
��R ^
=
��_ `

��a n
.
��n o
I1
��o q
)
��q r
]
��r s
public
�� 
byte
�� 
[
�� 
]
�� 
	sPassword
�� #
;
��# $
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
	MAX_RIGHT
��F O
,
��O P
ArraySubType
��Q ]
=
��^ _

��` m
.
��m n
U4
��n p
)
��p q
]
��q r
public
�� 
uint
�� 
[
�� 
]
�� 
dwLocalRight
�� &
;
��& '
public
�� 
uint
�� "
dwLocalPlaybackRight
�� ,
;
��, -
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
	MAX_RIGHT
��F O
,
��O P
ArraySubType
��Q ]
=
��^ _

��` m
.
��m n
U4
��n p
)
��p q
]
��q r
public
�� 
uint
�� 
[
�� 
]
�� 

�� '
;
��' (
public
�� 
uint
�� 
dwNetPreviewRight
�� )
;
��) *
public
�� 
uint
��  
dwNetPlaybackRight
�� *
;
��* +
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .
	ByValTStr
��. 7
,
��7 8
	SizeConst
��9 B
=
��C D
$num
��E G
)
��G H
]
��H I
public
�� 
string
�� 
sUserIP
�� !
;
��! "
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MACADDR_LEN
��F Q
,
��Q R
ArraySubType
��S _
=
��` a

��b o
.
��o p
I1
��p r
)
��r s
]
��s t
public
�� 
byte
�� 
[
�� 
]
�� 
	byMACAddr
�� #
;
��# $
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
,
��4 5
CharSet
��6 =
=
��> ?
CharSet
��@ G
.
��G H
Ansi
��H L
)
��L M
]
��M N
public
�� 
struct
�� 
NET_DVR_USER_INFO
�� '
{
�� 	
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
NAME_LEN
��F N
,
��N O
ArraySubType
��P \
=
��] ^

��_ l
.
��l m
I1
��m o
)
��o p
]
��p q
public
�� 
byte
�� 
[
�� 
]
�� 
	sUserName
�� #
;
��# $
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E

PASSWD_LEN
��F P
,
��P Q
ArraySubType
��R ^
=
��_ `

��a n
.
��n o
I1
��o q
)
��q r
]
��r s
public
�� 
byte
�� 
[
�� 
]
�� 
	sPassword
�� #
;
��# $
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
	MAX_RIGHT
��F O
,
��O P
ArraySubType
��Q ]
=
��^ _

��` m
.
��m n
U4
��n p
)
��p q
]
��q r
public
�� 
uint
�� 
[
�� 
]
�� 
dwLocalRight
�� &
;
��& '
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
	MAX_RIGHT
��F O
,
��O P
ArraySubType
��Q ]
=
��^ _

��` m
.
��m n
U4
��n p
)
��p q
]
��q r
public
�� 
uint
�� 
[
�� 
]
�� 

�� '
;
��' (
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .
	ByValTStr
��. 7
,
��7 8
	SizeConst
��9 B
=
��C D
$num
��E G
)
��G H
]
��H I
public
�� 
string
�� 
sUserIP
�� !
;
��! "
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MACADDR_LEN
��F Q
,
��Q R
ArraySubType
��S _
=
��` a

��b o
.
��o p
I1
��p r
)
��r s
]
��s t
public
�� 
byte
�� 
[
�� 
]
�� 
	byMACAddr
�� #
;
��# $
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� 
NET_DVR_USER_V40
�� &
{
�� 	
public
�� 
uint
�� 
dwSize
�� 
;
�� 
public
�� 
uint
�� 
dwMaxUserNum
�� $
;
��$ %
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_USERNUM_V30
��F U
,
��U V
ArraySubType
��W c
=
��d e

��f s
.
��s t
Struct
��t z
)
��z {
]
��{ |
public
�� #
NET_DVR_USER_INFO_V40
�� (
[
��( )
]
��) *
struUser
��+ 3
;
��3 4
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� 
NET_DVR_USER_V30
�� &
{
�� 	
public
�� 
uint
�� 
dwSize
�� 
;
�� 
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_USERNUM_V30
��F U
,
��U V
ArraySubType
��W c
=
��d e

��f s
.
��s t
Struct
��t z
)
��z {
]
��{ |
public
�� #
NET_DVR_USER_INFO_V30
�� (
[
��( )
]
��) *
struUser
��+ 3
;
��3 4
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� 
NET_DVR_USER_EX
�� %
{
�� 	
public
�� 
uint
�� 
dwSize
�� 
;
�� 
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_USERNUM
��F Q
,
��Q R
ArraySubType
��S _
=
��` a

��b o
.
��o p
Struct
��p v
)
��v w
]
��w x
public
�� "
NET_DVR_USER_INFO_EX
�� '
[
��' (
]
��( )
struUser
��* 2
;
��2 3
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� 
NET_DVR_USER
�� "
{
�� 	
public
�� 
uint
�� 
dwSize
�� 
;
�� 
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_USERNUM
��F Q
,
��Q R
ArraySubType
��S _
=
��` a

��b o
.
��o p
Struct
��p v
)
��v w
]
��w x
public
�� 
NET_DVR_USER_INFO
�� $
[
��$ %
]
��% &
struUser
��' /
;
��/ 0
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� #
NET_DVR_EXCEPTION_V40
�� +
{
�� 	
public
�� 
uint
�� 
dwSize
�� 
;
�� 
public
�� 
uint
�� 

�� %
;
��% &
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E"
MAX_EXCEPTIONNUM_V30
��F Z
,
��Z [
ArraySubType
��\ h
=
��i j

��k x
.
��x y
Struct
��y 
)�� �
]��� �
public
�� )
NET_DVR_HANDLEEXCEPTION_V41
�� .
[
��. /
]
��/ 0!
struExceptionHandle
��1 D
;
��D E
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F I
,
��I J
ArraySubType
��K W
=
��X Y

��Z g
.
��g h
I1
��h j
)
��j k
]
��k l
public
�� 
byte
�� 
[
�� 
]
�� 
byRes
�� 
;
��  
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� #
NET_DVR_EXCEPTION_V30
�� +
{
�� 	
public
�� 
uint
�� 
dwSize
�� 
;
�� 
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E"
MAX_EXCEPTIONNUM_V30
��F Z
,
��Z [
ArraySubType
��\ h
=
��i j

��k x
.
��x y
Struct
��y 
)�� �
]��� �
public
�� )
NET_DVR_HANDLEEXCEPTION_V30
�� .
[
��. /
]
��/ 0%
struExceptionHandleType
��1 H
;
��H I
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� 
NET_DVR_EXCEPTION
�� '
{
�� 	
public
�� 
uint
�� 
dwSize
�� 
;
�� 
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_EXCEPTIONNUM
��F V
,
��V W
ArraySubType
��X d
=
��e f

��g t
.
��t u
Struct
��u {
)
��{ |
]
��| }
public
�� %
NET_DVR_HANDLEEXCEPTION
�� *
[
��* +
]
��+ ,%
struExceptionHandleType
��- D
;
��D E
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� &
NET_DVR_CHANNELSTATE_V30
�� .
{
�� 	
public
�� 
byte
�� 
byRecordStatic
�� &
;
��& '
public
�� 
byte
�� 
bySignalStatic
�� &
;
��& '
public
�� 
byte
�� 
byHardwareStatic
�� (
;
��( )
public
�� 
byte
�� 
byRes1
�� 
;
�� 
public
�� 
uint
�� 
	dwBitRate
�� !
;
��! "
public
�� 
uint
�� 
	dwLinkNum
�� !
;
��! "
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_LINK
��F N
,
��N O
ArraySubType
��P \
=
��] ^

��_ l
.
��l m
Struct
��m s
)
��s t
]
��t u
public
�� 
NET_DVR_IPADDR
�� !
[
��! "
]
��" #
struClientIP
��$ 0
;
��0 1
public
�� 
uint
�� 
dwIPLinkNum
�� #
;
��# $
public
�� 
byte
�� 
byExceedMaxLink
�� '
;
��' (
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F G
,
��G H
ArraySubType
��I U
=
��V W

��X e
.
��e f
I1
��f h
)
��h i
]
��i j
public
�� 
byte
�� 
[
�� 
]
�� 
byRes
�� 
;
��  
public
�� 
uint
�� 
dwChannelNo
�� #
;
��# $
public
�� 
void
�� 
Init
�� 
(
�� 
)
�� 
{
�� 
struClientIP
�� 
=
�� 
new
�� "
NET_DVR_IPADDR
��# 1
[
��1 2
MAX_LINK
��2 :
]
��: ;
;
��; <
for
�� 
(
�� 
int
�� 
i
�� 
=
�� 
$num
�� 
;
�� 
i
��  !
<
��" #
MAX_LINK
��$ ,
;
��, -
i
��. /
++
��/ 1
)
��1 2
{
�� 
struClientIP
��  
[
��  !
i
��! "
]
��" #
.
��# $
Init
��$ (
(
��( )
)
��) *
;
��* +
}
�� 
byRes
�� 
=
�� 
new
�� 
byte
��  
[
��  !
$num
��! #
]
��# $
;
��$ %
}
�� 
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� "
NET_DVR_CHANNELSTATE
�� *
{
�� 	
public
�� 
byte
�� 
byRecordStatic
�� &
;
��& '
public
�� 
byte
�� 
bySignalStatic
�� &
;
��& '
public
�� 
byte
�� 
byHardwareStatic
�� (
;
��( )
public
�� 
byte
�� 
reservedData
�� $
;
��$ %
public
�� 
uint
�� 
	dwBitRate
�� !
;
��! "
public
�� 
uint
�� 
	dwLinkNum
�� !
;
��! "
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_LINK
��F N
,
��N O
ArraySubType
��P \
=
��] ^

��_ l
.
��l m
U4
��m o
)
��o p
]
��p q
public
�� 
uint
�� 
[
�� 
]
�� 

dwClientIP
�� $
;
��$ %
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� 
NET_DVR_DISKSTATE
�� '
{
�� 	
public
�� 
uint
�� 
dwVolume
��  
;
��  !
public
�� 
uint
�� 
dwFreeSpace
�� #
;
��# $
public
�� 
uint
�� 
dwHardDiskStatic
�� (
;
��( )
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� #
NET_DVR_WORKSTATE_V40
�� +
{
�� 	
public
�� 
uint
�� 
dwSize
�� 
;
�� 
public
�� 
uint
�� 
dwDeviceStatic
�� &
;
��& '
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_DISKNUM_V30
��F U
,
��U V
ArraySubType
��W c
=
��d e

��f s
.
��s t
Struct
��t z
)
��z {
]
��{ |
public
�� 
NET_DVR_DISKSTATE
�� $
[
��$ %
]
��% & 
struHardDiskStatic
��' 9
;
��9 :
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_CHANNUM_V40
��F U
,
��U V
ArraySubType
��W c
=
��d e

��f s
.
��s t
Struct
��t z
)
��z {
]
��{ |
public
�� &
NET_DVR_CHANNELSTATE_V30
�� +
[
��+ ,
]
��, -
struChanStatic
��. <
;
��< =
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_ALARMIN_V40
��F U
,
��U V
ArraySubType
��W c
=
��d e

��f s
.
��s t
U4
��t v
)
��v w
]
��w x
public
�� 
uint
�� 
[
�� 
]
��  
dwHasAlarmInStatic
�� ,
;
��, -
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_ALARMOUT_V40
��F V
,
��V W
ArraySubType
��X d
=
��e f

��g t
.
��t u
U4
��u w
)
��w x
]
��x y
public
�� 
uint
�� 
[
�� 
]
�� !
dwHasAlarmOutStatic
�� -
;
��- .
public
�� 
uint
�� 
dwLocalDisplay
�� &
;
��& '
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E

��F S
,
��S T
ArraySubType
��U a
=
��b c

��d q
.
��q r
U4
��r t
)
��t u
]
��u v
public
�� 
uint
�� 
[
�� 
]
�� !
byAudioInChanStatus
�� -
;
��- .
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F I
,
��I J
ArraySubType
��K W
=
��X Y

��Z g
.
��g h
I1
��h j
)
��j k
]
��k l
public
�� 
byte
�� 
[
�� 
]
�� 
byRes
�� 
;
��  
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� '
NET_DVR_GETWORKSTATE_COND
�� /
{
�� 	
public
�� 
uint
�� 
dwSize
�� 
;
�� 
public
�� 
byte
�� 
byFindHardByCond
�� (
;
��( )
public
�� 
byte
�� 
byFindChanByCond
�� (
;
��( )
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F G
,
��G H
ArraySubType
��I U
=
��V W

��X e
.
��e f
I1
��f h
)
��h i
]
��i j
public
�� 
byte
�� 
[
�� 
]
�� 
byRes1
��  
;
��  !
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_DISKNUM_V30
��F U
,
��U V
ArraySubType
��W c
=
��d e

��f s
.
��s t
U4
��t v
)
��v w
]
��w x
public
�� 
uint
�� 
[
�� 
]
�� 
dwFindHardStatus
�� *
;
��* +
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_CHANNUM_V40
��F U
,
��U V
ArraySubType
��W c
=
��d e

��f s
.
��s t
U4
��t v
)
��v w
]
��w x
public
�� 
uint
�� 
[
�� 
]
�� 
dwFindChanNo
�� &
;
��& '
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F H
,
��H I
ArraySubType
��J V
=
��W X

��Y f
.
��f g
I1
��g i
)
��i j
]
��j k
public
�� 
byte
�� 
[
�� 
]
�� 
byRes
�� 
;
��  
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� #
NET_DVR_WORKSTATE_V30
�� +
{
�� 	
public
�� 
uint
�� 
dwDeviceStatic
�� &
;
��& '
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_DISKNUM_V30
��F U
,
��U V
ArraySubType
��W c
=
��d e

��f s
.
��s t
Struct
��t z
)
��z {
]
��{ |
public
�� 
NET_DVR_DISKSTATE
�� $
[
��$ %
]
��% & 
struHardDiskStatic
��' 9
;
��9 :
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_CHANNUM_V30
��F U
,
��U V
ArraySubType
��W c
=
��d e

��f s
.
��s t
Struct
��t z
)
��z {
]
��{ |
public
�� &
NET_DVR_CHANNELSTATE_V30
�� +
[
��+ ,
]
��, -
struChanStatic
��. <
;
��< =
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_ALARMIN_V30
��F U
,
��U V
ArraySubType
��W c
=
��d e

��f s
.
��s t
I1
��t v
)
��v w
]
��w x
public
�� 
byte
�� 
[
�� 
]
�� 
byAlarmInStatic
�� )
;
��) *
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_ALARMOUT_V30
��F V
,
��V W
ArraySubType
��X d
=
��e f

��g t
.
��t u
I1
��u w
)
��w x
]
��x y
public
�� 
byte
�� 
[
�� 
]
�� 
byAlarmOutStatic
�� *
;
��* +
public
�� 
uint
�� 
dwLocalDisplay
�� &
;
��& '
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E

��F S
,
��S T
ArraySubType
��U a
=
��b c

��d q
.
��q r
I1
��r t
)
��t u
]
��u v
public
�� 
byte
�� 
[
�� 
]
�� 
byAudioChanStatus
�� +
;
��+ ,
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F H
,
��H I
ArraySubType
��J V
=
��W X

��Y f
.
��f g
I1
��g i
)
��i j
]
��j k
public
�� 
byte
�� 
[
�� 
]
�� 
byRes
�� 
;
��  
public
�� 
void
�� 
Init
�� 
(
�� 
)
�� 
{
�� 
struHardDiskStatic
�� "
=
��# $
new
��% (
NET_DVR_DISKSTATE
��) :
[
��: ;
MAX_DISKNUM_V30
��; J
]
��J K
;
��K L
struChanStatic
�� 
=
��  
new
��! $&
NET_DVR_CHANNELSTATE_V30
��% =
[
��= >
MAX_CHANNUM_V30
��> M
]
��M N
;
��N O
for
�� 
(
�� 
int
�� 
i
�� 
=
�� 
$num
�� 
;
�� 
i
��  !
<
��" #
MAX_CHANNUM_V30
��$ 3
;
��3 4
i
��5 6
++
��6 8
)
��8 9
{
�� 
struChanStatic
�� "
[
��" #
i
��# $
]
��$ %
.
��% &
Init
��& *
(
��* +
)
��+ ,
;
��, -
}
�� 
byAlarmInStatic
�� 
=
��  !
new
��" %
byte
��& *
[
��* +
MAX_ALARMOUT_V30
��+ ;
]
��; <
;
��< =
byAlarmOutStatic
��  
=
��! "
new
��# &
byte
��' +
[
��+ ,
MAX_ALARMOUT_V30
��, <
]
��< =
;
��= >
byAudioChanStatus
�� !
=
��" #
new
��$ '
byte
��( ,
[
��, -

��- :
]
��: ;
;
��; <
byRes
�� 
=
�� 
new
�� 
byte
��  
[
��  !
$num
��! #
]
��# $
;
��$ %
}
�� 
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� 
NET_DVR_WORKSTATE
�� '
{
�� 	
public
�� 
uint
�� 
dwDeviceStatic
�� &
;
��& '
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_DISKNUM
��F Q
,
��Q R
ArraySubType
��S _
=
��` a

��b o
.
��o p
Struct
��p v
)
��v w
]
��w x
public
�� 
NET_DVR_DISKSTATE
�� $
[
��$ %
]
��% & 
struHardDiskStatic
��' 9
;
��9 :
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_CHANNUM
��F Q
,
��Q R
ArraySubType
��S _
=
��` a

��b o
.
��o p
Struct
��p v
)
��v w
]
��w x
public
�� "
NET_DVR_CHANNELSTATE
�� '
[
��' (
]
��( )
struChanStatic
��* 8
;
��8 9
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_ALARMIN
��F Q
,
��Q R
ArraySubType
��S _
=
��` a

��b o
.
��o p
I1
��p r
)
��r s
]
��s t
public
�� 
byte
�� 
[
�� 
]
�� 
byAlarmInStatic
�� )
;
��) *
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_ALARMOUT
��F R
,
��R S
ArraySubType
��T `
=
��a b

��c p
.
��p q
I1
��q s
)
��s t
]
��t u
public
�� 
byte
�� 
[
�� 
]
�� 
byAlarmOutStatic
�� *
;
��* +
public
�� 
uint
�� 
dwLocalDisplay
�� &
;
��& '
public
�� 
void
�� 
Init
�� 
(
�� 
)
�� 
{
�� 
struHardDiskStatic
�� "
=
��# $
new
��% (
NET_DVR_DISKSTATE
��) :
[
��: ;
MAX_DISKNUM
��; F
]
��F G
;
��G H
struChanStatic
�� 
=
��  
new
��! $"
NET_DVR_CHANNELSTATE
��% 9
[
��9 :
MAX_CHANNUM
��: E
]
��E F
;
��F G
byAlarmInStatic
�� 
=
��  !
new
��" %
byte
��& *
[
��* +
MAX_ALARMIN
��+ 6
]
��6 7
;
��7 8
byAlarmOutStatic
��  
=
��! "
new
��# &
byte
��' +
[
��+ ,
MAX_ALARMOUT
��, 8
]
��8 9
;
��9 :
}
�� 
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
,
��4 5
CharSet
��6 =
=
��> ?
CharSet
��@ G
.
��G H
Ansi
��H L
)
��L M
]
��M N
public
�� 
struct
�� 
NET_DVR_LOG_V30
�� %
{
�� 	
public
�� 
NET_DVR_TIME
�� 

strLogTime
��  *
;
��* +
public
�� 
uint
�� 
dwMajorType
�� #
;
��# $
public
�� 
uint
�� 
dwMinorType
�� #
;
��# $
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_NAMELEN
��F Q
,
��Q R
ArraySubType
��S _
=
��` a

��b o
.
��o p
I1
��p r
)
��r s
]
��s t
public
�� 
byte
�� 
[
�� 
]
�� 

sPanelUser
�� $
;
��$ %
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_NAMELEN
��F Q
,
��Q R
ArraySubType
��S _
=
��` a

��b o
.
��o p
I1
��p r
)
��r s
]
��s t
public
�� 
byte
�� 
[
�� 
]
�� 
sNetUser
�� "
;
��" #
public
�� 
NET_DVR_IPADDR
�� ! 
struRemoteHostAddr
��" 4
;
��4 5
public
�� 
uint
�� 

dwParaType
�� "
;
��" #
public
�� 
uint
�� 
	dwChannel
�� !
;
��! "
public
�� 
uint
�� 
dwDiskNumber
�� $
;
��$ %
public
�� 
uint
�� 

�� %
;
��% &
public
�� 
uint
�� 
dwAlarmOutPort
�� &
;
��& '
public
�� 
uint
�� 
	dwInfoLen
�� !
;
��! "
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .
	ByValTStr
��. 7
,
��7 8
	SizeConst
��9 B
=
��C D
LOG_INFO_LEN
��E Q
)
��Q R
]
��R S
public
�� 
string
�� 
sInfo
�� 
;
��  
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
,
��4 5
CharSet
��6 =
=
��> ?
CharSet
��@ G
.
��G H
Ansi
��H L
)
��L M
]
��M N
public
�� 
struct
�� 
NET_DVR_LOG
�� !
{
�� 	
public
�� 
NET_DVR_TIME
�� 

strLogTime
��  *
;
��* +
public
�� 
uint
�� 
dwMajorType
�� #
;
��# $
public
�� 
uint
�� 
dwMinorType
�� #
;
��# $
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_NAMELEN
��F Q
,
��Q R
ArraySubType
��S _
=
��` a

��b o
.
��o p
I1
��p r
)
��r s
]
��s t
public
�� 
byte
�� 
[
�� 
]
�� 

sPanelUser
�� $
;
��$ %
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_NAMELEN
��F Q
,
��Q R
ArraySubType
��S _
=
��` a

��b o
.
��o p
I1
��p r
)
��r s
]
��s t
public
�� 
byte
�� 
[
�� 
]
�� 
sNetUser
�� "
;
��" #
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .
	ByValTStr
��. 7
,
��7 8
	SizeConst
��9 B
=
��C D
$num
��E G
)
��G H
]
��H I
public
�� 
string
�� 
sRemoteHostAddr
�� )
;
��) *
public
�� 
uint
�� 

dwParaType
�� "
;
��" #
public
�� 
uint
�� 
	dwChannel
�� !
;
��! "
public
�� 
uint
�� 
dwDiskNumber
�� $
;
��$ %
public
�� 
uint
�� 

�� %
;
��% &
public
�� 
uint
�� 
dwAlarmOutPort
�� &
;
��& '
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� 0
"NET_DVR_ALARMHOST_SEARCH_LOG_PARAM
�� 8
{
�� 	
public
�� 
ushort
�� 

wMajorType
�� $
;
��$ %
public
�� 
ushort
�� 

wMinorType
�� $
;
��$ %
public
�� 
NET_DVR_TIME
�� 

��  -
;
��- .
public
�� 
NET_DVR_TIME
�� 
struEndTime
��  +
;
��+ ,
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F G
,
��G H
ArraySubType
��I U
=
��V W

��X e
.
��e f
I1
��f h
)
��h i
]
��i j
public
�� 
byte
�� 
[
�� 
]
�� 
byRes
�� 
;
��  
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� '
NET_DVR_ALARMHOST_LOG_RET
�� /
{
�� 	
public
�� 
NET_DVR_TIME
�� 
struLogTime
��  +
;
��+ ,
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
NAME_LEN
��F N
,
��N O
ArraySubType
��P \
=
��] ^

��_ l
.
��l m
I1
��m o
)
��o p
]
��p q
public
�� 
byte
�� 
[
�� 
]
�� 
	sUserName
�� #
;
��# $
public
�� 
NET_DVR_IPADDR
�� !

struIPAddr
��" ,
;
��, -
public
�� 
ushort
�� 

wMajorType
�� $
;
��$ %
public
�� 
ushort
�� 

wMinorType
�� $
;
��$ %
public
�� 
ushort
�� 
wParam
��  
;
��  !
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F H
,
��H I
ArraySubType
��J V
=
��W X

��Y f
.
��f g
I1
��g i
)
��i j
]
��j k
public
�� 
byte
�� 
[
�� 
]
�� 
byRes
�� 
;
��  
public
�� 
uint
�� 
	dwInfoLen
�� !
;
��! "
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .
	ByValTStr
��. 7
,
��7 8
	SizeConst
��9 B
=
��C D
LOG_INFO_LEN
��E Q
)
��Q R
]
��R S
public
�� 
string
�� 
sInfo
�� 
;
��  
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� (
NET_DVR_ALARMOUTSTATUS_V30
�� 0
{
�� 	
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_ALARMOUT_V30
��F V
,
��V W
ArraySubType
��X d
=
��e f

��g t
.
��t u
I1
��u w
)
��w x
]
��x y
public
�� 
byte
�� 
[
�� 
]
�� 
Output
��  
;
��  !
public
�� 
void
�� 
Init
�� 
(
�� 
)
�� 
{
�� 
Output
�� 
=
�� 
new
�� 
byte
�� !
[
��! "
MAX_ALARMOUT_V30
��" 2
]
��2 3
;
��3 4
}
�� 
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� $
NET_DVR_ALARMOUTSTATUS
�� ,
{
�� 	
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F G
,
��G H
ArraySubType
��I U
=
��V W

��X e
.
��e f
I1
��f h
)
��h i
]
��i j
public
�� 
byte
�� 
[
�� 
]
�� 
Output
��  
;
��  !
}
�� 	
public
�� 
const
�� 
int
�� 
NCR
�� 
=
�� 
$num
��  
;
��  !
public
�� 
const
�� 
int
�� 
DIEBOLD
��  
=
��! "
$num
��# $
;
��$ %
public
�� 
const
�� 
int
�� 
WINCOR_NIXDORF
�� '
=
��( )
$num
��* +
;
��+ ,
public
�� 
const
�� 
int
�� 
SIEMENS
��  
=
��! "
$num
��# $
;
��$ %
public
�� 
const
�� 
int
�� 
OLIVETTI
�� !
=
��" #
$num
��$ %
;
��% &
public
�� 
const
�� 
int
�� 
FUJITSU
��  
=
��! "
$num
��# $
;
��$ %
public
�� 
const
�� 
int
�� 
HITACHI
��  
=
��! "
$num
��# $
;
��$ %
public
�� 
const
�� 
int
�� 
SMI
�� 
=
�� 
$num
��  
;
��  !
public
�� 
const
�� 
int
�� 
IBM
�� 
=
�� 
$num
��  
;
��  !
public
�� 
const
�� 
int
�� 
BULL
�� 
=
�� 
$num
��  !
;
��! "
public
�� 
const
�� 
int
�� 
YiHua
�� 
=
��  
$num
��! #
;
��# $
public
�� 
const
�� 
int
�� 
LiDe
�� 
=
�� 
$num
��  "
;
��" #
public
�� 
const
�� 
int
�� 
GDYT
�� 
=
�� 
$num
��  "
;
��" #
public
�� 
const
�� 
int
�� 
	Mini_Banl
�� "
=
��# $
$num
��% '
;
��' (
public
�� 
const
�� 
int
�� 
GuangLi
��  
=
��! "
$num
��# %
;
��% &
public
�� 
const
�� 
int
�� 
DongXin
��  
=
��! "
$num
��# %
;
��% &
public
�� 
const
�� 
int
�� 
ChenTong
�� !
=
��" #
$num
��$ &
;
��& '
public
�� 
const
�� 
int
�� 
NanTian
��  
=
��! "
$num
��# %
;
��% &
public
�� 
const
�� 
int
�� 
XiaoXing
�� !
=
��" #
$num
��$ &
;
��& '
public
�� 
const
�� 
int
�� 
GZYY
�� 
=
�� 
$num
��  "
;
��" #
public
�� 
const
�� 
int
�� 
QHTLT
�� 
=
��  
$num
��! #
;
��# $
public
�� 
const
�� 
int
�� 
DRS918
�� 
=
��  !
$num
��" $
;
��$ %
public
�� 
const
�� 
int
�� 
KALATEL
��  
=
��! "
$num
��# %
;
��% &
public
�� 
const
�� 
int
�� 
NCR_2
�� 
=
��  
$num
��! #
;
��# $
public
�� 
const
�� 
int
�� 
NXS
�� 
=
�� 
$num
�� !
;
��! "
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
,
��4 5
CharSet
��6 =
=
��> ?
CharSet
��@ G
.
��G H
Ansi
��H L
)
��L M
]
��M N
public
�� 
struct
�� 
NET_DVR_TRADEINFO
�� '
{
�� 	
public
�� 
ushort
�� 
m_Year
��  
;
��  !
public
�� 
ushort
�� 
m_Month
�� !
;
��! "
public
�� 
ushort
�� 
m_Day
�� 
;
��  
public
�� 
ushort
�� 
m_Hour
��  
;
��  !
public
�� 
ushort
�� 
m_Minute
�� "
;
��" #
public
�� 
ushort
�� 
m_Second
�� "
;
��" #
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F H
,
��H I
ArraySubType
��J V
=
��W X

��Y f
.
��f g
I1
��g i
)
��i j
]
��j k
public
�� 
byte
�� 
[
�� 
]
�� 

DeviceName
�� $
;
��$ %
public
�� 
uint
�� 
dwChannelNumer
�� &
;
��& '
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F H
,
��H I
ArraySubType
��J V
=
��W X

��Y f
.
��f g
I1
��g i
)
��i j
]
��j k
public
�� 
byte
�� 
[
�� 
]
�� 

CardNumber
�� $
;
��$ %
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .
	ByValTStr
��. 7
,
��7 8
	SizeConst
��9 B
=
��C D
$num
��E G
)
��G H
]
��H I
public
�� 
string
�� 

cTradeType
�� $
;
��$ %
public
�� 
uint
�� 
dwCash
�� 
;
�� 
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� #
NET_DVR_FRAMETYPECODE
�� +
{
�� 	
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F H
,
��H I
ArraySubType
��J V
=
��W X

��Y f
.
��f g
I1
��g i
)
��i j
]
��j k
public
�� 
byte
�� 
[
�� 
]
�� 
code
�� 
;
�� 
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
,
��4 5
CharSet
��6 =
=
��> ?
CharSet
��@ G
.
��G H
Ansi
��H L
)
��L M
]
��M N
public
�� 
struct
�� !
NET_DVR_FRAMEFORMAT
�� )
{
�� 	
public
�� 
uint
�� 
dwSize
�� 
;
�� 
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .
	ByValTStr
��. 7
,
��7 8
	SizeConst
��9 B
=
��C D
$num
��E G
)
��G H
]
��H I
public
�� 
string
�� 
sATMIP
��  
;
��  !
public
�� 
uint
�� 
	dwATMType
�� !
;
��! "
public
�� 
uint
�� 
dwInputMode
�� #
;
��# $
public
�� 
uint
�� !
dwFrameSignBeginPos
�� +
;
��+ ,
public
�� 
uint
�� 
dwFrameSignLength
�� )
;
��) *
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F H
,
��H I
ArraySubType
��J V
=
��W X

��Y f
.
��f g
I1
��g i
)
��i j
]
��j k
public
�� 
byte
�� 
[
�� 
]
��  
byFrameSignContent
�� ,
;
��, -
public
�� 
uint
�� &
dwCardLengthInfoBeginPos
�� 0
;
��0 1
public
�� 
uint
�� $
dwCardLengthInfoLength
�� .
;
��. /
public
�� 
uint
�� &
dwCardNumberInfoBeginPos
�� 0
;
��0 1
public
�� 
uint
�� $
dwCardNumberInfoLength
�� .
;
��. /
public
�� 
uint
�� $
dwBusinessTypeBeginPos
�� .
;
��. /
public
�� 
uint
�� "
dwBusinessTypeLength
�� ,
;
��, -
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F H
,
��H I
ArraySubType
��J V
=
��W X

��Y f
.
��f g
Struct
��g m
)
��m n
]
��n o
public
�� #
NET_DVR_FRAMETYPECODE
�� (
[
��( )
]
��) *

��+ 8
;
��8 9
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� 
NET_DVR_FILTER
�� $
{
�� 	
public
�� 
byte
�� 
byEnable
��  
;
��  !
public
�� 
byte
�� 
byMode
�� 
;
�� 
public
�� 
byte
�� 
byFrameBeginPos
�� '
;
��' (
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F G
,
��G H
ArraySubType
��I U
=
��V W

��X e
.
��e f
I1
��f h
)
��h i
]
��i j
public
�� 
byte
�� 
[
�� 
]
�� 
byRes
�� 
;
��  
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F H
,
��H I
ArraySubType
��J V
=
��W X

��Y f
.
��f g
I1
��g i
)
��i j
]
��j k
public
�� 
byte
�� 
[
�� 
]
�� 
byFilterText
�� &
;
��& '
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F H
,
��H I
ArraySubType
��J V
=
��W X

��Y f
.
��f g
I1
��g i
)
��i j
]
��j k
public
�� 
byte
�� 
[
�� 
]
�� 
byRes2
��  
;
��  !
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� !
NET_DVR_IDENTIFICAT
�� )
{
�� 	
public
�� 
byte
�� 
byStartMode
�� #
;
��# $
public
�� 
byte
�� 
	byEndMode
�� !
;
��! "
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F G
,
��G H
ArraySubType
��I U
=
��V W

��X e
.
��e f
I1
��f h
)
��h i
]
��i j
public
�� 
byte
�� 
[
�� 
]
�� 
byRes
�� 
;
��  
public
�� #
NET_DVR_FRAMETYPECODE
�� (

��) 6
;
��6 7
public
�� #
NET_DVR_FRAMETYPECODE
�� (
struEndCode
��) 4
;
��4 5
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F H
,
��H I
ArraySubType
��J V
=
��W X

��Y f
.
��f g
I1
��g i
)
��i j
]
��j k
public
�� 
byte
�� 
[
�� 
]
�� 
byRes1
��  
;
��  !
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� &
NET_DVR_PACKAGE_LOCATION
�� .
{
�� 	
public
�� 
byte
�� 
byOffsetMode
�� $
;
��$ %
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F G
,
��G H
ArraySubType
��I U
=
��V W

��X e
.
��e f
I1
��f h
)
��h i
]
��i j
public
�� 
byte
�� 
[
�� 
]
�� 
byRes1
��  
;
��  !
public
�� 
uint
�� 
dwOffsetPos
�� #
;
��# $
public
�� #
NET_DVR_FRAMETYPECODE
�� (

��) 6
;
��6 7
public
�� 
byte
�� 
byMultiplierValue
�� )
;
��) *
public
�� 
byte
�� 

�� %
;
��% &
public
�� 
byte
�� 

byCodeMode
�� "
;
��" #
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F G
,
��G H
ArraySubType
��I U
=
��V W

��X e
.
��e f
I1
��f h
)
��h i
]
��i j
public
�� 
byte
�� 
[
�� 
]
�� 
byRes2
��  
;
��  !
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� $
NET_DVR_PACKAGE_LENGTH
�� ,
{
�� 	
public
�� 
byte
�� 
byLengthMode
�� $
;
��$ %
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F G
,
��G H
ArraySubType
��I U
=
��V W

��X e
.
��e f
I1
��f h
)
��h i
]
��i j
public
�� 
byte
�� 
[
�� 
]
�� 
byRes1
��  
;
��  !
public
�� 
uint
�� 
dwFixLength
�� #
;
��# $
public
�� 
uint
�� 
dwMaxLength
�� #
;
��# $
public
�� 
uint
�� 
dwMinLength
�� #
;
��# $
public
�� 
byte
�� 
	byEndMode
�� !
;
��! "
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F G
,
��G H
ArraySubType
��I U
=
��V W

��X e
.
��e f
I1
��f h
)
��h i
]
��i j
public
�� 
byte
�� 
[
�� 
]
�� 
byRes2
��  
;
��  !
public
�� #
NET_DVR_FRAMETYPECODE
�� (
struEndCode
��) 4
;
��4 5
public
�� 
uint
�� 
dwLengthPos
�� #
;
��# $
public
�� 
uint
�� 
dwLengthLen
�� #
;
��# $
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F G
,
��G H
ArraySubType
��I U
=
��V W

��X e
.
��e f
I1
��f h
)
��h i
]
��i j
public
�� 
byte
�� 
[
�� 
]
�� 
byRes3
��  
;
��  !
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� "
NET_DVR_OSD_POSITION
�� *
{
�� 	
public
�� 
byte
�� 
byPositionMode
�� &
;
��& '
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F G
,
��G H
ArraySubType
��I U
=
��V W

��X e
.
��e f
I1
��f h
)
��h i
]
��i j
public
�� 
byte
�� 
[
�� 
]
�� 
byRes1
��  
;
��  !
public
�� 
uint
�� 
dwPos_x
�� 
;
��  
public
�� 
uint
�� 
dwPos_y
�� 
;
��  
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F G
,
��G H
ArraySubType
��I U
=
��V W

��X e
.
��e f
I1
��f h
)
��h i
]
��i j
public
�� 
byte
�� 
[
�� 
]
�� 
byRes2
��  
;
��  !
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
,
��4 5
CharSet
��6 =
=
��> ?
CharSet
��@ G
.
��G H
Ansi
��H L
)
��L M
]
��M N
public
�� 
struct
�� !
NET_DVR_DATE_FORMAT
�� )
{
�� 	
public
�� 
byte
�� 
byItem1
�� 
;
��  
public
�� 
byte
�� 
byItem2
�� 
;
��  
public
�� 
byte
�� 
byItem3
�� 
;
��  
public
�� 
byte
�� 

byDateForm
�� "
;
��" #
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F H
,
��H I
ArraySubType
��J V
=
��W X

��Y f
.
��f g
I1
��g i
)
��i j
]
��j k
public
�� 
byte
�� 
[
�� 
]
�� 
byRes
�� 
;
��  
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .
	ByValTStr
��. 7
,
��7 8
	SizeConst
��9 B
=
��C D
$num
��E F
)
��F G
]
��G H
public
�� 
string
�� 

chSeprator
�� $
;
��$ %
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .
	ByValTStr
��. 7
,
��7 8
	SizeConst
��9 B
=
��C D
$num
��E F
)
��F G
]
��G H
public
�� 
string
�� 
chDisplaySeprator
�� +
;
��+ ,
public
�� 
byte
�� 

�� %
;
��% &
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F H
,
��H I
ArraySubType
��J V
=
��W X

��Y f
.
��f g
I1
��g i
)
��i j
]
��j k
public
�� 
byte
�� 
[
�� 
]
�� 
res
�� 
;
�� 
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
,
��4 5
CharSet
��6 =
=
��> ?
CharSet
��@ G
.
��G H
Ansi
��H L
)
��L M
]
��M N
public
�� 
struct
�� "
NET_DVRT_TIME_FORMAT
�� *
{
�� 	
public
�� 
byte
�� 

byTimeForm
�� "
;
��" #
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F H
,
��H I
ArraySubType
��J V
=
��W X

��Y f
.
��f g
I1
��g i
)
��i j
]
��j k
public
�� 
byte
�� 
[
�� 
]
�� 
byRes1
��  
;
��  !
public
�� 
byte
�� 

byHourMode
�� "
;
��" #
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F G
,
��G H
ArraySubType
��I U
=
��V W

��X e
.
��e f
I1
��f h
)
��h i
]
��i j
public
�� 
byte
�� 
[
�� 
]
�� 
byRes2
��  
;
��  !
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .
	ByValTStr
��. 7
,
��7 8
	SizeConst
��9 B
=
��C D
$num
��E F
)
��F G
]
��G H
public
�� 
string
�� 

chSeprator
�� $
;
��$ %
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .
	ByValTStr
��. 7
,
��7 8
	SizeConst
��9 B
=
��C D
$num
��E F
)
��F G
]
��G H
public
�� 
string
�� 
chDisplaySeprator
�� +
;
��+ ,
public
�� 
byte
�� 

�� %
;
��% &
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F G
,
��G H
ArraySubType
��I U
=
��V W

��X e
.
��e f
I1
��f h
)
��h i
]
��i j
public
�� 
byte
�� 
[
�� 
]
�� 
byRes3
��  
;
��  !
public
�� 
byte
�� 
byDisplayHourMode
�� )
;
��) *
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F H
,
��H I
ArraySubType
��J V
=
��W X

��Y f
.
��f g
I1
��g i
)
��i j
]
��j k
public
�� 
byte
�� 
[
�� 
]
�� 
byRes4
��  
;
��  !
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� %
NET_DVR_OVERLAY_CHANNEL
�� -
{
�� 	
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F H
,
��H I
ArraySubType
��J V
=
��W X

��Y f
.
��f g
I1
��g i
)
��i j
]
��j k
public
�� 
byte
�� 
[
�� 
]
�� 
	byChannel
�� #
;
��# $
public
�� 
uint
�� 
dwDelayTime
�� #
;
��# $
public
�� 
byte
�� 
byEnableDelayTime
�� )
;
��) *
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F H
,
��H I
ArraySubType
��J V
=
��W X

��Y f
.
��f g
I1
��g i
)
��i j
]
��j k
public
�� 
byte
�� 
[
�� 
]
�� 
byRes
�� 
;
��  
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� (
NET_DVR_ATM_PACKAGE_ACTION
�� 0
{
�� 	
public
�� &
NET_DVR_PACKAGE_LOCATION
�� +!
struPackageLocation
��, ?
;
��? @
public
�� "
NET_DVR_OSD_POSITION
�� '
struOsdPosition
��( 7
;
��7 8
public
�� #
NET_DVR_FRAMETYPECODE
�� (
struActionCode
��) 7
;
��7 8
public
�� #
NET_DVR_FRAMETYPECODE
�� (
struPreCode
��) 4
;
��4 5
public
�� 
byte
�� 
byActionCodeMode
�� (
;
��( )
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F G
,
��G H
ArraySubType
��I U
=
��V W

��X e
.
��e f
I1
��f h
)
��h i
]
��i j
public
�� 
byte
�� 
[
�� 
]
�� 
byRes
�� 
;
��  
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� &
NET_DVR_ATM_PACKAGE_DATE
�� .
{
�� 	
public
�� &
NET_DVR_PACKAGE_LOCATION
�� +!
struPackageLocation
��, ?
;
��? @
public
�� !
NET_DVR_DATE_FORMAT
�� &
struDateForm
��' 3
;
��3 4
public
�� "
NET_DVR_OSD_POSITION
�� '
struOsdPosition
��( 7
;
��7 8
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F G
,
��G H
ArraySubType
��I U
=
��V W

��X e
.
��e f
I1
��f h
)
��h i
]
��i j
public
�� 
byte
�� 
[
�� 
]
�� 
res
�� 
;
�� 
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� &
NET_DVR_ATM_PACKAGE_TIME
�� .
{
�� 	
public
�� &
NET_DVR_PACKAGE_LOCATION
�� +
location
��, 4
;
��4 5
public
�� "
NET_DVRT_TIME_FORMAT
�� '
struTimeForm
��( 4
;
��4 5
public
�� "
NET_DVR_OSD_POSITION
�� '
struOsdPosition
��( 7
;
��7 8
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F G
,
��G H
ArraySubType
��I U
=
��V W

��X e
.
��e f
I1
��f h
)
��h i
]
��i j
public
�� 
byte
�� 
[
�� 
]
�� 
byRes
�� 
;
��  
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� (
NET_DVR_ATM_PACKAGE_OTHERS
�� 0
{
�� 	
public
�� &
NET_DVR_PACKAGE_LOCATION
�� +!
struPackageLocation
��, ?
;
��? @
public
�� $
NET_DVR_PACKAGE_LENGTH
�� )
struPackageLength
��* ;
;
��; <
public
�� "
NET_DVR_OSD_POSITION
�� '
struOsdPosition
��( 7
;
��7 8
public
�� #
NET_DVR_FRAMETYPECODE
�� (
struPreCode
��) 4
;
��4 5
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F G
,
��G H
ArraySubType
��I U
=
��V W

��X e
.
��e f
I1
��f h
)
��h i
]
��i j
public
�� 
byte
�� 
[
�� 
]
�� 
res
�� 
;
�� 
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� .
 NET_DVR_ATM_USER_DEFINE_PROTOCOL
�� 6
{
�� 	
public
�� !
NET_DVR_IDENTIFICAT
�� & 
struIdentification
��' 9
;
��9 :
public
�� 
NET_DVR_FILTER
�� !

struFilter
��" ,
;
��, -
public
�� (
NET_DVR_ATM_PACKAGE_OTHERS
�� -
struCardNoPara
��. <
;
��< =
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
MAX_ACTION_TYPE
��F U
,
��U V
ArraySubType
��W c
=
��d e

��f s
.
��s t
Struct
��t z
)
��z {
]
��{ |
public
�� (
NET_DVR_ATM_PACKAGE_ACTION
�� -
[
��- .
]
��. /!
struTradeActionPara
��0 C
;
��C D
public
�� (
NET_DVR_ATM_PACKAGE_OTHERS
�� -
struAmountPara
��. <
;
��< =
public
�� (
NET_DVR_ATM_PACKAGE_OTHERS
�� -
struSerialNoPara
��. >
;
��> ?
public
�� %
NET_DVR_OVERLAY_CHANNEL
�� *
struOverlayChan
��+ :
;
��: ;
public
�� &
NET_DVR_ATM_PACKAGE_DATE
�� +
struRes1
��, 4
;
��4 5
public
�� &
NET_DVR_ATM_PACKAGE_TIME
�� +
struRes2
��, 4
;
��4 5
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F I
,
��I J
ArraySubType
��K W
=
��X Y

��Z g
.
��g h
I1
��h j
)
��j k
]
��k l
public
�� 
byte
�� 
[
�� 
]
�� 
byRes3
��  
;
��  !
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� )
NET_DVR_ATM_FRAMEFORMAT_V30
�� 1
{
�� 	
public
�� 
uint
�� 
dwSize
�� 
;
�� 
public
�� 
byte
�� 
byEnable
��  
;
��  !
public
�� 
byte
�� 
byInputMode
�� #
;
��# $
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F H
,
��H I
ArraySubType
��J V
=
��W X

��Y f
.
��f g
I1
��g i
)
��i j
]
��j k
public
�� 
byte
�� 
[
�� 
]
�� 
byRes1
��  
;
��  !
public
�� 
NET_DVR_IPADDR
�� !
	struAtmIp
��" +
;
��+ ,
public
�� 
ushort
�� 
wAtmPort
�� "
;
��" #
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F G
,
��G H
ArraySubType
��I U
=
��V W

��X e
.
��e f
I1
��f h
)
��h i
]
��i j
public
�� 
byte
�� 
[
�� 
]
�� 
byRes2
��  
;
��  !
public
�� 
uint
�� 
	dwAtmType
�� !
;
��! "
public
�� .
 NET_DVR_ATM_USER_DEFINE_PROTOCOL
�� 3'
struAtmUserDefineProtocol
��4 M
;
��M N
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .

ByValArray
��. 8
,
��8 9
	SizeConst
��: C
=
��D E
$num
��F G
,
��G H
ArraySubType
��I U
=
��V W

��X e
.
��e f
I1
��f h
)
��h i
]
��i j
public
�� 
byte
�� 
[
�� 
]
�� 
byRes3
��  
;
��  !
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
)
��4 5
]
��5 6
public
�� 
struct
�� $
NET_DVR_ATM_PROTO_TYPE
�� ,
{
�� 	
public
�� 
uint
�� 
	dwAtmType
�� !
;
��! "
[
�� 
MarshalAsAttribute
��
(
��  

��  -
.
��- .
	ByValTStr
��. 7
,
��7 8
	SizeConst
��9 B
=
��C D
ATM_DESC_LEN
��E Q
)
��Q R
]
��R S
public
�� 
string
�� 
chDesc
��  
;
��  !
}
�� 	
[
�� 	#
StructLayoutAttribute
��	 
(
�� 

LayoutKind
�� )
.
��) *

Sequential
��* 4
,
��4 5
CharSet
��6 =
=
��> ?
CharSet
��@ G
.
��G H
Ansi
��H L
)
��L M
]
��M N
public
�� 
struct
�� $
NET_DVR_ATM_PROTO_LIST
�� ,
{
� �  	
public
� �  
uint
� �  

� �  %
;
� � % &
[
� �  
MarshalAsAttribute
� � 
(
� �   

� �   -
.
� � - .

ByValArray
� � . 8
,
� � 8 9
	SizeConst
� � : C
=
� � D E"
MAX_ATM_PROTOCOL_NUM
� � F Z
,
� � Z [
ArraySubType
� � \ h
=
� � i j

� � k x
.
� � x y
Struct
� � y 
)� �  �
]� � � �
public
� �  $
NET_DVR_ATM_PROTO_TYPE
� �  )
[
� � ) *
]
� � * +
struAtmProtoType
� � , <
;
� � < =
}
� �  	
[
� �  	#
StructLayoutAttribute
� � 	 
(
� �  

LayoutKind
� �  )
.
� � ) *

Sequential
� � * 4
)
� � 4 5
]
� � 5 6
public
� �  
struct
� �  "
NET_DVR_ATM_PROTOCOL
� �  *
{
� �  	
public
� �  
uint
� �  
dwSize
� �  
;
� �  
public
� �  $
NET_DVR_ATM_PROTO_LIST
� �  )
struNetListenList
� � * ;
;
� � ; <
public
� �  $
NET_DVR_ATM_PROTO_LIST
� �  )"
struSerialListenList
� � * >
;
� � > ?
public
� �  $
NET_DVR_ATM_PROTO_LIST
� �  )
struNetProtoList
� � * :
;
� � : ;
public
� �  $
NET_DVR_ATM_PROTO_LIST
� �  )!
struSerialProtoList
� � * =
;
� � = >
public
� �  $
NET_DVR_ATM_PROTO_TYPE
� �  )
struCustomProto
� � * 9
;
� � 9 :
}
� �  	
[
� �  	#
StructLayoutAttribute
� � 	 
(
� �  

LayoutKind
� �  )
.
� � ) *

Sequential
� � * 4
)
� � 4 5
]
� � 5 6
public
� �  
struct
� �  !
NET_DVR_DECODERINFO
� �  )
{
� �  	
[
� �  
MarshalAsAttribute
� � 
(
� �   

� �   -
.
� � - .

ByValArray
� � . 8
,
� � 8 9
	SizeConst
� � : C
=
� � D E
$num
� � F H
,
� � H I
ArraySubType
� � J V
=
� � W X

� � Y f
.
� � f g
I1
� � g i
)
� � i j
]
� � j k
public
� �  
byte
� �  
[
� �  
]
� �  
byEncoderIP
� �  %
;
� � % &
[
� �  
MarshalAsAttribute
� � 
(
� �   

� �   -
.
� � - .

ByValArray
� � . 8
,
� � 8 9
	SizeConst
� � : C
=
� � D E
$num
� � F H
,
� � H I
ArraySubType
� � J V
=
� � W X

� � Y f
.
� � f g
I1
� � g i
)
� � i j
]
� � j k
public
� �  
byte
� �  
[
� �  
]
� �  

� �  '
;
� � ' (
[
� �  
MarshalAsAttribute
� � 
(
� �   

� �   -
.
� � - .

ByValArray
� � . 8
,
� � 8 9
	SizeConst
� � : C
=
� � D E
$num
� � F H
,
� � H I
ArraySubType
� � J V
=
� � W X

� � Y f
.
� � f g
I1
� � g i
)
� � i j
]
� � j k
public
� �  
byte
� �  
[
� �  
]
� �  
byEncoderPasswd
� �  )
;
� � ) *
public
� �  
byte
� �  

bySendMode
� �  "
;
� � " #
public
� �  
byte
� �  
byEncoderChannel
� �  (
;
� � ( )
public
� �  
ushort
� �  
wEncoderPort
� �  &
;
� � & '
[
� �  
MarshalAsAttribute
� � 
(
� �   

� �   -
.
� � - .

ByValArray
� � . 8
,
� � 8 9
	SizeConst
� � : C
=
� � D E
$num
� � F G
,
� � G H
ArraySubType
� � I U
=
� � V W

� � X e
.
� � e f
I1
� � f h
)
� � h i
]
� � i j
public
� �  
byte
� �  
[
� �  
]
� �  
reservedData
� �  &
;
� � & '
}
� �  	
[
� �  	#
StructLayoutAttribute
� � 	 
(
� �  

LayoutKind
� �  )
.
� � ) *

Sequential
� � * 4
)
� � 4 5
]
� � 5 6
public
� �  
struct
� �  "
NET_DVR_DECODERSTATE
� �  *
{
� �  	
[
� �  
MarshalAsAttribute
� � 
(
� �   

� �   -
.
� � - .

ByValArray
� � . 8
,
� � 8 9
	SizeConst
� � : C
=
� � D E
$num
� � F H
,
� � H I
ArraySubType
� � J V
=
� � W X

� � Y f
.
� � f g
I1
� � g i
)
� � i j
]
� � j k
public
� �  
byte
� �  
[
� �  
]
� �  
byEncoderIP
� �  %
;
� � % &
[
� �  
MarshalAsAttribute
� � 
(
� �   

� �   -
.
� � - .

ByValArray
� � . 8
,
� � 8 9
	SizeConst
� � : C
=
� � D E
$num
� � F H
,
� � H I
ArraySubType
� � J V
=
� � W X

� � Y f
.
� � f g
I1
� � g i
)
� � i j
]
� � j k
public
� �  
byte
� �  
[
� �  
]
� �  

� �  '
;
� � ' (
[
� �  
MarshalAsAttribute
� � 
(
� �   

� �   -
.
� � - .

ByValArray
� � . 8
,
� � 8 9
	SizeConst
� � : C
=
� � D E
$num
� � F H
,
� � H I
ArraySubType
� � J V
=
� � W X

� � Y f
.
� � f g
I1
� � g i
)
� � i j
]
� � j k
public
� �  
byte
� �  
[
� �  
]
� �  
byEncoderPasswd
� �  )
;
� � ) *
public
� �  
byte
� �  
byEncoderChannel
� �  (
;
� � ( )
public
� �  
byte
� �  

bySendMode
� �  "
;
� � " #
public
� �  
ushort
� �  
wEncoderPort
� �  &
;
� � & '
public
� �  
uint
� �  
dwConnectState
� �  &
;
� � & '
[
� �  
MarshalAsAttribute
� � 
(
� �   

� �   -
.
� � - .

ByValArray
� � . 8
,
� � 8 9
	SizeConst
� � : C
=
� � D E
$num
� � F G
,
� � G H
ArraySubType
� � I U
=
� � V W

� � X e
.
� � e f
I1
� � f h
)
� � h i
]
� � i j
public
� �  
byte
� �  
[
� �  
]
� �  
reservedData
� �  &
;
� � & '
}
� �  	
public
� �  
const
� �  
int
� �  
NET_DEC_STARTDEC
� �  )
=
� � * +
$num
� � , -
;
� � - .
public
� �  
const
� �  
int
� �  
NET_DEC_STOPDEC
� �  (
=
� � ) *
$num
� � + ,
;
� � , -
public
� �  
const
� �  
int
� �  
NET_DEC_STOPCYCLE
� �  *
=
� � + ,
$num
� � - .
;
� � . /
public
� �  
const
� �  
int
� �  #
NET_DEC_CONTINUECYCLE
� �  .
=
� � / 0
$num
� � 1 2
;
� � 2 3
[
� �  	#
StructLayoutAttribute
� � 	 
(
� �  

LayoutKind
� �  )
.
� � ) *

Sequential
� � * 4
,
� � 4 5
CharSet
� � 6 =
=
� � > ?
CharSet
� � @ G
.
� � G H
Ansi
� � H L
)
� � L M
]
� � M N
public
� �  
struct
� �  !
NET_DVR_DECCHANINFO
� �  )
{
� �  	
[
� �  
MarshalAsAttribute
� � 
(
� �   

� �   -
.
� � - .
	ByValTStr
� � . 7
,
� � 7 8
	SizeConst
� � 9 B
=
� � C D
$num
� � E G
)
� � G H
]
� � H I
public
� �  
string
� �  
sDVRIP
� �   
;
� �   !
public
� �  
ushort
� �  
wDVRPort
� �  "
;
� � " #
[
� �  
MarshalAsAttribute
� � 
(
� �   

� �   -
.
� � - .

ByValArray
� � . 8
,
� � 8 9
	SizeConst
� � : C
=
� � D E
NAME_LEN
� � F N
,
� � N O
ArraySubType
� � P \
=
� � ] ^

� � _ l
.
� � l m
I1
� � m o
)
� � o p
]
� � p q
public
� �  
byte
� �  
[
� �  
]
� �  
	sUserName
� �  #
;
� � # $
[
� �  
MarshalAsAttribute
� � 
(
� �   

� �   -
.
� � - .

ByValArray
� � . 8
,
� � 8 9
	SizeConst
� � : C
=
� � D E

PASSWD_LEN
� � F P
,
� � P Q
ArraySubType
� � R ^
=
� � _ `

� � a n
.
� � n o
I1
� � o q
)
� � q r
]
� � r s
public
� �  
byte
� �  
[
� �  
]
� �  
	sPassword
� �  #
;
� � # $
public
� �  
byte
� �  
	byChannel
� �  !
;
� � ! "
public
� �  
byte
� �  

byLinkMode
� �  "
;
� � " #
public
� �  
byte
� �  

byLinkType
� �  "
;
� � " #
}
� �  	
[
� �  	#
StructLayoutAttribute
� � 	 
(
� �  

LayoutKind
� �  )
.
� � ) *

Sequential
� � * 4
)
� � 4 5
]
� � 5 6
public
� �  
struct
� �  
NET_DVR_DECINFO
� �  %
{
� �  	
public
� �  
byte
� �  
byPoolChans
� �  #
;
� � # $
[
� �  
MarshalAsAttribute
� � 
(
� �   

� �   -
.
� � - .

ByValArray
� � . 8
,
� � 8 9
	SizeConst
� � : C
=
� � D E
MAX_DECPOOLNUM
� � F T
,
� � T U
ArraySubType
� � V b
=
� � c d

� � e r
.
� � r s
Struct
� � s y
)
� � y z
]
� � z {
public
� �  !
NET_DVR_DECCHANINFO
� �  &
[
� � & '
]
� � ' (
struchanConInfo
� � ) 8
;
� � 8 9
public
� �  
byte
� �  
byEnablePoll
� �  $
;
� � $ %
public
� �  
byte
� �  

byPoolTime
� �  "
;
� � " #
}
� �  	
[
� �  	#
StructLayoutAttribute
� � 	 
(
� �  

LayoutKind
� �  )
.
� � ) *

Sequential
� � * 4
)
� � 4 5
]
� � 5 6
public
� �  
struct
� �  
NET_DVR_DECCFG
� �  $
{
� �  	
public
� �  
uint
� �  
dwSize
� �  
;
� �  
public
� �  
uint
� �  
dwDecChanNum
� �  $
;
� � $ %
[
� �  
MarshalAsAttribute
� � 
(
� �   

� �   -
.
� � - .

ByValArray
� � . 8
,
� � 8 9
	SizeConst
� � : C
=
� � D E

MAX_DECNUM
� � F P
,
� � P Q
ArraySubType
� � R ^
=
� � _ `

� � a n
.
� � n o
Struct
� � o u
)
� � u v
]
� � v w
public
� �  
NET_DVR_DECINFO
� �  "
[
� � " #
]
� � # $
struDecInfo
� � % 0
;
� � 0 1
}
� �  	
[
� �  	#
StructLayoutAttribute
� � 	 
(
� �  

LayoutKind
� �  )
.
� � ) *

Sequential
� � * 4
,
� � 4 5
CharSet
� � 6 =
=
� � > ?
CharSet
� � @ G
.
� � G H
Ansi
� � H L
)
� � L M
]
� � M N
public
� �  
struct
� �  
NET_DVR_PORTINFO
� �  &
{
� �  	
public
� �  
uint
� �  
dwEnableTransPort
� �  )
;
� � ) *
[
� �  
MarshalAsAttribute
� � 
(
� �   

� �   -
.
� � - .
	ByValTStr
� � . 7
,
� � 7 8
	SizeConst
� � 9 B
=
� � C D
$num
� � E G
)
� � G H
]
� � H I
public
� �  
string
� �  

sDecoderIP
� �  $
;
� � $ %
public
� �  
ushort
� �  
wDecoderPort
� �  &
;
� � & '
public
� �  
ushort
� �  

� �  '
;
� � ' (
[
� �  
MarshalAsAttribute
� � 
(
� �   

� �   -
.
� � - .
	ByValTStr
� � . 7
,
� � 7 8
	SizeConst
� � 9 B
=
� � C D
$num
� � E F
)
� � F G
]
� � G H
public
� �  
string
� �  
cReserve
� �  "
;
� � " #
}
� �  	
[
� �  	#
StructLayoutAttribute
� � 	 
(
� �  

LayoutKind
� �  )
.
� � ) *

Sequential
� � * 4
)
� � 4 5
]
� � 5 6
public
� �  
struct
� �  
NET_DVR_PORTCFG
� �  %
{
� �  	
public
� �  
uint
� �  
dwSize
� �  
;
� �  
[
� �  
MarshalAsAttribute
� � 
(
� �   

� �   -
.
� � - .

ByValArray
� � . 8
,
� � 8 9
	SizeConst
� � : C
=
� � D E 
MAX_TRANSPARENTNUM
� � F X
,
� � X Y
ArraySubType
� � Z f
=
� � g h

� � i v
.
� � v w
Struct
� � w }
)
� � } ~
]
� � ~ 
public
� �  
NET_DVR_PORTINFO
� �  #
[
� � # $
]
� � $ %
struTransPortInfo
� � & 7
;
� � 7 8
}
� �  	
[
� �  	#
StructLayoutAttribute
� � 	 
(
� �  

LayoutKind
� �  )
.
� � ) *

Sequential
� � * 4
)
� � 4 5
]
� � 5 6
public
� �  
struct
� �  
bytime
� �  
{
� �  	
public
� �  
uint
� �  
	dwChannel
� �  !
;
� � ! "
[
� �  
MarshalAsAttribute
� � 
(
� �   

� �   -
.
� � - .

ByValArray
� � . 8
,
� � 8 9
	SizeConst
� � : C
=
� � D E
$num
� � F H
,
� � H I
ArraySubType
� � J V
=
� � W X

� � Y f
.
� � f g
I1
� � g i
)
� � i j
]
� � j k
public
� �  
byte
� �  
[
� �  
]
� �  
	sUserName
� �  #
;
� � # $
[
� �  
MarshalAsAttribute
� � 
(
� �   

� �   -
.
� � - .

ByValArray
� � . 8
,
� � 8 9
	SizeConst
� � : C
=
� � D E
$num
� � F H
,
� � H I
ArraySubType
� � J V
=
� � W X

� � Y f
.
� � f g
I1
� � g i
)
� � i j
]
� � j k
public
� �  
byte
� �  
[
� �  
]
� �  
	sPassword
� �  #
;
� � # $
public
� �  
NET_DVR_TIME
� �  

� �   -
;
� � - .
public
� �  
NET_DVR_TIME
� �  
struStopTime
� �   ,
;
� � , -
}
� �  	
[
�!�! 	#
StructLayoutAttribute
�!�!	 
(
�!�! 

LayoutKind
�!�! )
.
�!�!) *

Sequential
�!�!* 4
,
�!�!4 5
CharSet
�!�!6 =
=
�!�!> ?
CharSet
�!�!@ G
.
�!�!G H
Ansi
�!�!H L
)
�!�!L M
]
�!�!M N
public
�!�! 
struct
�!�! $
NET_DVR_PLAYREMOTEFILE
�!�! ,
{
�!�! 	
public
�!�! 
uint
�!�! 
dwSize
�!�! 
;
�!�! 
[
�!�! 
MarshalAsAttribute
�!�!
(
�!�!  

�!�!  -
.
�!�!- .
	ByValTStr
�!�!. 7
,
�!�!7 8
	SizeConst
�!�!9 B
=
�!�!C D
$num
�!�!E G
)
�!�!G H
]
�!�!H I
public
�!�! 
string
�!�! 

sDecoderIP
�!�! $
;
�!�!$ %
public
�!�! 
ushort
�!�! 
wDecoderPort
�!�! &
;
�!�!& '
public
�!�! 
ushort
�!�! 
	wLoadMode
�!�! #
;
�!�!# $
[
�!�! 
StructLayoutAttribute
�!�!
(
�!�!" #

LayoutKind
�!�!# -
.
�!�!- .
Explicit
�!�!. 6
)
�!�!6 7
]
�!�!7 8
public
�!�! 
struct
�!�! 
	mode_size
�!�! #
{
�!�! 
[
�!�! "
FieldOffsetAttribute
�!�! %
(
�!�!% &
$num
�!�!& '
)
�!�!' (
]
�!�!( )
[
�!�!  
MarshalAsAttribute
�!�! #
(
�!�!# $

�!�!$ 1
.
�!�!1 2

ByValArray
�!�!2 <
,
�!�!< =
	SizeConst
�!�!> G
=
�!�!H I
$num
�!�!J M
,
�!�!M N
ArraySubType
�!�!O [
=
�!�!\ ]

�!�!^ k
.
�!�!k l
I1
�!�!l n
)
�!�!n o
]
�!�!o p
public
�!�! 
byte
�!�! 
[
�!�! 
]
�!�! 
byFile
�!�! $
;
�!�!$ %
[
�!�! "
FieldOffsetAttribute
�!�! %
(
�!�!% &
$num
�!�!& '
)
�!�!' (
]
�!�!( )
public
�!�! 
bytime
�!�! 
bytime
�!�! $
;
�!�!$ %
}
�!�! 
}
�!�! 	
[
�!�! 	#
StructLayoutAttribute
�!�!	 
(
�!�! 

LayoutKind
�!�! )
.
�!�!) *

Sequential
�!�!* 4
,
�!�!4 5
CharSet
�!�!6 =
=
�!�!> ?
CharSet
�!�!@ G
.
�!�!G H
Ansi
�!�!H L
)
�!�!L M
]
�!�!M N
public
�!�! 
struct
�!�! #
NET_DVR_DECCHANSTATUS
�!�! +
{
�!�! 	
public
�!�! 
uint
�!�! 

dwWorkType
�!�! "
;
�!�!" #
[
�!�! 
MarshalAsAttribute
�!�!
(
�!�!  

�!�!  -
.
�!�!- .
	ByValTStr
�!�!. 7
,
�!�!7 8
	SizeConst
�!�!9 B
=
�!�!C D
$num
�!�!E G
)
�!�!G H
]
�!�!H I
public
�!�! 
string
�!�! 
sDVRIP
�!�!  
;
�!�!  !
public
�!�! 
ushort
�!�! 
wDVRPort
�!�! "
;
�!�!" #
public
�!�! 
byte
�!�! 
	byChannel
�!�! !
;
�!�!! "
public
�!�! 
byte
�!�! 

byLinkMode
�!�! "
;
�!�!" #
public
�!�! 
uint
�!�! 

dwLinkType
�!�! "
;
�!�!" #
[
�!�! 
StructLayoutAttribute
�!�!
(
�!�!" #

LayoutKind
�!�!# -
.
�!�!- .
Explicit
�!�!. 6
)
�!�!6 7
]
�!�!7 8
public
�!�! 
struct
�!�! 

objectInfo
�!�! $
{
�!�! 
[
�!�! #
StructLayoutAttribute
�!�! &
(
�!�!& '

LayoutKind
�!�!' 1
.
�!�!1 2

Sequential
�!�!2 <
)
�!�!< =
]
�!�!= >
public
�!�! 
struct
�!�! 
userInfo
�!�! &
{
�!�! 
[
�!�!  
MarshalAsAttribute
�!�! '
(
�!�!' (

�!�!( 5
.
�!�!5 6

ByValArray
�!�!6 @
,
�!�!@ A
	SizeConst
�!�!B K
=
�!�!L M
$num
�!�!N P
,
�!�!P Q
ArraySubType
�!�!R ^
=
�!�!_ `

�!�!a n
.
�!�!n o
I1
�!�!o q
)
�!�!q r
]
�!�!r s
public
�!�! 
byte
�!�! 
[
�!�!  
]
�!�!  !
	sUserName
�!�!" +
;
�!�!+ ,
[
�!�!  
MarshalAsAttribute
�!�! '
(
�!�!' (

�!�!( 5
.
�!�!5 6

ByValArray
�!�!6 @
,
�!�!@ A
	SizeConst
�!�!B K
=
�!�!L M
$num
�!�!N P
,
�!�!P Q
ArraySubType
�!�!R ^
=
�!�!_ `

�!�!a n
.
�!�!n o
I1
�!�!o q
)
�!�!q r
]
�!�!r s
public
�!�! 
byte
�!�! 
[
�!�!  
]
�!�!  !
	sPassword
�!�!" +
;
�!�!+ ,
[
�!�!  
MarshalAsAttribute
�!�! '
(
�!�!' (

�!�!( 5
.
�!�!5 6
	ByValTStr
�!�!6 ?
,
�!�!? @
	SizeConst
�!�!A J
=
�!�!K L
$num
�!�!M O
)
�!�!O P
]
�!�!P Q
public
�!�! 
string
�!�! !
cReserve
�!�!" *
;
�!�!* +
}
�!�! 
[
�!�! #
StructLayoutAttribute
�!�! &
(
�!�!& '

LayoutKind
�!�!' 1
.
�!�!1 2

Sequential
�!�!2 <
)
�!�!< =
]
�!�!= >
public
�!�! 
struct
�!�! 
fileInfo
�!�! &
{
�!�! 
[
�!�!  
MarshalAsAttribute
�!�! '
(
�!�!' (

�!�!( 5
.
�!�!5 6

ByValArray
�!�!6 @
,
�!�!@ A
	SizeConst
�!�!B K
=
�!�!L M
$num
�!�!N Q
,
�!�!Q R
ArraySubType
�!�!S _
=
�!�!` a

�!�!b o
.
�!�!o p
I1
�!�!p r
)
�!�!r s
]
�!�!s t
public
�!�! 
byte
�!�! 
[
�!�!  
]
�!�!  !
fileName
�!�!" *
;
�!�!* +
}
�!�! 
[
�!�! #
StructLayoutAttribute
�!�! &
(
�!�!& '

LayoutKind
�!�!' 1
.
�!�!1 2

Sequential
�!�!2 <
)
�!�!< =
]
�!�!= >
public
�!�! 
struct
�!�! 
timeInfo
�!�! &
{
�!�! 
public
�!�! 
uint
�!�! 
	dwChannel
�!�!  )
;
�!�!) *
[
�!�!  
MarshalAsAttribute
�!�! '
(
�!�!' (

�!�!( 5
.
�!�!5 6

ByValArray
�!�!6 @
,
�!�!@ A
	SizeConst
�!�!B K
=
�!�!L M
$num
�!�!N P
,
�!�!P Q
ArraySubType
�!�!R ^
=
�!�!_ `

�!�!a n
.
�!�!n o
I1
�!�!o q
)
�!�!q r
]
�!�!r s
public
�!�! 
byte
�!�! 
[
�!�!  
]
�!�!  !
	sUserName
�!�!" +
;
�!�!+ ,
[
�!�!  
MarshalAsAttribute
�!�! '
(
�!�!' (

�!�!( 5
.
�!�!5 6

ByValArray
�!�!6 @
,
�!�!@ A
	SizeConst
�!�!B K
=
�!�!L M
$num
�!�!N P
,
�!�!P Q
ArraySubType
�!�!R ^
=
�!�!_ `

�!�!a n
.
�!�!n o
I1
�!�!o q
)
�!�!q r
]
�!�!r s
public
�!�! 
byte
�!�! 
[
�!�!  
]
�!�!  !
	sPassword
�!�!" +
;
�!�!+ ,
public
�!�! 
NET_DVR_TIME
�!�! '

�!�!( 5
;
�!�!5 6
public
�!�! 
NET_DVR_TIME
�!�! '
struStopTime
�!�!( 4
;
�!�!4 5
}
�!�! 
}
�!�! 
}
�!�! 	
[
�!�! 	#
StructLayoutAttribute
�!�!	 
(
�!�! 

LayoutKind
�!�! )
.
�!�!) *

Sequential
�!�!* 4
)
�!�!4 5
]
�!�!5 6
public
�!�! 
struct
�!�! 
NET_DVR_DECSTATUS
�!�! '
{
�!�! 	
public
�!�! 
uint
�!�! 
dwSize
�!�! 
;
�!�! 
[
�!�! 
MarshalAsAttribute
�!�!
(
�!�!  

�!�!  -
.
�!�!- .

ByValArray
�!�!. 8
,
�!�!8 9
	SizeConst
�!�!: C
=
�!�!D E

MAX_DECNUM
�!�!F P
,
�!�!P Q
ArraySubType
�!�!R ^
=
�!�!_ `

�!�!a n
.
�!�!n o
Struct
�!�!o u
)
�!�!u v
]
�!�!v w
public
�!�! #
NET_DVR_DECCHANSTATUS
�!�! (
[
�!�!( )
]
�!�!) *
struTransPortInfo
�!�!+ <
;
�!�!< =
}
�!�! 	
[
�!�! 	#
StructLayoutAttribute
�!�!	 
(
�!�! 

LayoutKind
�!�! )
.
�!�!) *

Sequential
�!�!* 4
,
�!�!4 5
CharSet
�!�!6 =
=
�!�!> ?
CharSet
�!�!@ G
.
�!�!G H
Ansi
�!�!H L
)
�!�!L M
]
�!�!M N
public
�!�! 
struct
�!�! $
NET_DVR_SHOWSTRINGINFO
�!�! ,
{
�!�! 	
public
�!�! 
ushort
�!�! 
wShowString
�!�! %
;
�!�!% &
public
�!�! 
ushort
�!�! 
wStringSize
�!�! %
;
�!�!% &
public
�!�! 
ushort
�!�! !
wShowStringTopLeftX
�!�! -
;
�!�!- .
public
�!�! 
ushort
�!�! !
wShowStringTopLeftY
�!�! -
;
�!�!- .
[
�!�! 
MarshalAsAttribute
�!�!
(
�!�!  

�!�!  -
.
�!�!- .
	ByValTStr
�!�!. 7
,
�!�!7 8
	SizeConst
�!�!9 B
=
�!�!C D
$num
�!�!E G
)
�!�!G H
]
�!�!H I
public
�!�! 
string
�!�! 
sString
�!�! !
;
�!�!! "
}
�!�! 	
[
�!�! 	#
StructLayoutAttribute
�!�!	 
(
�!�! 

LayoutKind
�!�! )
.
�!�!) *

Sequential
�!�!* 4
)
�!�!4 5
]
�!�!5 6
public
�!�! 
struct
�!�! $
NET_DVR_SHOWSTRING_V30
�!�! ,
{
�!�! 	
public
�!�! 
uint
�!�! 
dwSize
�!�! 
;
�!�! 
[
�!�! 
MarshalAsAttribute
�!�!
(
�!�!  

�!�!  -
.
�!�!- .

ByValArray
�!�!. 8
,
�!�!8 9
	SizeConst
�!�!: C
=
�!�!D E
MAX_STRINGNUM_V30
�!�!F W
,
�!�!W X
ArraySubType
�!�!Y e
=
�!�!f g

�!�!h u
.
�!�!u v
Struct
�!�!v |
)
�!�!| }
]
�!�!} ~
public
�!�! $
NET_DVR_SHOWSTRINGINFO
�!�! )
[
�!�!) *
]
�!�!* +
struStringInfo
�!�!, :
;
�!�!: ;
}
�!�! 	
[
�!�! 	#
StructLayoutAttribute
�!�!	 
(
�!�! 

LayoutKind
�!�! )
.
�!�!) *

Sequential
�!�!* 4
)
�!�!4 5
]
�!�!5 6
public
�!�! 
struct
�!�! #
NET_DVR_SHOWSTRING_EX
�!�! +
{
�!�! 	
public
�!�! 
uint
�!�! 
dwSize
�!�! 
;
�!�! 
[
�!�! 
MarshalAsAttribute
�!�!
(
�!�!  

�!�!  -
.
�!�!- .

ByValArray
�!�!. 8
,
�!�!8 9
	SizeConst
�!�!: C
=
�!�!D E
MAX_STRINGNUM_EX
�!�!F V
,
�!�!V W
ArraySubType
�!�!X d
=
�!�!e f

�!�!g t
.
�!�!t u
Struct
�!�!u {
)
�!�!{ |
]
�!�!| }
public
�!�! $
NET_DVR_SHOWSTRINGINFO
�!�! )
[
�!�!) *
]
�!�!* +
struStringInfo
�!�!, :
;
�!�!: ;
}
�!�! 	
[
�!�! 	#
StructLayoutAttribute
�!�!	 
(
�!�! 

LayoutKind
�!�! )
.
�!�!) *

Sequential
�!�!* 4
)
�!�!4 5
]
�!�!5 6
public
�!�! 
struct
�!�!  
NET_DVR_SHOWSTRING
�!�! (
{
�!�! 	
public
�!�! 
uint
�!�! 
dwSize
�!�! 
;
�!�! 
[
�!�! 
MarshalAsAttribute
�!�!
(
�!�!  

�!�!  -
.
�!�!- .

ByValArray
�!�!. 8
,
�!�!8 9
	SizeConst
�!�!: C
=
�!�!D E

�!�!F S
,
�!�!S T
ArraySubType
�!�!U a
=
�!�!b c

�!�!d q
.
�!�!q r
Struct
�!�!r x
)
�!�!x y
]
�!�!y z
public
�!�! $
NET_DVR_SHOWSTRINGINFO
�!�! )
[
�!�!) *
]
�!�!* +
struStringInfo
�!�!, :
;
�!�!: ;
}
�!�! 	
[
�!�! 	#
StructLayoutAttribute
�!�!	 
(
�!�! 

LayoutKind
�!�! )
.
�!�!) *

Sequential
�!�!* 4
)
�!�!4 5
]
�!�!5 6
public
�!�! 
struct
�!�! 
struReceiver
�!�! "
{
�!�! 	
[
�!�! 
MarshalAsAttribute
�!�!
(
�!�!  

�!�!  -
.
�!�!- .

ByValArray
�!�!. 8
,
�!�!8 9
	SizeConst
�!�!: C
=
�!�!D E
NAME_LEN
�!�!F N
,
�!�!N O
ArraySubType
�!�!P \
=
�!�!] ^

�!�!_ l
.
�!�!l m
I1
�!�!m o
)
�!�!o p
]
�!�!p q
public
�!�! 
byte
�!�! 
[
�!�! 
]
�!�! 
sName
�!�! 
;
�!�!  
[
�!�! 
MarshalAsAttribute
�!�!
(
�!�!  

�!�!  -
.
�!�!- .

ByValArray
�!�!. 8
,
�!�!8 9
	SizeConst
�!�!: C
=
�!�!D E 
MAX_EMAIL_ADDR_LEN
�!�!F X
,
�!�!X Y
ArraySubType
�!�!Z f
=
�!�!g h

�!�!i v
.
�!�!v w
I1
�!�!w y
)
�!�!y z
]
�!�!z {
public
�"�" 
byte
�"�" 
[
�"�" 
]
�"�" 
sAddress
�"�" "
;
�"�"" #
}
�"�" 	
[
�"�" 	#
StructLayoutAttribute
�"�"	 
(
�"�" 

LayoutKind
�"�" )
.
�"�") *

Sequential
�"�"* 4
)
�"�"4 5
]
�"�"5 6
public
�"�" 
struct
�"�" "
NET_DVR_EMAILCFG_V30
�"�" *
{
�"�" 	
public
�"�" 
uint
�"�" 
dwSize
�"�" 
;
�"�" 
[
�"�" 
MarshalAsAttribute
�"�"
(
�"�"  

�"�"  -
.
�"�"- .

ByValArray
�"�". 8
,
�"�"8 9
	SizeConst
�"�": C
=
�"�"D E
NAME_LEN
�"�"F N
,
�"�"N O
ArraySubType
�"�"P \
=
�"�"] ^

�"�"_ l
.
�"�"l m
I1
�"�"m o
)
�"�"o p
]
�"�"p q
public
�"�" 
byte
�"�" 
[
�"�" 
]
�"�" 
sAccount
�"�" "
;
�"�"" #
[
�"�" 
MarshalAsAttribute
�"�"
(
�"�"  

�"�"  -
.
�"�"- .

ByValArray
�"�". 8
,
�"�"8 9
	SizeConst
�"�": C
=
�"�"D E
MAX_EMAIL_PWD_LEN
�"�"F W
,
�"�"W X
ArraySubType
�"�"Y e
=
�"�"f g

�"�"h u
.
�"�"u v
I1
�"�"v x
)
�"�"x y
]
�"�"y z
public
�"�" 
byte
�"�" 
[
�"�" 
]
�"�" 
	sPassword
�"�" #
;
�"�"# $
[
�"�" 
StructLayoutAttribute
�"�"
(
�"�"" #

LayoutKind
�"�"# -
.
�"�"- .

Sequential
�"�". 8
)
�"�"8 9
]
�"�"9 :
public
�"�" 
struct
�"�" 

struSender
�"�" $
{
�"�" 
[
�"�"  
MarshalAsAttribute
�"�" #
(
�"�"# $

�"�"$ 1
.
�"�"1 2

ByValArray
�"�"2 <
,
�"�"< =
	SizeConst
�"�"> G
=
�"�"H I
NAME_LEN
�"�"J R
,
�"�"R S
ArraySubType
�"�"T `
=
�"�"a b

�"�"c p
.
�"�"p q
I1
�"�"q s
)
�"�"s t
]
�"�"t u
public
�"�" 
byte
�"�" 
[
�"�" 
]
�"�" 
sName
�"�" #
;
�"�"# $
[
�"�"  
MarshalAsAttribute
�"�" #
(
�"�"# $

�"�"$ 1
.
�"�"1 2

ByValArray
�"�"2 <
,
�"�"< =
	SizeConst
�"�"> G
=
�"�"H I 
MAX_EMAIL_ADDR_LEN
�"�"J \
,
�"�"\ ]
ArraySubType
�"�"^ j
=
�"�"k l

�"�"m z
.
�"�"z {
I1
�"�"{ }
)
�"�"} ~
]
�"�"~ 
public
�"�" 
byte
�"�" 
[
�"�" 
]
�"�" 
sAddress
�"�" &
;
�"�"& '
}
�"�" 
[
�"�" 
MarshalAsAttribute
�"�"
(
�"�"  

�"�"  -
.
�"�"- .

ByValArray
�"�". 8
,
�"�"8 9
	SizeConst
�"�": C
=
�"�"D E 
MAX_EMAIL_ADDR_LEN
�"�"F X
,
�"�"X Y
ArraySubType
�"�"Z f
=
�"�"g h

�"�"i v
.
�"�"v w
I1
�"�"w y
)
�"�"y z
]
�"�"z {
public
�"�" 
byte
�"�" 
[
�"�" 
]
�"�" 
sSmtpServer
�"�" %
;
�"�"% &
[
�"�" 
MarshalAsAttribute
�"�"
(
�"�"  

�"�"  -
.
�"�"- .

ByValArray
�"�". 8
,
�"�"8 9
	SizeConst
�"�": C
=
�"�"D E 
MAX_EMAIL_ADDR_LEN
�"�"F X
,
�"�"X Y
ArraySubType
�"�"Z f
=
�"�"g h

�"�"i v
.
�"�"v w
I1
�"�"w y
)
�"�"y z
]
�"�"z {
public
�"�" 
byte
�"�" 
[
�"�" 
]
�"�" 
sPop3Server
�"�" %
;
�"�"% &
[
�"�" 
MarshalAsAttribute
�"�"
(
�"�"  

�"�"  -
.
�"�"- .

ByValArray
�"�". 8
,
�"�"8 9
	SizeConst
�"�": C
=
�"�"D E
$num
�"�"F G
,
�"�"G H
ArraySubType
�"�"I U
=
�"�"V W

�"�"X e
.
�"�"e f
Struct
�"�"f l
)
�"�"l m
]
�"�"m n
public
�"�" 
struReceiver
�"�" 
[
�"�"  
]
�"�"  !
struStringInfo
�"�"" 0
;
�"�"0 1
public
�"�" 
byte
�"�" 
byAttachment
�"�" $
;
�"�"$ %
public
�"�" 
byte
�"�"  
bySmtpServerVerify
�"�" *
;
�"�"* +
public
�"�" 
byte
�"�" 
byMailInterval
�"�" &
;
�"�"& '
public
�"�" 
byte
�"�" 
byEnableSSL
�"�" #
;
�"�"# $
public
�"�" 
ushort
�"�" 
	wSmtpPort
�"�" #
;
�"�"# $
[
�"�" 
MarshalAsAttribute
�"�"
(
�"�"  

�"�"  -
.
�"�"- .

ByValArray
�"�". 8
,
�"�"8 9
	SizeConst
�"�": C
=
�"�"D E
$num
�"�"F H
,
�"�"H I
ArraySubType
�"�"J V
=
�"�"W X

�"�"Y f
.
�"�"f g
I1
�"�"g i
)
�"�"i j
]
�"�"j k
public
�"�" 
byte
�"�" 
[
�"�" 
]
�"�" 
byRes
�"�" 
;
�"�"  
}
�"�" 	
[
�"�" 	#
StructLayoutAttribute
�"�"	 
(
�"�" 

LayoutKind
�"�" )
.
�"�") *

Sequential
�"�"* 4
)
�"�"4 5
]
�"�"5 6
public
�"�" 
struct
�"�" !
NET_DVR_CRUISE_PARA
�"�" )
{
�"�" 	
public
�"�" 
uint
�"�" 
dwSize
�"�" 
;
�"�" 
[
�"�" 
MarshalAsAttribute
�"�"
(
�"�"  

�"�"  -
.
�"�"- .

ByValArray
�"�". 8
,
�"�"8 9
	SizeConst
�"�": C
=
�"�"D E$
CRUISE_MAX_PRESET_NUMS
�"�"F \
,
�"�"\ ]
ArraySubType
�"�"^ j
=
�"�"k l

�"�"m z
.
�"�"z {
I1
�"�"{ }
)
�"�"} ~
]
�"�"~ 
public
�"�" 
byte
�"�" 
[
�"�" 
]
�"�" 

byPresetNo
�"�" $
;
�"�"$ %
[
�"�" 
MarshalAsAttribute
�"�"
(
�"�"  

�"�"  -
.
�"�"- .

ByValArray
�"�". 8
,
�"�"8 9
	SizeConst
�"�": C
=
�"�"D E$
CRUISE_MAX_PRESET_NUMS
�"�"F \
,
�"�"\ ]
ArraySubType
�"�"^ j
=
�"�"k l

�"�"m z
.
�"�"z {
I1
�"�"{ }
)
�"�"} ~
]
�"�"~ 
public
�"�" 
byte
�"�" 
[
�"�" 
]
�"�" 

�"�" '
;
�"�"' (
[
�"�" 
MarshalAsAttribute
�"�"
(
�"�"  

�"�"  -
.
�"�"- .

ByValArray
�"�". 8
,
�"�"8 9
	SizeConst
�"�": C
=
�"�"D E$
CRUISE_MAX_PRESET_NUMS
�"�"F \
,
�"�"\ ]
ArraySubType
�"�"^ j
=
�"�"k l

�"�"m z
.
�"�"z {
U2
�"�"{ }
)
�"�"} ~
]
�"�"~ 
public
�"�" 
ushort
�"�" 
[
�"�" 
]
�"�" 

wDwellTime
�"�" &
;
�"�"& '
public
�"�" 
byte
�"�"  
byEnableThisCruise
�"�" *
;
�"�"* +
[
�"�" 
MarshalAsAttribute
�"�"
(
�"�"  

�"�"  -
.
�"�"- .

ByValArray
�"�". 8
,
�"�"8 9
	SizeConst
�"�": C
=
�"�"D E
$num
�"�"F H
,
�"�"H I
ArraySubType
�"�"J V
=
�"�"W X

�"�"Y f
.
�"�"f g
I1
�"�"g i
)
�"�"i j
]
�"�"j k
public
�"�" 
byte
�"�" 
[
�"�" 
]
�"�" 
res
�"�" 
;
�"�" 
}
�"�" 	
[
�"�" 	#
StructLayoutAttribute
�"�"	 
(
�"�" 

LayoutKind
�"�" )
.
�"�") *

Sequential
�"�"* 4
)
�"�"4 5
]
�"�"5 6
public
�"�" 
struct
�"�" 
NET_DVR_TIMEPOINT
�"�" '
{
�"�" 	
public
�"�" 
uint
�"�" 
dwMonth
�"�" 
;
�"�"  
public
�"�" 
uint
�"�" 
dwWeekNo
�"�"  
;
�"�"  !
public
�"�" 
uint
�"�" 

dwWeekDate
�"�" "
;
�"�"" #
public
�"�" 
uint
�"�" 
dwHour
�"�" 
;
�"�" 
public
�"�" 
uint
�"�" 
dwMin
�"�" 
;
�"�" 
}
�"�" 	
[
�"�" 	#
StructLayoutAttribute
�"�"	 
(
�"�" 

LayoutKind
�"�" )
.
�"�") *

Sequential
�"�"* 4
)
�"�"4 5
]
�"�"5 6
public
�"�" 
struct
�"�"  
NET_DVR_ZONEANDDST
�"�" (
{
�"�" 	
public
�"�" 
uint
�"�" 
dwSize
�"�" 
;
�"�" 
[
�"�" 
MarshalAsAttribute
�"�"
(
�"�"  

�"�"  -
.
�"�"- .

ByValArray
�"�". 8
,
�"�"8 9
	SizeConst
�"�": C
=
�"�"D E
$num
�"�"F H
,
�"�"H I
ArraySubType
�"�"J V
=
�"�"W X

�"�"Y f
.
�"�"f g
I1
�"�"g i
)
�"�"i j
]
�"�"j k
public
�"�" 
byte
�"�" 
[
�"�" 
]
�"�" 
byRes1
�"�"  
;
�"�"  !
public
�"�" 
uint
�"�" 
dwEnableDST
�"�" #
;
�"�"# $
public
�"�" 
byte
�"�" 
	byDSTBias
�"�" !
;
�"�"! "
[
�"�" 
MarshalAsAttribute
�"�"
(
�"�"  

�"�"  -
.
�"�"- .

ByValArray
�"�". 8
,
�"�"8 9
	SizeConst
�"�": C
=
�"�"D E
$num
�"�"F G
,
�"�"G H
ArraySubType
�"�"I U
=
�"�"V W

�"�"X e
.
�"�"e f
I1
�"�"f h
)
�"�"h i
]
�"�"i j
public
�"�" 
byte
�"�" 
[
�"�" 
]
�"�" 
byRes2
�"�"  
;
�"�"  !
public
�"�" 
NET_DVR_TIMEPOINT
�"�" $
struBeginPoint
�"�"% 3
;
�"�"3 4
public
�"�" 
NET_DVR_TIMEPOINT
�"�" $
struEndPoint
�"�"% 1
;
�"�"1 2
}
�"�" 	
[
�"�" 	#
StructLayoutAttribute
�"�"	 
(
�"�" 

LayoutKind
�"�" )
.
�"�") *

Sequential
�"�"* 4
)
�"�"4 5
]
�"�"5 6
public
�"�" 
struct
�"�" 
NET_DVR_JPEGPARA
�"�" &
{
�"�" 	
public
�"�" 
ushort
�"�" 
wPicSize
�"�" "
;
�"�"" #
public
�"�" 
ushort
�"�" 
wPicQuality
�"�" %
;
�"�"% &
}
�"�" 	
[
�"�" 	#
StructLayoutAttribute
�"�"	 
(
�"�" 

LayoutKind
�"�" )
.
�"�") *

Sequential
�"�"* 4
)
�"�"4 5
]
�"�"5 6
public
�"�" 
struct
�"�" 
NET_DVR_AUXOUTCFG
�"�" '
{
�"�" 	
public
�"�" 
uint
�"�" 
dwSize
�"�" 
;
�"�" 
public
�"�" 
uint
�"�" 
dwAlarmOutChan
�"�" &
;
�"�"& '
public
�"�" 
uint
�"�" #
dwAlarmChanSwitchTime
�"�" -
;
�"�"- .
[
�"�" 
MarshalAsAttribute
�"�"
(
�"�"  

�"�"  -
.
�"�"- .

ByValArray
�"�". 8
,
�"�"8 9
	SizeConst
�"�": C
=
�"�"D E

MAX_AUXOUT
�"�"F P
,
�"�"P Q
ArraySubType
�"�"R ^
=
�"�"_ `

�"�"a n
.
�"�"n o
U4
�"�"o q
)
�"�"q r
]
�"�"r s
public
�"�" 
uint
�"�" 
[
�"�" 
]
�"�" 
dwAuxSwitchTime
�"�" )
;
�"�") *
[
�"�" 
MarshalAsAttribute
�"�"
(
�"�"  

�"�"  -
.
�"�"- .

ByValArray
�"�". 8
,
�"�"8 9
	SizeConst
�"�": C
=
�"�"D E

MAX_AUXOUT
�"�"F P
*
�"�"Q R

MAX_WINDOW
�"�"S ]
,
�"�"] ^
ArraySubType
�"�"_ k
=
�"�"l m

�"�"n {
.
�"�"{ |
I1
�"�"| ~
)
�"�"~ 
]�"�" �
public
�"�" 
byte
�"�" 
[
�"�" 
]
�"�" 

byAuxOrder
�"�" $
;
�"�"$ %
}
�"�" 	
[
�"�" 	#
StructLayoutAttribute
�"�"	 
(
�"�" 

LayoutKind
�"�" )
.
�"�") *

Sequential
�"�"* 4
)
�"�"4 5
]
�"�"5 6
public
�"�" 
struct
�"�" 
NET_DVR_NTPPARA
�"�" %
{
�"�" 	
[
�"�" 
MarshalAsAttribute
�"�"
(
�"�"  

�"�"  -
.
�"�"- .

ByValArray
�"�". 8
,
�"�"8 9
	SizeConst
�"�": C
=
�"�"D E
$num
�"�"F H
,
�"�"H I
ArraySubType
�"�"J V
=
�"�"W X

�"�"Y f
.
�"�"f g
I1
�"�"g i
)
�"�"i j
]
�"�"j k
public
�"�" 
byte
�"�" 
[
�"�" 
]
�"�" 

sNTPServer
�"�" $
;
�"�"$ %
public
�"�" 
ushort
�"�" 
	wInterval
�"�" #
;
�"�"# $
public
�"�" 
byte
�"�" 
byEnableNTP
�"�" #
;
�"�"# $
public
�"�" 
byte
�"�" 
cTimeDifferenceH
�"�" (
;
�"�"( )
public
�"�" 
byte
�"�" 
cTimeDifferenceM
�"�" (
;
�"�"( )
public
�"�" 
byte
�"�" 
res1
�"�" 
;
�"�" 
public
�"�" 
ushort
�"�" 
wNtpPort
�"�" "
;
�"�"" #
[
�"�" 
MarshalAsAttribute
�"�"
(
�"�"  

�"�"  -
.
�"�"- .

ByValArray
�"�". 8
,
�"�"8 9
	SizeConst
�"�": C
=
�"�"D E
$num
�"�"F G
,
�"�"G H
ArraySubType
�"�"I U
=
�"�"V W

�"�"X e
.
�"�"e f
I1
�"�"f h
)
�"�"h i
]
�"�"i j
public
�"�" 
byte
�"�" 
[
�"�" 
]
�"�" 
res2
�"�" 
;
�"�" 
}
�"�" 	
[
�"�" 	#
StructLayoutAttribute
�"�"	 
(
�"�" 

LayoutKind
�"�" )
.
�"�") *

Sequential
�"�"* 4
)
�"�"4 5
]
�"�"5 6
public
�"�" 
struct
�"�" 
NET_DVR_DDNSPARA
�"�" &
{
�"�" 	
[
�"�" 
MarshalAsAttribute
�"�"
(
�"�"  

�"�"  -
.
�"�"- .

ByValArray
�"�". 8
,
�"�"8 9
	SizeConst
�"�": C
=
�"�"D E
NAME_LEN
�"�"F N
,
�"�"N O
ArraySubType
�"�"P \
=
�"�"] ^

�"�"_ l
.
�"�"l m
I1
�"�"m o
)
�"�"o p
]
�"�"p q
public
�"�" 
byte
�"�" 
[
�"�" 
]
�"�" 
	sUsername
�"�" #
;
�"�"# $
[
�"�" 
MarshalAsAttribute
�"�"
(
�"�"  

�"�"  -
.
�"�"- .

ByValArray
�"�". 8
,
�"�"8 9
	SizeConst
�"�": C
=
�"�"D E

PASSWD_LEN
�"�"F P
,
�"�"P Q
ArraySubType
�"�"R ^
=
�"�"_ `

�"�"a n
.
�"�"n o
I1
�"�"o q
)
�"�"q r
]
�"�"r s
public
�#�# 
byte
�#�# 
[
�#�# 
]
�#�# 
	sPassword
�#�# #
;
�#�## $
[
�#�# 
MarshalAsAttribute
�#�#
(
�#�#  

�#�#  -
.
�#�#- .

ByValArray
�#�#. 8
,
�#�#8 9
	SizeConst
�#�#: C
=
�#�#D E
$num
�#�#F H
,
�#�#H I
ArraySubType
�#�#J V
=
�#�#W X

�#�#Y f
.
�#�#f g
I1
�#�#g i
)
�#�#i j
]
�#�#j k
public
�#�# 
byte
�#�# 
[
�#�# 
]
�#�# 
sDomainName
�#�# %
;
�#�#% &
public
�#�# 
byte
�#�# 
byEnableDDNS
�#�# $
;
�#�#$ %
[
�#�# 
MarshalAsAttribute
�#�#
(
�#�#  

�#�#  -
.
�#�#- .

ByValArray
�#�#. 8
,
�#�#8 9
	SizeConst
�#�#: C
=
�#�#D E
$num
�#�#F H
,
�#�#H I
ArraySubType
�#�#J V
=
�#�#W X

�#�#Y f
.
�#�#f g
I1
�#�#g i
)
�#�#i j
]
�#�#j k
public
�#�# 
byte
�#�# 
[
�#�# 
]
�#�# 
res
�#�# 
;
�#�# 
}
�#�# 	
[
�#�# 	#
StructLayoutAttribute
�#�#	 
(
�#�# 

LayoutKind
�#�# )
.
�#�#) *

Sequential
�#�#* 4
)
�#�#4 5
]
�#�#5 6
public
�#�# 
struct
�#�# !
NET_DVR_DDNSPARA_EX
�#�# )
{
�#�# 	
public
�#�# 
byte
�#�# 
byHostIndex
�#�# #
;
�#�## $
public
�#�# 
byte
�#�# 
byEnableDDNS
�#�# $
;
�#�#$ %
public
�#�# 
ushort
�#�# 
	wDDNSPort
�#�# #
;
�#�## $
[
�#�# 
MarshalAsAttribute
�#�#
(
�#�#  

�#�#  -
.
�#�#- .

ByValArray
�#�#. 8
,
�#�#8 9
	SizeConst
�#�#: C
=
�#�#D E
NAME_LEN
�#�#F N
,
�#�#N O
ArraySubType
�#�#P \
=
�#�#] ^

�#�#_ l
.
�#�#l m
I1
�#�#m o
)
�#�#o p
]
�#�#p q
public
�#�# 
byte
�#�# 
[
�#�# 
]
�#�# 
	sUsername
�#�# #
;
�#�## $
[
�#�# 
MarshalAsAttribute
�#�#
(
�#�#  

�#�#  -
.
�#�#- .

ByValArray
�#�#. 8
,
�#�#8 9
	SizeConst
�#�#: C
=
�#�#D E

PASSWD_LEN
�#�#F P
,
�#�#P Q
ArraySubType
�#�#R ^
=
�#�#_ `

�#�#a n
.
�#�#n o
I1
�#�#o q
)
�#�#q r
]
�#�#r s
public
�#�# 
byte
�#�# 
[
�#�# 
]
�#�# 
	sPassword
�#�# #
;
�#�## $
[
�#�# 
MarshalAsAttribute
�#�#
(
�#�#  

�#�#  -
.
�#�#- .

ByValArray
�#�#. 8
,
�#�#8 9
	SizeConst
�#�#: C
=
�#�#D E
MAX_DOMAIN_NAME
�#�#F U
,
�#�#U V
ArraySubType
�#�#W c
=
�#�#d e

�#�#f s
.
�#�#s t
I1
�#�#t v
)
�#�#v w
]
�#�#w x
public
�#�# 
byte
�#�# 
[
�#�# 
]
�#�# 
sDomainName
�#�# %
;
�#�#% &
[
�#�# 
MarshalAsAttribute
�#�#
(
�#�#  

�#�#  -
.
�#�#- .

ByValArray
�#�#. 8
,
�#�#8 9
	SizeConst
�#�#: C
=
�#�#D E
MAX_DOMAIN_NAME
�#�#F U
,
�#�#U V
ArraySubType
�#�#W c
=
�#�#d e

�#�#f s
.
�#�#s t
I1
�#�#t v
)
�#�#v w
]
�#�#w x
public
�#�# 
byte
�#�# 
[
�#�# 
]
�#�# 
sServerName
�#�# %
;
�#�#% &
[
�#�# 
MarshalAsAttribute
�#�#
(
�#�#  

�#�#  -
.
�#�#- .

ByValArray
�#�#. 8
,
�#�#8 9
	SizeConst
�#�#: C
=
�#�#D E
$num
�#�#F H
,
�#�#H I
ArraySubType
�#�#J V
=
�#�#W X

�#�#Y f
.
�#�#f g
I1
�#�#g i
)
�#�#i j
]
�#�#j k
public
�#�# 
byte
�#�# 
[
�#�# 
]
�#�# 
byRes
�#�# 
;
�#�#  
}
�#�# 	
[
�#�# 	#
StructLayoutAttribute
�#�#	 
(
�#�# 

LayoutKind
�#�# )
.
�#�#) *

Sequential
�#�#* 4
)
�#�#4 5
]
�#�#5 6
public
�#�# 
struct
�#�# 
struDDNS
�#�# 
{
�#�# 	
[
�#�# 
MarshalAsAttribute
�#�#
(
�#�#  

�#�#  -
.
�#�#- .

ByValArray
�#�#. 8
,
�#�#8 9
	SizeConst
�#�#: C
=
�#�#D E
NAME_LEN
�#�#F N
,
�#�#N O
ArraySubType
�#�#P \
=
�#�#] ^

�#�#_ l
.
�#�#l m
I1
�#�#m o
)
�#�#o p
]
�#�#p q
public
�#�# 
byte
�#�# 
[
�#�# 
]
�#�# 
	sUsername
�#�# #
;
�#�## $
[
�#�# 
MarshalAsAttribute
�#�#
(
�#�#  

�#�#  -
.
�#�#- .

ByValArray
�#�#. 8
,
�#�#8 9
	SizeConst
�#�#: C
=
�#�#D E

PASSWD_LEN
�#�#F P
,
�#�#P Q
ArraySubType
�#�#R ^
=
�#�#_ `

�#�#a n
.
�#�#n o
I1
�#�#o q
)
�#�#q r
]
�#�#r s
public
�#�# 
byte
�#�# 
[
�#�# 
]
�#�# 
	sPassword
�#�# #
;
�#�## $
[
�#�# 
MarshalAsAttribute
�#�#
(
�#�#  

�#�#  -
.
�#�#- .

ByValArray
�#�#. 8
,
�#�#8 9
	SizeConst
�#�#: C
=
�#�#D E
MAX_DOMAIN_NAME
�#�#F U
,
�#�#U V
ArraySubType
�#�#W c
=
�#�#d e

�#�#f s
.
�#�#s t
I1
�#�#t v
)
�#�#v w
]
�#�#w x
public
�#�# 
byte
�#�# 
[
�#�# 
]
�#�# 
sDomainName
�#�# %
;
�#�#% &
[
�#�# 
MarshalAsAttribute
�#�#
(
�#�#  

�#�#  -
.
�#�#- .

ByValArray
�#�#. 8
,
�#�#8 9
	SizeConst
�#�#: C
=
�#�#D E
MAX_DOMAIN_NAME
�#�#F U
,
�#�#U V
ArraySubType
�#�#W c
=
�#�#d e

�#�#f s
.
�#�#s t
I1
�#�#t v
)
�#�#v w
]
�#�#w x
public
�#�# 
byte
�#�# 
[
�#�# 
]
�#�# 
sServerName
�#�# %
;
�#�#% &
public
�#�# 
ushort
�#�# 
	wDDNSPort
�#�# #
;
�#�## $
[
�#�# 
MarshalAsAttribute
�#�#
(
�#�#  

�#�#  -
.
�#�#- .

ByValArray
�#�#. 8
,
�#�#8 9
	SizeConst
�#�#: C
=
�#�#D E
$num
�#�#F H
,
�#�#H I
ArraySubType
�#�#J V
=
�#�#W X

�#�#Y f
.
�#�#f g
I1
�#�#g i
)
�#�#i j
]
�#�#j k
public
�#�# 
byte
�#�# 
[
�#�# 
]
�#�# 
byRes
�#�# 
;
�#�#  
}
�#�# 	
[
�#�# 	#
StructLayoutAttribute
�#�#	 
(
�#�# 

LayoutKind
�#�# )
.
�#�#) *

Sequential
�#�#* 4
)
�#�#4 5
]
�#�#5 6
public
�#�# 
struct
�#�# "
NET_DVR_DDNSPARA_V30
�#�# *
{
�#�# 	
public
�#�# 
byte
�#�# 
byEnableDDNS
�#�# $
;
�#�#$ %
public
�#�# 
byte
�#�# 
byHostIndex
�#�# #
;
�#�## $
[
�#�# 
MarshalAsAttribute
�#�#
(
�#�#  

�#�#  -
.
�#�#- .

ByValArray
�#�#. 8
,
�#�#8 9
	SizeConst
�#�#: C
=
�#�#D E
$num
�#�#F G
,
�#�#G H
ArraySubType
�#�#I U
=
�#�#V W

�#�#X e
.
�#�#e f
I1
�#�#f h
)
�#�#h i
]
�#�#i j
public
�#�# 
byte
�#�# 
[
�#�# 
]
�#�# 
byRes1
�#�#  
;
�#�#  !
[
�#�# 
MarshalAsAttribute
�#�#
(
�#�#  

�#�#  -
.
�#�#- .

ByValArray
�#�#. 8
,
�#�#8 9
	SizeConst
�#�#: C
=
�#�#D E

�#�#F S
,
�#�#S T
ArraySubType
�#�#U a
=
�#�#b c

�#�#d q
.
�#�#q r
Struct
�#�#r x
)
�#�#x y
]
�#�#y z
public
�#�# 
struDDNS
�#�# 
[
�#�# 
]
�#�# 
struDDNS
�#�# &
;
�#�#& '
[
�#�# 
MarshalAsAttribute
�#�#
(
�#�#  

�#�#  -
.
�#�#- .

ByValArray
�#�#. 8
,
�#�#8 9
	SizeConst
�#�#: C
=
�#�#D E
$num
�#�#F H
,
�#�#H I
ArraySubType
�#�#J V
=
�#�#W X

�#�#Y f
.
�#�#f g
I1
�#�#g i
)
�#�#i j
]
�#�#j k
public
�#�# 
byte
�#�# 
[
�#�# 
]
�#�# 
byRes2
�#�#  
;
�#�#  !
}
�#�# 	
[
�#�# 	#
StructLayoutAttribute
�#�#	 
(
�#�# 

LayoutKind
�#�# )
.
�#�#) *

Sequential
�#�#* 4
)
�#�#4 5
]
�#�#5 6
public
�#�# 
struct
�#�# 
NET_DVR_EMAILPARA
�#�# '
{
�#�# 	
[
�#�# 
MarshalAsAttribute
�#�#
(
�#�#  

�#�#  -
.
�#�#- .

ByValArray
�#�#. 8
,
�#�#8 9
	SizeConst
�#�#: C
=
�#�#D E
$num
�#�#F H
,
�#�#H I
ArraySubType
�#�#J V
=
�#�#W X

�#�#Y f
.
�#�#f g
I1
�#�#g i
)
�#�#i j
]
�#�#j k
public
�#�# 
byte
�#�# 
[
�#�# 
]
�#�# 
	sUsername
�#�# #
;
�#�## $
[
�#�# 
MarshalAsAttribute
�#�#
(
�#�#  

�#�#  -
.
�#�#- .

ByValArray
�#�#. 8
,
�#�#8 9
	SizeConst
�#�#: C
=
�#�#D E
$num
�#�#F H
,
�#�#H I
ArraySubType
�#�#J V
=
�#�#W X

�#�#Y f
.
�#�#f g
I1
�#�#g i
)
�#�#i j
]
�#�#j k
public
�#�# 
byte
�#�# 
[
�#�# 
]
�#�# 
	sPassword
�#�# #
;
�#�## $
[
�#�# 
MarshalAsAttribute
�#�#
(
�#�#  

�#�#  -
.
�#�#- .

ByValArray
�#�#. 8
,
�#�#8 9
	SizeConst
�#�#: C
=
�#�#D E
$num
�#�#F H
,
�#�#H I
ArraySubType
�#�#J V
=
�#�#W X

�#�#Y f
.
�#�#f g
I1
�#�#g i
)
�#�#i j
]
�#�#j k
public
�#�# 
byte
�#�# 
[
�#�# 
]
�#�# 
sSmtpServer
�#�# %
;
�#�#% &
[
�#�# 
MarshalAsAttribute
�#�#
(
�#�#  

�#�#  -
.
�#�#- .

ByValArray
�#�#. 8
,
�#�#8 9
	SizeConst
�#�#: C
=
�#�#D E
$num
�#�#F H
,
�#�#H I
ArraySubType
�#�#J V
=
�#�#W X

�#�#Y f
.
�#�#f g
I1
�#�#g i
)
�#�#i j
]
�#�#j k
public
�#�# 
byte
�#�# 
[
�#�# 
]
�#�# 
sPop3Server
�#�# %
;
�#�#% &
[
�#�# 
MarshalAsAttribute
�#�#
(
�#�#  

�#�#  -
.
�#�#- .

ByValArray
�#�#. 8
,
�#�#8 9
	SizeConst
�#�#: C
=
�#�#D E
$num
�#�#F H
,
�#�#H I
ArraySubType
�#�#J V
=
�#�#W X

�#�#Y f
.
�#�#f g
I1
�#�#g i
)
�#�#i j
]
�#�#j k
public
�#�# 
byte
�#�# 
[
�#�# 
]
�#�# 
	sMailAddr
�#�# #
;
�#�## $
[
�#�# 
MarshalAsAttribute
�#�#
(
�#�#  

�#�#  -
.
�#�#- .

ByValArray
�#�#. 8
,
�#�#8 9
	SizeConst
�#�#: C
=
�#�#D E
$num
�#�#F H
,
�#�#H I
ArraySubType
�#�#J V
=
�#�#W X

�#�#Y f
.
�#�#f g
I1
�#�#g i
)
�#�#i j
]
�#�#j k
public
�#�# 
byte
�#�# 
[
�#�# 
]
�#�# 
sEventMailAddr1
�#�# )
;
�#�#) *
[
�#�# 
MarshalAsAttribute
�#�#
(
�#�#  

�#�#  -
.
�#�#- .

ByValArray
�#�#. 8
,
�#�#8 9
	SizeConst
�#�#: C
=
�#�#D E
$num
�#�#F H
,
�#�#H I
ArraySubType
�#�#J V
=
�#�#W X

�#�#Y f
.
�#�#f g
I1
�#�#g i
)
�#�#i j
]
�#�#j k
public
�#�# 
byte
�#�# 
[
�#�# 
]
�#�# 
sEventMailAddr2
�#�# )
;
�#�#) *
[
�#�# 
MarshalAsAttribute
�#�#
(
�#�#  

�#�#  -
.
�#�#- .

ByValArray
�#�#. 8
,
�#�#8 9
	SizeConst
�#�#: C
=
�#�#D E
$num
�#�#F H
,
�#�#H I
ArraySubType
�#�#J V
=
�#�#W X

�#�#Y f
.
�#�#f g
I1
�#�#g i
)
�#�#i j
]
�#�#j k
public
�#�# 
byte
�#�# 
[
�#�# 
]
�#�# 
res
�#�# 
;
�#�# 
}
�#�# 	
[
�#�# 	#
StructLayoutAttribute
�#�#	 
(
�#�# 

LayoutKind
�#�# )
.
�#�#) *

Sequential
�#�#* 4
,
�#�#4 5
CharSet
�#�#6 =
=
�#�#> ?
CharSet
�#�#@ G
.
�#�#G H
Ansi
�#�#H L
)
�#�#L M
]
�#�#M N
public
�#�# 
struct
�#�# 
NET_DVR_NETAPPCFG
�#�# '
{
�#�# 	
public
�#�# 
uint
�#�# 
dwSize
�#�# 
;
�#�# 
[
�#�# 
MarshalAsAttribute
�#�#
(
�#�#  

�#�#  -
.
�#�#- .
	ByValTStr
�#�#. 7
,
�#�#7 8
	SizeConst
�#�#9 B
=
�#�#C D
$num
�#�#E G
)
�#�#G H
]
�#�#H I
public
�#�# 
string
�#�# 
sDNSIp
�#�#  
;
�#�#  !
public
�#�# 
NET_DVR_NTPPARA
�#�# " 
struNtpClientParam
�#�## 5
;
�#�#5 6
public
�#�# 
NET_DVR_DDNSPARA
�#�# #!
struDDNSClientParam
�#�#$ 7
;
�#�#7 8
[
�#�# 
MarshalAsAttribute
�#�#
(
�#�#  

�#�#  -
.
�#�#- .

ByValArray
�#�#. 8
,
�#�#8 9
	SizeConst
�#�#: C
=
�#�#D E
$num
�#�#F I
,
�#�#I J
ArraySubType
�#�#K W
=
�#�#X Y

�#�#Z g
.
�#�#g h
I1
�#�#h j
)
�#�#j k
]
�#�#k l
public
�#�# 
byte
�#�# 
[
�#�# 
]
�#�# 
res
�#�# 
;
�#�# 
}
�#�# 	
[
�#�# 	#
StructLayoutAttribute
�#�#	 
(
�#�# 

LayoutKind
�#�# )
.
�#�#) *

Sequential
�#�#* 4
,
�#�#4 5
CharSet
�#�#6 =
=
�#�#> ?
CharSet
�#�#@ G
.
�#�#G H
Ansi
�#�#H L
)
�#�#L M
]
�#�#M N
public
�#�# 
struct
�#�#  
NET_DVR_SINGLE_NFS
�#�# (
{
�#�# 	
[
�#�# 
MarshalAsAttribute
�#�#
(
�#�#  

�#�#  -
.
�#�#- .
	ByValTStr
�#�#. 7
,
�#�#7 8
	SizeConst
�#�#9 B
=
�#�#C D
$num
�#�#E G
)
�#�#G H
]
�#�#H I
public
�#�# 
string
�#�# 
sNfsHostIPAddr
�#�# (
;
�#�#( )
[
�#�# 
MarshalAsAttribute
�#�#
(
�#�#  

�#�#  -
.
�#�#- .

ByValArray
�#�#. 8
,
�#�#8 9
	SizeConst
�#�#: C
=
�#�#D E
PATHNAME_LEN
�#�#F R
,
�#�#R S
ArraySubType
�#�#T `
=
�#�#a b

�#�#c p
.
�#�#p q
I1
�#�#q s
)
�#�#s t
]
�#�#t u
public
�#�# 
byte
�#�# 
[
�#�# 
]
�#�# 

�#�# '
;
�#�#' (
public
�#�# 
void
�#�# 
Init
�#�# 
(
�#�# 
)
�#�# 
{
�#�# 
this
�#�# 
.
�#�# 

�#�# "
=
�#�## $
new
�#�#% (
byte
�#�#) -
[
�#�#- .
PATHNAME_LEN
�#�#. :
]
�#�#: ;
;
�#�#; <
}
�#�# 
}
�#�# 	
[
�#�# 	#
StructLayoutAttribute
�#�#	 
(
�#�# 

LayoutKind
�#�# )
.
�#�#) *

Sequential
�#�#* 4
)
�#�#4 5
]
�#�#5 6
public
�#�# 
struct
�#�# 
NET_DVR_NFSCFG
�#�# $
{
�#�# 	
public
�#�# 
uint
�#�# 
dwSize
�#�# 
;
�#�# 
[
�#�# 
MarshalAsAttribute
�#�#
(
�#�#  

�#�#  -
.
�#�#- .

ByValArray
�#�#. 8
,
�#�#8 9
	SizeConst
�#�#: C
=
�#�#D E
MAX_NFS_DISK
�#�#F R
,
�#�#R S
ArraySubType
�#�#T `
=
�#�#a b

�#�#c p
.
�#�#p q
Struct
�#�#q w
)
�#�#w x
]
�#�#x y
public
�#�#  
NET_DVR_SINGLE_NFS
�#�# %
[
�#�#% &
]
�#�#& '
struNfsDiskParam
�#�#( 8
;
�#�#8 9
public
�#�# 
void
�#�# 
Init
�#�# 
(
�#�# 
)
�#�# 
{
�#�# 
this
�#�# 
.
�#�# 
struNfsDiskParam
�#�# %
=
�#�#& '
new
�#�#( + 
NET_DVR_SINGLE_NFS
�#�#, >
[
�#�#> ?
MAX_NFS_DISK
�#�#? K
]
�#�#K L
;
�#�#L M
for
�#�# 
(
�#�# 
int
�#�# 
i
�#�# 
=
�#�# 
$num
�#�# 
;
�#�# 
i
�#�#  !
<
�#�#" #
MAX_NFS_DISK
�#�#$ 0
;
�#�#0 1
i
�#�#2 3
++
�#�#3 5
)
�#�#5 6
{
�#�# 
struNfsDiskParam
�#�# $
[
�#�#$ %
i
�#�#% &
]
�#�#& '
.
�#�#' (
Init
�#�#( ,
(
�#�#, -
)
�#�#- .
;
�#�#. /
}
�#�# 
}
�#�# 
}
�#�# 	
[
�#�# 	#
StructLayoutAttribute
�#�#	 
(
�#�# 

LayoutKind
�#�# )
.
�#�#) *

Sequential
�#�#* 4
)
�#�#4 5
]
�#�#5 6
public
�#�# 
struct
�#�# 
NET_DVR_ISCSI_CFG
�#�# '
{
�#�# 	
public
�#�# 
uint
�#�# 
dwSize
�#�# 
;
�#�# 
public
�$�$ 
ushort
�$�$ 
wVrmPort
�$�$ "
;
�$�$" #
public
�$�$ 
byte
�$�$ 
byEnable
�$�$  
;
�$�$  !
[
�$�$ 
MarshalAsAttribute
�$�$
(
�$�$  

�$�$  -
.
�$�$- .

ByValArray
�$�$. 8
,
�$�$8 9
	SizeConst
�$�$: C
=
�$�$D E
$num
�$�$F H
,
�$�$H I
ArraySubType
�$�$J V
=
�$�$W X

�$�$Y f
.
�$�$f g
I1
�$�$g i
)
�$�$i j
]
�$�$j k
public
�$�$ 
byte
�$�$ 
[
�$�$ 
]
�$�$ 
byRes
�$�$ 
;
�$�$  
public
�$�$ 
NET_DVR_IPADDR
�$�$ !
struVrmAddr
�$�$" -
;
�$�$- .
[
�$�$ 
MarshalAsAttribute
�$�$
(
�$�$  

�$�$  -
.
�$�$- .
	ByValTStr
�$�$. 7
,
�$�$7 8
	SizeConst
�$�$9 B
=
�$�$C D
$num
�$�$E G
)
�$�$G H
]
�$�$H I
public
�$�$ 
string
�$�$ 
chNvtIndexCode
�$�$ (
;
�$�$( )
}
�$�$ 	
[
�$�$ 	#
StructLayoutAttribute
�$�$	 
(
�$�$ 

LayoutKind
�$�$ )
.
�$�$) *

Sequential
�$�$* 4
)
�$�$4 5
]
�$�$5 6
public
�$�$ 
struct
�$�$ "
NET_DVR_CRUISE_POINT
�$�$ *
{
�$�$ 	
public
�$�$ 
byte
�$�$ 
	PresetNum
�$�$ !
;
�$�$! "
public
�$�$ 
byte
�$�$ 
Dwell
�$�$ 
;
�$�$ 
public
�$�$ 
byte
�$�$ 
Speed
�$�$ 
;
�$�$ 
public
�$�$ 
byte
�$�$ 
Reserve
�$�$ 
;
�$�$  
public
�$�$ 
void
�$�$ 
Init
�$�$ 
(
�$�$ 
)
�$�$ 
{
�$�$ 
	PresetNum
�$�$ 
=
�$�$ 
$num
�$�$ 
;
�$�$ 
Dwell
�$�$ 
=
�$�$ 
$num
�$�$ 
;
�$�$ 
Speed
�$�$ 
=
�$�$ 
$num
�$�$ 
;
�$�$ 
Reserve
�$�$ 
=
�$�$ 
$num
�$�$ 
;
�$�$ 
}
�$�$ 
}
�$�$ 	
[
�$�$ 	#
StructLayoutAttribute
�$�$	 
(
�$�$ 

LayoutKind
�$�$ )
.
�$�$) *

Sequential
�$�$* 4
)
�$�$4 5
]
�$�$5 6
public
�$�$ 
struct
�$�$  
NET_DVR_CRUISE_RET
�$�$ (
{
�$�$ 	
[
�$�$ 
MarshalAsAttribute
�$�$
(
�$�$  

�$�$  -
.
�$�$- .

ByValArray
�$�$. 8
,
�$�$8 9
	SizeConst
�$�$: C
=
�$�$D E
$num
�$�$F H
,
�$�$H I
ArraySubType
�$�$J V
=
�$�$W X

�$�$Y f
.
�$�$f g
Struct
�$�$g m
)
�$�$m n
]
�$�$n o
public
�$�$ "
NET_DVR_CRUISE_POINT
�$�$ '
[
�$�$' (
]
�$�$( )
struCruisePoint
�$�$* 9
;
�$�$9 :
public
�$�$ 
void
�$�$ 
Init
�$�$ 
(
�$�$ 
)
�$�$ 
{
�$�$ 
struCruisePoint
�$�$ 
=
�$�$  !
new
�$�$" %"
NET_DVR_CRUISE_POINT
�$�$& :
[
�$�$: ;
$num
�$�$; =
]
�$�$= >
;
�$�$> ?
for
�$�$ 
(
�$�$ 
int
�$�$ 
i
�$�$ 
=
�$�$ 
$num
�$�$ 
;
�$�$ 
i
�$�$  !
<
�$�$" #
$num
�$�$$ &
;
�$�$& '
i
�$�$( )
++
�$�$) +
)
�$�$+ ,
{
�$�$ 
struCruisePoint
�$�$ #
[
�$�$# $
i
�$�$$ %
]
�$�$% &
.
�$�$& '
Init
�$�$' +
(
�$�$+ ,
)
�$�$, -
;
�$�$- .
}
�$�$ 
}
�$�$ 
}
�$�$ 	
[
�$�$ 	#
StructLayoutAttribute
�$�$	 
(
�$�$ 

LayoutKind
�$�$ )
.
�$�$) *

Sequential
�$�$* 4
,
�$�$4 5
CharSet
�$�$6 =
=
�$�$> ?
CharSet
�$�$@ G
.
�$�$G H
Ansi
�$�$H L
)
�$�$L M
]
�$�$M N
public
�$�$ 
struct
�$�$ "
NET_DVR_NETCFG_OTHER
�$�$ *
{
�$�$ 	
public
�$�$ 
uint
�$�$ 
dwSize
�$�$ 
;
�$�$ 
[
�$�$ 
MarshalAsAttribute
�$�$
(
�$�$  

�$�$  -
.
�$�$- .
	ByValTStr
�$�$. 7
,
�$�$7 8
	SizeConst
�$�$9 B
=
�$�$C D
$num
�$�$E G
)
�$�$G H
]
�$�$H I
public
�$�$ 
string
�$�$ 
sFirstDNSIP
�$�$ %
;
�$�$% &
[
�$�$ 
MarshalAsAttribute
�$�$
(
�$�$  

�$�$  -
.
�$�$- .
	ByValTStr
�$�$. 7
,
�$�$7 8
	SizeConst
�$�$9 B
=
�$�$C D
$num
�$�$E G
)
�$�$G H
]
�$�$H I
public
�$�$ 
string
�$�$ 
sSecondDNSIP
�$�$ &
;
�$�$& '
[
�$�$ 
MarshalAsAttribute
�$�$
(
�$�$  

�$�$  -
.
�$�$- .
	ByValTStr
�$�$. 7
,
�$�$7 8
	SizeConst
�$�$9 B
=
�$�$C D
$num
�$�$E G
)
�$�$G H
]
�$�$H I
public
�$�$ 
string
�$�$ 
sRes
�$�$ 
;
�$�$ 
}
�$�$ 	
[
�$�$ 	#
StructLayoutAttribute
�$�$	 
(
�$�$ 

LayoutKind
�$�$ )
.
�$�$) *

Sequential
�$�$* 4
,
�$�$4 5
CharSet
�$�$6 =
=
�$�$> ?
CharSet
�$�$@ G
.
�$�$G H
Ansi
�$�$H L
)
�$�$L M
]
�$�$M N
public
�$�$ 
struct
�$�$ $
NET_DVR_MATRIX_DECINFO
�$�$ ,
{
�$�$ 	
[
�$�$ 
MarshalAsAttribute
�$�$
(
�$�$  

�$�$  -
.
�$�$- .
	ByValTStr
�$�$. 7
,
�$�$7 8
	SizeConst
�$�$9 B
=
�$�$C D
$num
�$�$E G
)
�$�$G H
]
�$�$H I
public
�$�$ 
string
�$�$ 
sDVRIP
�$�$  
;
�$�$  !
public
�$�$ 
ushort
�$�$ 
wDVRPort
�$�$ "
;
�$�$" #
public
�$�$ 
byte
�$�$ 
	byChannel
�$�$ !
;
�$�$! "
public
�$�$ 
byte
�$�$ 
byTransProtocol
�$�$ '
;
�$�$' (
public
�$�$ 
byte
�$�$ 
byTransMode
�$�$ #
;
�$�$# $
[
�$�$ 
MarshalAsAttribute
�$�$
(
�$�$  

�$�$  -
.
�$�$- .

ByValArray
�$�$. 8
,
�$�$8 9
	SizeConst
�$�$: C
=
�$�$D E
$num
�$�$F G
,
�$�$G H
ArraySubType
�$�$I U
=
�$�$V W

�$�$X e
.
�$�$e f
I1
�$�$f h
)
�$�$h i
]
�$�$i j
public
�$�$ 
byte
�$�$ 
[
�$�$ 
]
�$�$ 
byRes
�$�$ 
;
�$�$  
[
�$�$ 
MarshalAsAttribute
�$�$
(
�$�$  

�$�$  -
.
�$�$- .

ByValArray
�$�$. 8
,
�$�$8 9
	SizeConst
�$�$: C
=
�$�$D E
NAME_LEN
�$�$F N
,
�$�$N O
ArraySubType
�$�$P \
=
�$�$] ^

�$�$_ l
.
�$�$l m
I1
�$�$m o
)
�$�$o p
]
�$�$p q
public
�$�$ 
byte
�$�$ 
[
�$�$ 
]
�$�$ 
	sUserName
�$�$ #
;
�$�$# $
[
�$�$ 
MarshalAsAttribute
�$�$
(
�$�$  

�$�$  -
.
�$�$- .

ByValArray
�$�$. 8
,
�$�$8 9
	SizeConst
�$�$: C
=
�$�$D E

PASSWD_LEN
�$�$F P
,
�$�$P Q
ArraySubType
�$�$R ^
=
�$�$_ `

�$�$a n
.
�$�$n o
I1
�$�$o q
)
�$�$q r
]
�$�$r s
public
�$�$ 
byte
�$�$ 
[
�$�$ 
]
�$�$ 
	sPassword
�$�$ #
;
�$�$# $
}
�$�$ 	
[
�$�$ 	#
StructLayoutAttribute
�$�$	 
(
�$�$ 

LayoutKind
�$�$ )
.
�$�$) *

Sequential
�$�$* 4
)
�$�$4 5
]
�$�$5 6
public
�$�$ 
struct
�$�$ (
NET_DVR_MATRIX_DYNAMIC_DEC
�$�$ 0
{
�$�$ 	
public
�$�$ 
uint
�$�$ 
dwSize
�$�$ 
;
�$�$ 
public
�$�$ $
NET_DVR_MATRIX_DECINFO
�$�$ )
struDecChanInfo
�$�$* 9
;
�$�$9 :
}
�$�$ 	
[
�$�$ 	#
StructLayoutAttribute
�$�$	 
(
�$�$ 

LayoutKind
�$�$ )
.
�$�$) *

Sequential
�$�$* 4
,
�$�$4 5
CharSet
�$�$6 =
=
�$�$> ?
CharSet
�$�$@ G
.
�$�$G H
Ansi
�$�$H L
)
�$�$L M
]
�$�$M N
public
�$�$ 
struct
�$�$ ,
NET_DVR_MATRIX_DEC_CHAN_STATUS
�$�$ 4
{
�$�$ 	
public
�$�$ 
uint
�$�$ 
dwSize
�$�$ 
;
�$�$ 
public
�$�$ 
uint
�$�$ 

dwIsLinked
�$�$ "
;
�$�$" #
public
�$�$ 
uint
�$�$ 
dwStreamCpRate
�$�$ &
;
�$�$& '
[
�$�$ 
MarshalAsAttribute
�$�$
(
�$�$  

�$�$  -
.
�$�$- .
	ByValTStr
�$�$. 7
,
�$�$7 8
	SizeConst
�$�$9 B
=
�$�$C D
$num
�$�$E G
)
�$�$G H
]
�$�$H I
public
�$�$ 
string
�$�$ 
cRes
�$�$ 
;
�$�$ 
}
�$�$ 	
[
�$�$ 	#
StructLayoutAttribute
�$�$	 
(
�$�$ 

LayoutKind
�$�$ )
.
�$�$) *

Sequential
�$�$* 4
,
�$�$4 5
CharSet
�$�$6 =
=
�$�$> ?
CharSet
�$�$@ G
.
�$�$G H
Ansi
�$�$H L
)
�$�$L M
]
�$�$M N
public
�$�$ 
struct
�$�$ *
NET_DVR_MATRIX_DEC_CHAN_INFO
�$�$ 2
{
�$�$ 	
public
�$�$ 
uint
�$�$ 
dwSize
�$�$ 
;
�$�$ 
public
�$�$ $
NET_DVR_MATRIX_DECINFO
�$�$ )
struDecChanInfo
�$�$* 9
;
�$�$9 :
public
�$�$ 
uint
�$�$ 

dwDecState
�$�$ "
;
�$�$" #
public
�$�$ 
NET_DVR_TIME
�$�$ 
	StartTime
�$�$  )
;
�$�$) *
public
�$�$ 
NET_DVR_TIME
�$�$ 
StopTime
�$�$  (
;
�$�$( )
[
�$�$ 
MarshalAsAttribute
�$�$
(
�$�$  

�$�$  -
.
�$�$- .
	ByValTStr
�$�$. 7
,
�$�$7 8
	SizeConst
�$�$9 B
=
�$�$C D
$num
�$�$E H
)
�$�$H I
]
�$�$I J
public
�$�$ 
string
�$�$ 
	sFileName
�$�$ #
;
�$�$# $
}
�$�$ 	
[
�$�$ 	#
StructLayoutAttribute
�$�$	 
(
�$�$ 

LayoutKind
�$�$ )
.
�$�$) *

Sequential
�$�$* 4
)
�$�$4 5
]
�$�$5 6
public
�$�$ 
struct
�$�$ (
NET_DVR_MATRIX_DECCHANINFO
�$�$ 0
{
�$�$ 	
public
�$�$ 
uint
�$�$ 
dwEnable
�$�$  
;
�$�$  !
public
�$�$ $
NET_DVR_MATRIX_DECINFO
�$�$ )
struDecChanInfo
�$�$* 9
;
�$�$9 :
}
�$�$ 	
[
�$�$ 	#
StructLayoutAttribute
�$�$	 
(
�$�$ 

LayoutKind
�$�$ )
.
�$�$) *

Sequential
�$�$* 4
)
�$�$4 5
]
�$�$5 6
public
�$�$ 
struct
�$�$ )
NET_DVR_MATRIX_LOOP_DECINFO
�$�$ 1
{
�$�$ 	
public
�$�$ 
uint
�$�$ 
dwSize
�$�$ 
;
�$�$ 
public
�$�$ 
uint
�$�$ 

dwPoolTime
�$�$ "
;
�$�$" #
[
�$�$ 
MarshalAsAttribute
�$�$
(
�$�$  

�$�$  -
.
�$�$- .

ByValArray
�$�$. 8
,
�$�$8 9
	SizeConst
�$�$: C
=
�$�$D E
MAX_CYCLE_CHAN
�$�$F T
,
�$�$T U
ArraySubType
�$�$V b
=
�$�$c d

�$�$e r
.
�$�$r s
Struct
�$�$s y
)
�$�$y z
]
�$�$z {
public
�$�$ (
NET_DVR_MATRIX_DECCHANINFO
�$�$ -
[
�$�$- .
]
�$�$. /
struchanConInfo
�$�$0 ?
;
�$�$? @
}
�$�$ 	
[
�$�$ 	#
StructLayoutAttribute
�$�$	 
(
�$�$ 

LayoutKind
�$�$ )
.
�$�$) *

Sequential
�$�$* 4
)
�$�$4 5
]
�$�$5 6
public
�$�$ 
struct
�$�$ 

TTY_CONFIG
�$�$  
{
�$�$ 	
public
�$�$ 
byte
�$�$ 
baudrate
�$�$  
;
�$�$  !
public
�$�$ 
byte
�$�$ 
databits
�$�$  
;
�$�$  !
public
�$�$ 
byte
�$�$ 
stopbits
�$�$  
;
�$�$  !
public
�%�% 
byte
�%�% 
parity
�%�% 
;
�%�% 
public
�%�% 
byte
�%�% 
flowcontrol
�%�% #
;
�%�%# $
[
�%�% 
MarshalAsAttribute
�%�%
(
�%�%  

�%�%  -
.
�%�%- .

ByValArray
�%�%. 8
,
�%�%8 9
	SizeConst
�%�%: C
=
�%�%D E
$num
�%�%F G
,
�%�%G H
ArraySubType
�%�%I U
=
�%�%V W

�%�%X e
.
�%�%e f
I1
�%�%f h
)
�%�%h i
]
�%�%i j
public
�%�% 
byte
�%�% 
[
�%�% 
]
�%�% 
res
�%�% 
;
�%�% 
}
�%�% 	
[
�%�% 	#
StructLayoutAttribute
�%�%	 
(
�%�% 

LayoutKind
�%�% )
.
�%�%) *

Sequential
�%�%* 4
,
�%�%4 5
CharSet
�%�%6 =
=
�%�%> ?
CharSet
�%�%@ G
.
�%�%G H
Ansi
�%�%H L
)
�%�%L M
]
�%�%M N
public
�%�% 
struct
�%�% +
NET_DVR_MATRIX_TRAN_CHAN_INFO
�%�% 3
{
�%�% 	
public
�%�% 
byte
�%�% 
byTranChanEnable
�%�% (
;
�%�%( )
public
�%�% 
byte
�%�% !
byLocalSerialDevice
�%�% +
;
�%�%+ ,
public
�%�% 
byte
�%�% "
byRemoteSerialDevice
�%�% ,
;
�%�%, -
public
�%�% 
byte
�%�% 
res1
�%�% 
;
�%�% 
[
�%�% 
MarshalAsAttribute
�%�%
(
�%�%  

�%�%  -
.
�%�%- .
	ByValTStr
�%�%. 7
,
�%�%7 8
	SizeConst
�%�%9 B
=
�%�%C D
$num
�%�%E G
)
�%�%G H
]
�%�%H I
public
�%�% 
string
�%�% 
sRemoteDevIP
�%�% &
;
�%�%& '
public
�%�% 
ushort
�%�% 
wRemoteDevPort
�%�% (
;
�%�%( )
[
�%�% 
MarshalAsAttribute
�%�%
(
�%�%  

�%�%  -
.
�%�%- .

ByValArray
�%�%. 8
,
�%�%8 9
	SizeConst
�%�%: C
=
�%�%D E
$num
�%�%F G
,
�%�%G H
ArraySubType
�%�%I U
=
�%�%V W

�%�%X e
.
�%�%e f
I1
�%�%f h
)
�%�%h i
]
�%�%i j
public
�%�% 
byte
�%�% 
[
�%�% 
]
�%�% 
res2
�%�% 
;
�%�% 
public
�%�% 

TTY_CONFIG
�%�%  
RemoteSerialDevCfg
�%�% 0
;
�%�%0 1
}
�%�% 	
[
�%�% 	#
StructLayoutAttribute
�%�%	 
(
�%�% 

LayoutKind
�%�% )
.
�%�%) *

Sequential
�%�%* 4
)
�%�%4 5
]
�%�%5 6
public
�%�% 
struct
�%�% -
NET_DVR_MATRIX_TRAN_CHAN_CONFIG
�%�% 5
{
�%�% 	
public
�%�% 
uint
�%�% 
dwSize
�%�% 
;
�%�% 
public
�%�% 
byte
�%�% 
by232IsDualChan
�%�% '
;
�%�%' (
public
�%�% 
byte
�%�% 
by485IsDualChan
�%�% '
;
�%�%' (
[
�%�% 
MarshalAsAttribute
�%�%
(
�%�%  

�%�%  -
.
�%�%- .

ByValArray
�%�%. 8
,
�%�%8 9
	SizeConst
�%�%: C
=
�%�%D E
$num
�%�%F G
,
�%�%G H
ArraySubType
�%�%I U
=
�%�%V W

�%�%X e
.
�%�%e f
I1
�%�%f h
)
�%�%h i
]
�%�%i j
public
�%�% 
byte
�%�% 
[
�%�% 
]
�%�% 
res
�%�% 
;
�%�% 
[
�%�% 
MarshalAsAttribute
�%�%
(
�%�%  

�%�%  -
.
�%�%- .

ByValArray
�%�%. 8
,
�%�%8 9
	SizeConst
�%�%: C
=
�%�%D E
MAX_SERIAL_NUM
�%�%F T
,
�%�%T U
ArraySubType
�%�%V b
=
�%�%c d

�%�%e r
.
�%�%r s
Struct
�%�%s y
)
�%�%y z
]
�%�%z {
public
�%�% +
NET_DVR_MATRIX_TRAN_CHAN_INFO
�%�% 0
[
�%�%0 1
]
�%�%1 2
struTranInfo
�%�%3 ?
;
�%�%? @
}
�%�% 	
[
�%�% 	#
StructLayoutAttribute
�%�%	 
(
�%�% 

LayoutKind
�%�% )
.
�%�%) *

Sequential
�%�%* 4
,
�%�%4 5
CharSet
�%�%6 =
=
�%�%> ?
CharSet
�%�%@ G
.
�%�%G H
Ansi
�%�%H L
)
�%�%L M
]
�%�%M N
public
�%�% 
struct
�%�% ,
NET_DVR_MATRIX_DEC_REMOTE_PLAY
�%�% 4
{
�%�% 	
public
�%�% 
uint
�%�% 
dwSize
�%�% 
;
�%�% 
[
�%�% 
MarshalAsAttribute
�%�%
(
�%�%  

�%�%  -
.
�%�%- .
	ByValTStr
�%�%. 7
,
�%�%7 8
	SizeConst
�%�%9 B
=
�%�%C D
$num
�%�%E G
)
�%�%G H
]
�%�%H I
public
�%�% 
string
�%�% 
sDVRIP
�%�%  
;
�%�%  !
public
�%�% 
ushort
�%�% 
wDVRPort
�%�% "
;
�%�%" #
public
�%�% 
byte
�%�% 
	byChannel
�%�% !
;
�%�%! "
public
�%�% 
byte
�%�% 
	byReserve
�%�% !
;
�%�%! "
[
�%�% 
MarshalAsAttribute
�%�%
(
�%�%  

�%�%  -
.
�%�%- .

ByValArray
�%�%. 8
,
�%�%8 9
	SizeConst
�%�%: C
=
�%�%D E
NAME_LEN
�%�%F N
,
�%�%N O
ArraySubType
�%�%P \
=
�%�%] ^

�%�%_ l
.
�%�%l m
I1
�%�%m o
)
�%�%o p
]
�%�%p q
public
�%�% 
byte
�%�% 
[
�%�% 
]
�%�% 
	sUserName
�%�% #
;
�%�%# $
[
�%�% 
MarshalAsAttribute
�%�%
(
�%�%  

�%�%  -
.
�%�%- .

ByValArray
�%�%. 8
,
�%�%8 9
	SizeConst
�%�%: C
=
�%�%D E

PASSWD_LEN
�%�%F P
,
�%�%P Q
ArraySubType
�%�%R ^
=
�%�%_ `

�%�%a n
.
�%�%n o
I1
�%�%o q
)
�%�%q r
]
�%�%r s
public
�%�% 
byte
�%�% 
[
�%�% 
]
�%�% 
	sPassword
�%�% #
;
�%�%# $
public
�%�% 
uint
�%�% 

dwPlayMode
�%�% "
;
�%�%" #
public
�%�% 
NET_DVR_TIME
�%�% 
	StartTime
�%�%  )
;
�%�%) *
public
�%�% 
NET_DVR_TIME
�%�% 
StopTime
�%�%  (
;
�%�%( )
[
�%�% 
MarshalAsAttribute
�%�%
(
�%�%  

�%�%  -
.
�%�%- .
	ByValTStr
�%�%. 7
,
�%�%7 8
	SizeConst
�%�%9 B
=
�%�%C D
$num
�%�%E H
)
�%�%H I
]
�%�%I J
public
�%�% 
string
�%�% 
	sFileName
�%�% #
;
�%�%# $
}
�%�% 	
[
�%�% 	#
StructLayoutAttribute
�%�%	 
(
�%�% 

LayoutKind
�%�% )
.
�%�%) *

Sequential
�%�%* 4
)
�%�%4 5
]
�%�%5 6
public
�%�% 
struct
�%�% 4
&NET_DVR_MATRIX_DEC_REMOTE_PLAY_CONTROL
�%�% <
{
�%�% 	
public
�%�% 
uint
�%�% 
dwSize
�%�% 
;
�%�% 
public
�%�% 
uint
�%�% 
	dwPlayCmd
�%�% !
;
�%�%! "
public
�%�% 
uint
�%�% 

dwCmdParam
�%�% "
;
�%�%" #
}
�%�% 	
[
�%�% 	#
StructLayoutAttribute
�%�%	 
(
�%�% 

LayoutKind
�%�% )
.
�%�%) *

Sequential
�%�%* 4
)
�%�%4 5
]
�%�%5 6
public
�%�% 
struct
�%�% 3
%NET_DVR_MATRIX_DEC_REMOTE_PLAY_STATUS
�%�% ;
{
�%�% 	
public
�%�% 
uint
�%�% 
dwSize
�%�% 
;
�%�% 
public
�%�% 
uint
�%�% 
dwCurMediaFileLen
�%�% )
;
�%�%) *
public
�%�% 
uint
�%�% $
dwCurMediaFilePosition
�%�% .
;
�%�%. /
public
�%�% 
uint
�%�% $
dwCurMediaFileDuration
�%�% .
;
�%�%. /
public
�%�% 
uint
�%�% 

�%�% %
;
�%�%% &
public
�%�% 
uint
�%�% "
dwCurMediaFIleFrames
�%�% ,
;
�%�%, -
public
�%�% 
uint
�%�% 

�%�% %
;
�%�%% &
[
�%�% 
MarshalAsAttribute
�%�%
(
�%�%  

�%�%  -
.
�%�%- .

ByValArray
�%�%. 8
,
�%�%8 9
	SizeConst
�%�%: C
=
�%�%D E
$num
�%�%F H
,
�%�%H I
ArraySubType
�%�%J V
=
�%�%W X

�%�%Y f
.
�%�%f g
I1
�%�%g i
)
�%�%i j
]
�%�%j k
public
�%�% 
byte
�%�% 
[
�%�% 
]
�%�% 
res
�%�% 
;
�%�% 
}
�%�% 	
[
�%�% 	#
StructLayoutAttribute
�%�%	 
(
�%�% 

LayoutKind
�%�% )
.
�%�%) *

Sequential
�%�%* 4
)
�%�%4 5
]
�%�%5 6
public
�%�% 
struct
�%�% (
NET_DVR_MATRIX_PASSIVEMODE
�%�% 0
{
�%�% 	
public
�%�% 
ushort
�%�% 
wTransProtol
�%�% &
;
�%�%& '
public
�%�% 
ushort
�%�% 
wPassivePort
�%�% &
;
�%�%& '
public
�%�% 
NET_DVR_IPADDR
�%�% !
struMcastIP
�%�%" -
;
�%�%- .
[
�%�% 
MarshalAsAttribute
�%�%
(
�%�%  

�%�%  -
.
�%�%- .

ByValArray
�%�%. 8
,
�%�%8 9
	SizeConst
�%�%: C
=
�%�%D E
$num
�%�%F G
,
�%�%G H
ArraySubType
�%�%I U
=
�%�%V W

�%�%X e
.
�%�%e f
I1
�%�%f h
)
�%�%h i
]
�%�%i j
public
�%�% 
byte
�%�% 
[
�%�% 
]
�%�% 
res
�%�% 
;
�%�% 
}
�%�% 	
[
�%�% 	#
StructLayoutAttribute
�%�%	 
(
�%�% 

LayoutKind
�%�% )
.
�%�%) *

Sequential
�%�%* 4
)
�%�%4 5
]
�%�%5 6
public
�%�% 
struct
�%�% /
!NET_DVR_MATRIX_TRAN_CHAN_INFO_V30
�%�% 7
{
�%�% 	
public
�%�% 
byte
�%�% 
byTranChanEnable
�%�% (
;
�%�%( )
public
�%�% 
byte
�%�% !
byLocalSerialDevice
�%�% +
;
�%�%+ ,
public
�%�% 
byte
�%�% "
byRemoteSerialDevice
�%�% ,
;
�%�%, -
public
�%�% 
byte
�%�% 
byRes1
�%�% 
;
�%�% 
public
�%�% 
NET_DVR_IPADDR
�%�% !
struRemoteDevIP
�%�%" 1
;
�%�%1 2
public
�%�% 
ushort
�%�% 
wRemoteDevPort
�%�% (
;
�%�%( )
public
�%�% 
byte
�%�% 
byIsEstablished
�%�% '
;
�%�%' (
public
�%�% 
byte
�%�% 
byRes2
�%�% 
;
�%�% 
public
�%�% 

TTY_CONFIG
�%�%  
RemoteSerialDevCfg
�%�% 0
;
�%�%0 1
[
�%�% 
MarshalAsAttribute
�%�%
(
�%�%  

�%�%  -
.
�%�%- .

ByValArray
�%�%. 8
,
�%�%8 9
	SizeConst
�%�%: C
=
�%�%D E
NAME_LEN
�%�%F N
,
�%�%N O
ArraySubType
�%�%P \
=
�%�%] ^

�%�%_ l
.
�%�%l m
I1
�%�%m o
)
�%�%o p
]
�%�%p q
public
�%�% 
byte
�%�% 
[
�%�% 
]
�%�% 

byUsername
�%�% $
;
�%�%$ %
[
�%�% 
MarshalAsAttribute
�%�%
(
�%�%  

�%�%  -
.
�%�%- .

ByValArray
�%�%. 8
,
�%�%8 9
	SizeConst
�%�%: C
=
�%�%D E

PASSWD_LEN
�%�%F P
,
�%�%P Q
ArraySubType
�%�%R ^
=
�%�%_ `

�%�%a n
.
�%�%n o
I1
�%�%o q
)
�%�%q r
]
�%�%r s
public
�%�% 
byte
�%�% 
[
�%�% 
]
�%�% 

byPassword
�%�% $
;
�%�%$ %
[
�%�% 
MarshalAsAttribute
�%�%
(
�%�%  

�%�%  -
.
�%�%- .

ByValArray
�%�%. 8
,
�%�%8 9
	SizeConst
�%�%: C
=
�%�%D E
$num
�%�%F H
,
�%�%H I
ArraySubType
�%�%J V
=
�%�%W X

�%�%Y f
.
�%�%f g
I1
�%�%g i
)
�%�%i j
]
�%�%j k
public
�%�% 
byte
�%�% 
[
�%�% 
]
�%�% 
byRes3
�%�%  
;
�%�%  !
}
�%�% 	
[
�&�& 	#
StructLayoutAttribute
�&�&	 
(
�&�& 

LayoutKind
�&�& )
.
�&�&) *

Sequential
�&�&* 4
)
�&�&4 5
]
�&�&5 6
public
�&�& 
struct
�&�& 1
#NET_DVR_MATRIX_TRAN_CHAN_CONFIG_V30
�&�& 9
{
�&�& 	
public
�&�& 
uint
�&�& 
dwSize
�&�& 
;
�&�& 
public
�&�& 
byte
�&�& 
by232IsDualChan
�&�& '
;
�&�&' (
public
�&�& 
byte
�&�& 
by485IsDualChan
�&�& '
;
�&�&' (
[
�&�& 
MarshalAsAttribute
�&�&
(
�&�&  

�&�&  -
.
�&�&- .

ByValArray
�&�&. 8
,
�&�&8 9
	SizeConst
�&�&: C
=
�&�&D E
$num
�&�&F G
,
�&�&G H
ArraySubType
�&�&I U
=
�&�&V W

�&�&X e
.
�&�&e f
I1
�&�&f h
)
�&�&h i
]
�&�&i j
public
�&�& 
byte
�&�& 
[
�&�& 
]
�&�& 
vyRes
�&�& 
;
�&�&  
[
�&�& 
MarshalAsAttribute
�&�&
(
�&�&  

�&�&  -
.
�&�&- .

ByValArray
�&�&. 8
,
�&�&8 9
	SizeConst
�&�&: C
=
�&�&D E
MAX_SERIAL_NUM
�&�&F T
,
�&�&T U
ArraySubType
�&�&V b
=
�&�&c d

�&�&e r
.
�&�&r s
Struct
�&�&s y
)
�&�&y z
]
�&�&z {
public
�&�& +
NET_DVR_MATRIX_TRAN_CHAN_INFO
�&�& 0
[
�&�&0 1
]
�&�&1 2
struTranInfo
�&�&3 ?
;
�&�&? @
}
�&�& 	
[
�&�& 	#
StructLayoutAttribute
�&�&	 
(
�&�& 

LayoutKind
�&�& )
.
�&�&) *

Sequential
�&�&* 4
)
�&�&4 5
]
�&�&5 6
public
�&�& 
struct
�&�& *
NET_DVR_MATRIX_CHAN_INFO_V30
�&�& 2
{
�&�& 	
public
�&�& 
uint
�&�& 
dwEnable
�&�&  
;
�&�&  !
public
�&�& -
NET_DVR_STREAM_MEDIA_SERVER_CFG
�&�& 2"
streamMediaServerCfg
�&�&3 G
;
�&�&G H
public
�&�& #
NET_DVR_DEV_CHAN_INFO
�&�& (
struDevChanInfo
�&�&) 8
;
�&�&8 9
}
�&�& 	
[
�&�& 	#
StructLayoutAttribute
�&�&	 
(
�&�& 

LayoutKind
�&�& )
.
�&�&) *

Sequential
�&�&* 4
)
�&�&4 5
]
�&�&5 6
public
�&�& 
struct
�&�& -
NET_DVR_MATRIX_LOOP_DECINFO_V30
�&�& 5
{
�&�& 	
public
�&�& 
uint
�&�& 
dwSize
�&�& 
;
�&�& 
public
�&�& 
uint
�&�& 

dwPoolTime
�&�& "
;
�&�&" #
[
�&�& 
MarshalAsAttribute
�&�&
(
�&�&  

�&�&  -
.
�&�&- .

ByValArray
�&�&. 8
,
�&�&8 9
	SizeConst
�&�&: C
=
�&�&D E 
MAX_CYCLE_CHAN_V30
�&�&F X
,
�&�&X Y
ArraySubType
�&�&Z f
=
�&�&g h

�&�&i v
.
�&�&v w
Struct
�&�&w }
)
�&�&} ~
]
�&�&~ 
public
�&�& *
NET_DVR_MATRIX_CHAN_INFO_V30
�&�& /
[
�&�&/ 0
]
�&�&0 1
struchanConInfo
�&�&2 A
;
�&�&A B
[
�&�& 
MarshalAsAttribute
�&�&
(
�&�&  

�&�&  -
.
�&�&- .

ByValArray
�&�&. 8
,
�&�&8 9
	SizeConst
�&�&: C
=
�&�&D E
$num
�&�&F H
,
�&�&H I
ArraySubType
�&�&J V
=
�&�&W X

�&�&Y f
.
�&�&f g
I1
�&�&g i
)
�&�&i j
]
�&�&j k
public
�&�& 
byte
�&�& 
[
�&�& 
]
�&�& 
byRes
�&�& 
;
�&�&  
}
�&�& 	
[
�&�& 	#
StructLayoutAttribute
�&�&	 
(
�&�& 

LayoutKind
�&�& )
.
�&�&) *

Sequential
�&�&* 4
,
�&�&4 5
CharSet
�&�&6 =
=
�&�&> ?
CharSet
�&�&@ G
.
�&�&G H
Ansi
�&�&H L
)
�&�&L M
]
�&�&M N
public
�&�& 
struct
�&�& .
 NET_DVR_MATRIX_DEC_CHAN_INFO_V30
�&�& 6
{
�&�& 	
public
�&�& 
uint
�&�& 
dwSize
�&�& 
;
�&�& 
public
�&�& -
NET_DVR_STREAM_MEDIA_SERVER_CFG
�&�& 2"
streamMediaServerCfg
�&�&3 G
;
�&�&G H
public
�&�& #
NET_DVR_DEV_CHAN_INFO
�&�& (
struDevChanInfo
�&�&) 8
;
�&�&8 9
public
�&�& 
uint
�&�& 

dwDecState
�&�& "
;
�&�&" #
public
�&�& 
NET_DVR_TIME
�&�& 
	StartTime
�&�&  )
;
�&�&) *
public
�&�& 
NET_DVR_TIME
�&�& 
StopTime
�&�&  (
;
�&�&( )
[
�&�& 
MarshalAsAttribute
�&�&
(
�&�&  

�&�&  -
.
�&�&- .
	ByValTStr
�&�&. 7
,
�&�&7 8
	SizeConst
�&�&9 B
=
�&�&C D
$num
�&�&E H
)
�&�&H I
]
�&�&I J
public
�&�& 
string
�&�& 
	sFileName
�&�& #
;
�&�&# $
public
�&�& 
uint
�&�& 
dwGetStreamMode
�&�& '
;
�&�&' (
public
�&�& (
NET_DVR_MATRIX_PASSIVEMODE
�&�& -
struPassiveMode
�&�&. =
;
�&�&= >
[
�&�& 
MarshalAsAttribute
�&�&
(
�&�&  

�&�&  -
.
�&�&- .

ByValArray
�&�&. 8
,
�&�&8 9
	SizeConst
�&�&: C
=
�&�&D E
$num
�&�&F H
,
�&�&H I
ArraySubType
�&�&J V
=
�&�&W X

�&�&Y f
.
�&�&f g
I1
�&�&g i
)
�&�&i j
]
�&�&j k
public
�&�& 
byte
�&�& 
[
�&�& 
]
�&�& 
byRes
�&�& 
;
�&�&  
}
�&�& 	
public
�&�& 
const
�&�& 
int
�&�& 
MAX_RESOLUTIONNUM
�&�& *
=
�&�&+ ,
$num
�&�&- /
;
�&�&/ 0
[
�&�& 	#
StructLayoutAttribute
�&�&	 
(
�&�& 

LayoutKind
�&�& )
.
�&�&) *

Sequential
�&�&* 4
)
�&�&4 5
]
�&�&5 6
public
�&�& 
struct
�&�& $
NET_DVR_MATRIX_ABILITY
�&�& ,
{
�&�& 	
public
�&�& 
uint
�&�& 
dwSize
�&�& 
;
�&�& 
public
�&�& 
byte
�&�& 
	byDecNums
�&�& !
;
�&�&! "
public
�&�& 
byte
�&�& 
byStartChan
�&�& #
;
�&�&# $
public
�&�& 
byte
�&�& 
	byVGANums
�&�& !
;
�&�&! "
public
�&�& 
byte
�&�& 
	byBNCNums
�&�& !
;
�&�&! "
[
�&�& 
MarshalAsAttribute
�&�&
(
�&�&  

�&�&  -
.
�&�&- .

ByValArray
�&�&. 8
,
�&�&8 9
	SizeConst
�&�&: C
=
�&�&D E
$num
�&�&F G
*
�&�&H I
$num
�&�&J L
,
�&�&L M
ArraySubType
�&�&N Z
=
�&�&[ \

�&�&] j
.
�&�&j k
I1
�&�&k m
)
�&�&m n
]
�&�&n o
public
�&�& 
byte
�&�& 
[
�&�& 
]
�&�& 
byVGAWindowMode
�&�& )
;
�&�&) *
[
�&�& 
MarshalAsAttribute
�&�&
(
�&�&  

�&�&  -
.
�&�&- .

ByValArray
�&�&. 8
,
�&�&8 9
	SizeConst
�&�&: C
=
�&�&D E
$num
�&�&F G
,
�&�&G H
ArraySubType
�&�&I U
=
�&�&V W

�&�&X e
.
�&�&e f
I1
�&�&f h
)
�&�&h i
]
�&�&i j
public
�&�& 
byte
�&�& 
[
�&�& 
]
�&�& 
byBNCWindowMode
�&�& )
;
�&�&) *
public
�&�& 
byte
�&�& 
	byDspNums
�&�& !
;
�&�&! "
public
�&�& 
byte
�&�& 

byHDMINums
�&�& "
;
�&�&" #
public
�&�& 
byte
�&�& 
	byDVINums
�&�& !
;
�&�&! "
[
�&�& 
MarshalAsAttribute
�&�&
(
�&�&  

�&�&  -
.
�&�&- .

ByValArray
�&�&. 8
,
�&�&8 9
	SizeConst
�&�&: C
=
�&�&D E
$num
�&�&F H
,
�&�&H I
ArraySubType
�&�&J V
=
�&�&W X

�&�&Y f
.
�&�&f g
I1
�&�&g i
)
�&�&i j
]
�&�&j k
public
�&�& 
byte
�&�& 
[
�&�& 
]
�&�& 
byRes1
�&�&  
;
�&�&  !
[
�&�& 
MarshalAsAttribute
�&�&
(
�&�&  

�&�&  -
.
�&�&- .

ByValArray
�&�&. 8
,
�&�&8 9
	SizeConst
�&�&: C
=
�&�&D E
MAX_RESOLUTIONNUM
�&�&F W
,
�&�&W X
ArraySubType
�&�&Y e
=
�&�&f g

�&�&h u
.
�&�&u v
I1
�&�&v x
)
�&�&x y
]
�&�&y z
public
�&�& 
byte
�&�& 
[
�&�& 
]
�&�& !
bySupportResolution
�&�& -
;
�&�&- .
[
�&�& 
MarshalAsAttribute
�&�&
(
�&�&  

�&�&  -
.
�&�&- .

ByValArray
�&�&. 8
,
�&�&8 9
	SizeConst
�&�&: C
=
�&�&D E
$num
�&�&F G
*
�&�&H I
$num
�&�&J K
,
�&�&K L
ArraySubType
�&�&M Y
=
�&�&Z [

�&�&\ i
.
�&�&i j
I1
�&�&j l
)
�&�&l m
]
�&�&m n
public
�&�& 
byte
�&�& 
[
�&�& 
]
�&�& 
byHDMIWindowMode
�&�& *
;
�&�&* +
[
�&�& 
MarshalAsAttribute
�&�&
(
�&�&  

�&�&  -
.
�&�&- .

ByValArray
�&�&. 8
,
�&�&8 9
	SizeConst
�&�&: C
=
�&�&D E
$num
�&�&F G
*
�&�&H I
$num
�&�&J K
,
�&�&K L
ArraySubType
�&�&M Y
=
�&�&Z [

�&�&\ i
.
�&�&i j
I1
�&�&j l
)
�&�&l m
]
�&�&m n
public
�&�& 
byte
�&�& 
[
�&�& 
]
�&�& 
byDVIWindowMode
�&�& )
;
�&�&) *
[
�&�& 
MarshalAsAttribute
�&�&
(
�&�&  

�&�&  -
.
�&�&- .

ByValArray
�&�&. 8
,
�&�&8 9
	SizeConst
�&�&: C
=
�&�&D E
$num
�&�&F H
,
�&�&H I
ArraySubType
�&�&J V
=
�&�&W X

�&�&Y f
.
�&�&f g
I1
�&�&g i
)
�&�&i j
]
�&�&j k
public
�&�& 
byte
�&�& 
[
�&�& 
]
�&�& 
byRes2
�&�&  
;
�&�&  !
}
�&�& 	
[
�&�& 	#
StructLayoutAttribute
�&�&	 
(
�&�& 

LayoutKind
�&�& )
.
�&�&) *

Sequential
�&�&* 4
)
�&�&4 5
]
�&�&5 6
public
�&�& 
struct
�&�& "
NET_DVR_DISP_LOGOCFG
�&�& *
{
�&�& 	
public
�&�& 
uint
�&�& 
dwCorordinateX
�&�& &
;
�&�&& '
public
�&�& 
uint
�&�& 
dwCorordinateY
�&�& &
;
�&�&& '
public
�&�& 
ushort
�&�& 
	wPicWidth
�&�& #
;
�&�&# $
public
�&�& 
ushort
�&�& 

wPicHeight
�&�& $
;
�&�&$ %
[
�&�& 
MarshalAsAttribute
�&�&
(
�&�&  

�&�&  -
.
�&�&- .

ByValArray
�&�&. 8
,
�&�&8 9
	SizeConst
�&�&: C
=
�&�&D E
$num
�&�&F G
,
�&�&G H
ArraySubType
�&�&I U
=
�&�&V W

�&�&X e
.
�&�&e f
I1
�&�&f h
)
�&�&h i
]
�&�&i j
public
�&�& 
byte
�&�& 
[
�&�& 
]
�&�& 
byRes1
�&�&  
;
�&�&  !
public
�&�& 
byte
�&�& 
byFlash
�&�& 
;
�&�&  
public
�&�& 
byte
�&�& 

�&�& %
;
�&�&% &
[
�&�& 
MarshalAsAttribute
�&�&
(
�&�&  

�&�&  -
.
�&�&- .

ByValArray
�&�&. 8
,
�&�&8 9
	SizeConst
�&�&: C
=
�&�&D E
$num
�&�&F G
,
�&�&G H
ArraySubType
�&�&I U
=
�&�&V W

�&�&X e
.
�&�&e f
I1
�&�&f h
)
�&�&h i
]
�&�&i j
public
�&�& 
byte
�&�& 
[
�&�& 
]
�&�& 
byRes2
�&�&  
;
�&�&  !
public
�&�& 
uint
�&�& 

dwLogoSize
�&�& "
;
�&�&" #
}
�&�& 	
public
�&�& 
const
�&�& 
int
�&�& $
NET_DVR_ENCODER_UNKOWN
�&�& /
=
�&�&0 1
$num
�&�&2 3
;
�&�&3 4
public
�&�& 
const
�&�& 
int
�&�& "
NET_DVR_ENCODER_H264
�&�& -
=
�&�&. /
$num
�&�&0 1
;
�&�&1 2
public
�&�& 
const
�&�& 
int
�&�& "
NET_DVR_ENCODER_S264
�&�& -
=
�&�&. /
$num
�&�&0 1
;
�&�&1 2
public
�&�& 
const
�&�& 
int
�&�& #
NET_DVR_ENCODER_MPEG4
�&�& .
=
�&�&/ 0
$num
�&�&1 2
;
�&�&2 3
public
�&�& 
const
�&�& 
int
�&�& $
NET_DVR_ORIGINALSTREAM
�&�& /
=
�&�&0 1
$num
�&�&2 3
;
�&�&3 4
public
�&�& 
const
�&�& 
int
�&�& 
NET_DVR_PICTURE
�&�& (
=
�&�&) *
$num
�&�&+ ,
;
�&�&, -
public
�&�& 
const
�&�& 
int
�&�& #
NET_DVR_ENCODER_MJPEG
�&�& .
=
�&�&/ 0
$num
�&�&1 2
;
�&�&2 3
public
�&�& 
const
�&�& 
int
�&�& #
NET_DVR_ECONDER_MPEG2
�&�& .
=
�&�&/ 0
$num
�&�&1 2
;
�&�&2 3
public
�&�& 
const
�&�& 
int
�&�& (
NET_DVR_STREAM_TYPE_UNKOWN
�&�& 3
=
�&�&4 5
$num
�&�&6 7
;
�&�&7 8
public
�&�& 
const
�&�& 
int
�&�& *
NET_DVR_STREAM_TYPE_HIKPRIVT
�&�& 5
=
�&�&6 7
$num
�&�&8 9
;
�&�&9 :
public
�&�& 
const
�&�& 
int
�&�& $
NET_DVR_STREAM_TYPE_TS
�&�& /
=
�&�&0 1
$num
�&�&2 3
;
�&�&3 4
public
�&�& 
const
�&�& 
int
�&�& $
NET_DVR_STREAM_TYPE_PS
�&�& /
=
�&�&0 1
$num
�&�&2 3
;
�&�&3 4
public
�&�& 
const
�&�& 
int
�&�& %
NET_DVR_STREAM_TYPE_RTP
�&�& 0
=
�&�&1 2
$num
�&�&3 4
;
�&�&4 5
[
�&�& 	#
StructLayoutAttribute
�&�&	 
(
�&�& 

LayoutKind
�&�& )
.
�&�&) *

Sequential
�&�&* 4
)
�&�&4 5
]
�&�&5 6
public
�&�& 
struct
�&�& (
NET_DVR_MATRIX_CHAN_STATUS
�&�& 0
{
�&�& 	
public
�&�& 
byte
�&�& 
byDecodeStatus
�&�& &
;
�&�&& '
public
�&�& 
byte
�&�& 
byStreamType
�&�& $
;
�&�&$ %
public
�&�& 
byte
�&�& 
byPacketType
�&�& $
;
�&�&$ %
public
�&�& 
byte
�&�& 
byRecvBufUsage
�&�& &
;
�&�&& '
public
�&�& 
byte
�&�& 

�&�& %
;
�&�&% &
public
�&�& 
byte
�&�& 
	byFpsDecV
�&�& !
;
�&�&! "
public
�&�& 
byte
�&�& 
	byFpsDecA
�&�& !
;
�&�&! "
public
�&�& 
byte
�&�& 
	byCpuLoad
�&�& !
;
�&�&! "
[
�&�& 
MarshalAsAttribute
�&�&
(
�&�&  

�&�&  -
.
�&�&- .

ByValArray
�&�&. 8
,
�&�&8 9
	SizeConst
�&�&: C
=
�&�&D E
$num
�&�&F G
,
�&�&G H
ArraySubType
�&�&I U
=
�&�&V W

�&�&X e
.
�&�&e f
I1
�&�&f h
)
�&�&h i
]
�&�&i j
public
�&�& 
byte
�&�& 
[
�&�& 
]
�&�& 
byRes1
�&�&  
;
�&�&  !
public
�&�& 
uint
�&�& 

dwDecodedV
�&�& "
;
�&�&" #
public
�&�& 
uint
�&�& 

dwDecodedA
�&�& "
;
�&�&" #
public
�&�& 
ushort
�&�& 
wImgW
�&�& 
;
�&�&  
public
�&�& 
ushort
�&�& 
wImgH
�&�& 
;
�&�&  
public
�'�' 
byte
�'�' 

�'�' %
;
�'�'% &
[
�'�' 
MarshalAsAttribute
�'�'
(
�'�'  

�'�'  -
.
�'�'- .

ByValArray
�'�'. 8
,
�'�'8 9
	SizeConst
�'�': C
=
�'�'D E
$num
�'�'F G
,
�'�'G H
ArraySubType
�'�'I U
=
�'�'V W

�'�'X e
.
�'�'e f
I1
�'�'f h
)
�'�'h i
]
�'�'i j
public
�'�' 
byte
�'�' 
[
�'�' 
]
�'�' 
byRes2
�'�'  
;
�'�'  !
public
�'�' 
uint
�'�' 
	dwDecChan
�'�' !
;
�'�'! "
[
�'�' 
MarshalAsAttribute
�'�'
(
�'�'  

�'�'  -
.
�'�'- .

ByValArray
�'�'. 8
,
�'�'8 9
	SizeConst
�'�': C
=
�'�'D E
$num
�'�'F H
,
�'�'H I
ArraySubType
�'�'J V
=
�'�'W X

�'�'Y f
.
�'�'f g
I1
�'�'g i
)
�'�'i j
]
�'�'j k
public
�'�' 
byte
�'�' 
[
�'�' 
]
�'�' 
byRes3
�'�'  
;
�'�'  !
}
�'�' 	
public
�'�' 
const
�'�' 
int
�'�' $
NET_DVR_MAX_DISPREGION
�'�' /
=
�'�'0 1
$num
�'�'2 4
;
�'�'4 5
public
�'�' 
enum
�'�' 
VGA_MODE
�'�' 
{
�'�' 	
VGA_NOT_AVALIABLE
�'�' 
,
�'�' (
VGA_THS8200_MODE_SVGA_60HZ
�'�' &
,
�'�'& '(
VGA_THS8200_MODE_SVGA_75HZ
�'�' &
,
�'�'& ''
VGA_THS8200_MODE_XGA_60HZ
�'�' %
,
�'�'% &'
VGA_THS8200_MODE_XGA_75HZ
�'�' %
,
�'�'% &(
VGA_THS8200_MODE_SXGA_60HZ
�'�' &
,
�'�'& '(
VGA_THS8200_MODE_720P_60HZ
�'�' &
,
�'�'& ')
VGA_THS8200_MODE_1080I_60HZ
�'�' '
,
�'�'' ()
VGA_THS8200_MODE_1080P_30HZ
�'�' '
,
�'�'' ((
VGA_THS8200_MODE_UXGA_30HZ
�'�' &
,
�'�'& '(
HDMI_SII9134_MODE_XGA_60HZ
�'�' &
,
�'�'& ')
HDMI_SII9134_MODE_SXGA_60HZ
�'�' '
,
�'�'' (*
HDMI_SII9134_MODE_SXGA2_60HZ
�'�' (
,
�'�'( ))
HDMI_SII9134_MODE_720P_60HZ
�'�' '
,
�'�'' ()
HDMI_SII9134_MODE_720P_50HZ
�'�' '
,
�'�'' (*
HDMI_SII9134_MODE_1080I_60HZ
�'�' (
,
�'�'( )*
HDMI_SII9134_MODE_1080I_50HZ
�'�' (
,
�'�'( )*
HDMI_SII9134_MODE_1080P_25HZ
�'�' (
,
�'�'( )*
HDMI_SII9134_MODE_1080P_30HZ
�'�' (
,
�'�'( )*
HDMI_SII9134_MODE_1080P_50HZ
�'�' (
,
�'�'( )*
HDMI_SII9134_MODE_1080P_60HZ
�'�' (
,
�'�'( ))
HDMI_SII9134_MODE_UXGA_60HZ
�'�' '
,
�'�'' ('
DVI_SII9134_MODE_XGA_60HZ
�'�' %
,
�'�'% &(
DVI_SII9134_MODE_SXGA_60HZ
�'�' &
,
�'�'& ')
DVI_SII9134_MODE_SXGA2_60HZ
�'�' '
,
�'�'' ((
DVI_SII9134_MODE_720P_60HZ
�'�' &
,
�'�'& '(
DVI_SII9134_MODE_720P_50HZ
�'�' &
,
�'�'& ')
DVI_SII9134_MODE_1080I_60HZ
�'�' '
,
�'�'' ()
DVI_SII9134_MODE_1080I_50HZ
�'�' '
,
�'�'' ()
DVI_SII9134_MODE_1080P_25HZ
�'�' '
,
�'�'' ()
DVI_SII9134_MODE_1080P_30HZ
�'�' '
,
�'�'' ()
DVI_SII9134_MODE_1080P_50HZ
�'�' '
,
�'�'' ()
DVI_SII9134_MODE_1080P_60HZ
�'�' '
,
�'�'' ((
DVI_SII9134_MODE_UXGA_60HZ
�'�' &
,
�'�'& '(
VGA_DECSVR_MODE_SXGA2_60HZ
�'�' &
,
�'�'& ')
HDMI_DECSVR_MODE_1080P_24HZ
�'�' '
,
�'�'' ((
DVI_DECSVR_MODE_1080P_24HZ
�'�' &
,
�'�'& ')
YPbPr_DECSVR_MODE_720P_60HZ
�'�' '
,
�'�'' (*
YPbPr_DECSVR_MODE_1080I_60HZ
�'�' (
}
�'�' 	
public
�'�' 
const
�'�' 
int
�'�' 
LOW_DEC_FPS_1_2
�'�' (
=
�'�') *
$num
�'�'+ -
;
�'�'- .
public
�'�' 
const
�'�' 
int
�'�' 
LOW_DEC_FPS_1_4
�'�' (
=
�'�') *
$num
�'�'+ -
;
�'�'- .
public
�'�' 
const
�'�' 
int
�'�' 
LOW_DEC_FPS_1_8
�'�' (
=
�'�') *
$num
�'�'+ -
;
�'�'- .
public
�'�' 
const
�'�' 
int
�'�' 
LOW_DEC_FPS_1_16
�'�' )
=
�'�'* +
$num
�'�', .
;
�'�'. /
public
�'�' 
enum
�'�' 
VIDEO_STANDARD
�'�' "
{
�'�' 	
VS_NON
�'�' 
=
�'�' 
$num
�'�' 
,
�'�' 
VS_NTSC
�'�' 
=
�'�' 
$num
�'�' 
,
�'�' 
VS_PAL
�'�' 
=
�'�' 
$num
�'�' 
,
�'�' 
}
�'�' 	
[
�'�' 	#
StructLayoutAttribute
�'�'	 
(
�'�' 

LayoutKind
�'�' )
.
�'�') *

Sequential
�'�'* 4
)
�'�'4 5
]
�'�'5 6
public
�'�' 
struct
�'�' !
UNION_VIDEOPLATFORM
�'�' )
{
�'�' 	
[
�'�' 
MarshalAsAttribute
�'�'
(
�'�'  

�'�'  -
.
�'�'- .

ByValArray
�'�'. 8
,
�'�'8 9
	SizeConst
�'�': C
=
�'�'D E
MAX_WINDOWS
�'�'F Q
,
�'�'Q R
ArraySubType
�'�'S _
=
�'�'` a

�'�'b o
.
�'�'o p
I1
�'�'p r
)
�'�'r s
]
�'�'s t
public
�'�' 
byte
�'�' 
[
�'�' 
]
�'�' 
byJoinDecoderId
�'�' )
;
�'�') *
}
�'�' 	
[
�'�' 	#
StructLayoutAttribute
�'�'	 
(
�'�' 

LayoutKind
�'�' )
.
�'�') *

Sequential
�'�'* 4
)
�'�'4 5
]
�'�'5 6
public
�'�' 
struct
�'�' $
UNION_NOTVIDEOPLATFORM
�'�' ,
{
�'�' 	
[
�'�' 
MarshalAsAttribute
�'�'
(
�'�'  

�'�'  -
.
�'�'- .

ByValArray
�'�'. 8
,
�'�'8 9
	SizeConst
�'�': C
=
�'�'D E
$num
�'�'F H
,
�'�'H I
ArraySubType
�'�'J V
=
�'�'W X

�'�'Y f
.
�'�'f g
I1
�'�'g i
)
�'�'i j
]
�'�'j k
public
�'�' 
byte
�'�' 
[
�'�' 
]
�'�' 
byRes
�'�' 
;
�'�'  
}
�'�' 	
[
�'�' 	#
StructLayoutAttribute
�'�'	 
(
�'�' 

LayoutKind
�'�' )
.
�'�') *

Sequential
�'�'* 4
)
�'�'4 5
]
�'�'5 6
public
�'�' 
struct
�'�' '
NET_DVR_VGA_DISP_CHAN_CFG
�'�' /
{
�'�' 	
public
�'�' 
uint
�'�' 
dwSize
�'�' 
;
�'�' 
public
�'�' 
byte
�'�' 
byAudio
�'�' 
;
�'�'  
public
�'�' 
byte
�'�' 
byAudioWindowIdx
�'�' (
;
�'�'( )
public
�'�' 
byte
�'�' 
byVgaResolution
�'�' '
;
�'�'' (
public
�'�' 
byte
�'�' 

�'�' %
;
�'�'% &
public
�'�' 
uint
�'�' 
dwWindowMode
�'�' $
;
�'�'$ %
[
�'�' 
MarshalAsAttribute
�'�'
(
�'�'  

�'�'  -
.
�'�'- .

ByValArray
�'�'. 8
,
�'�'8 9
	SizeConst
�'�': C
=
�'�'D E
MAX_WINDOWS
�'�'F Q
,
�'�'Q R
ArraySubType
�'�'S _
=
�'�'` a

�'�'b o
.
�'�'o p
I1
�'�'p r
)
�'�'r s
]
�'�'s t
public
�'�' 
byte
�'�' 
[
�'�' 
]
�'�' 

�'�' '
;
�'�'' (
public
�'�' 
byte
�'�' 
byEnlargeStatus
�'�' '
;
�'�'' (
public
�'�' 
byte
�'�' %
byEnlargeSubWindowIndex
�'�' /
;
�'�'/ 0
[
�'�' 
StructLayoutAttribute
�'�'
(
�'�'" #

LayoutKind
�'�'# -
.
�'�'- .
Explicit
�'�'. 6
)
�'�'6 7
]
�'�'7 8
public
�'�' 
struct
�'�' 
struDiff
�'�' "
{
�'�' 
[
�'�' "
FieldOffsetAttribute
�'�' %
(
�'�'% &
$num
�'�'& '
)
�'�'' (
]
�'�'( )
[
�'�'  
MarshalAsAttribute
�'�' #
(
�'�'# $

�'�'$ 1
.
�'�'1 2

ByValArray
�'�'2 <
,
�'�'< =
	SizeConst
�'�'> G
=
�'�'H I
$num
�'�'J L
,
�'�'L M
ArraySubType
�'�'N Z
=
�'�'[ \

�'�'] j
.
�'�'j k
I1
�'�'k m
)
�'�'m n
]
�'�'n o
public
�'�' 
byte
�'�' 
[
�'�' 
]
�'�' 
byRes
�'�' #
;
�'�'# $
[
�'�' "
FieldOffsetAttribute
�'�' %
(
�'�'% &
$num
�'�'& '
)
�'�'' (
]
�'�'( )
public
�'�' !
UNION_VIDEOPLATFORM
�'�' *
struVideoPlatform
�'�'+ <
;
�'�'< =
[
�'�' "
FieldOffsetAttribute
�'�' %
(
�'�'% &
$num
�'�'& '
)
�'�'' (
]
�'�'( )
public
�'�' $
UNION_NOTVIDEOPLATFORM
�'�' -"
struNotVideoPlatform
�'�'. B
;
�'�'B C
}
�'�' 
public
�'�' 
byte
�'�' 
byUnionType
�'�' #
;
�'�'# $
public
�'�' 
byte
�'�' 
byScale
�'�' 
;
�'�'  
}
�'�' 	
[
�'�' 	#
StructLayoutAttribute
�'�'	 
(
�'�' 

LayoutKind
�'�' )
.
�'�') *

Sequential
�'�'* 4
)
�'�'4 5
]
�'�'5 6
public
�'�' 
struct
�'�' &
NET_DVR_DISP_CHAN_STATUS
�'�' .
{
�'�' 	
public
�'�' 
byte
�'�' 
byDispStatus
�'�' $
;
�'�'$ %
public
�'�' 
byte
�'�' 
byBVGA
�'�' 
;
�'�' 
public
�'�' 
byte
�'�' 

�'�' %
;
�'�'% &
public
�'�' 
byte
�'�' 
byWindowMode
�'�' $
;
�'�'$ %
[
�'�' 
MarshalAsAttribute
�'�'
(
�'�'  

�'�'  -
.
�'�'- .

ByValArray
�'�'. 8
,
�'�'8 9
	SizeConst
�'�': C
=
�'�'D E
MAX_WINDOWS
�'�'F Q
,
�'�'Q R
ArraySubType
�'�'S _
=
�'�'` a

�'�'b o
.
�'�'o p
I1
�'�'p r
)
�'�'r s
]
�'�'s t
public
�'�' 
byte
�'�' 
[
�'�' 
]
�'�' 

�'�' '
;
�'�'' (
[
�'�' 
MarshalAsAttribute
�'�'
(
�'�'  

�'�'  -
.
�'�'- .

ByValArray
�'�'. 8
,
�'�'8 9
	SizeConst
�'�': C
=
�'�'D E$
NET_DVR_MAX_DISPREGION
�'�'F \
,
�'�'\ ]
ArraySubType
�'�'^ j
=
�'�'k l

�'�'m z
.
�'�'z {
I1
�'�'{ }
)
�'�'} ~
]
�'�'~ 
public
�'�' 
byte
�'�' 
[
�'�' 
]
�'�' 
	byFpsDisp
�'�' #
;
�'�'# $
public
�(�( 
byte
�(�( 
byScreenMode
�(�( $
;
�(�($ %
[
�(�( 
MarshalAsAttribute
�(�(
(
�(�(  

�(�(  -
.
�(�(- .

ByValArray
�(�(. 8
,
�(�(8 9
	SizeConst
�(�(: C
=
�(�(D E
$num
�(�(F H
,
�(�(H I
ArraySubType
�(�(J V
=
�(�(W X

�(�(Y f
.
�(�(f g
I1
�(�(g i
)
�(�(i j
]
�(�(j k
public
�(�( 
byte
�(�( 
[
�(�( 
]
�(�( 
byRes2
�(�(  
;
�(�(  !
}
�(�( 	
public
�(�( 
const
�(�( 
int
�(�( 
MAX_DECODECHANNUM
�(�( *
=
�(�(+ ,
$num
�(�(- /
;
�(�(/ 0
public
�(�( 
const
�(�( 
int
�(�( 
MAX_DISPCHANNUM
�(�( (
=
�(�() *
$num
�(�(+ -
;
�(�(- .
[
�(�( 	#
StructLayoutAttribute
�(�(	 
(
�(�( 

LayoutKind
�(�( )
.
�(�() *

Sequential
�(�(* 4
)
�(�(4 5
]
�(�(5 6
public
�(�( 
struct
�(�( )
NET_DVR_DECODER_WORK_STATUS
�(�( 1
{
�(�( 	
public
�(�( 
uint
�(�( 
dwSize
�(�( 
;
�(�( 
[
�(�( 
MarshalAsAttribute
�(�(
(
�(�(  

�(�(  -
.
�(�(- .

ByValArray
�(�(. 8
,
�(�(8 9
	SizeConst
�(�(: C
=
�(�(D E
MAX_DECODECHANNUM
�(�(F W
,
�(�(W X
ArraySubType
�(�(Y e
=
�(�(f g

�(�(h u
.
�(�(u v
Struct
�(�(v |
)
�(�(| }
]
�(�(} ~
public
�(�( (
NET_DVR_MATRIX_CHAN_STATUS
�(�( -
[
�(�(- .
]
�(�(. /
struDecChanStatus
�(�(0 A
;
�(�(A B
[
�(�( 
MarshalAsAttribute
�(�(
(
�(�(  

�(�(  -
.
�(�(- .

ByValArray
�(�(. 8
,
�(�(8 9
	SizeConst
�(�(: C
=
�(�(D E
MAX_DISPCHANNUM
�(�(F U
,
�(�(U V
ArraySubType
�(�(W c
=
�(�(d e

�(�(f s
.
�(�(s t
Struct
�(�(t z
)
�(�(z {
]
�(�({ |
public
�(�( &
NET_DVR_DISP_CHAN_STATUS
�(�( +
[
�(�(+ ,
]
�(�(, - 
struDispChanStatus
�(�(. @
;
�(�(@ A
[
�(�( 
MarshalAsAttribute
�(�(
(
�(�(  

�(�(  -
.
�(�(- .

ByValArray
�(�(. 8
,
�(�(8 9
	SizeConst
�(�(: C
=
�(�(D E 
MAX_ANALOG_ALARMIN
�(�(F X
,
�(�(X Y
ArraySubType
�(�(Z f
=
�(�(g h

�(�(i v
.
�(�(v w
I1
�(�(w y
)
�(�(y z
]
�(�(z {
public
�(�( 
byte
�(�( 
[
�(�( 
]
�(�( 
byAlarmInStatus
�(�( )
;
�(�() *
[
�(�( 
MarshalAsAttribute
�(�(
(
�(�(  

�(�(  -
.
�(�(- .

ByValArray
�(�(. 8
,
�(�(8 9
	SizeConst
�(�(: C
=
�(�(D E!
MAX_ANALOG_ALARMOUT
�(�(F Y
,
�(�(Y Z
ArraySubType
�(�([ g
=
�(�(h i

�(�(j w
.
�(�(w x
I1
�(�(x z
)
�(�(z {
]
�(�({ |
public
�(�( 
byte
�(�( 
[
�(�( 
]
�(�( 
byAalarmOutStatus
�(�( +
;
�(�(+ ,
public
�(�( 
byte
�(�( !
byAudioInChanStatus
�(�( +
;
�(�(+ ,
[
�(�( 
MarshalAsAttribute
�(�(
(
�(�(  

�(�(  -
.
�(�(- .

ByValArray
�(�(. 8
,
�(�(8 9
	SizeConst
�(�(: C
=
�(�(D E
$num
�(�(F I
,
�(�(I J
ArraySubType
�(�(K W
=
�(�(X Y

�(�(Z g
.
�(�(g h
I1
�(�(h j
)
�(�(j k
]
�(�(k l
public
�(�( 
byte
�(�( 
[
�(�( 
]
�(�( 
byRes
�(�( 
;
�(�(  
}
�(�( 	
[
�(�( 	#
StructLayoutAttribute
�(�(	 
(
�(�( 

LayoutKind
�(�( )
.
�(�() *

Sequential
�(�(* 4
)
�(�(4 5
]
�(�(5 6
public
�(�( 
struct
�(�( +
NET_DVR_PASSIVEDECODE_CONTROL
�(�( 3
{
�(�( 	
public
�(�( 
uint
�(�( 
dwSize
�(�( 
;
�(�( 
public
�(�( 
uint
�(�( 
	dwPlayCmd
�(�( !
;
�(�(! "
public
�(�( 
uint
�(�( 

dwCmdParam
�(�( "
;
�(�(" #
[
�(�( 
MarshalAsAttribute
�(�(
(
�(�(  

�(�(  -
.
�(�(- .

ByValArray
�(�(. 8
,
�(�(8 9
	SizeConst
�(�(: C
=
�(�(D E
$num
�(�(F H
,
�(�(H I
ArraySubType
�(�(J V
=
�(�(W X

�(�(Y f
.
�(�(f g
I1
�(�(g i
)
�(�(i j
]
�(�(j k
public
�(�( 
byte
�(�( 
[
�(�( 
]
�(�( 
byRes
�(�( 
;
�(�(  
}
�(�( 	
public
�(�( 
const
�(�( 
int
�(�( 
PASSIVE_DEC_PAUSE
�(�( *
=
�(�(+ ,
$num
�(�(- .
;
�(�(. /
public
�(�( 
const
�(�( 
int
�(�(  
PASSIVE_DEC_RESUME
�(�( +
=
�(�(, -
$num
�(�(. /
;
�(�(/ 0
public
�(�( 
const
�(�( 
int
�(�( 
PASSIVE_DEC_FAST
�(�( )
=
�(�(* +
$num
�(�(, -
;
�(�(- .
public
�(�( 
const
�(�( 
int
�(�( 
PASSIVE_DEC_SLOW
�(�( )
=
�(�(* +
$num
�(�(, -
;
�(�(- .
public
�(�( 
const
�(�( 
int
�(�(  
PASSIVE_DEC_NORMAL
�(�( +
=
�(�(, -
$num
�(�(. /
;
�(�(/ 0
public
�(�( 
const
�(�( 
int
�(�( "
PASSIVE_DEC_ONEBYONE
�(�( -
=
�(�(. /
$num
�(�(0 1
;
�(�(1 2
public
�(�( 
const
�(�( 
int
�(�( "
PASSIVE_DEC_AUDIO_ON
�(�( -
=
�(�(. /
$num
�(�(0 1
;
�(�(1 2
public
�(�( 
const
�(�( 
int
�(�( #
PASSIVE_DEC_AUDIO_OFF
�(�( .
=
�(�(/ 0
$num
�(�(1 2
;
�(�(2 3
public
�(�( 
const
�(�( 
int
�(�( %
PASSIVE_DEC_RESETBUFFER
�(�( 0
=
�(�(1 2
$num
�(�(3 4
;
�(�(4 5
[
�(�( 	#
StructLayoutAttribute
�(�(	 
(
�(�( 

LayoutKind
�(�( )
.
�(�() *

Sequential
�(�(* 4
)
�(�(4 5
]
�(�(5 6
public
�(�( 
struct
�(�( ,
NET_DVR_MATRIX_DECCHAN_CONTROL
�(�( 4
{
�(�( 	
public
�(�( 
uint
�(�( 
dwSize
�(�( 
;
�(�( 
public
�(�( 
byte
�(�( "
byDecChanScaleStatus
�(�( ,
;
�(�(, -
public
�(�( 
byte
�(�( 

�(�( %
;
�(�(% &
[
�(�( 
MarshalAsAttribute
�(�(
(
�(�(  

�(�(  -
.
�(�(- .

ByValArray
�(�(. 8
,
�(�(8 9
	SizeConst
�(�(: C
=
�(�(D E
$num
�(�(F H
,
�(�(H I
ArraySubType
�(�(J V
=
�(�(W X

�(�(Y f
.
�(�(f g
I1
�(�(g i
)
�(�(i j
]
�(�(j k
public
�(�( 
byte
�(�( 
[
�(�( 
]
�(�( 
byRes
�(�( 
;
�(�(  
}
�(�( 	
public
�(�( 
const
�(�( 
int
�(�( 
MAX_SUBSYSTEM_NUM
�(�( *
=
�(�(+ ,
$num
�(�(- /
;
�(�(/ 0
public
�(�( 
const
�(�( 
int
�(�( #
MAX_SUBSYSTEM_NUM_V40
�(�( .
=
�(�(/ 0
$num
�(�(1 4
;
�(�(4 5
public
�(�( 
const
�(�( 
int
�(�( 

�(�( &
=
�(�(' (
$num
�(�() +
;
�(�(+ ,
public
�(�( 
const
�(�( 
int
�(�( 
MAX_LOOPPLANNUM
�(�( (
=
�(�() *
$num
�(�(+ -
;
�(�(- .
public
�(�( 
const
�(�( 
int
�(�(  
DECODE_TIMESEGMENT
�(�( +
=
�(�(, -
$num
�(�(. /
;
�(�(/ 0
public
�(�( 
const
�(�( 
int
�(�( 
MAX_DOMAIN_NAME
�(�( (
=
�(�() *
$num
�(�(+ -
;
�(�(- .
public
�(�( 
const
�(�( 
int
�(�( 
MAX_DISKNUM_V30
�(�( (
=
�(�() *
$num
�(�(+ -
;
�(�(- .
public
�(�( 
const
�(�( 
int
�(�( 
MAX_DAYS
�(�( !
=
�(�(" #
$num
�(�($ %
;
�(�(% &
public
�(�( 
const
�(�( 
int
�(�( 
MAX_DISPNUM_V41
�(�( (
=
�(�() *
$num
�(�(+ -
;
�(�(- .
public
�(�( 
const
�(�( 
int
�(�( 
MAX_WINDOWS_NUM
�(�( (
=
�(�() *
$num
�(�(+ -
;
�(�(- .
public
�(�( 
const
�(�( 
int
�(�( 
MAX_VOUTNUM
�(�( $
=
�(�(% &
$num
�(�(' )
;
�(�() *
public
�(�( 
const
�(�( 
int
�(�( 
MAX_SUPPORT_RES
�(�( (
=
�(�() *
$num
�(�(+ -
;
�(�(- .
public
�(�( 
const
�(�( 
int
�(�( 
MAX_BIGSCREENNUM
�(�( )
=
�(�(* +
$num
�(�(, /
;
�(�(/ 0
public
�(�( 
const
�(�( 
int
�(�( #
VIDEOPLATFORM_ABILITY
�(�( .
=
�(�(/ 0
$num
�(�(1 6
;
�(�(6 7
public
�(�( 
const
�(�( 
int
�(�( '
MATRIXDECODER_ABILITY_V41
�(�( 2
=
�(�(3 4
$num
�(�(5 :
;
�(�(: ;
public
�(�( 
const
�(�( 
int
�(�( -
NET_DVR_MATRIX_BIGSCREENCFG_GET
�(�( 8
=
�(�(9 :
$num
�(�(; ?
;
�(�(? @
[
�(�( 	#
StructLayoutAttribute
�(�(	 
(
�(�( 

LayoutKind
�(�( )
.
�(�() *

Sequential
�(�(* 4
)
�(�(4 5
]
�(�(5 6
public
�(�( 
struct
�(�( #
NET_DVR_SUBSYSTEMINFO
�(�( +
{
�(�( 	
public
�(�( 
byte
�(�( 
bySubSystemType
�(�( '
;
�(�(' (
public
�(�( 
byte
�(�( 
byChan
�(�( 
;
�(�( 
public
�(�( 
byte
�(�( 
byLoginType
�(�( #
;
�(�(# $
[
�(�( 
MarshalAsAttribute
�(�(
(
�(�(  

�(�(  -
.
�(�(- .

ByValArray
�(�(. 8
,
�(�(8 9
	SizeConst
�(�(: C
=
�(�(D E
$num
�(�(F G
,
�(�(G H
ArraySubType
�(�(I U
=
�(�(V W

�(�(X e
.
�(�(e f
I1
�(�(f h
)
�(�(h i
]
�(�(i j
public
�(�( 
byte
�(�( 
[
�(�( 
]
�(�( 
byRes1
�(�(  
;
�(�(  !
public
�(�( 
NET_DVR_IPADDR
�(�( !
struSubSystemIP
�(�(" 1
;
�(�(1 2
public
�(�( 
ushort
�(�( 
wSubSystemPort
�(�( (
;
�(�(( )
[
�(�( 
MarshalAsAttribute
�(�(
(
�(�(  

�(�(  -
.
�(�(- .

ByValArray
�(�(. 8
,
�(�(8 9
	SizeConst
�(�(: C
=
�(�(D E
$num
�(�(F G
,
�(�(G H
ArraySubType
�(�(I U
=
�(�(V W

�(�(X e
.
�(�(e f
I1
�(�(f h
)
�(�(h i
]
�(�(i j
public
�(�( 
byte
�(�( 
[
�(�( 
]
�(�( 
byRes2
�(�(  
;
�(�(  !
public
�(�( 
NET_DVR_IPADDR
�(�( !!
struSubSystemIPMask
�(�(" 5
;
�(�(5 6
public
�(�( 
NET_DVR_IPADDR
�(�( !
struGatewayIpAddr
�(�(" 3
;
�(�(3 4
[
�(�( 
MarshalAsAttribute
�(�(
(
�(�(  

�(�(  -
.
�(�(- .

ByValArray
�(�(. 8
,
�(�(8 9
	SizeConst
�(�(: C
=
�(�(D E
NAME_LEN
�(�(F N
,
�(�(N O
ArraySubType
�(�(P \
=
�(�(] ^

�(�(_ l
.
�(�(l m
I1
�(�(m o
)
�(�(o p
]
�(�(p q
public
�(�( 
byte
�(�( 
[
�(�( 
]
�(�( 
	sUserName
�(�( #
;
�(�(# $
[
�(�( 
MarshalAsAttribute
�(�(
(
�(�(  

�(�(  -
.
�(�(- .

ByValArray
�(�(. 8
,
�(�(8 9
	SizeConst
�(�(: C
=
�(�(D E

PASSWD_LEN
�(�(F P
,
�(�(P Q
ArraySubType
�(�(R ^
=
�(�(_ `

�(�(a n
.
�(�(n o
I1
�(�(o q
)
�(�(q r
]
�(�(r s
public
�(�( 
byte
�(�( 
[
�(�( 
]
�(�( 
	sPassword
�(�( #
;
�(�(# $
[
�(�( 
MarshalAsAttribute
�(�(
(
�(�(  

�(�(  -
.
�(�(- .
	ByValTStr
�(�(. 7
,
�(�(7 8
	SizeConst
�(�(9 B
=
�(�(C D
MAX_DOMAIN_NAME
�(�(E T
)
�(�(T U
]
�(�(U V
public
�(�( 
string
�(�( 
sDomainName
�(�( %
;
�(�(% &
[
�(�( 
MarshalAsAttribute
�(�(
(
�(�(  

�(�(  -
.
�(�(- .
	ByValTStr
�(�(. 7
,
�(�(7 8
	SizeConst
�(�(9 B
=
�(�(C D
MAX_DOMAIN_NAME
�(�(E T
)
�(�(T U
]
�(�(U V
public
�(�( 
string
�(�( 
sDnsAddress
�(�( %
;
�(�(% &
[
�(�( 
MarshalAsAttribute
�(�(
(
�(�(  

�(�(  -
.
�(�(- .

ByValArray
�(�(. 8
,
�(�(8 9
	SizeConst
�(�(: C
=
�(�(D E
SERIALNO_LEN
�(�(F R
,
�(�(R S
ArraySubType
�(�(T `
=
�(�(a b

�(�(c p
.
�(�(p q
I1
�(�(q s
)
�(�(s t
]
�(�(t u
public
�(�( 
byte
�(�( 
[
�(�( 
]
�(�( 

�(�( '
;
�(�(' (
}
�(�( 	
[
�(�( 	#
StructLayoutAttribute
�(�(	 
(
�(�( 

LayoutKind
�(�( )
.
�(�() *

Sequential
�(�(* 4
)
�(�(4 5
]
�(�(5 6
public
�(�( 
struct
�(�( &
NET_DVR_ALLSUBSYSTEMINFO
�(�( .
{
�(�( 	
public
�(�( 
uint
�(�( 
dwSize
�(�( 
;
�(�( 
[
�(�( 
MarshalAsAttribute
�(�(
(
�(�(  

�(�(  -
.
�(�(- .

ByValArray
�(�(. 8
,
�(�(8 9
	SizeConst
�(�(: C
=
�(�(D E
MAX_SUBSYSTEM_NUM
�(�(F W
,
�(�(W X
ArraySubType
�(�(Y e
=
�(�(f g

�(�(h u
.
�(�(u v
Struct
�(�(v |
)
�(�(| }
]
�(�(} ~
public
�(�( #
NET_DVR_SUBSYSTEMINFO
�(�( (
[
�(�(( )
]
�(�() *
struSubSystemInfo
�(�(+ <
;
�(�(< =
[
�(�( 
MarshalAsAttribute
�(�(
(
�(�(  

�(�(  -
.
�(�(- .

ByValArray
�(�(. 8
,
�(�(8 9
	SizeConst
�(�(: C
=
�(�(D E
$num
�(�(F G
,
�(�(G H
ArraySubType
�(�(I U
=
�(�(V W

�(�(X e
.
�(�(e f
I1
�(�(f h
)
�(�(h i
]
�(�(i j
public
�(�( 
byte
�(�( 
[
�(�( 
]
�(�( 
byRes
�(�( 
;
�(�(  
}
�(�( 	
[
�(�( 	#
StructLayoutAttribute
�(�(	 
(
�(�( 

LayoutKind
�(�( )
.
�(�() *

Sequential
�(�(* 4
)
�(�(4 5
]
�(�(5 6
public
�(�( 
struct
�(�( %
NET_DVR_LOOPPLAN_SUBCFG
�(�( -
{
�(�( 	
public
�(�( 
uint
�(�( 
dwSize
�(�( 
;
�(�( 
public
�(�( 
uint
�(�( 

dwPoolTime
�(�( "
;
�(�(" #
[
�(�( 
MarshalAsAttribute
�(�(
(
�(�(  

�(�(  -
.
�(�(- .

ByValArray
�(�(. 8
,
�(�(8 9
	SizeConst
�(�(: C
=
�(�(D E 
MAX_CYCLE_CHAN_V30
�(�(F X
,
�(�(X Y
ArraySubType
�(�(Z f
=
�(�(g h

�(�(i v
.
�(�(v w
Struct
�(�(w }
)
�(�(} ~
]
�(�(~ 
public
�(�( *
NET_DVR_MATRIX_CHAN_INFO_V30
�(�( /
[
�(�(/ 0
]
�(�(0 1
struChanConInfo
�(�(2 A
;
�(�(A B
[
�(�( 
MarshalAsAttribute
�(�(
(
�(�(  

�(�(  -
.
�(�(- .

ByValArray
�(�(. 8
,
�(�(8 9
	SizeConst
�(�(: C
=
�(�(D E
$num
�(�(F H
,
�(�(H I
ArraySubType
�(�(J V
=
�(�(W X

�(�(Y f
.
�(�(f g
I1
�(�(g i
)
�(�(i j
]
�(�(j k
public
�(�( 
byte
�(�( 
[
�(�( 
]
�(�( 
byRes
�(�( 
;
�(�(  
}
�(�( 	
[
�(�( 	#
StructLayoutAttribute
�(�(	 
(
�(�( 

LayoutKind
�(�( )
.
�(�() *

Sequential
�(�(* 4
)
�(�(4 5
]
�(�(5 6
public
�)�) 
struct
�)�) "
NET_DVR_ALARMMODECFG
�)�) *
{
�)�) 	
public
�)�) 
uint
�)�) 
dwSize
�)�) 
;
�)�) 
public
�)�) 
byte
�)�) 
byAlarmMode
�)�) #
;
�)�)# $
public
�)�) 
ushort
�)�) 
	wLoopTime
�)�) #
;
�)�)# $
[
�)�) 
MarshalAsAttribute
�)�)
(
�)�)  

�)�)  -
.
�)�)- .

ByValArray
�)�). 8
,
�)�)8 9
	SizeConst
�)�): C
=
�)�)D E
$num
�)�)F G
,
�)�)G H
ArraySubType
�)�)I U
=
�)�)V W

�)�)X e
.
�)�)e f
I1
�)�)f h
)
�)�)h i
]
�)�)i j
public
�)�) 
byte
�)�) 
[
�)�) 
]
�)�) 
byRes
�)�) 
;
�)�)  
}
�)�) 	
[
�)�) 	#
StructLayoutAttribute
�)�)	 
(
�)�) 

LayoutKind
�)�) )
.
�)�)) *

Sequential
�)�)* 4
)
�)�)4 5
]
�)�)5 6
public
�)�) 
struct
�)�) &
NET_DVR_CODESPLITTERINFO
�)�) .
{
�)�) 	
public
�)�) 
uint
�)�) 
dwSize
�)�) 
;
�)�) 
public
�)�) 
NET_DVR_IPADDR
�)�) !
struIP
�)�)" (
;
�)�)( )
public
�)�) 
ushort
�)�) 
wPort
�)�) 
;
�)�)  
[
�)�) 
MarshalAsAttribute
�)�)
(
�)�)  

�)�)  -
.
�)�)- .

ByValArray
�)�). 8
,
�)�)8 9
	SizeConst
�)�): C
=
�)�)D E
$num
�)�)F G
,
�)�)G H
ArraySubType
�)�)I U
=
�)�)V W

�)�)X e
.
�)�)e f
I1
�)�)f h
)
�)�)h i
]
�)�)i j
public
�)�) 
byte
�)�) 
[
�)�) 
]
�)�) 
byRes1
�)�)  
;
�)�)  !
[
�)�) 
MarshalAsAttribute
�)�)
(
�)�)  

�)�)  -
.
�)�)- .

ByValArray
�)�). 8
,
�)�)8 9
	SizeConst
�)�): C
=
�)�)D E
NAME_LEN
�)�)F N
,
�)�)N O
ArraySubType
�)�)P \
=
�)�)] ^

�)�)_ l
.
�)�)l m
I1
�)�)m o
)
�)�)o p
]
�)�)p q
public
�)�) 
byte
�)�) 
[
�)�) 
]
�)�) 
	sUserName
�)�) #
;
�)�)# $
[
�)�) 
MarshalAsAttribute
�)�)
(
�)�)  

�)�)  -
.
�)�)- .

ByValArray
�)�). 8
,
�)�)8 9
	SizeConst
�)�): C
=
�)�)D E

PASSWD_LEN
�)�)F P
,
�)�)P Q
ArraySubType
�)�)R ^
=
�)�)_ `

�)�)a n
.
�)�)n o
I1
�)�)o q
)
�)�)q r
]
�)�)r s
public
�)�) 
byte
�)�) 
[
�)�) 
]
�)�) 
	sPassword
�)�) #
;
�)�)# $
public
�)�) 
byte
�)�) 
byChan
�)�) 
;
�)�) 
public
�)�) 
byte
�)�) 
	by485Port
�)�) !
;
�)�)! "
[
�)�) 
MarshalAsAttribute
�)�)
(
�)�)  

�)�)  -
.
�)�)- .

ByValArray
�)�). 8
,
�)�)8 9
	SizeConst
�)�): C
=
�)�)D E
$num
�)�)F H
,
�)�)H I
ArraySubType
�)�)J V
=
�)�)W X

�)�)Y f
.
�)�)f g
I1
�)�)g i
)
�)�)i j
]
�)�)j k
public
�)�) 
byte
�)�) 
[
�)�) 
]
�)�) 
byRes2
�)�)  
;
�)�)  !
}
�)�) 	
[
�)�) 	#
StructLayoutAttribute
�)�)	 
(
�)�) 

LayoutKind
�)�) )
.
�)�)) *

Sequential
�)�)* 4
)
�)�)4 5
]
�)�)5 6
public
�)�) 
struct
�)�) "
NET_DVR_ASSOCIATECFG
�)�) *
{
�)�) 	
public
�)�) 
byte
�)�) 
byAssociateType
�)�) '
;
�)�)' (
public
�)�) 
ushort
�)�) 
wAlarmDelay
�)�) %
;
�)�)% &
public
�)�) 
byte
�)�) 

byAlarmNum
�)�) "
;
�)�)" #
[
�)�) 
MarshalAsAttribute
�)�)
(
�)�)  

�)�)  -
.
�)�)- .

ByValArray
�)�). 8
,
�)�)8 9
	SizeConst
�)�): C
=
�)�)D E
$num
�)�)F G
,
�)�)G H
ArraySubType
�)�)I U
=
�)�)V W

�)�)X e
.
�)�)e f
I1
�)�)f h
)
�)�)h i
]
�)�)i j
public
�)�) 
byte
�)�) 
[
�)�) 
]
�)�) 
byRes
�)�) 
;
�)�)  
}
�)�) 	
[
�)�) 	#
StructLayoutAttribute
�)�)	 
(
�)�) 

LayoutKind
�)�) )
.
�)�)) *

Sequential
�)�)* 4
)
�)�)4 5
]
�)�)5 6
public
�)�) 
struct
�)�) #
NET_DVR_DYNAMICDECODE
�)�) +
{
�)�) 	
public
�)�) 
uint
�)�) 
dwSize
�)�) 
;
�)�) 
public
�)�) "
NET_DVR_ASSOCIATECFG
�)�) '
struAssociateCfg
�)�)( 8
;
�)�)8 9
public
�)�) #
NET_DVR_PU_STREAM_CFG
�)�) (
struPuStreamCfg
�)�)) 8
;
�)�)8 9
[
�)�) 
MarshalAsAttribute
�)�)
(
�)�)  

�)�)  -
.
�)�)- .

ByValArray
�)�). 8
,
�)�)8 9
	SizeConst
�)�): C
=
�)�)D E
$num
�)�)F G
,
�)�)G H
ArraySubType
�)�)I U
=
�)�)V W

�)�)X e
.
�)�)e f
I1
�)�)f h
)
�)�)h i
]
�)�)i j
public
�)�) 
byte
�)�) 
[
�)�) 
]
�)�) 
byRes
�)�) 
;
�)�)  
}
�)�) 	
[
�)�) 	#
StructLayoutAttribute
�)�)	 
(
�)�) 

LayoutKind
�)�) )
.
�)�)) *

Sequential
�)�)* 4
)
�)�)4 5
]
�)�)5 6
public
�)�) 
struct
�)�) !
NET_DVR_DECODESCHED
�)�) )
{
�)�) 	
public
�)�) 
NET_DVR_SCHEDTIME
�)�) $

�)�)% 2
;
�)�)2 3
public
�)�) 
byte
�)�) 
byDecodeType
�)�) $
;
�)�)$ %
public
�)�) 
byte
�)�) 
byLoopGroup
�)�) #
;
�)�)# $
[
�)�) 
MarshalAsAttribute
�)�)
(
�)�)  

�)�)  -
.
�)�)- .

ByValArray
�)�). 8
,
�)�)8 9
	SizeConst
�)�): C
=
�)�)D E
$num
�)�)F G
,
�)�)G H
ArraySubType
�)�)I U
=
�)�)V W

�)�)X e
.
�)�)e f
I1
�)�)f h
)
�)�)h i
]
�)�)i j
public
�)�) 
byte
�)�) 
[
�)�) 
]
�)�) 
byRes
�)�) 
;
�)�)  
public
�)�) #
NET_DVR_PU_STREAM_CFG
�)�) (
struDynamicDec
�)�)) 7
;
�)�)7 8
}
�)�) 	
[
�)�) 	#
StructLayoutAttribute
�)�)	 
(
�)�) 

LayoutKind
�)�) )
.
�)�)) *

Sequential
�)�)* 4
)
�)�)4 5
]
�)�)5 6
public
�)�) 
struct
�)�)  
NET_DVR_PLANDECODE
�)�) (
{
�)�) 	
public
�)�) 
uint
�)�) 
dwSize
�)�) 
;
�)�) 
[
�)�) 
MarshalAsAttribute
�)�)
(
�)�)  

�)�)  -
.
�)�)- .

ByValArray
�)�). 8
,
�)�)8 9
	SizeConst
�)�): C
=
�)�)D E
MAX_DAYS
�)�)F N
*
�)�)O P 
DECODE_TIMESEGMENT
�)�)Q c
,
�)�)c d
ArraySubType
�)�)e q
=
�)�)r s

.�)�)� �
I1�)�)� �
)�)�)� �
]�)�)� �
public
�)�) !
NET_DVR_DECODESCHED
�)�) &
[
�)�)& '
]
�)�)' (
struDecodeSched
�)�)) 8
;
�)�)8 9
[
�)�) 
MarshalAsAttribute
�)�)
(
�)�)  

�)�)  -
.
�)�)- .

ByValArray
�)�). 8
,
�)�)8 9
	SizeConst
�)�): C
=
�)�)D E
$num
�)�)F G
,
�)�)G H
ArraySubType
�)�)I U
=
�)�)V W

�)�)X e
.
�)�)e f
I1
�)�)f h
)
�)�)h i
]
�)�)i j
public
�)�) 
byte
�)�) 
[
�)�) 
]
�)�) 
byres
�)�) 
;
�)�)  
}
�)�) 	
[
�)�) 	#
StructLayoutAttribute
�)�)	 
(
�)�) 

LayoutKind
�)�) )
.
�)�)) *

Sequential
�)�)* 4
)
�)�)4 5
]
�)�)5 6
public
�)�) 
struct
�)�) +
NET_DVR_VIDEOPLATFORM_ABILITY
�)�) 3
{
�)�) 	
public
�)�) 
uint
�)�) 
dwSize
�)�) 
;
�)�) 
public
�)�) 
byte
�)�) !
byCodeSubSystemNums
�)�) +
;
�)�)+ ,
public
�)�) 
byte
�)�) #
byDecodeSubSystemNums
�)�) -
;
�)�)- .
[
�)�) 
System
�)�)
.
�)�) 
Runtime
�)�) 
.
�)�) 
InteropServices
�)�) +
.
�)�)+ , 
MarshalAsAttribute
�)�), >
(
�)�)> ?
System
�)�)? E
.
�)�)E F
Runtime
�)�)F M
.
�)�)M N
InteropServices
�)�)N ]
.
�)�)] ^

�)�)^ k
.
�)�)k l

ByValArray
�)�)l v
,
�)�)v w
	SizeConst�)�)x �
=�)�)� �
$num�)�)� �
,�)�)� �
ArraySubType�)�)� �
=�)�)� �
System�)�)� �
.�)�)� �
Runtime�)�)� �
.�)�)� �
InteropServices�)�)� �
.�)�)� �

.�)�)� �
I1�)�)� �
)�)�)� �
]�)�)� �
public
�)�) 
byte
�)�) 
[
�)�) 
]
�)�) 
byWindowMode
�)�) &
;
�)�)& '
[
�)�) 
System
�)�)
.
�)�) 
Runtime
�)�) 
.
�)�) 
InteropServices
�)�) +
.
�)�)+ , 
MarshalAsAttribute
�)�), >
(
�)�)> ?
System
�)�)? E
.
�)�)E F
Runtime
�)�)F M
.
�)�)M N
InteropServices
�)�)N ]
.
�)�)] ^

�)�)^ k
.
�)�)k l

ByValArray
�)�)l v
,
�)�)v w
	SizeConst�)�)x �
=�)�)� �
$num�)�)� �
,�)�)� �
ArraySubType�)�)� �
=�)�)� �
System�)�)� �
.�)�)� �
Runtime�)�)� �
.�)�)� �
InteropServices�)�)� �
.�)�)� �

.�)�)� �
I1�)�)� �
)�)�)� �
]�)�)� �
public
�)�) 
byte
�)�) 
[
�)�) 
]
�)�) 
byRes
�)�) 
;
�)�)  
}
�)�) 	
[
�)�) 	#
StructLayoutAttribute
�)�)	 
(
�)�) 

LayoutKind
�)�) )
.
�)�)) *

Sequential
�)�)* 4
)
�)�)4 5
]
�)�)5 6
public
�)�) 
struct
�)�) '
NET_DVR_SUBSYSTEM_ABILITY
�)�) /
{
�)�) 	
public
�)�) 
byte
�)�) 
bySubSystemType
�)�) '
;
�)�)' (
public
�)�) 
byte
�)�) 
	byChanNum
�)�) !
;
�)�)! "
public
�)�) 
byte
�)�) 
byStartChan
�)�) #
;
�)�)# $
public
�)�) 
byte
�)�) 
	bySlotNum
�)�) !
;
�)�)! "
[
�)�) 
MarshalAsAttribute
�)�)
(
�)�)  

�)�)  -
.
�)�)- .

ByValArray
�)�). 8
,
�)�)8 9
	SizeConst
�)�): C
=
�)�)D E
$num
�)�)F G
,
�)�)G H
ArraySubType
�)�)I U
=
�)�)V W

�)�)X e
.
�)�)e f
I1
�)�)f h
)
�)�)h i
]
�)�)i j
public
�)�) 
byte
�)�) 
[
�)�) 
]
�)�) 
byRes1
�)�)  
;
�)�)  !
public
�)�) &
struDecoderSystemAbility
�)�) +
_struAbility
�)�), 8
;
�)�)8 9
}
�)�) 	
[
�)�) 	#
StructLayoutAttribute
�)�)	 
(
�)�) 

LayoutKind
�)�) )
.
�)�)) *

Sequential
�)�)* 4
)
�)�)4 5
]
�)�)5 6
public
�)�) 
struct
�)�) &
struDecoderSystemAbility
�)�) .
{
�)�) 	
public
�)�) 
byte
�)�) 
	byVGANums
�)�) !
;
�)�)! "
public
�)�) 
byte
�)�) 
	byBNCNums
�)�) !
;
�)�)! "
public
�)�) 
byte
�)�) 

byHDMINums
�)�) "
;
�)�)" #
public
�)�) 
byte
�)�) 
	byDVINums
�)�) !
;
�)�)! "
public
�)�) 
byte
�)�) 
byLayerNums
�)�) #
;
�)�)# $
public
�)�) 
byte
�)�) 
	bySpartan
�)�) !
;
�)�)! "
public
�)�) 
byte
�)�) 
	byDecType
�)�) !
;
�)�)! "
public
�)�) 
byte
�)�) 
byOutputSwitch
�)�) &
;
�)�)& '
[
�)�) 
MarshalAsAttribute
�)�)
(
�)�)  

�)�)  -
.
�)�)- .

ByValArray
�)�). 8
,
�)�)8 9
	SizeConst
�)�): C
=
�)�)D E
$num
�)�)F H
,
�)�)H I
ArraySubType
�)�)J V
=
�)�)W X

�)�)Y f
.
�)�)f g
I1
�)�)g i
)
�)�)i j
]
�)�)j k
public
�)�) 
byte
�)�) 
[
�)�) 
]
�)�) 
byRes1
�)�)  
;
�)�)  !
public
�)�) 
byte
�)�) 

�)�) %
;
�)�)% &
[
�)�) 
MarshalAsAttribute
�)�)
(
�)�)  

�)�)  -
.
�)�)- .

ByValArray
�)�). 8
,
�)�)8 9
	SizeConst
�)�): C
=
�)�)D E
$num
�)�)F I
,
�)�)I J
ArraySubType
�)�)K W
=
�)�)X Y

�)�)Z g
.
�)�)g h
I1
�)�)h j
)
�)�)j k
]
�)�)k l
public
�)�) 
byte
�)�) 
[
�)�) 
]
�)�) 
byRes2
�)�)  
;
�)�)  !
}
�)�) 	
[
�)�) 	#
StructLayoutAttribute
�)�)	 
(
�)�) 

LayoutKind
�)�) )
.
�)�)) *

Sequential
�)�)* 4
)
�)�)4 5
]
�)�)5 6
public
�)�) 
struct
�)�) 
struAbility
�)�) !
{
�)�) 	
[
�)�) 
MarshalAsAttribute
�)�)
(
�)�)  

�)�)  -
.
�)�)- .

ByValArray
�)�). 8
,
�)�)8 9
	SizeConst
�)�): C
=
�)�)D E
$num
�)�)F I
,
�)�)I J
ArraySubType
�)�)K W
=
�)�)X Y

�)�)Z g
.
�)�)g h
I1
�)�)h j
)
�)�)j k
]
�)�)k l
public
�)�) 
byte
�)�) 
[
�)�) 
]
�)�) 
byRes
�)�) 
;
�)�)  
}
�)�) 	
[
�)�) 	#
StructLayoutAttribute
�)�)	 
(
�)�) 

LayoutKind
�)�) )
.
�)�)) *

Sequential
�)�)* 4
)
�)�)4 5
]
�)�)5 6
public
�)�) 
struct
�)�) /
!NET_DVR_VIDEOPLATFORM_ABILITY_V40
�)�) 7
{
�)�) 	
public
�)�) 
uint
�)�) 
dwSize
�)�) 
;
�)�) 
public
�)�) 
byte
�)�) !
byCodeSubSystemNums
�)�) +
;
�)�)+ ,
public
�)�) 
byte
�)�) #
byDecodeSubSystemNums
�)�) -
;
�)�)- .
public
�)�) 
byte
�)�) 
bySupportNat
�)�) $
;
�)�)$ %
public
�)�) 
byte
�)�) "
byInputSubSystemNums
�)�) ,
;
�)�), -
public
�*�* 
byte
�*�* #
byOutputSubSystemNums
�*�* -
;
�*�*- .
public
�*�* 
byte
�*�* (
byCodeSpitterSubSystemNums
�*�* 2
;
�*�*2 3
public
�*�* 
byte
�*�* &
byAlarmHostSubSystemNums
�*�* 0
;
�*�*0 1
public
�*�* 
byte
�*�* #
bySupportBigScreenNum
�*�* -
;
�*�*- .
public
�*�* 
byte
�*�*  
byVCASubSystemNums
�*�* *
;
�*�** +
public
�*�* 
byte
�*�* 
byV6SubSystemNums
�*�* )
;
�*�*) *
public
�*�* 
byte
�*�* &
byV6DecoderSubSystemNums
�*�* 0
;
�*�*0 1
public
�*�* 
byte
�*�* !
bySupportBigScreenX
�*�* +
;
�*�*+ ,
public
�*�* 
byte
�*�* !
bySupportBigScreenY
�*�* +
;
�*�*+ ,
public
�*�* 
byte
�*�*  
bySupportSceneNums
�*�* *
;
�*�** +
public
�*�* 
byte
�*�* "
byVcaSupportChanMode
�*�* ,
;
�*�*, -
public
�*�* 
byte
�*�* !
bySupportScreenNums
�*�* +
;
�*�*+ ,
public
�*�* 
byte
�*�*  
bySupportLayerNums
�*�* *
;
�*�** +
public
�*�* 
byte
�*�* !
byNotSupportPreview
�*�* +
;
�*�*+ ,
public
�*�* 
byte
�*�* !
byNotSupportStorage
�*�* +
;
�*�*+ ,
public
�*�* 
byte
�*�* 
byUploadLogoMode
�*�* (
;
�*�*( )
[
�*�* 
MarshalAsAttribute
�*�*
(
�*�*  

�*�*  -
.
�*�*- .

ByValArray
�*�*. 8
,
�*�*8 9
	SizeConst
�*�*: C
=
�*�*D E#
MAX_SUBSYSTEM_NUM_V40
�*�*F [
,
�*�*[ \
ArraySubType
�*�*] i
=
�*�*j k

�*�*l y
.
�*�*y z
Struct�*�*z �
)�*�*� �
]�*�*� �
public
�*�* '
NET_DVR_SUBSYSTEM_ABILITY
�*�* ,
[
�*�*, -
]
�*�*- ."
struSubSystemAbility
�*�*/ C
;
�*�*C D
public
�*�* 
byte
�*�* 
	by485Nums
�*�* !
;
�*�*! "
public
�*�* 
byte
�*�* 
	by232Nums
�*�* !
;
�*�*! "
public
�*�* 
byte
�*�* 
bySerieStartChan
�*�* (
;
�*�*( )
public
�*�* 
byte
�*�* 
byScreenMode
�*�* $
;
�*�*$ %
public
�*�* 
byte
�*�* 
byDevVersion
�*�* $
;
�*�*$ %
public
�*�* 
byte
�*�* "
bySupportBaseMapNums
�*�* ,
;
�*�*, -
public
�*�* 
ushort
�*�* 
wBaseLengthX
�*�* &
;
�*�*& '
public
�*�* 
ushort
�*�* 
wBaseLengthY
�*�* &
;
�*�*& '
public
�*�* 
byte
�*�* #
bySupportPictureTrans
�*�* -
;
�*�*- .
public
�*�* 
byte
�*�* "
bySupportPreAllocDec
�*�* ,
;
�*�*, -
[
�*�* 
MarshalAsAttribute
�*�*
(
�*�*  

�*�*  -
.
�*�*- .

ByValArray
�*�*. 8
,
�*�*8 9
	SizeConst
�*�*: C
=
�*�*D E
$num
�*�*F I
,
�*�*I J
ArraySubType
�*�*K W
=
�*�*X Y

�*�*Z g
.
�*�*g h
I1
�*�*h j
)
�*�*j k
]
�*�*k l
public
�*�* 
byte
�*�* 
[
�*�* 
]
�*�* 
byRes2
�*�*  
;
�*�*  !
}
�*�* 	
[
�*�* 	#
StructLayoutAttribute
�*�*	 
(
�*�* 

LayoutKind
�*�* )
.
�*�*) *

Sequential
�*�** 4
)
�*�*4 5
]
�*�*5 6
public
�*�* 
struct
�*�* %
NET_DVR_SINGLESCREENCFG
�*�* -
{
�*�* 	
public
�*�* 
byte
�*�* 
byScreenSeq
�*�* #
;
�*�*# $
public
�*�* 
byte
�*�* 
bySubSystemNum
�*�* &
;
�*�*& '
public
�*�* 
byte
�*�* 
	byDispNum
�*�* !
;
�*�*! "
[
�*�* 
MarshalAsAttribute
�*�*
(
�*�*  

�*�*  -
.
�*�*- .

ByValArray
�*�*. 8
,
�*�*8 9
	SizeConst
�*�*: C
=
�*�*D E
$num
�*�*F G
,
�*�*G H
ArraySubType
�*�*I U
=
�*�*V W

�*�*X e
.
�*�*e f
I1
�*�*f h
)
�*�*h i
]
�*�*i j
public
�*�* 
byte
�*�* 
[
�*�* 
]
�*�* 
byRes
�*�* 
;
�*�*  
}
�*�* 	
[
�*�* 	#
StructLayoutAttribute
�*�*	 
(
�*�* 

LayoutKind
�*�* )
.
�*�*) *

Sequential
�*�** 4
)
�*�*4 5
]
�*�*5 6
public
�*�* 
struct
�*�* "
NET_DVR_BIGSCREENCFG
�*�* *
{
�*�* 	
public
�*�* 
uint
�*�* 
dwSize
�*�* 
;
�*�* 
public
�*�* 
byte
�*�* 
byEnable
�*�*  
;
�*�*  !
public
�*�* 
byte
�*�* 
byModeX
�*�* 
;
�*�*  
public
�*�* 
byte
�*�* 
byModeY
�*�* 
;
�*�*  
public
�*�* 
byte
�*�*  
byMainDecodeSystem
�*�* *
;
�*�** +
public
�*�* 
byte
�*�* #
byMainDecoderDispChan
�*�* -
;
�*�*- .
public
�*�* 
byte
�*�* 
byVideoStandard
�*�* '
;
�*�*' (
[
�*�* 
MarshalAsAttribute
�*�*
(
�*�*  

�*�*  -
.
�*�*- .

ByValArray
�*�*. 8
,
�*�*8 9
	SizeConst
�*�*: C
=
�*�*D E
$num
�*�*F G
,
�*�*G H
ArraySubType
�*�*I U
=
�*�*V W

�*�*X e
.
�*�*e f
I1
�*�*f h
)
�*�*h i
]
�*�*i j
public
�*�* 
byte
�*�* 
[
�*�* 
]
�*�* 
byRes1
�*�*  
;
�*�*  !
public
�*�* 
uint
�*�* 
dwResolution
�*�* $
;
�*�*$ %
[
�*�* 
MarshalAsAttribute
�*�*
(
�*�*  

�*�*  -
.
�*�*- .

ByValArray
�*�*. 8
,
�*�*8 9
	SizeConst
�*�*: C
=
�*�*D E
MAX_BIGSCREENNUM
�*�*F V
,
�*�*V W
ArraySubType
�*�*X d
=
�*�*e f

�*�*g t
.
�*�*t u
Struct
�*�*u {
)
�*�*{ |
]
�*�*| }
public
�*�* %
NET_DVR_SINGLESCREENCFG
�*�* *
[
�*�** +
]
�*�*+ ,$
struFollowSingleScreen
�*�*- C
;
�*�*C D
public
�*�* 
ushort
�*�* 
wBigScreenX
�*�* %
;
�*�*% &
public
�*�* 
ushort
�*�* 
wBigScreenY
�*�* %
;
�*�*% &
[
�*�* 
MarshalAsAttribute
�*�*
(
�*�*  

�*�*  -
.
�*�*- .

ByValArray
�*�*. 8
,
�*�*8 9
	SizeConst
�*�*: C
=
�*�*D E
$num
�*�*F H
,
�*�*H I
ArraySubType
�*�*J V
=
�*�*W X

�*�*Y f
.
�*�*f g
I1
�*�*g i
)
�*�*i j
]
�*�*j k
public
�*�* 
byte
�*�* 
[
�*�* 
]
�*�* 
byRes2
�*�*  
;
�*�*  !
public
�*�* 
void
�*�* 
Init
�*�* 
(
�*�* 
)
�*�* 
{
�*�* 
byRes1
�*�* 
=
�*�* 
new
�*�* 
byte
�*�* !
[
�*�*! "
$num
�*�*" #
]
�*�*# $
;
�*�*$ %$
struFollowSingleScreen
�*�* &
=
�*�*' (
new
�*�*) ,%
NET_DVR_SINGLESCREENCFG
�*�*- D
[
�*�*D E
MAX_BIGSCREENNUM
�*�*E U
]
�*�*U V
;
�*�*V W
byRes2
�*�* 
=
�*�* 
new
�*�* 
byte
�*�* !
[
�*�*! "
$num
�*�*" $
]
�*�*$ %
;
�*�*% &
}
�*�* 
}
�*�* 	
[
�*�* 	#
StructLayoutAttribute
�*�*	 
(
�*�* 

LayoutKind
�*�* )
.
�*�*) *

Sequential
�*�** 4
,
�*�*4 5
CharSet
�*�*6 =
=
�*�*> ?
CharSet
�*�*@ G
.
�*�*G H
Ansi
�*�*H L
)
�*�*L M
]
�*�*M N
public
�*�* 
struct
�*�* 
NET_DVR_EMAILCFG
�*�* &
{
�*�* 	
public
�*�* 
uint
�*�* 
dwSize
�*�* 
;
�*�* 
[
�*�* 
MarshalAsAttribute
�*�*
(
�*�*  

�*�*  -
.
�*�*- .
	ByValTStr
�*�*. 7
,
�*�*7 8
	SizeConst
�*�*9 B
=
�*�*C D
$num
�*�*E G
)
�*�*G H
]
�*�*H I
public
�*�* 
string
�*�* 
	sUserName
�*�* #
;
�*�*# $
[
�*�* 
MarshalAsAttribute
�*�*
(
�*�*  

�*�*  -
.
�*�*- .
	ByValTStr
�*�*. 7
,
�*�*7 8
	SizeConst
�*�*9 B
=
�*�*C D
$num
�*�*E G
)
�*�*G H
]
�*�*H I
public
�*�* 
string
�*�* 
	sPassWord
�*�* #
;
�*�*# $
[
�*�* 
MarshalAsAttribute
�*�*
(
�*�*  

�*�*  -
.
�*�*- .
	ByValTStr
�*�*. 7
,
�*�*7 8
	SizeConst
�*�*9 B
=
�*�*C D
$num
�*�*E G
)
�*�*G H
]
�*�*H I
public
�*�* 
string
�*�* 
	sFromName
�*�* #
;
�*�*# $
[
�*�* 
MarshalAsAttribute
�*�*
(
�*�*  

�*�*  -
.
�*�*- .
	ByValTStr
�*�*. 7
,
�*�*7 8
	SizeConst
�*�*9 B
=
�*�*C D
$num
�*�*E G
)
�*�*G H
]
�*�*H I
public
�*�* 
string
�*�* 
	sFromAddr
�*�* #
;
�*�*# $
[
�*�* 
MarshalAsAttribute
�*�*
(
�*�*  

�*�*  -
.
�*�*- .
	ByValTStr
�*�*. 7
,
�*�*7 8
	SizeConst
�*�*9 B
=
�*�*C D
$num
�*�*E G
)
�*�*G H
]
�*�*H I
public
�*�* 
string
�*�* 
sToName1
�*�* "
;
�*�*" #
[
�*�* 
MarshalAsAttribute
�*�*
(
�*�*  

�*�*  -
.
�*�*- .
	ByValTStr
�*�*. 7
,
�*�*7 8
	SizeConst
�*�*9 B
=
�*�*C D
$num
�*�*E G
)
�*�*G H
]
�*�*H I
public
�*�* 
string
�*�* 
sToName2
�*�* "
;
�*�*" #
[
�*�* 
MarshalAsAttribute
�*�*
(
�*�*  

�*�*  -
.
�*�*- .
	ByValTStr
�*�*. 7
,
�*�*7 8
	SizeConst
�*�*9 B
=
�*�*C D
$num
�*�*E G
)
�*�*G H
]
�*�*H I
public
�*�* 
string
�*�* 
sToAddr1
�*�* "
;
�*�*" #
[
�*�* 
MarshalAsAttribute
�*�*
(
�*�*  

�*�*  -
.
�*�*- .
	ByValTStr
�*�*. 7
,
�*�*7 8
	SizeConst
�*�*9 B
=
�*�*C D
$num
�*�*E G
)
�*�*G H
]
�*�*H I
public
�*�* 
string
�*�* 
sToAddr2
�*�* "
;
�*�*" #
[
�*�* 
MarshalAsAttribute
�*�*
(
�*�*  

�*�*  -
.
�*�*- .
	ByValTStr
�*�*. 7
,
�*�*7 8
	SizeConst
�*�*9 B
=
�*�*C D
$num
�*�*E G
)
�*�*G H
]
�*�*H I
public
�*�* 
string
�*�* 
sEmailServer
�*�* &
;
�*�*& '
public
�*�* 
byte
�*�* 
byServerType
�*�* $
;
�*�*$ %
public
�*�* 
byte
�*�* 
byUseAuthen
�*�* #
;
�*�*# $
public
�*�* 
byte
�*�* 
byAttachment
�*�* $
;
�*�*$ %
public
�*�* 
byte
�*�* 
byMailinterval
�*�* &
;
�*�*& '
}
�*�* 	
[
�*�* 	#
StructLayoutAttribute
�*�*	 
(
�*�* 

LayoutKind
�*�* )
.
�*�*) *

Sequential
�*�** 4
)
�*�*4 5
]
�*�*5 6
public
�*�* 
struct
�*�* (
NET_DVR_COMPRESSIONCFG_NEW
�*�* 0
{
�*�* 	
public
�*�* 
uint
�*�* 
dwSize
�*�* 
;
�*�* 
public
�*�* )
NET_DVR_COMPRESSION_INFO_EX
�*�* . 
struLowCompression
�*�*/ A
;
�*�*A B
public
�*�* )
NET_DVR_COMPRESSION_INFO_EX
�*�* ."
struEventCompression
�*�*/ C
;
�*�*C D
}
�*�* 	
[
�*�* 	#
StructLayoutAttribute
�*�*	 
(
�*�* 

LayoutKind
�*�* )
.
�*�*) *

Sequential
�*�** 4
)
�*�*4 5
]
�*�*5 6
public
�*�* 
struct
�*�* 
NET_DVR_PTZPOS
�*�* $
{
�*�* 	
public
�*�* 
ushort
�*�* 
wAction
�*�* !
;
�*�*! "
public
�*�* 
ushort
�*�* 
wPanPos
�*�* !
;
�*�*! "
public
�*�* 
ushort
�*�* 
wTiltPos
�*�* "
;
�*�*" #
public
�*�* 
ushort
�*�* 
wZoomPos
�*�* "
;
�*�*" #
}
�*�* 	
[
�*�* 	#
StructLayoutAttribute
�*�*	 
(
�*�* 

LayoutKind
�*�* )
.
�*�*) *

Sequential
�*�** 4
)
�*�*4 5
]
�*�*5 6
public
�*�* 
struct
�*�* 
NET_DVR_PTZSCOPE
�*�* &
{
�*�* 	
public
�*�* 
ushort
�*�* 

wPanPosMin
�*�* $
;
�*�*$ %
public
�*�* 
ushort
�*�* 

wPanPosMax
�*�* $
;
�*�*$ %
public
�*�* 
ushort
�*�* 
wTiltPosMin
�*�* %
;
�*�*% &
public
�*�* 
ushort
�*�* 
wTiltPosMax
�*�* %
;
�*�*% &
public
�+�+ 
ushort
�+�+ 
wZoomPosMin
�+�+ %
;
�+�+% &
public
�+�+ 
ushort
�+�+ 
wZoomPosMax
�+�+ %
;
�+�+% &
}
�+�+ 	
[
�+�+ 	#
StructLayoutAttribute
�+�+	 
(
�+�+ 

LayoutKind
�+�+ )
.
�+�+) *

Sequential
�+�+* 4
)
�+�+4 5
]
�+�+5 6
public
�+�+ 
struct
�+�+ 
NET_DVR_RTSPCFG
�+�+ %
{
�+�+ 	
public
�+�+ 
uint
�+�+ 
dwSize
�+�+ 
;
�+�+ 
public
�+�+ 
ushort
�+�+ 
wPort
�+�+ 
;
�+�+  
[
�+�+ 
MarshalAsAttribute
�+�+
(
�+�+  

�+�+  -
.
�+�+- .

ByValArray
�+�+. 8
,
�+�+8 9
	SizeConst
�+�+: C
=
�+�+D E
$num
�+�+F H
,
�+�+H I
ArraySubType
�+�+J V
=
�+�+W X

�+�+Y f
.
�+�+f g
I1
�+�+g i
)
�+�+i j
]
�+�+j k
public
�+�+ 
byte
�+�+ 
[
�+�+ 
]
�+�+ 
	byReserve
�+�+ #
;
�+�+# $
}
�+�+ 	
[
�+�+ 	#
StructLayoutAttribute
�+�+	 
(
�+�+ 

LayoutKind
�+�+ )
.
�+�+) *

Sequential
�+�+* 4
)
�+�+4 5
]
�+�+5 6
public
�+�+ 
struct
�+�+  
NET_DVR_DEVICEINFO
�+�+ (
{
�+�+ 	
[
�+�+ 
MarshalAsAttribute
�+�+
(
�+�+  

�+�+  -
.
�+�+- .

ByValArray
�+�+. 8
,
�+�+8 9
	SizeConst
�+�+: C
=
�+�+D E
SERIALNO_LEN
�+�+F R
,
�+�+R S
ArraySubType
�+�+T `
=
�+�+a b

�+�+c p
.
�+�+p q
I1
�+�+q s
)
�+�+s t
]
�+�+t u
public
�+�+ 
byte
�+�+ 
[
�+�+ 
]
�+�+ 

�+�+ '
;
�+�+' (
public
�+�+ 
byte
�+�+ 
byAlarmInPortNum
�+�+ (
;
�+�+( )
public
�+�+ 
byte
�+�+ 
byAlarmOutPortNum
�+�+ )
;
�+�+) *
public
�+�+ 
byte
�+�+ 
	byDiskNum
�+�+ !
;
�+�+! "
public
�+�+ 
byte
�+�+ 
	byDVRType
�+�+ !
;
�+�+! "
public
�+�+ 
byte
�+�+ 
	byChanNum
�+�+ !
;
�+�+! "
public
�+�+ 
byte
�+�+ 
byStartChan
�+�+ #
;
�+�+# $
}
�+�+ 	
[
�+�+ 	#
StructLayoutAttribute
�+�+	 
(
�+�+ 

LayoutKind
�+�+ )
.
�+�+) *

Sequential
�+�+* 4
)
�+�+4 5
]
�+�+5 6
public
�+�+ 
struct
�+�+ $
NET_DVR_DEVICEINFO_V30
�+�+ ,
{
�+�+ 	
[
�+�+ 
MarshalAsAttribute
�+�+
(
�+�+  

�+�+  -
.
�+�+- .

ByValArray
�+�+. 8
,
�+�+8 9
	SizeConst
�+�+: C
=
�+�+D E
SERIALNO_LEN
�+�+F R
,
�+�+R S
ArraySubType
�+�+T `
=
�+�+a b

�+�+c p
.
�+�+p q
I1
�+�+q s
)
�+�+s t
]
�+�+t u
public
�+�+ 
byte
�+�+ 
[
�+�+ 
]
�+�+ 

�+�+ '
;
�+�+' (
public
�+�+ 
byte
�+�+ 
byAlarmInPortNum
�+�+ (
;
�+�+( )
public
�+�+ 
byte
�+�+ 
byAlarmOutPortNum
�+�+ )
;
�+�+) *
public
�+�+ 
byte
�+�+ 
	byDiskNum
�+�+ !
;
�+�+! "
public
�+�+ 
byte
�+�+ 
	byDVRType
�+�+ !
;
�+�+! "
public
�+�+ 
byte
�+�+ 
	byChanNum
�+�+ !
;
�+�+! "
public
�+�+ 
byte
�+�+ 
byStartChan
�+�+ #
;
�+�+# $
public
�+�+ 
byte
�+�+ 
byAudioChanNum
�+�+ &
;
�+�+& '
public
�+�+ 
byte
�+�+ 
byIPChanNum
�+�+ #
;
�+�+# $
public
�+�+ 
byte
�+�+ 

�+�+ %
;
�+�+% &
public
�+�+ 
byte
�+�+ 
byMainProto
�+�+ #
;
�+�+# $
public
�+�+ 
byte
�+�+ 

bySubProto
�+�+ "
;
�+�+" #
public
�+�+ 
byte
�+�+ 
	bySupport
�+�+ !
;
�+�+! "
public
�+�+ 
byte
�+�+ 

bySupport1
�+�+ "
;
�+�+" #
public
�+�+ 
byte
�+�+ 

bySupport2
�+�+ "
;
�+�+" #
public
�+�+ 
ushort
�+�+ 
wDevType
�+�+ "
;
�+�+" #
public
�+�+ 
byte
�+�+ 

bySupport3
�+�+ "
;
�+�+" #
public
�+�+ 
byte
�+�+  
byMultiStreamProto
�+�+ *
;
�+�+* +
public
�+�+ 
byte
�+�+ 
byStartDChan
�+�+ $
;
�+�+$ %
public
�+�+ 
byte
�+�+ 
byStartDTalkChan
�+�+ (
;
�+�+( )
public
�+�+ 
byte
�+�+ 
byHighDChanNum
�+�+ &
;
�+�+& '
public
�+�+ 
byte
�+�+ 

bySupport4
�+�+ "
;
�+�+" #
public
�+�+ 
byte
�+�+ 
byLanguageType
�+�+ &
;
�+�+& '
[
�+�+ 
MarshalAsAttribute
�+�+
(
�+�+  

�+�+  -
.
�+�+- .

ByValArray
�+�+. 8
,
�+�+8 9
	SizeConst
�+�+: C
=
�+�+D E
$num
�+�+F G
,
�+�+G H
ArraySubType
�+�+I U
=
�+�+V W

�+�+X e
.
�+�+e f
I1
�+�+f h
)
�+�+h i
]
�+�+i j
public
�+�+ 
byte
�+�+ 
[
�+�+ 
]
�+�+ 
byRes2
�+�+  
;
�+�+  !
}
�+�+ 	
public
�+�+ 
enum
�+�+ %
SDK_NETWORK_ENVIRONMENT
�+�+ +
{
�+�+ 	 
LOCAL_AREA_NETWORK
�+�+ 
=
�+�+  
$num
�+�+! "
,
�+�+" #
WIDE_AREA_NETWORK
�+�+ 
,
�+�+ 
}
�+�+ 	
public
�+�+ 
enum
�+�+ 
DISPLAY_MODE
�+�+  
{
�+�+ 	

NORMALMODE
�+�+ 
=
�+�+ 
$num
�+�+ 
,
�+�+ 
OVERLAYMODE
�+�+ 
}
�+�+ 	
public
�+�+ 
enum
�+�+ 
	SEND_MODE
�+�+ 
{
�+�+ 	
PTOPTCPMODE
�+�+ 
=
�+�+ 
$num
�+�+ 
,
�+�+ 
PTOPUDPMODE
�+�+ 
,
�+�+ 
	MULTIMODE
�+�+ 
,
�+�+ 
RTPMODE
�+�+ 
,
�+�+ 
RESERVEDMODE
�+�+ 
}
�,�, 	
public
�,�, 
enum
�,�, 
CAPTURE_MODE
�,�,  
{
�,�, 	
BMP_MODE
�,�, 
=
�,�, 
$num
�,�, 
,
�,�, 
	JPEG_MODE
�,�, 
=
�,�, 
$num
�,�, 
}
�,�, 	
public
�,�, 
enum
�,�, 
REALSOUND_MODE
�,�, "
{
�,�, 	
MONOPOLIZE_MODE
�,�, 
=
�,�, 
$num
�,�, 
,
�,�,  

SHARE_MODE
�,�, 
=
�,�, 
$num
�,�, 
}
�,�, 	
public
�,�, 
struct
�,�,  
NET_DVR_CLIENTINFO
�,�, (
{
�,�, 	
public
�,�, 
Int32
�,�, 
lChannel
�,�, !
;
�,�,! "
public
�,�, 
Int32
�,�, 
	lLinkMode
�,�, "
;
�,�," #
public
�,�, 
IntPtr
�,�, 
hPlayWnd
�,�, "
;
�,�," #
public
�,�, 
string
�,�, 
sMultiCastIP
�,�, &
;
�,�,& '
}
�,�, 	
[
�,�, 	#
StructLayoutAttribute
�,�,	 
(
�,�, 

LayoutKind
�,�, )
.
�,�,) *

Sequential
�,�,* 4
)
�,�,4 5
]
�,�,5 6
public
�,�, 
struct
�,�, 
NET_DVR_SDKSTATE
�,�, &
{
�,�, 	
public
�,�, 
uint
�,�, 
dwTotalLoginNum
�,�, '
;
�,�,' (
public
�,�, 
uint
�,�,  
dwTotalRealPlayNum
�,�, *
;
�,�,* +
public
�,�, 
uint
�,�,  
dwTotalPlayBackNum
�,�, *
;
�,�,* +
public
�,�, 
uint
�,�, !
dwTotalAlarmChanNum
�,�, +
;
�,�,+ ,
public
�,�, 
uint
�,�, 
dwTotalFormatNum
�,�, (
;
�,�,( )
public
�,�, 
uint
�,�, "
dwTotalFileSearchNum
�,�, ,
;
�,�,, -
public
�,�, 
uint
�,�, !
dwTotalLogSearchNum
�,�, +
;
�,�,+ ,
public
�,�, 
uint
�,�, 
dwTotalSerialNum
�,�, (
;
�,�,( )
public
�,�, 
uint
�,�, 
dwTotalUpgradeNum
�,�, )
;
�,�,) *
public
�,�, 
uint
�,�,  
dwTotalVoiceComNum
�,�, *
;
�,�,* +
public
�,�, 
uint
�,�, !
dwTotalBroadCastNum
�,�, +
;
�,�,+ ,
public
�,�, 
uint
�,�, 
dwTotalListenNum
�,�, (
;
�,�,( )
public
�,�, 
uint
�,�, 
dwEmailTestNum
�,�, &
;
�,�,& '
public
�,�, 
uint
�,�, 
dwBackupNum
�,�, #
;
�,�,# $
public
�,�, 
uint
�,�, %
dwTotalInquestUploadNum
�,�, /
;
�,�,/ 0
[
�,�, 
MarshalAsAttribute
�,�,
(
�,�,  

�,�,  -
.
�,�,- .

ByValArray
�,�,. 8
,
�,�,8 9
	SizeConst
�,�,: C
=
�,�,D E
$num
�,�,F G
,
�,�,G H
ArraySubType
�,�,I U
=
�,�,V W

�,�,X e
.
�,�,e f
U4
�,�,f h
)
�,�,h i
]
�,�,i j
public
�,�, 
uint
�,�, 
[
�,�, 
]
�,�, 
dwRes
�,�, 
;
�,�,  
}
�,�, 	
[
�,�, 	#
StructLayoutAttribute
�,�,	 
(
�,�, 

LayoutKind
�,�, )
.
�,�,) *

Sequential
�,�,* 4
)
�,�,4 5
]
�,�,5 6
public
�,�, 
struct
�,�, 
NET_DVR_SDKABL
�,�, $
{
�,�, 	
public
�,�, 
uint
�,�, 

�,�, %
;
�,�,% &
public
�,�, 
uint
�,�, 
dwMaxRealPlayNum
�,�, (
;
�,�,( )
public
�,�, 
uint
�,�, 
dwMaxPlayBackNum
�,�, (
;
�,�,( )
public
�,�, 
uint
�,�, 
dwMaxAlarmChanNum
�,�, )
;
�,�,) *
public
�,�, 
uint
�,�, 
dwMaxFormatNum
�,�, &
;
�,�,& '
public
�,�, 
uint
�,�,  
dwMaxFileSearchNum
�,�, *
;
�,�,* +
public
�,�, 
uint
�,�, 
dwMaxLogSearchNum
�,�, )
;
�,�,) *
public
�,�, 
uint
�,�, 
dwMaxSerialNum
�,�, &
;
�,�,& '
public
�,�, 
uint
�,�, 
dwMaxUpgradeNum
�,�, '
;
�,�,' (
public
�,�, 
uint
�,�, 
dwMaxVoiceComNum
�,�, (
;
�,�,( )
public
�,�, 
uint
�,�, 
dwMaxBroadCastNum
�,�, )
;
�,�,) *
[
�,�, 
MarshalAsAttribute
�,�,
(
�,�,  

�,�,  -
.
�,�,- .

ByValArray
�,�,. 8
,
�,�,8 9
	SizeConst
�,�,: C
=
�,�,D E
$num
�,�,F H
,
�,�,H I
ArraySubType
�,�,J V
=
�,�,W X

�,�,Y f
.
�,�,f g
U4
�,�,g i
)
�,�,i j
]
�,�,j k
public
�,�, 
uint
�,�, 
[
�,�, 
]
�,�, 
dwRes
�,�, 
;
�,�,  
}
�,�, 	
[
�,�, 	#
StructLayoutAttribute
�,�,	 
(
�,�, 

LayoutKind
�,�, )
.
�,�,) *

Sequential
�,�,* 4
,
�,�,4 5
CharSet
�,�,6 =
=
�,�,> ?
CharSet
�,�,@ G
.
�,�,G H
Ansi
�,�,H L
)
�,�,L M
]
�,�,M N
public
�,�, 
struct
�,�, 
NET_DVR_ALARMER
�,�, %
{
�,�, 	
public
�,�, 
byte
�,�, 

�,�, %
;
�,�,% &
public
�,�, 
byte
�,�, 

�,�, %
;
�,�,% &
public
�,�, 
byte
�,�, 
byVersionValid
�,�, &
;
�,�,& '
public
�,�, 
byte
�,�, 
byDeviceNameValid
�,�, )
;
�,�,) *
public
�,�, 
byte
�,�, 
byMacAddrValid
�,�, &
;
�,�,& '
public
�,�, 
byte
�,�, 
byLinkPortValid
�,�, '
;
�,�,' (
public
�,�, 
byte
�,�, 
byDeviceIPValid
�,�, '
;
�,�,' (
public
�,�, 
byte
�,�, 
bySocketIPValid
�,�, '
;
�,�,' (
public
�,�, 
int
�,�, 
lUserID
�,�, 
;
�,�, 
[
�,�, 
MarshalAsAttribute
�,�,
(
�,�,  

�,�,  -
.
�,�,- .

ByValArray
�,�,. 8
,
�,�,8 9
	SizeConst
�,�,: C
=
�,�,D E
SERIALNO_LEN
�,�,F R
,
�,�,R S
ArraySubType
�,�,T `
=
�,�,a b

�,�,c p
.
�,�,p q
I1
�,�,q s
)
�,�,s t
]
�,�,t u
public
�,�, 
byte
�,�, 
[
�,�, 
]
�,�, 

�,�, '
;
�,�,' (
public
�,�, 
uint
�,�, 
dwDeviceVersion
�,�, '
;
�,�,' (
[
�,�, 
MarshalAsAttribute
�,�,
(
�,�,  

�,�,  -
.
�,�,- .
	ByValTStr
�,�,. 7
,
�,�,7 8
	SizeConst
�,�,9 B
=
�,�,C D
NAME_LEN
�,�,E M
)
�,�,M N
]
�,�,N O
public
�,�, 
string
�,�, 
sDeviceName
�,�, %
;
�,�,% &
[
�,�, 
MarshalAsAttribute
�,�,
(
�,�,  

�,�,  -
.
�,�,- .

ByValArray
�,�,. 8
,
�,�,8 9
	SizeConst
�,�,: C
=
�,�,D E
MACADDR_LEN
�,�,F Q
,
�,�,Q R
ArraySubType
�,�,S _
=
�,�,` a

�,�,b o
.
�,�,o p
I1
�,�,p r
)
�,�,r s
]
�,�,s t
public
�,�, 
byte
�,�, 
[
�,�, 
]
�,�, 
	byMacAddr
�,�, #
;
�,�,# $
public
�,�, 
ushort
�,�, 
	wLinkPort
�,�, #
;
�,�,# $
[
�,�, 
MarshalAsAttribute
�,�,
(
�,�,  

�,�,  -
.
�,�,- .
	ByValTStr
�,�,. 7
,
�,�,7 8
	SizeConst
�,�,9 B
=
�,�,C D
$num
�,�,E H
)
�,�,H I
]
�,�,I J
public
�,�, 
string
�,�, 
	sDeviceIP
�,�, #
;
�,�,# $
[
�,�, 
MarshalAsAttribute
�,�,
(
�,�,  

�,�,  -
.
�,�,- .
	ByValTStr
�,�,. 7
,
�,�,7 8
	SizeConst
�,�,9 B
=
�,�,C D
$num
�,�,E H
)
�,�,H I
]
�,�,I J
public
�,�, 
string
�,�, 
	sSocketIP
�,�, #
;
�,�,# $
public
�,�, 
byte
�,�, 
byIpProtocol
�,�, $
;
�,�,$ %
[
�,�, 
MarshalAsAttribute
�,�,
(
�,�,  

�,�,  -
.
�,�,- .

ByValArray
�,�,. 8
,
�,�,8 9
	SizeConst
�,�,: C
=
�,�,D E
$num
�,�,F H
,
�,�,H I
ArraySubType
�,�,J V
=
�,�,W X

�,�,Y f
.
�,�,f g
I1
�,�,g i
)
�,�,i j
]
�,�,j k
public
�,�, 
byte
�,�, 
[
�,�, 
]
�,�, 
byRes2
�,�,  
;
�,�,  !
}
�,�, 	
[
�,�, 	#
StructLayoutAttribute
�,�,	 
(
�,�, 

LayoutKind
�,�, )
.
�,�,) *

Sequential
�,�,* 4
)
�,�,4 5
]
�,�,5 6
public
�,�, 
struct
�,�, "
NET_DVR_DISPLAY_PARA
�,�, *
{
�,�, 	
public
�,�, 
int
�,�, 
	bToScreen
�,�,  
;
�,�,  !
public
�,�, 
int
�,�, 
bToVideoOut
�,�, "
;
�,�," #
public
�,�, 
int
�,�, 
nLeft
�,�, 
;
�,�, 
public
�,�, 
int
�,�, 
nTop
�,�, 
;
�,�, 
public
�,�, 
int
�,�, 
nWidth
�,�, 
;
�,�, 
public
�,�, 
int
�,�, 
nHeight
�,�, 
;
�,�, 
public
�,�, 
int
�,�, 
	nReserved
�,�,  
;
�,�,  !
}
�,�, 	
[
�,�, 	#
StructLayoutAttribute
�,�,	 
(
�,�, 

LayoutKind
�,�, )
.
�,�,) *

Sequential
�,�,* 4
)
�,�,4 5
]
�,�,5 6
public
�,�, 
struct
�,�, 
NET_DVR_CARDINFO
�,�, &
{
�,�, 	
public
�,�, 
int
�,�, 
lChannel
�,�, 
;
�,�,  
public
�,�, 
int
�,�, 
	lLinkMode
�,�,  
;
�,�,  !
[
�,�, 
MarshalAsAttribute
�,�,
(
�,�,  

�,�,  -
.
�,�,- .
LPStr
�,�,. 3
)
�,�,3 4
]
�,�,4 5
public
�,�, 
string
�,�, 
sMultiCastIP
�,�, &
;
�,�,& '
public
�,�, "
NET_DVR_DISPLAY_PARA
�,�, '
struDisplayPara
�,�,( 7
;
�,�,7 8
}
�,�, 	
[
�,�, 	#
StructLayoutAttribute
�,�,	 
(
�,�, 

LayoutKind
�,�, )
.
�,�,) *

Sequential
�,�,* 4
,
�,�,4 5
CharSet
�,�,6 =
=
�,�,> ?
CharSet
�,�,@ G
.
�,�,G H
Ansi
�,�,H L
)
�,�,L M
]
�,�,M N
public
�,�, 
struct
�,�, 
NET_DVR_FIND_DATA
�,�, '
{
�,�, 	
[
�,�, 
MarshalAsAttribute
�,�,
(
�,�,  

�,�,  -
.
�,�,- .
	ByValTStr
�,�,. 7
,
�,�,7 8
	SizeConst
�,�,9 B
=
�,�,C D
$num
�,�,E H
)
�,�,H I
]
�,�,I J
public
�,�, 
string
�,�, 
	sFileName
�,�, #
;
�,�,# $
public
�,�, 
NET_DVR_TIME
�,�, 

�,�,  -
;
�,�,- .
public
�,�, 
NET_DVR_TIME
�,�, 
struStopTime
�,�,  ,
;
�,�,, -
public
�-�- 
uint
�-�- 

dwFileSize
�-�- "
;
�-�-" #
}
�-�- 	
[
�-�- 	#
StructLayoutAttribute
�-�-	 
(
�-�- 

LayoutKind
�-�- )
.
�-�-) *

Sequential
�-�-* 4
,
�-�-4 5
CharSet
�-�-6 =
=
�-�-> ?
CharSet
�-�-@ G
.
�-�-G H
Ansi
�-�-H L
)
�-�-L M
]
�-�-M N
public
�-�- 
struct
�-�- "
NET_DVR_FINDDATA_V30
�-�- *
{
�-�- 	
[
�-�- 
MarshalAsAttribute
�-�-
(
�-�-  

�-�-  -
.
�-�-- .
	ByValTStr
�-�-. 7
,
�-�-7 8
	SizeConst
�-�-9 B
=
�-�-C D
$num
�-�-E H
)
�-�-H I
]
�-�-I J
public
�-�- 
string
�-�- 
	sFileName
�-�- #
;
�-�-# $
public
�-�- 
NET_DVR_TIME
�-�- 

�-�-  -
;
�-�-- .
public
�-�- 
NET_DVR_TIME
�-�- 
struStopTime
�-�-  ,
;
�-�-, -
public
�-�- 
uint
�-�- 

dwFileSize
�-�- "
;
�-�-" #
[
�-�- 
MarshalAsAttribute
�-�-
(
�-�-  

�-�-  -
.
�-�-- .
	ByValTStr
�-�-. 7
,
�-�-7 8
	SizeConst
�-�-9 B
=
�-�-C D
$num
�-�-E G
)
�-�-G H
]
�-�-H I
public
�-�- 
string
�-�- 
sCardNum
�-�- "
;
�-�-" #
public
�-�- 
byte
�-�- 
byLocked
�-�-  
;
�-�-  !
public
�-�- 
byte
�-�- 

byFileType
�-�- "
;
�-�-" #
[
�-�- 
MarshalAsAttribute
�-�-
(
�-�-  

�-�-  -
.
�-�-- .

ByValArray
�-�-. 8
,
�-�-8 9
	SizeConst
�-�-: C
=
�-�-D E
$num
�-�-F G
,
�-�-G H
ArraySubType
�-�-I U
=
�-�-V W

�-�-X e
.
�-�-e f
I1
�-�-f h
)
�-�-h i
]
�-�-i j
public
�-�- 
byte
�-�- 
[
�-�- 
]
�-�- 
byRes
�-�- 
;
�-�-  
}
�-�- 	
[
�-�- 	#
StructLayoutAttribute
�-�-	 
(
�-�- 

LayoutKind
�-�- )
.
�-�-) *

Sequential
�-�-* 4
,
�-�-4 5
CharSet
�-�-6 =
=
�-�-> ?
CharSet
�-�-@ G
.
�-�-G H
Ansi
�-�-H L
)
�-�-L M
]
�-�-M N
public
�-�- 
struct
�-�- "
NET_DVR_FINDDATA_V40
�-�- *
{
�-�- 	
[
�-�- 
MarshalAsAttribute
�-�-
(
�-�-  

�-�-  -
.
�-�-- .
	ByValTStr
�-�-. 7
,
�-�-7 8
	SizeConst
�-�-9 B
=
�-�-C D
$num
�-�-E H
)
�-�-H I
]
�-�-I J
public
�-�- 
string
�-�- 
	sFileName
�-�- #
;
�-�-# $
public
�-�- 
NET_DVR_TIME
�-�- 

�-�-  -
;
�-�-- .
public
�-�- 
NET_DVR_TIME
�-�- 
struStopTime
�-�-  ,
;
�-�-, -
public
�-�- 
uint
�-�- 

dwFileSize
�-�- "
;
�-�-" #
[
�-�- 
MarshalAsAttribute
�-�-
(
�-�-  

�-�-  -
.
�-�-- .
	ByValTStr
�-�-. 7
,
�-�-7 8
	SizeConst
�-�-9 B
=
�-�-C D
$num
�-�-E G
)
�-�-G H
]
�-�-H I
public
�-�- 
string
�-�- 
sCardNum
�-�- "
;
�-�-" #
public
�-�- 
byte
�-�- 
byLocked
�-�-  
;
�-�-  !
public
�-�- 
byte
�-�- 

byFileType
�-�- "
;
�-�-" #
public
�-�- 
byte
�-�- 

�-�- %
;
�-�-% &
public
�-�- 
byte
�-�- 
byRes
�-�- 
;
�-�- 
public
�-�- 
uint
�-�- 
dwFileIndex
�-�- #
;
�-�-# $
[
�-�- 
MarshalAsAttribute
�-�-
(
�-�-  

�-�-  -
.
�-�-- .

ByValArray
�-�-. 8
,
�-�-8 9
	SizeConst
�-�-: C
=
�-�-D E
$num
�-�-F I
,
�-�-I J
ArraySubType
�-�-K W
=
�-�-X Y

�-�-Z g
.
�-�-g h
I1
�-�-h j
)
�-�-j k
]
�-�-k l
public
�-�- 
byte
�-�- 
[
�-�- 
]
�-�- 
byRes1
�-�-  
;
�-�-  !
}
�-�- 	
[
�-�- 	#
StructLayoutAttribute
�-�-	 
(
�-�- 

LayoutKind
�-�- )
.
�-�-) *

Sequential
�-�-* 4
,
�-�-4 5
CharSet
�-�-6 =
=
�-�-> ?
CharSet
�-�-@ G
.
�-�-G H
Ansi
�-�-H L
)
�-�-L M
]
�-�-M N
public
�-�- 
struct
�-�- #
NET_DVR_FINDDATA_CARD
�-�- +
{
�-�- 	
[
�-�- 
MarshalAsAttribute
�-�-
(
�-�-  

�-�-  -
.
�-�-- .
	ByValTStr
�-�-. 7
,
�-�-7 8
	SizeConst
�-�-9 B
=
�-�-C D
$num
�-�-E H
)
�-�-H I
]
�-�-I J
public
�-�- 
string
�-�- 
	sFileName
�-�- #
;
�-�-# $
public
�-�- 
NET_DVR_TIME
�-�- 

�-�-  -
;
�-�-- .
public
�-�- 
NET_DVR_TIME
�-�- 
struStopTime
�-�-  ,
;
�-�-, -
public
�-�- 
uint
�-�- 

dwFileSize
�-�- "
;
�-�-" #
[
�-�- 
MarshalAsAttribute
�-�-
(
�-�-  

�-�-  -
.
�-�-- .
	ByValTStr
�-�-. 7
,
�-�-7 8
	SizeConst
�-�-9 B
=
�-�-C D
$num
�-�-E G
)
�-�-G H
]
�-�-H I
public
�-�- 
string
�-�- 
sCardNum
�-�- "
;
�-�-" #
}
�-�- 	
[
�-�- 	#
StructLayoutAttribute
�-�-	 
(
�-�- 

LayoutKind
�-�- )
.
�-�-) *

Sequential
�-�-* 4
)
�-�-4 5
]
�-�-5 6
public
�-�- 
struct
�-�- 
NET_DVR_FILECOND
�-�- &
{
�-�- 	
public
�-�- 
int
�-�- 
lChannel
�-�- 
;
�-�-  
public
�-�- 
uint
�-�- 

dwFileType
�-�- "
;
�-�-" #
public
�-�- 
uint
�-�- 

dwIsLocked
�-�- "
;
�-�-" #
public
�-�- 
uint
�-�- 
dwUseCardNo
�-�- #
;
�-�-# $
[
�-�- 
MarshalAsAttribute
�-�-
(
�-�-  

�-�-  -
.
�-�-- .

ByValArray
�-�-. 8
,
�-�-8 9
	SizeConst
�-�-: C
=
�-�-D E
$num
�-�-F H
,
�-�-H I
ArraySubType
�-�-J V
=
�-�-W X

�-�-Y f
.
�-�-f g
I1
�-�-g i
)
�-�-i j
]
�-�-j k
public
�-�- 
byte
�-�- 
[
�-�- 
]
�-�- 
sCardNumber
�-�- %
;
�-�-% &
public
�-�- 
NET_DVR_TIME
�-�- 

�-�-  -
;
�-�-- .
public
�-�- 
NET_DVR_TIME
�-�- 
struStopTime
�-�-  ,
;
�-�-, -
}
�-�- 	
[
�-�- 	#
StructLayoutAttribute
�-�-	 
(
�-�- 

LayoutKind
�-�- )
.
�-�-) *

Sequential
�-�-* 4
)
�-�-4 5
]
�-�-5 6
public
�-�- 
struct
�-�- !
NET_DVR_POINT_FRAME
�-�- )
{
�-�- 	
public
�-�- 
int
�-�- 
xTop
�-�- 
;
�-�- 
public
�-�- 
int
�-�- 
yTop
�-�- 
;
�-�- 
public
�-�- 
int
�-�- 
xBottom
�-�- 
;
�-�- 
public
�-�- 
int
�-�- 
yBottom
�-�- 
;
�-�- 
public
�-�- 
int
�-�- 
bCounter
�-�- 
;
�-�-  
}
�-�- 	
[
�-�- 	#
StructLayoutAttribute
�-�-	 
(
�-�- 

LayoutKind
�-�- )
.
�-�-) *

Sequential
�-�-* 4
)
�-�-4 5
]
�-�-5 6
public
�-�- 
struct
�-�- '
NET_DVR_COMPRESSION_AUDIO
�-�- /
{
�-�- 	
public
�-�- 
byte
�-�- 
byAudioEncType
�-�- &
;
�-�-& '
[
�-�- 
MarshalAsAttribute
�-�-
(
�-�-  

�-�-  -
.
�-�-- .

ByValArray
�-�-. 8
,
�-�-8 9
	SizeConst
�-�-: C
=
�-�-D E
$num
�-�-F G
,
�-�-G H
ArraySubType
�-�-I U
=
�-�-V W

�-�-X e
.
�-�-e f
I1
�-�-f h
)
�-�-h i
]
�-�-i j
public
�-�- 
byte
�-�- 
[
�-�- 
]
�-�- 
byres
�-�- 
;
�-�-  
}
�-�- 	
[
�-�- 	#
StructLayoutAttribute
�-�-	 
(
�-�- 

LayoutKind
�-�- )
.
�-�-) *

Sequential
�-�-* 4
,
�-�-4 5
CharSet
�-�-6 =
=
�-�-> ?
CharSet
�-�-@ G
.
�-�-G H
Ansi
�-�-H L
)
�-�-L M
]
�-�-M N
public
�-�- 
struct
�-�- 
NET_DVR_AP_INFO
�-�- %
{
�-�- 	
[
�-�- 
MarshalAsAttribute
�-�-
(
�-�-  

�-�-  -
.
�-�-- .
	ByValTStr
�-�-. 7
,
�-�-7 8
	SizeConst
�-�-9 B
=
�-�-C D
IW_ESSID_MAX_SIZE
�-�-E V
)
�-�-V W
]
�-�-W X
public
�-�- 
string
�-�- 
sSsid
�-�- 
;
�-�-  
public
�-�- 
uint
�-�- 
dwMode
�-�- 
;
�-�- 
public
�-�- 
uint
�-�- 

dwSecurity
�-�- "
;
�-�-" #
public
�-�- 
uint
�-�- 
	dwChannel
�-�- !
;
�-�-! "
public
�-�- 
uint
�-�- 
dwSignalStrength
�-�- (
;
�-�-( )
public
�-�- 
uint
�-�- 
dwSpeed
�-�- 
;
�-�-  
}
�-�- 	
[
�-�- 	#
StructLayoutAttribute
�-�-	 
(
�-�- 

LayoutKind
�-�- )
.
�-�-) *

Sequential
�-�-* 4
)
�-�-4 5
]
�-�-5 6
public
�-�- 
struct
�-�- "
NET_DVR_AP_INFO_LIST
�-�- *
{
�-�- 	
public
�-�- 
uint
�-�- 
dwSize
�-�- 
;
�-�- 
public
�-�- 
uint
�-�- 
dwCount
�-�- 
;
�-�-  
[
�-�- 
MarshalAsAttribute
�-�-
(
�-�-  

�-�-  -
.
�-�-- .

ByValArray
�-�-. 8
,
�-�-8 9
	SizeConst
�-�-: C
=
�-�-D E
WIFI_MAX_AP_COUNT
�-�-F W
,
�-�-W X
ArraySubType
�-�-Y e
=
�-�-f g

�-�-h u
.
�-�-u v
Struct
�-�-v |
)
�-�-| }
]
�-�-} ~
public
�-�- 
NET_DVR_AP_INFO
�-�- "
[
�-�-" #
]
�-�-# $

struApInfo
�-�-% /
;
�-�-/ 0
}
�-�- 	
[
�-�- 	#
StructLayoutAttribute
�-�-	 
(
�-�- 

LayoutKind
�-�- )
.
�-�-) *

Sequential
�-�-* 4
,
�-�-4 5
CharSet
�-�-6 =
=
�-�-> ?
CharSet
�-�-@ G
.
�-�-G H
Ansi
�-�-H L
)
�-�-L M
]
�-�-M N
public
�-�- 
struct
�-�- "
NET_DVR_WIFIETHERNET
�-�- *
{
�-�- 	
[
�-�- 
MarshalAsAttribute
�-�-
(
�-�-  

�-�-  -
.
�-�-- .
	ByValTStr
�-�-. 7
,
�-�-7 8
	SizeConst
�-�-9 B
=
�-�-C D
$num
�-�-E G
)
�-�-G H
]
�-�-H I
public
�-�- 
string
�-�- 

sIpAddress
�-�- $
;
�-�-$ %
[
�-�- 
MarshalAsAttribute
�-�-
(
�-�-  

�-�-  -
.
�-�-- .
	ByValTStr
�-�-. 7
,
�-�-7 8
	SizeConst
�-�-9 B
=
�-�-C D
$num
�-�-E G
)
�-�-G H
]
�-�-H I
public
�-�- 
string
�-�- 
sIpMask
�-�- !
;
�-�-! "
[
�-�- 
MarshalAsAttribute
�-�-
(
�-�-  

�-�-  -
.
�-�-- .

ByValArray
�-�-. 8
,
�-�-8 9
	SizeConst
�-�-: C
=
�-�-D E
MACADDR_LEN
�-�-F Q
,
�-�-Q R
ArraySubType
�-�-S _
=
�-�-` a

�-�-b o
.
�-�-o p
I1
�-�-p r
)
�-�-r s
]
�-�-s t
public
�-�- 
byte
�-�- 
[
�-�- 
]
�-�- 
	byMACAddr
�-�- #
;
�-�-# $
[
�-�- 
MarshalAsAttribute
�-�-
(
�-�-  

�-�-  -
.
�-�-- .

ByValArray
�-�-. 8
,
�-�-8 9
	SizeConst
�-�-: C
=
�-�-D E
$num
�-�-F G
,
�-�-G H
ArraySubType
�-�-I U
=
�-�-V W

�-�-X e
.
�-�-e f
I1
�-�-f h
)
�-�-h i
]
�-�-i j
public
�-�- 
byte
�-�- 
[
�-�- 
]
�-�- 
bRes
�-�- 
;
�-�- 
public
�-�- 
uint
�-�- 
dwEnableDhcp
�-�- $
;
�-�-$ %
public
�-�- 
uint
�-�- 
	dwAutoDns
�-�- !
;
�-�-! "
[
�-�- 
MarshalAsAttribute
�-�-
(
�-�-  

�-�-  -
.
�-�-- .
	ByValTStr
�-�-. 7
,
�-�-7 8
	SizeConst
�-�-9 B
=
�-�-C D
$num
�-�-E G
)
�-�-G H
]
�-�-H I
public
�-�- 
string
�-�- 
	sFirstDns
�-�- #
;
�-�-# $
[
�-�- 
MarshalAsAttribute
�-�-
(
�-�-  

�-�-  -
.
�-�-- .
	ByValTStr
�-�-. 7
,
�-�-7 8
	SizeConst
�-�-9 B
=
�-�-C D
$num
�-�-E G
)
�-�-G H
]
�-�-H I
public
�-�- 
string
�-�- 

sSecondDns
�-�- $
;
�-�-$ %
[
�.�. 
MarshalAsAttribute
�.�.
(
�.�.  

�.�.  -
.
�.�.- .
	ByValTStr
�.�.. 7
,
�.�.7 8
	SizeConst
�.�.9 B
=
�.�.C D
$num
�.�.E G
)
�.�.G H
]
�.�.H I
public
�.�. 
string
�.�. 
sGatewayIpAddr
�.�. (
;
�.�.( )
[
�.�. 
MarshalAsAttribute
�.�.
(
�.�.  

�.�.  -
.
�.�.- .

ByValArray
�.�.. 8
,
�.�.8 9
	SizeConst
�.�.: C
=
�.�.D E
$num
�.�.F G
,
�.�.G H
ArraySubType
�.�.I U
=
�.�.V W

�.�.X e
.
�.�.e f
I1
�.�.f h
)
�.�.h i
]
�.�.i j
public
�.�. 
byte
�.�. 
[
�.�. 
]
�.�. 
bRes2
�.�. 
;
�.�.  
}
�.�. 	
[
�.�. 	#
StructLayoutAttribute
�.�.	 
(
�.�. 

LayoutKind
�.�. )
.
�.�.) *

Sequential
�.�.* 4
,
�.�.4 5
CharSet
�.�.6 =
=
�.�.> ?
CharSet
�.�.@ G
.
�.�.G H
Ansi
�.�.H L
)
�.�.L M
]
�.�.M N
public
�.�. 
struct
�.�. 
UNION_EAP_TTLS
�.�. $
{
�.�. 	
public
�.�. 
byte
�.�. 
byEapolVersion
�.�. &
;
�.�.& '
public
�.�. 
byte
�.�. 

byAuthType
�.�. "
;
�.�." #
[
�.�. 
MarshalAsAttribute
�.�.
(
�.�.  

�.�.  -
.
�.�.- .

ByValArray
�.�.. 8
,
�.�.8 9
	SizeConst
�.�.: C
=
�.�.D E
$num
�.�.F G
,
�.�.G H
ArraySubType
�.�.I U
=
�.�.V W

�.�.X e
.
�.�.e f
I1
�.�.f h
)
�.�.h i
]
�.�.i j
public
�.�. 
byte
�.�. 
[
�.�. 
]
�.�. 
byRes1
�.�.  
;
�.�.  !
[
�.�. 
MarshalAsAttribute
�.�.
(
�.�.  

�.�.  -
.
�.�.- .

ByValArray
�.�.. 8
,
�.�.8 9
	SizeConst
�.�.: C
=
�.�.D E
NAME_LEN
�.�.F N
,
�.�.N O
ArraySubType
�.�.P \
=
�.�.] ^

�.�._ l
.
�.�.l m
I1
�.�.m o
)
�.�.o p
]
�.�.p q
public
�.�. 
byte
�.�. 
[
�.�. 
]
�.�. 
byAnonyIdentity
�.�. )
;
�.�.) *
[
�.�. 
MarshalAsAttribute
�.�.
(
�.�.  

�.�.  -
.
�.�.- .

ByValArray
�.�.. 8
,
�.�.8 9
	SizeConst
�.�.: C
=
�.�.D E
NAME_LEN
�.�.F N
,
�.�.N O
ArraySubType
�.�.P \
=
�.�.] ^

�.�._ l
.
�.�.l m
I1
�.�.m o
)
�.�.o p
]
�.�.p q
public
�.�. 
byte
�.�. 
[
�.�. 
]
�.�. 

byUserName
�.�. $
;
�.�.$ %
[
�.�. 
MarshalAsAttribute
�.�.
(
�.�.  

�.�.  -
.
�.�.- .

ByValArray
�.�.. 8
,
�.�.8 9
	SizeConst
�.�.: C
=
�.�.D E
NAME_LEN
�.�.F N
,
�.�.N O
ArraySubType
�.�.P \
=
�.�.] ^

�.�._ l
.
�.�.l m
I1
�.�.m o
)
�.�.o p
]
�.�.p q
public
�.�. 
byte
�.�. 
[
�.�. 
]
�.�. 

byPassword
�.�. $
;
�.�.$ %
[
�.�. 
MarshalAsAttribute
�.�.
(
�.�.  

�.�.  -
.
�.�.- .

ByValArray
�.�.. 8
,
�.�.8 9
	SizeConst
�.�.: C
=
�.�.D E
$num
�.�.F H
,
�.�.H I
ArraySubType
�.�.J V
=
�.�.W X

�.�.Y f
.
�.�.f g
I1
�.�.g i
)
�.�.i j
]
�.�.j k
public
�.�. 
byte
�.�. 
[
�.�. 
]
�.�. 
byRes
�.�. 
;
�.�.  
}
�.�. 	
[
�.�. 	#
StructLayoutAttribute
�.�.	 
(
�.�. 

LayoutKind
�.�. )
.
�.�.) *

Sequential
�.�.* 4
,
�.�.4 5
CharSet
�.�.6 =
=
�.�.> ?
CharSet
�.�.@ G
.
�.�.G H
Ansi
�.�.H L
)
�.�.L M
]
�.�.M N
public
�.�. 
struct
�.�. 
UNION_EAP_PEAP
�.�. $
{
�.�. 	
public
�.�. 
byte
�.�. 
byEapolVersion
�.�. &
;
�.�.& '
public
�.�. 
byte
�.�. 

byAuthType
�.�. "
;
�.�." #
public
�.�. 
byte
�.�. 

�.�. %
;
�.�.% &
public
�.�. 
byte
�.�. 
byPeapLabel
�.�. #
;
�.�.# $
[
�.�. 
MarshalAsAttribute
�.�.
(
�.�.  

�.�.  -
.
�.�.- .

ByValArray
�.�.. 8
,
�.�.8 9
	SizeConst
�.�.: C
=
�.�.D E
NAME_LEN
�.�.F N
,
�.�.N O
ArraySubType
�.�.P \
=
�.�.] ^

�.�._ l
.
�.�.l m
I1
�.�.m o
)
�.�.o p
]
�.�.p q
public
�.�. 
byte
�.�. 
[
�.�. 
]
�.�. 
byAnonyIdentity
�.�. )
;
�.�.) *
[
�.�. 
MarshalAsAttribute
�.�.
(
�.�.  

�.�.  -
.
�.�.- .

ByValArray
�.�.. 8
,
�.�.8 9
	SizeConst
�.�.: C
=
�.�.D E
NAME_LEN
�.�.F N
,
�.�.N O
ArraySubType
�.�.P \
=
�.�.] ^

�.�._ l
.
�.�.l m
I1
�.�.m o
)
�.�.o p
]
�.�.p q
public
�.�. 
byte
�.�. 
[
�.�. 
]
�.�. 

byUserName
�.�. $
;
�.�.$ %
[
�.�. 
MarshalAsAttribute
�.�.
(
�.�.  

�.�.  -
.
�.�.- .

ByValArray
�.�.. 8
,
�.�.8 9
	SizeConst
�.�.: C
=
�.�.D E
NAME_LEN
�.�.F N
,
�.�.N O
ArraySubType
�.�.P \
=
�.�.] ^

�.�._ l
.
�.�.l m
I1
�.�.m o
)
�.�.o p
]
�.�.p q
public
�.�. 
byte
�.�. 
[
�.�. 
]
�.�. 

byPassword
�.�. $
;
�.�.$ %
[
�.�. 
MarshalAsAttribute
�.�.
(
�.�.  

�.�.  -
.
�.�.- .

ByValArray
�.�.. 8
,
�.�.8 9
	SizeConst
�.�.: C
=
�.�.D E
$num
�.�.F H
,
�.�.H I
ArraySubType
�.�.J V
=
�.�.W X

�.�.Y f
.
�.�.f g
I1
�.�.g i
)
�.�.i j
]
�.�.j k
public
�.�. 
byte
�.�. 
[
�.�. 
]
�.�. 
byRes
�.�. 
;
�.�.  
}
�.�. 	
[
�.�. 	#
StructLayoutAttribute
�.�.	 
(
�.�. 

LayoutKind
�.�. )
.
�.�.) *

Sequential
�.�.* 4
,
�.�.4 5
CharSet
�.�.6 =
=
�.�.> ?
CharSet
�.�.@ G
.
�.�.G H
Ansi
�.�.H L
)
�.�.L M
]
�.�.M N
public
�.�. 
struct
�.�. 

�.�. #
{
�.�. 	
public
�.�. 
byte
�.�. 
byEapolVersion
�.�. &
;
�.�.& '
[
�.�. 
MarshalAsAttribute
�.�.
(
�.�.  

�.�.  -
.
�.�.- .

ByValArray
�.�.. 8
,
�.�.8 9
	SizeConst
�.�.: C
=
�.�.D E
$num
�.�.F G
,
�.�.G H
ArraySubType
�.�.I U
=
�.�.V W

�.�.X e
.
�.�.e f
I1
�.�.f h
)
�.�.h i
]
�.�.i j
public
�.�. 
byte
�.�. 
[
�.�. 
]
�.�. 
byRes1
�.�.  
;
�.�.  !
[
�.�. 
MarshalAsAttribute
�.�.
(
�.�.  

�.�.  -
.
�.�.- .

ByValArray
�.�.. 8
,
�.�.8 9
	SizeConst
�.�.: C
=
�.�.D E
NAME_LEN
�.�.F N
,
�.�.N O
ArraySubType
�.�.P \
=
�.�.] ^

�.�._ l
.
�.�.l m
I1
�.�.m o
)
�.�.o p
]
�.�.p q
public
�.�. 
byte
�.�. 
[
�.�. 
]
�.�. 

byIdentity
�.�. $
;
�.�.$ %
[
�.�. 
MarshalAsAttribute
�.�.
(
�.�.  

�.�.  -
.
�.�.- .

ByValArray
�.�.. 8
,
�.�.8 9
	SizeConst
�.�.: C
=
�.�.D E
NAME_LEN
�.�.F N
,
�.�.N O
ArraySubType
�.�.P \
=
�.�.] ^

�.�._ l
.
�.�.l m
I1
�.�.m o
)
�.�.o p
]
�.�.p q
public
�.�. 
byte
�.�. 
[
�.�. 
]
�.�. 
byPrivateKeyPswd
�.�. *
;
�.�.* +
[
�.�. 
MarshalAsAttribute
�.�.
(
�.�.  

�.�.  -
.
�.�.- .

ByValArray
�.�.. 8
,
�.�.8 9
	SizeConst
�.�.: C
=
�.�.D E
$num
�.�.F H
,
�.�.H I
ArraySubType
�.�.J V
=
�.�.W X

�.�.Y f
.
�.�.f g
I1
�.�.g i
)
�.�.i j
]
�.�.j k
public
�.�. 
byte
�.�. 
[
�.�. 
]
�.�. 
byRes
�.�. 
;
�.�.  
}
�.�. 	
[
�.�. 	#
StructLayoutAttribute
�.�.	 
(
�.�. 

LayoutKind
�.�. )
.
�.�.) *
Explicit
�.�.* 2
)
�.�.2 3
]
�.�.3 4
public
�.�. 
struct
�.�. 
WIFI_AUTH_PARAM
�.�. %
{
�.�. 	
[
�.�. 
FieldOffsetAttribute
�.�.
(
�.�.! "
$num
�.�." #
)
�.�.# $
]
�.�.$ %
public
�.�. 
UNION_EAP_TTLS
�.�. !
EAP_TTLS
�.�." *
;
�.�.* +
[
�.�. 
FieldOffsetAttribute
�.�.
(
�.�.! "
$num
�.�." #
)
�.�.# $
]
�.�.$ %
public
�.�. 
UNION_EAP_PEAP
�.�. !
EAP_PEAP
�.�." *
;
�.�.* +
[
�.�. 
FieldOffsetAttribute
�.�.
(
�.�.! "
$num
�.�." #
)
�.�.# $
]
�.�.$ %
public
�.�. 

�.�.  
EAP_TLS
�.�.! (
;
�.�.( )
}
�.�. 	
[
�.�. 	#
StructLayoutAttribute
�.�.	 
(
�.�. 

LayoutKind
�.�. )
.
�.�.) *

Sequential
�.�.* 4
,
�.�.4 5
CharSet
�.�.6 =
=
�.�.> ?
CharSet
�.�.@ G
.
�.�.G H
Ansi
�.�.H L
)
�.�.L M
]
�.�.M N
public
�.�. 
struct
�.�. 
	UNION_WEP
�.�. 
{
�.�. 	
public
�.�. 
uint
�.�. 
dwAuthentication
�.�. (
;
�.�.( )
public
�.�. 
uint
�.�. 
dwKeyLength
�.�. #
;
�.�.# $
public
�.�. 
uint
�.�. 
	dwKeyType
�.�. !
;
�.�.! "
public
�.�. 
uint
�.�. 
dwActive
�.�.  
;
�.�.  !
[
�.�. 
MarshalAsAttribute
�.�.
(
�.�.  

�.�.  -
.
�.�.- .
	ByValTStr
�.�.. 7
,
�.�.7 8
	SizeConst
�.�.9 B
=
�.�.C D$
WIFI_WEP_MAX_KEY_COUNT
�.�.E [
*
�.�.\ ]%
WIFI_WEP_MAX_KEY_LENGTH
�.�.^ u
)
�.�.u v
]
�.�.v w
public
�.�. 
string
�.�. 
sKeyInfo
�.�. "
;
�.�." #
}
�.�. 	
[
�.�. 	#
StructLayoutAttribute
�.�.	 
(
�.�. 

LayoutKind
�.�. )
.
�.�.) *

Sequential
�.�.* 4
,
�.�.4 5
CharSet
�.�.6 =
=
�.�.> ?
CharSet
�.�.@ G
.
�.�.G H
Ansi
�.�.H L
)
�.�.L M
]
�.�.M N
public
�.�. 
struct
�.�. 

�.�. #
{
�.�. 	
public
�.�. 
uint
�.�. 
dwKeyLength
�.�. #
;
�.�.# $
[
�.�. 
MarshalAsAttribute
�.�.
(
�.�.  

�.�.  -
.
�.�.- .
	ByValTStr
�.�.. 7
,
�.�.7 8
	SizeConst
�.�.9 B
=
�.�.C D)
WIFI_WPA_PSK_MAX_KEY_LENGTH
�.�.E `
)
�.�.` a
]
�.�.a b
public
�.�. 
string
�.�. 
sKeyInfo
�.�. "
;
�.�." #
public
�.�. 
byte
�.�. 

�.�. %
;
�.�.% &
}
�.�. 	
[
�.�. 	#
StructLayoutAttribute
�.�.	 
(
�.�. 

LayoutKind
�.�. )
.
�.�.) *

Sequential
�.�.* 4
,
�.�.4 5
CharSet
�.�.6 =
=
�.�.> ?
CharSet
�.�.@ G
.
�.�.G H
Ansi
�.�.H L
)
�.�.L M
]
�.�.M N
public
�.�. 
struct
�.�. 
UNION_WPA_WPA2
�.�. $
{
�.�. 	
public
�.�. 
byte
�.�. 

�.�. %
;
�.�.% &
public
�.�. 
byte
�.�. 

byAuthType
�.�. "
;
�.�." #
[
�.�. 
MarshalAsAttribute
�.�.
(
�.�.  

�.�.  -
.
�.�.- .

ByValArray
�.�.. 8
,
�.�.8 9
	SizeConst
�.�.: C
=
�.�.D E
$num
�.�.F G
,
�.�.G H
ArraySubType
�.�.I U
=
�.�.V W

�.�.X e
.
�.�.e f
I1
�.�.f h
)
�.�.h i
]
�.�.i j
public
�.�. 
byte
�.�. 
[
�.�. 
]
�.�. 
byRes
�.�. 
;
�.�.  
public
�.�. 
WIFI_AUTH_PARAM
�.�. "

auth_param
�.�.# -
;
�.�.- .
}
�.�. 	
[
�.�. 	#
StructLayoutAttribute
�.�.	 
(
�.�. 

LayoutKind
�.�. )
.
�.�.) *

Sequential
�.�.* 4
,
�.�.4 5
CharSet
�.�.6 =
=
�.�.> ?
CharSet
�.�.@ G
.
�.�.G H
Ansi
�.�.H L
)
�.�.L M
]
�.�.M N
public
�.�. 
struct
�.�. !
NET_DVR_WIFI_CFG_EX
�.�. )
{
�.�. 	
public
�.�. "
NET_DVR_WIFIETHERNET
�.�. '
struEtherNet
�.�.( 4
;
�.�.4 5
[
�.�. 
MarshalAsAttribute
�.�.
(
�.�.  

�.�.  -
.
�.�.- .
	ByValTStr
�.�.. 7
,
�.�.7 8
	SizeConst
�.�.9 B
=
�.�.C D
IW_ESSID_MAX_SIZE
�.�.E V
)
�.�.V W
]
�.�.W X
public
�.�. 
string
�.�. 
sEssid
�.�.  
;
�.�.  !
public
�.�. 
uint
�.�. 
dwMode
�.�. 
;
�.�. 
public
�.�. 
uint
�.�. 

dwSecurity
�.�. "
;
�.�." #
[
�.�. 
StructLayoutAttribute
�.�.
(
�.�." #

LayoutKind
�.�.# -
.
�.�.- .
Explicit
�.�.. 6
)
�.�.6 7
]
�.�.7 8
public
�.�. 
struct
�.�. 
key
�.�. 
{
�.�. 
[
�.�. "
FieldOffsetAttribute
�.�. %
(
�.�.% &
$num
�.�.& '
)
�.�.' (
]
�.�.( )
public
�.�. 
	UNION_WEP
�.�.  
wep
�.�.! $
;
�.�.$ %
[
�.�. "
FieldOffsetAttribute
�.�. %
(
�.�.% &
$num
�.�.& '
)
�.�.' (
]
�.�.( )
public
�.�. 

�.�. $
wpa_psk
�.�.% ,
;
�.�., -
[
�.�. "
FieldOffsetAttribute
�.�. %
(
�.�.% &
$num
�.�.& '
)
�.�.' (
]
�.�.( )
public
�.�. 
UNION_WPA_WPA2
�.�. %
wpa_wpa2
�.�.& .
;
�.�.. /
}
�.�. 
}
�.�. 	
[
�.�. 	#
StructLayoutAttribute
�.�.	 
(
�.�. 

LayoutKind
�.�. )
.
�.�.) *

Sequential
�.�.* 4
)
�.�.4 5
]
�.�.5 6
public
�.�. 
struct
�.�. 
NET_DVR_WIFI_CFG
�.�. &
{
�.�. 	
public
�.�. 
uint
�.�. 
dwSize
�.�. 
;
�.�. 
public
�.�. !
NET_DVR_WIFI_CFG_EX
�.�. &
struWifiCfg
�.�.' 2
;
�.�.2 3
}
�.�. 	
[
�.�. 	#
StructLayoutAttribute
�.�.	 
(
�.�. 

LayoutKind
�.�. )
.
�.�.) *

Sequential
�.�.* 4
)
�.�.4 5
]
�.�.5 6
public
�/�/ 
struct
�/�/ )
NET_DVR_WIFI_CONNECT_STATUS
�/�/ 1
{
�/�/ 	
public
�/�/ 
uint
�/�/ 
dwSize
�/�/ 
;
�/�/ 
public
�/�/ 
byte
�/�/ 
byCurStatus
�/�/ #
;
�/�/# $
[
�/�/ 
MarshalAsAttribute
�/�/
(
�/�/  

�/�/  -
.
�/�/- .

ByValArray
�/�/. 8
,
�/�/8 9
	SizeConst
�/�/: C
=
�/�/D E
$num
�/�/F G
,
�/�/G H
ArraySubType
�/�/I U
=
�/�/V W

�/�/X e
.
�/�/e f
I1
�/�/f h
)
�/�/h i
]
�/�/i j
public
�/�/ 
byte
�/�/ 
[
�/�/ 
]
�/�/ 
byRes1
�/�/  
;
�/�/  !
public
�/�/ 
uint
�/�/ 
dwErrorCode
�/�/ #
;
�/�/# $
[
�/�/ 
MarshalAsAttribute
�/�/
(
�/�/  

�/�/  -
.
�/�/- .

ByValArray
�/�/. 8
,
�/�/8 9
	SizeConst
�/�/: C
=
�/�/D E
$num
�/�/F I
,
�/�/I J
ArraySubType
�/�/K W
=
�/�/X Y

�/�/Z g
.
�/�/g h
I1
�/�/h j
)
�/�/j k
]
�/�/k l
public
�/�/ 
byte
�/�/ 
[
�/�/ 
]
�/�/ 
byRes
�/�/ 
;
�/�/  
}
�/�/ 	
[
�/�/ 	#
StructLayoutAttribute
�/�/	 
(
�/�/ 

LayoutKind
�/�/ )
.
�/�/) *

Sequential
�/�/* 4
)
�/�/4 5
]
�/�/5 6
public
�/�/ 
struct
�/�/ #
NET_DVR_WIFI_WORKMODE
�/�/ +
{
�/�/ 	
public
�/�/ 
uint
�/�/ 
dwSize
�/�/ 
;
�/�/ 
public
�/�/ 
uint
�/�/ $
dwNetworkInterfaceMode
�/�/ .
;
�/�/. /
}
�/�/ 	
public
�/�/ 
const
�/�/ 
int
�/�/ 
MAX_VCA_CHAN
�/�/ %
=
�/�/& '
$num
�/�/( *
;
�/�/* +
[
�/�/ 	#
StructLayoutAttribute
�/�/	 
(
�/�/ 

LayoutKind
�/�/ )
.
�/�/) *

Sequential
�/�/* 4
)
�/�/4 5
]
�/�/5 6
public
�/�/ 
struct
�/�/ 
NET_VCA_CTRLINFO
�/�/ &
{
�/�/ 	
public
�/�/ 
byte
�/�/ 
byVCAEnable
�/�/ #
;
�/�/# $
public
�/�/ 
byte
�/�/ 
	byVCAType
�/�/ !
;
�/�/! "
public
�/�/ 
byte
�/�/ 
byStreamWithVCA
�/�/ '
;
�/�/' (
public
�/�/ 
byte
�/�/ 
byMode
�/�/ 
;
�/�/ 
public
�/�/ 
byte
�/�/ 

�/�/ %
;
�/�/% &
[
�/�/ 
MarshalAsAttribute
�/�/
(
�/�/  

�/�/  -
.
�/�/- .

ByValArray
�/�/. 8
,
�/�/8 9
	SizeConst
�/�/: C
=
�/�/D E
$num
�/�/F G
,
�/�/G H
ArraySubType
�/�/I U
=
�/�/V W

�/�/X e
.
�/�/e f
I1
�/�/f h
)
�/�/h i
]
�/�/i j
public
�/�/ 
byte
�/�/ 
[
�/�/ 
]
�/�/ 
byRes
�/�/ 
;
�/�/  
}
�/�/ 	
[
�/�/ 	#
StructLayoutAttribute
�/�/	 
(
�/�/ 

LayoutKind
�/�/ )
.
�/�/) *

Sequential
�/�/* 4
)
�/�/4 5
]
�/�/5 6
public
�/�/ 
struct
�/�/ 
NET_VCA_CTRLCFG
�/�/ %
{
�/�/ 	
public
�/�/ 
uint
�/�/ 
dwSize
�/�/ 
;
�/�/ 
[
�/�/ 
MarshalAsAttribute
�/�/
(
�/�/  

�/�/  -
.
�/�/- .

ByValArray
�/�/. 8
,
�/�/8 9
	SizeConst
�/�/: C
=
�/�/D E
MAX_VCA_CHAN
�/�/F R
,
�/�/R S
ArraySubType
�/�/T `
=
�/�/a b

�/�/c p
.
�/�/p q
Struct
�/�/q w
)
�/�/w x
]
�/�/x y
public
�/�/ 
NET_VCA_CTRLINFO
�/�/ #
[
�/�/# $
]
�/�/$ %
struCtrlInfo
�/�/& 2
;
�/�/2 3
[
�/�/ 
MarshalAsAttribute
�/�/
(
�/�/  

�/�/  -
.
�/�/- .

ByValArray
�/�/. 8
,
�/�/8 9
	SizeConst
�/�/: C
=
�/�/D E
$num
�/�/F H
,
�/�/H I
ArraySubType
�/�/J V
=
�/�/W X

�/�/Y f
.
�/�/f g
I1
�/�/g i
)
�/�/i j
]
�/�/j k
public
�/�/ 
byte
�/�/ 
[
�/�/ 
]
�/�/ 
byRes
�/�/ 
;
�/�/  
}
�/�/ 	
[
�/�/ 	#
StructLayoutAttribute
�/�/	 
(
�/�/ 

LayoutKind
�/�/ )
.
�/�/) *

Sequential
�/�/* 4
)
�/�/4 5
]
�/�/5 6
public
�/�/ 
struct
�/�/ !
NET_VCA_DEV_ABILITY
�/�/ )
{
�/�/ 	
public
�/�/ 
uint
�/�/ 
dwSize
�/�/ 
;
�/�/ 
public
�/�/ 
byte
�/�/ 
byVCAChanNum
�/�/ $
;
�/�/$ %
public
�/�/ 
byte
�/�/ 
byPlateChanNum
�/�/ &
;
�/�/& '
public
�/�/ 
byte
�/�/ 
byBBaseChanNum
�/�/ &
;
�/�/& '
public
�/�/ 
byte
�/�/ 
byBAdvanceChanNum
�/�/ )
;
�/�/) *
public
�/�/ 
byte
�/�/ 
byBFullChanNum
�/�/ &
;
�/�/& '
public
�/�/ 
byte
�/�/ 
byATMChanNum
�/�/ $
;
�/�/$ %
public
�/�/ 
byte
�/�/ 
byPDCChanNum
�/�/ $
;
�/�/$ %
public
�/�/ 
byte
�/�/ 
byITSChanNum
�/�/ $
;
�/�/$ %
public
�/�/ 
byte
�/�/ 
byBPrisonChanNum
�/�/ (
;
�/�/( )
public
�/�/ 
byte
�/�/ 
byFSnapChanNum
�/�/ &
;
�/�/& '
public
�/�/ 
byte
�/�/ !
byFSnapRecogChanNum
�/�/ +
;
�/�/+ ,
public
�/�/ 
byte
�/�/ !
byFRetrievalChanNum
�/�/ +
;
�/�/+ ,
public
�/�/ 
byte
�/�/ 
	bySupport
�/�/ !
;
�/�/! "
public
�/�/ 
byte
�/�/ 
byFRecogChanNum
�/�/ '
;
�/�/' (
public
�/�/ 
byte
�/�/ "
byBPPerimeterChanNum
�/�/ ,
;
�/�/, -
public
�/�/ 
byte
�/�/ 
byTPSChanNum
�/�/ $
;
�/�/$ %
public
�/�/ 
byte
�/�/ 
byTFSChanNum
�/�/ $
;
�/�/$ %
public
�/�/ 
byte
�/�/ !
byFSnapBFullChanNum
�/�/ +
;
�/�/+ ,
[
�/�/ 
MarshalAsAttribute
�/�/
(
�/�/  

�/�/  -
.
�/�/- .

ByValArray
�/�/. 8
,
�/�/8 9
	SizeConst
�/�/: C
=
�/�/D E
$num
�/�/F H
,
�/�/H I
ArraySubType
�/�/J V
=
�/�/W X

�/�/Y f
.
�/�/f g
I1
�/�/g i
)
�/�/i j
]
�/�/j k
public
�/�/ 
byte
�/�/ 
[
�/�/ 
]
�/�/ 
byRes
�/�/ 
;
�/�/  
}
�/�/ 	
public
�/�/ 
enum
�/�/ 
VCA_ABILITY_TYPE
�/�/ $
:
�/�/% &
uint
�/�/' +
{
�/�/ 	$
TRAVERSE_PLANE_ABILITY
�/�/ "
=
�/�/# $
$num
�/�/% )
,
�/�/) * 
ENTER_AREA_ABILITY
�/�/ 
=
�/�/  
$num
�/�/! %
,
�/�/% &
EXIT_AREA_ABILITY
�/�/ 
=
�/�/ 
$num
�/�/  $
,
�/�/$ %
INTRUSION_ABILITY
�/�/ 
=
�/�/ 
$num
�/�/  $
,
�/�/$ %
LOITER_ABILITY
�/�/ 
=
�/�/ 
$num
�/�/ !
,
�/�/! "
LEFT_TAKE_ABILITY
�/�/ 
=
�/�/ 
$num
�/�/  $
,
�/�/$ %
PARKING_ABILITY
�/�/ 
=
�/�/ 
$num
�/�/ "
,
�/�/" #
RUN_ABILITY
�/�/ 
=
�/�/ 
$num
�/�/ 
,
�/�/ "
HIGH_DENSITY_ABILITY
�/�/  
=
�/�/! "
$num
�/�/# (
,
�/�/( )
LF_TRACK_ABILITY
�/�/ 
=
�/�/ 
$num
�/�/ $
,
�/�/$ %$
VIOLENT_MOTION_ABILITY
�/�/ "
=
�/�/# $
$num
�/�/% *
,
�/�/* +!
REACH_HIGHT_ABILITY
�/�/ 
=
�/�/  !
$num
�/�/" '
,
�/�/' (
GET_UP_ABILITY
�/�/ 
=
�/�/ 
$num
�/�/ #
,
�/�/# $
LEFT_ABILITY
�/�/ 
=
�/�/ 
$num
�/�/ !
,
�/�/! "
TAKE_ABILITY
�/�/ 
=
�/�/ 
$num
�/�/ !
,
�/�/! "
LEAVE_POSITION
�/�/ 
=
�/�/ 
$num
�/�/ #
,
�/�/# $

�/�/ 
=
�/�/ 
$num
�/�/ #
,
�/�/# $'
KEY_PERSON_GET_UP_ABILITY
�/�/ %
=
�/�/& '
$num
�/�/( /
,
�/�// 0
FALL_DOWN_ABILITY
�/�/ 
=
�/�/ 
$num
�/�/  '
,
�/�/' ($
AUDIO_ABNORMAL_ABILITY
�/�/ "
=
�/�/# $
$num
�/�/% -
,
�/�/- .&
ADV_REACH_HEIGHT_ABILITY
�/�/ $
=
�/�/% &
$num
�/�/' /
,
�/�// 0"
TOILET_TARRY_ABILITY
�/�/  
=
�/�/! "
$num
�/�/# +
,
�/�/+ , 
YARD_TARRY_ABILITY
�/�/ 
=
�/�/  
$num
�/�/! )
,
�/�/) *(
ADV_TRAVERSE_PLANE_ABILITY
�/�/ &
=
�/�/' (
$num
�/�/) 2
,
�/�/2 3!
HUMAN_ENTER_ABILITY
�/�/ 
=
�/�/  !
$num
�/�/" ,
,
�/�/, -
OVER_TIME_ABILITY
�/�/ 
=
�/�/ 
$num
�/�/  *
,
�/�/* +
STICK_UP_ABILITY
�/�/ 
=
�/�/ 
$num
�/�/ )
,
�/�/) *%
INSTALL_SCANNER_ABILITY
�/�/ #
=
�/�/$ %
$num
�/�/& 0
}
�/�/ 	
public
�/�/ 
enum
�/�/ #
VCA_CHAN_ABILITY_TYPE
�/�/ )
{
�/�/ 	
VCA_BEHAVIOR_BASE
�/�/ 
=
�/�/ 
$num
�/�/  !
,
�/�/! ""
VCA_BEHAVIOR_ADVANCE
�/�/  
=
�/�/! "
$num
�/�/# $
,
�/�/$ %
VCA_BEHAVIOR_FULL
�/�/ 
=
�/�/ 
$num
�/�/  !
,
�/�/! "
	VCA_PLATE
�/�/ 
=
�/�/ 
$num
�/�/ 
,
�/�/ 
VCA_ATM
�/�/ 
=
�/�/ 
$num
�/�/ 
,
�/�/ 
VCA_PDC
�/�/ 
=
�/�/ 
$num
�/�/ 
,
�/�/ 
VCA_ITS
�/�/ 
=
�/�/ 
$num
�/�/ 
,
�/�/ !
VCA_BEHAVIOR_PRISON
�/�/ 
=
�/�/  !
$num
�/�/" #
,
�/�/# $

�/�/ 
=
�/�/ 
$num
�/�/ 
,
�/�/  
VCA_FACE_SNAPRECOG
�/�/ 
=
�/�/  
$num
�/�/! #
,
�/�/# $ 
VCA_FACE_RETRIEVAL
�/�/ 
=
�/�/  
$num
�/�/! #
,
�/�/# $
VCA_FACE_RECOG
�/�/ 
=
�/�/ 
$num
�/�/ 
,
�/�/  +
VCA_BEHAVIOR_PRISON_PERIMETER
�/�/ )
=
�/�/* +
$num
�/�/, .
,
�/�/. /
VCA_TPS
�/�/ 
=
�/�/ 
$num
�/�/ 
,
�/�/ 
VCA_TFS
�/�/ 
=
�/�/ 
$num
�/�/ 
,
�/�/ #
VCA_BEHAVIOR_FACESNAP
�/�/ !
=
�/�/" #
$num
�/�/$ &
}
�/�/ 	
public
�0�0 
enum
�0�0  
VCA_CHAN_MODE_TYPE
�0�0 &
{
�0�0 	

�0�0 
=
�0�0 
$num
�0�0 
,
�0�0 
VCA_ATM_SURROUND
�0�0 
=
�0�0 
$num
�0�0  
,
�0�0  !
VCA_ATM_FACE
�0�0 
=
�0�0 
$num
�0�0 
}
�0�0 	
public
�0�0 
enum
�0�0  
TFS_CHAN_MODE_TYPE
�0�0 &
{
�0�0 	
TFS_CITYROAD
�0�0 
=
�0�0 
$num
�0�0 
,
�0�0 
TFS_FREEWAY
�0�0 
=
�0�0 
$num
�0�0 
}
�0�0 	
public
�0�0 
enum
�0�0 &
BEHAVIOR_SCENE_MODE_TYPE
�0�0 ,
{
�0�0 	$
BEHAVIOR_SCENE_DEFAULT
�0�0 "
=
�0�0# $
$num
�0�0% &
,
�0�0& '!
BEHAVIOR_SCENE_WALL
�0�0 
=
�0�0  !
$num
�0�0" #
,
�0�0# $#
BEHAVIOR_SCENE_INDOOR
�0�0 !
=
�0�0" #
$num
�0�0$ %
}
�0�0 	
[
�0�0 	#
StructLayoutAttribute
�0�0	 
(
�0�0 

LayoutKind
�0�0 )
.
�0�0) *

Sequential
�0�0* 4
)
�0�04 5
]
�0�05 6
public
�0�0 
struct
�0�0 #
NET_VCA_CHAN_IN_PARAM
�0�0 +
{
�0�0 	
public
�0�0 
byte
�0�0 
	byVCAType
�0�0 !
;
�0�0! "
public
�0�0 
byte
�0�0 
byMode
�0�0 
;
�0�0 
[
�0�0 
MarshalAsAttribute
�0�0
(
�0�0  

�0�0  -
.
�0�0- .

ByValArray
�0�0. 8
,
�0�08 9
	SizeConst
�0�0: C
=
�0�0D E
$num
�0�0F G
,
�0�0G H
ArraySubType
�0�0I U
=
�0�0V W

�0�0X e
.
�0�0e f
I1
�0�0f h
)
�0�0h i
]
�0�0i j
public
�0�0 
byte
�0�0 
[
�0�0 
]
�0�0 
byRes
�0�0 
;
�0�0  
}
�0�0 	
[
�0�0 	#
StructLayoutAttribute
�0�0	 
(
�0�0 

LayoutKind
�0�0 )
.
�0�0) *

Sequential
�0�0* 4
)
�0�04 5
]
�0�05 6
public
�0�0 
struct
�0�0 &
NET_VCA_BEHAVIOR_ABILITY
�0�0 .
{
�0�0 	
public
�0�0 
uint
�0�0 
dwSize
�0�0 
;
�0�0 
public
�0�0 
uint
�0�0 

�0�0 %
;
�0�0% &
public
�0�0 
byte
�0�0 
byMaxRuleNum
�0�0 $
;
�0�0$ %
public
�0�0 
byte
�0�0 
byMaxTargetNum
�0�0 &
;
�0�0& '
public
�0�0 
byte
�0�0 
	bySupport
�0�0 !
;
�0�0! "
[
�0�0 
MarshalAsAttribute
�0�0
(
�0�0  

�0�0  -
.
�0�0- .

ByValArray
�0�0. 8
,
�0�08 9
	SizeConst
�0�0: C
=
�0�0D E
$num
�0�0F G
,
�0�0G H
ArraySubType
�0�0I U
=
�0�0V W

�0�0X e
.
�0�0e f
I1
�0�0f h
)
�0�0h i
]
�0�0i j
public
�0�0 
byte
�0�0 
[
�0�0 
]
�0�0 
byRes
�0�0 
;
�0�0  
}
�0�0 	
[
�0�0 	#
StructLayoutAttribute
�0�0	 
(
�0�0 

LayoutKind
�0�0 )
.
�0�0) *

Sequential
�0�0* 4
)
�0�04 5
]
�0�05 6
public
�0�0 
struct
�0�0 !
NET_DVR_ITS_ABILITY
�0�0 )
{
�0�0 	
public
�0�0 
uint
�0�0 
dwSize
�0�0 
;
�0�0 
public
�0�0 
uint
�0�0 

�0�0 %
;
�0�0% &
public
�0�0 
byte
�0�0 
byMaxRuleNum
�0�0 $
;
�0�0$ %
public
�0�0 
byte
�0�0 
byMaxTargetNum
�0�0 &
;
�0�0& '
[
�0�0 
MarshalAsAttribute
�0�0
(
�0�0  

�0�0  -
.
�0�0- .

ByValArray
�0�0. 8
,
�0�08 9
	SizeConst
�0�0: C
=
�0�0D E
$num
�0�0F H
,
�0�0H I
ArraySubType
�0�0J V
=
�0�0W X

�0�0Y f
.
�0�0f g
I1
�0�0g i
)
�0�0i j
]
�0�0j k
public
�0�0 
byte
�0�0 
[
�0�0 
]
�0�0 
byRes
�0�0 
;
�0�0  
}
�0�0 	
[
�0�0 	#
StructLayoutAttribute
�0�0	 
(
�0�0 

LayoutKind
�0�0 )
.
�0�0) *

Sequential
�0�0* 4
)
�0�04 5
]
�0�05 6
public
�0�0 
struct
�0�0 

�0�0 #
{
�0�0 	
public
�0�0 
float
�0�0 
fX
�0�0 
;
�0�0 
public
�0�0 
float
�0�0 
fY
�0�0 
;
�0�0 
}
�0�0 	
[
�0�0 	#
StructLayoutAttribute
�0�0	 
(
�0�0 

LayoutKind
�0�0 )
.
�0�0) *

Sequential
�0�0* 4
)
�0�04 5
]
�0�05 6
public
�0�0 
struct
�0�0 
NET_VCA_RECT
�0�0 "
{
�0�0 	
public
�0�0 
float
�0�0 
fX
�0�0 
;
�0�0 
public
�0�0 
float
�0�0 
fY
�0�0 
;
�0�0 
public
�0�0 
float
�0�0 
fWidth
�0�0 
;
�0�0  
public
�0�0 
float
�0�0 
fHeight
�0�0  
;
�0�0  !
}
�0�0 	
public
�0�0 
enum
�0�0 
VCA_EVENT_TYPE
�0�0 "
:
�0�0# $
uint
�0�0% )
{
�0�0 	 
VCA_TRAVERSE_PLANE
�0�0 
=
�0�0  
$num
�0�0! $
,
�0�0$ %
VCA_ENTER_AREA
�0�0 
=
�0�0 
$num
�0�0  
,
�0�0  !

�0�0 
=
�0�0 
$num
�0�0 
,
�0�0  

�0�0 
=
�0�0 
$num
�0�0 
,
�0�0  

VCA_LOITER
�0�0 
=
�0�0 
$num
�0�0 
,
�0�0 

�0�0 
=
�0�0 
$num
�0�0  
,
�0�0  !
VCA_PARKING
�0�0 
=
�0�0 
$num
�0�0 
,
�0�0 
VCA_RUN
�0�0 
=
�0�0 
$num
�0�0 
,
�0�0 
VCA_HIGH_DENSITY
�0�0 
=
�0�0 
$num
�0�0 $
,
�0�0$ % 
VCA_VIOLENT_MOTION
�0�0 
=
�0�0  
$num
�0�0! &
,
�0�0& '
VCA_REACH_HIGHT
�0�0 
=
�0�0 
$num
�0�0 #
,
�0�0# $

VCA_GET_UP
�0�0 
=
�0�0 
$num
�0�0 
,
�0�0 
VCA_LEFT
�0�0 
=
�0�0 
$num
�0�0 
,
�0�0 
VCA_TAKE
�0�0 
=
�0�0 
$num
�0�0 
,
�0�0  
VCA_LEAVE_POSITION
�0�0 
=
�0�0  
$num
�0�0! '
,
�0�0' (
	VCA_TRAIL
�0�0 
=
�0�0 
$num
�0�0 
,
�0�0 #
VCA_KEY_PERSON_GET_UP
�0�0 !
=
�0�0" #
$num
�0�0$ +
,
�0�0+ ,

�0�0 
=
�0�0 
$num
�0�0 #
,
�0�0# $ 
VCA_AUDIO_ABNORMAL
�0�0 
=
�0�0  
$num
�0�0! )
,
�0�0) *"
VCA_ADV_REACH_HEIGHT
�0�0  
=
�0�0! "
$num
�0�0# +
,
�0�0+ ,
VCA_TOILET_TARRY
�0�0 
=
�0�0 
$num
�0�0 '
,
�0�0' (
VCA_YARD_TARRY
�0�0 
=
�0�0 
$num
�0�0 %
,
�0�0% &$
VCA_ADV_TRAVERSE_PLANE
�0�0 "
=
�0�0# $
$num
�0�0% .
,
�0�0. /
VCA_HUMAN_ENTER
�0�0 
=
�0�0 
$num
�0�0 (
,
�0�0( )

�0�0 
=
�0�0 
$num
�0�0 &
,
�0�0& '
VCA_STICK_UP
�0�0 
=
�0�0 
$num
�0�0 %
,
�0�0% &!
VCA_INSTALL_SCANNER
�0�0 
=
�0�0  !
$num
�0�0" ,
}
�0�0 	
public
�0�0 
enum
�0�0 $
VCA_RULE_EVENT_TYPE_EX
�0�0 *
{
�0�0 	+
ENUM_VCA_EVENT_TRAVERSE_PLANE
�0�0 )
=
�0�0* +
$num
�0�0, -
,
�0�0- .'
ENUM_VCA_EVENT_ENTER_AREA
�0�0 %
=
�0�0& '
$num
�0�0( )
,
�0�0) *&
ENUM_VCA_EVENT_EXIT_AREA
�0�0 $
=
�0�0% &
$num
�0�0' (
,
�0�0( )&
ENUM_VCA_EVENT_INTRUSION
�0�0 $
=
�0�0% &
$num
�0�0' (
,
�0�0( )#
ENUM_VCA_EVENT_LOITER
�0�0 !
=
�0�0" #
$num
�0�0$ %
,
�0�0% &&
ENUM_VCA_EVENT_LEFT_TAKE
�0�0 $
=
�0�0% &
$num
�0�0' (
,
�0�0( )$
ENUM_VCA_EVENT_PARKING
�0�0 "
=
�0�0# $
$num
�0�0% &
,
�0�0& ' 
ENUM_VCA_EVENT_RUN
�0�0 
=
�0�0  
$num
�0�0! "
,
�0�0" #)
ENUM_VCA_EVENT_HIGH_DENSITY
�0�0 '
=
�0�0( )
$num
�0�0* +
,
�0�0+ ,+
ENUM_VCA_EVENT_VIOLENT_MOTION
�0�0 )
=
�0�0* +
$num
�0�0, .
,
�0�0. /(
ENUM_VCA_EVENT_REACH_HIGHT
�0�0 &
=
�0�0' (
$num
�0�0) +
,
�0�0+ ,#
ENUM_VCA_EVENT_GET_UP
�0�0 !
=
�0�0" #
$num
�0�0$ &
,
�0�0& '!
ENUM_VCA_EVENT_LEFT
�0�0 
=
�0�0  !
$num
�0�0" $
,
�0�0$ %!
ENUM_VCA_EVENT_TAKE
�0�0 
=
�0�0  !
$num
�0�0" $
,
�0�0$ %+
ENUM_VCA_EVENT_LEAVE_POSITION
�0�0 )
=
�0�0* +
$num
�0�0, .
,
�0�0. /"
ENUM_VCA_EVENT_TRAIL
�1�1  
=
�1�1! "
$num
�1�1# %
,
�1�1% &.
 ENUM_VCA_EVENT_KEY_PERSON_GET_UP
�1�1 ,
=
�1�1- .
$num
�1�1/ 1
,
�1�11 2&
ENUM_VCA_EVENT_FALL_DOWN
�1�1 $
=
�1�1% &
$num
�1�1' )
,
�1�1) *+
ENUM_VCA_EVENT_AUDIO_ABNORMAL
�1�1 )
=
�1�1* +
$num
�1�1, .
,
�1�1. /-
ENUM_VCA_EVENT_ADV_REACH_HEIGHT
�1�1 +
=
�1�1, -
$num
�1�1. 0
,
�1�10 1)
ENUM_VCA_EVENT_TOILET_TARRY
�1�1 '
=
�1�1( )
$num
�1�1* ,
,
�1�1, -'
ENUM_VCA_EVENT_YARD_TARRY
�1�1 %
=
�1�1& '
$num
�1�1( *
,
�1�1* +/
!ENUM_VCA_EVENT_ADV_TRAVERSE_PLANE
�1�1 -
=
�1�1. /
$num
�1�10 2
,
�1�12 3(
ENUM_VCA_EVENT_HUMAN_ENTER
�1�1 &
=
�1�1' (
$num
�1�1) +
,
�1�1+ ,&
ENUM_VCA_EVENT_OVER_TIME
�1�1 $
=
�1�1% &
$num
�1�1' )
,
�1�1) *%
ENUM_VCA_EVENT_STICK_UP
�1�1 #
=
�1�1$ %
$num
�1�1& (
,
�1�1( ),
ENUM_VCA_EVENT_INSTALL_SCANNER
�1�1 *
=
�1�1+ ,
$num
�1�1- /
}
�1�1 	
public
�1�1 
enum
�1�1 !
VCA_CROSS_DIRECTION
�1�1 '
{
�1�1 	 
VCA_BOTH_DIRECTION
�1�1 
,
�1�1 
VCA_LEFT_GO_RIGHT
�1�1 
,
�1�1 
VCA_RIGHT_GO_LEFT
�1�1 
,
�1�1 
}
�1�1 	
[
�1�1 	#
StructLayoutAttribute
�1�1	 
(
�1�1 

LayoutKind
�1�1 )
.
�1�1) *

Sequential
�1�1* 4
)
�1�14 5
]
�1�15 6
public
�1�1 
struct
�1�1 
NET_VCA_LINE
�1�1 "
{
�1�1 	
public
�1�1 

�1�1  
	struStart
�1�1! *
;
�1�1* +
public
�1�1 

�1�1  
struEnd
�1�1! (
;
�1�1( )
}
�1�1 	
[
�1�1 	#
StructLayoutAttribute
�1�1	 
(
�1�1 

LayoutKind
�1�1 )
.
�1�1) *

Sequential
�1�1* 4
)
�1�14 5
]
�1�15 6
public
�1�1 
struct
�1�1 
NET_VCA_POLYGON
�1�1 %
{
�1�1 	
public
�1�1 
uint
�1�1 

dwPointNum
�1�1 "
;
�1�1" #
[
�1�1 
MarshalAsAttribute
�1�1
(
�1�1  

�1�1  -
.
�1�1- .

ByValArray
�1�1. 8
,
�1�18 9
	SizeConst
�1�1: C
=
�1�1D E'
VCA_MAX_POLYGON_POINT_NUM
�1�1F _
,
�1�1_ `
ArraySubType
�1�1a m
=
�1�1n o

�1�1p }
.
�1�1} ~
Struct�1�1~ �
)�1�1� �
]�1�1� �
public
�1�1 

�1�1  
[
�1�1  !
]
�1�1! "
struPos
�1�1# *
;
�1�1* +
}
�1�1 	
[
�1�1 	#
StructLayoutAttribute
�1�1	 
(
�1�1 

LayoutKind
�1�1 )
.
�1�1) *

Sequential
�1�1* 4
)
�1�14 5
]
�1�15 6
public
�1�1 
struct
�1�1 $
NET_VCA_TRAVERSE_PLANE
�1�1 ,
{
�1�1 	
public
�1�1 
NET_VCA_LINE
�1�1 
struPlaneBottom
�1�1  /
;
�1�1/ 0
public
�1�1 !
VCA_CROSS_DIRECTION
�1�1 &
dwCrossDirection
�1�1' 7
;
�1�17 8
public
�1�1 
byte
�1�1 
byRes1
�1�1 
;
�1�1 
public
�1�1 
byte
�1�1 

�1�1 %
;
�1�1% &
[
�1�1 
MarshalAsAttribute
�1�1
(
�1�1  

�1�1  -
.
�1�1- .

ByValArray
�1�1. 8
,
�1�18 9
	SizeConst
�1�1: C
=
�1�1D E
$num
�1�1F H
,
�1�1H I
ArraySubType
�1�1J V
=
�1�1W X

�1�1Y f
.
�1�1f g
I1
�1�1g i
)
�1�1i j
]
�1�1j k
public
�1�1 
byte
�1�1 
[
�1�1 
]
�1�1 
byRes2
�1�1  
;
�1�1  !
}
�1�1 	
[
�1�1 	#
StructLayoutAttribute
�1�1	 
(
�1�1 

LayoutKind
�1�1 )
.
�1�1) *

Sequential
�1�1* 4
)
�1�14 5
]
�1�15 6
public
�1�1 
struct
�1�1 
NET_VCA_AREA
�1�1 "
{
�1�1 	
public
�1�1 
NET_VCA_POLYGON
�1�1 "

struRegion
�1�1# -
;
�1�1- .
[
�1�1 
MarshalAsAttribute
�1�1
(
�1�1  

�1�1  -
.
�1�1- .

ByValArray
�1�1. 8
,
�1�18 9
	SizeConst
�1�1: C
=
�1�1D E
$num
�1�1F G
,
�1�1G H
ArraySubType
�1�1I U
=
�1�1V W

�1�1X e
.
�1�1e f
I1
�1�1f h
)
�1�1h i
]
�1�1i j
public
�1�1 
byte
�1�1 
[
�1�1 
]
�1�1 
byRes
�1�1 
;
�1�1  
}
�1�1 	
[
�1�1 	#
StructLayoutAttribute
�1�1	 
(
�1�1 

LayoutKind
�1�1 )
.
�1�1) *

Sequential
�1�1* 4
)
�1�14 5
]
�1�15 6
public
�1�1 
struct
�1�1 
NET_VCA_INTRUSION
�1�1 '
{
�1�1 	
public
�1�1 
NET_VCA_POLYGON
�1�1 "

struRegion
�1�1# -
;
�1�1- .
public
�1�1 
ushort
�1�1 
	wDuration
�1�1 #
;
�1�1# $
public
�1�1 
byte
�1�1 

�1�1 %
;
�1�1% &
public
�1�1 
byte
�1�1 
byRate
�1�1 
;
�1�1 
[
�1�1 
MarshalAsAttribute
�1�1
(
�1�1  

�1�1  -
.
�1�1- .

ByValArray
�1�1. 8
,
�1�18 9
	SizeConst
�1�1: C
=
�1�1D E
$num
�1�1F G
,
�1�1G H
ArraySubType
�1�1I U
=
�1�1V W

�1�1X e
.
�1�1e f
I1
�1�1f h
)
�1�1h i
]
�1�1i j
public
�1�1 
byte
�1�1 
[
�1�1 
]
�1�1 
byRes
�1�1 
;
�1�1  
}
�1�1 	
[
�1�1 	#
StructLayoutAttribute
�1�1	 
(
�1�1 

LayoutKind
�1�1 )
.
�1�1) *

Sequential
�1�1* 4
)
�1�14 5
]
�1�15 6
public
�1�1 
struct
�1�1 
NET_VCA_LOITER
�1�1 $
{
�1�1 	
public
�1�1 
NET_VCA_POLYGON
�1�1 "

struRegion
�1�1# -
;
�1�1- .
public
�1�1 
ushort
�1�1 
	wDuration
�1�1 #
;
�1�1# $
[
�1�1 
MarshalAsAttribute
�1�1
(
�1�1  

�1�1  -
.
�1�1- .

ByValArray
�1�1. 8
,
�1�18 9
	SizeConst
�1�1: C
=
�1�1D E
$num
�1�1F G
,
�1�1G H
ArraySubType
�1�1I U
=
�1�1V W

�1�1X e
.
�1�1e f
I1
�1�1f h
)
�1�1h i
]
�1�1i j
public
�1�1 
byte
�1�1 
[
�1�1 
]
�1�1 
byRes
�1�1 
;
�1�1  
}
�1�1 	
[
�1�1 	#
StructLayoutAttribute
�1�1	 
(
�1�1 

LayoutKind
�1�1 )
.
�1�1) *

Sequential
�1�1* 4
)
�1�14 5
]
�1�15 6
public
�1�1 
struct
�1�1 
NET_VCA_TAKE_LEFT
�1�1 '
{
�1�1 	
public
�1�1 
NET_VCA_POLYGON
�1�1 "

struRegion
�1�1# -
;
�1�1- .
public
�1�1 
ushort
�1�1 
	wDuration
�1�1 #
;
�1�1# $
[
�1�1 
MarshalAsAttribute
�1�1
(
�1�1  

�1�1  -
.
�1�1- .

ByValArray
�1�1. 8
,
�1�18 9
	SizeConst
�1�1: C
=
�1�1D E
$num
�1�1F G
,
�1�1G H
ArraySubType
�1�1I U
=
�1�1V W

�1�1X e
.
�1�1e f
I1
�1�1f h
)
�1�1h i
]
�1�1i j
public
�1�1 
byte
�1�1 
[
�1�1 
]
�1�1 
byRes
�1�1 
;
�1�1  
}
�1�1 	
[
�1�1 	#
StructLayoutAttribute
�1�1	 
(
�1�1 

LayoutKind
�1�1 )
.
�1�1) *

Sequential
�1�1* 4
)
�1�14 5
]
�1�15 6
public
�1�1 
struct
�1�1 
NET_VCA_PARKING
�1�1 %
{
�1�1 	
public
�1�1 
NET_VCA_POLYGON
�1�1 "

struRegion
�1�1# -
;
�1�1- .
public
�1�1 
ushort
�1�1 
	wDuration
�1�1 #
;
�1�1# $
[
�1�1 
MarshalAsAttribute
�1�1
(
�1�1  

�1�1  -
.
�1�1- .

ByValArray
�1�1. 8
,
�1�18 9
	SizeConst
�1�1: C
=
�1�1D E
$num
�1�1F G
,
�1�1G H
ArraySubType
�1�1I U
=
�1�1V W

�1�1X e
.
�1�1e f
I1
�1�1f h
)
�1�1h i
]
�1�1i j
public
�1�1 
byte
�1�1 
[
�1�1 
]
�1�1 
byRes
�1�1 
;
�1�1  
}
�1�1 	
[
�1�1 	#
StructLayoutAttribute
�1�1	 
(
�1�1 

LayoutKind
�1�1 )
.
�1�1) *

Sequential
�1�1* 4
)
�1�14 5
]
�1�15 6
public
�1�1 
struct
�1�1 
NET_VCA_RUN
�1�1 !
{
�1�1 	
public
�1�1 
NET_VCA_POLYGON
�1�1 "

struRegion
�1�1# -
;
�1�1- .
public
�1�1 
float
�1�1 
fRunDistance
�1�1 %
;
�1�1% &
public
�1�1 
byte
�1�1 
byRes1
�1�1 
;
�1�1 
public
�1�1 
byte
�1�1 
byMode
�1�1 
;
�1�1 
[
�1�1 
MarshalAsAttribute
�1�1
(
�1�1  

�1�1  -
.
�1�1- .

ByValArray
�1�1. 8
,
�1�18 9
	SizeConst
�1�1: C
=
�1�1D E
$num
�1�1F G
,
�1�1G H
ArraySubType
�1�1I U
=
�1�1V W

�1�1X e
.
�1�1e f
I1
�1�1f h
)
�1�1h i
]
�1�1i j
public
�1�1 
byte
�1�1 
[
�1�1 
]
�1�1 
byRes
�1�1 
;
�1�1  
}
�2�2 	
[
�2�2 	#
StructLayoutAttribute
�2�2	 
(
�2�2 

LayoutKind
�2�2 )
.
�2�2) *

Sequential
�2�2* 4
)
�2�24 5
]
�2�25 6
public
�2�2 
struct
�2�2 "
NET_VCA_HIGH_DENSITY
�2�2 *
{
�2�2 	
public
�2�2 
NET_VCA_POLYGON
�2�2 "

struRegion
�2�2# -
;
�2�2- .
public
�2�2 
float
�2�2 
fDensity
�2�2 !
;
�2�2! "
[
�2�2 
MarshalAsAttribute
�2�2
(
�2�2  

�2�2  -
.
�2�2- .

ByValArray
�2�2. 8
,
�2�28 9
	SizeConst
�2�2: C
=
�2�2D E
$num
�2�2F G
,
�2�2G H
ArraySubType
�2�2I U
=
�2�2V W

�2�2X e
.
�2�2e f
I1
�2�2f h
)
�2�2h i
]
�2�2i j
public
�2�2 
byte
�2�2 
[
�2�2 
]
�2�2 
byRes
�2�2 
;
�2�2  
public
�2�2 
ushort
�2�2 
	wDuration
�2�2 #
;
�2�2# $
}
�2�2 	
[
�2�2 	#
StructLayoutAttribute
�2�2	 
(
�2�2 

LayoutKind
�2�2 )
.
�2�2) *

Sequential
�2�2* 4
)
�2�24 5
]
�2�25 6
public
�2�2 
struct
�2�2 $
NET_VCA_VIOLENT_MOTION
�2�2 ,
{
�2�2 	
public
�2�2 
NET_VCA_POLYGON
�2�2 "

struRegion
�2�2# -
;
�2�2- .
public
�2�2 
ushort
�2�2 
	wDuration
�2�2 #
;
�2�2# $
public
�2�2 
byte
�2�2 

�2�2 %
;
�2�2% &
public
�2�2 
byte
�2�2 
byMode
�2�2 
;
�2�2 
[
�2�2 
MarshalAsAttribute
�2�2
(
�2�2  

�2�2  -
.
�2�2- .

ByValArray
�2�2. 8
,
�2�28 9
	SizeConst
�2�2: C
=
�2�2D E
$num
�2�2F G
,
�2�2G H
ArraySubType
�2�2I U
=
�2�2V W

�2�2X e
.
�2�2e f
I1
�2�2f h
)
�2�2h i
]
�2�2i j
public
�2�2 
byte
�2�2 
[
�2�2 
]
�2�2 
byRes
�2�2 
;
�2�2  
}
�2�2 	
[
�2�2 	#
StructLayoutAttribute
�2�2	 
(
�2�2 

LayoutKind
�2�2 )
.
�2�2) *

Sequential
�2�2* 4
)
�2�24 5
]
�2�25 6
public
�2�2 
struct
�2�2 !
NET_VCA_REACH_HIGHT
�2�2 )
{
�2�2 	
public
�2�2 
NET_VCA_LINE
�2�2 
struVcaLine
�2�2  +
;
�2�2+ ,
public
�2�2 
ushort
�2�2 
	wDuration
�2�2 #
;
�2�2# $
[
�2�2 
MarshalAsAttribute
�2�2
(
�2�2  

�2�2  -
.
�2�2- .

ByValArray
�2�2. 8
,
�2�28 9
	SizeConst
�2�2: C
=
�2�2D E
$num
�2�2F G
,
�2�2G H
ArraySubType
�2�2I U
=
�2�2V W

�2�2X e
.
�2�2e f
I1
�2�2f h
)
�2�2h i
]
�2�2i j
public
�2�2 
byte
�2�2 
[
�2�2 
]
�2�2 
byRes
�2�2 
;
�2�2  
}
�2�2 	
[
�2�2 	#
StructLayoutAttribute
�2�2	 
(
�2�2 

LayoutKind
�2�2 )
.
�2�2) *

Sequential
�2�2* 4
)
�2�24 5
]
�2�25 6
public
�2�2 
struct
�2�2 
NET_VCA_GET_UP
�2�2 $
{
�2�2 	
public
�2�2 
NET_VCA_POLYGON
�2�2 "

struRegion
�2�2# -
;
�2�2- .
public
�2�2 
ushort
�2�2 
	wDuration
�2�2 #
;
�2�2# $
public
�2�2 
byte
�2�2 
byMode
�2�2 
;
�2�2 
public
�2�2 
byte
�2�2 

�2�2 %
;
�2�2% &
[
�2�2 
MarshalAsAttribute
�2�2
(
�2�2  

�2�2  -
.
�2�2- .

ByValArray
�2�2. 8
,
�2�28 9
	SizeConst
�2�2: C
=
�2�2D E
$num
�2�2F G
,
�2�2G H
ArraySubType
�2�2I U
=
�2�2V W

�2�2X e
.
�2�2e f
I1
�2�2f h
)
�2�2h i
]
�2�2i j
public
�2�2 
byte
�2�2 
[
�2�2 
]
�2�2 
byRes
�2�2 
;
�2�2  
}
�2�2 	
[
�2�2 	#
StructLayoutAttribute
�2�2	 
(
�2�2 

LayoutKind
�2�2 )
.
�2�2) *

Sequential
�2�2* 4
)
�2�24 5
]
�2�25 6
public
�2�2 
struct
�2�2 
NET_VCA_LEFT
�2�2 "
{
�2�2 	
public
�2�2 
NET_VCA_POLYGON
�2�2 "

struRegion
�2�2# -
;
�2�2- .
public
�2�2 
ushort
�2�2 
	wDuration
�2�2 #
;
�2�2# $
public
�2�2 
byte
�2�2 

�2�2 %
;
�2�2% &
[
�2�2 
MarshalAsAttribute
�2�2
(
�2�2  

�2�2  -
.
�2�2- .

ByValArray
�2�2. 8
,
�2�28 9
	SizeConst
�2�2: C
=
�2�2D E
$num
�2�2F G
,
�2�2G H
ArraySubType
�2�2I U
=
�2�2V W

�2�2X e
.
�2�2e f
I1
�2�2f h
)
�2�2h i
]
�2�2i j
public
�2�2 
byte
�2�2 
[
�2�2 
]
�2�2 
byRes
�2�2 
;
�2�2  
}
�2�2 	
[
�2�2 	#
StructLayoutAttribute
�2�2	 
(
�2�2 

LayoutKind
�2�2 )
.
�2�2) *

Sequential
�2�2* 4
)
�2�24 5
]
�2�25 6
public
�2�2 
struct
�2�2 
NET_VCA_TAKE
�2�2 "
{
�2�2 	
public
�2�2 
NET_VCA_POLYGON
�2�2 "

struRegion
�2�2# -
;
�2�2- .
public
�2�2 
ushort
�2�2 
	wDuration
�2�2 #
;
�2�2# $
public
�2�2 
byte
�2�2 

�2�2 %
;
�2�2% &
[
�2�2 
MarshalAsAttribute
�2�2
(
�2�2  

�2�2  -
.
�2�2- .

ByValArray
�2�2. 8
,
�2�28 9
	SizeConst
�2�2: C
=
�2�2D E
$num
�2�2F G
,
�2�2G H
ArraySubType
�2�2I U
=
�2�2V W

�2�2X e
.
�2�2e f
I1
�2�2f h
)
�2�2h i
]
�2�2i j
public
�2�2 
byte
�2�2 
[
�2�2 
]
�2�2 
byRes
�2�2 
;
�2�2  
}
�2�2 	
[
�2�2 	#
StructLayoutAttribute
�2�2	 
(
�2�2 

LayoutKind
�2�2 )
.
�2�2) *

Sequential
�2�2* 4
)
�2�24 5
]
�2�25 6
public
�2�2 
struct
�2�2 
NET_VCA_OVER_TIME
�2�2 '
{
�2�2 	
public
�2�2 
NET_VCA_POLYGON
�2�2 "

struRegion
�2�2# -
;
�2�2- .
public
�2�2 
ushort
�2�2 
	wDuration
�2�2 #
;
�2�2# $
[
�2�2 
MarshalAsAttribute
�2�2
(
�2�2  

�2�2  -
.
�2�2- .

ByValArray
�2�2. 8
,
�2�28 9
	SizeConst
�2�2: C
=
�2�2D E
$num
�2�2F G
,
�2�2G H
ArraySubType
�2�2I U
=
�2�2V W

�2�2X e
.
�2�2e f
I1
�2�2f h
)
�2�2h i
]
�2�2i j
public
�2�2 
byte
�2�2 
[
�2�2 
]
�2�2 
byRes
�2�2 
;
�2�2  
}
�2�2 	
[
�2�2 	#
StructLayoutAttribute
�2�2	 
(
�2�2 

LayoutKind
�2�2 )
.
�2�2) *

Sequential
�2�2* 4
)
�2�24 5
]
�2�25 6
public
�2�2 
struct
�2�2 !
NET_VCA_HUMAN_ENTER
�2�2 )
{
�2�2 	
[
�2�2 
MarshalAsAttribute
�2�2
(
�2�2  

�2�2  -
.
�2�2- .

ByValArray
�2�2. 8
,
�2�28 9
	SizeConst
�2�2: C
=
�2�2D E
$num
�2�2F H
,
�2�2H I
ArraySubType
�2�2J V
=
�2�2W X

�2�2Y f
.
�2�2f g
U4
�2�2g i
)
�2�2i j
]
�2�2j k
public
�2�2 
uint
�2�2 
[
�2�2 
]
�2�2 
dwRes
�2�2 
;
�2�2  
}
�2�2 	
[
�2�2 	#
StructLayoutAttribute
�2�2	 
(
�2�2 

LayoutKind
�2�2 )
.
�2�2) *

Sequential
�2�2* 4
)
�2�24 5
]
�2�25 6
public
�2�2 
struct
�2�2 
NET_VCA_STICK_UP
�2�2 &
{
�2�2 	
public
�2�2 
NET_VCA_POLYGON
�2�2 "

struRegion
�2�2# -
;
�2�2- .
public
�2�2 
ushort
�2�2 
	wDuration
�2�2 #
;
�2�2# $
public
�2�2 
byte
�2�2 

�2�2 %
;
�2�2% &
[
�2�2 
MarshalAsAttribute
�2�2
(
�2�2  

�2�2  -
.
�2�2- .

ByValArray
�2�2. 8
,
�2�28 9
	SizeConst
�2�2: C
=
�2�2D E
$num
�2�2F G
,
�2�2G H
ArraySubType
�2�2I U
=
�2�2V W

�2�2X e
.
�2�2e f
I1
�2�2f h
)
�2�2h i
]
�2�2i j
public
�2�2 
byte
�2�2 
[
�2�2 
]
�2�2 
byRes
�2�2 
;
�2�2  
}
�2�2 	
[
�2�2 	#
StructLayoutAttribute
�2�2	 
(
�2�2 

LayoutKind
�2�2 )
.
�2�2) *

Sequential
�2�2* 4
)
�2�24 5
]
�2�25 6
public
�2�2 
struct
�2�2 
NET_VCA_SCANNER
�2�2 %
{
�2�2 	
public
�2�2 
NET_VCA_POLYGON
�2�2 "

struRegion
�2�2# -
;
�2�2- .
public
�2�2 
ushort
�2�2 
	wDuration
�2�2 #
;
�2�2# $
public
�2�2 
byte
�2�2 

�2�2 %
;
�2�2% &
[
�2�2 
MarshalAsAttribute
�2�2
(
�2�2  

�2�2  -
.
�2�2- .

ByValArray
�2�2. 8
,
�2�28 9
	SizeConst
�2�2: C
=
�2�2D E
$num
�2�2F G
,
�2�2G H
ArraySubType
�2�2I U
=
�2�2V W

�2�2X e
.
�2�2e f
I1
�2�2f h
)
�2�2h i
]
�2�2i j
public
�2�2 
byte
�2�2 
[
�2�2 
]
�2�2 
byRes
�2�2 
;
�2�2  
}
�2�2 	
[
�2�2 	#
StructLayoutAttribute
�2�2	 
(
�2�2 

LayoutKind
�2�2 )
.
�2�2) *

Sequential
�2�2* 4
)
�2�24 5
]
�2�25 6
public
�2�2 
struct
�2�2 $
NET_VCA_LEAVE_POSITION
�2�2 ,
{
�2�2 	
public
�2�2 
NET_VCA_POLYGON
�2�2 "

struRegion
�2�2# -
;
�2�2- .
public
�2�2 
ushort
�2�2 
wLeaveDelay
�2�2 %
;
�2�2% &
public
�2�2 
ushort
�2�2 
wStaticDelay
�2�2 &
;
�2�2& '
public
�2�2 
byte
�2�2 
byMode
�2�2 
;
�2�2 
public
�2�2 
byte
�2�2 
byPersonType
�2�2 $
;
�2�2$ %
[
�2�2 
MarshalAsAttribute
�2�2
(
�2�2  

�2�2  -
.
�2�2- .

ByValArray
�2�2. 8
,
�2�28 9
	SizeConst
�2�2: C
=
�2�2D E
$num
�2�2F G
,
�2�2G H
ArraySubType
�2�2I U
=
�2�2V W

�2�2X e
.
�2�2e f
I1
�2�2f h
)
�2�2h i
]
�2�2i j
public
�2�2 
byte
�2�2 
[
�2�2 
]
�2�2 
byRes
�2�2 
;
�2�2  
}
�2�2 	
[
�2�2 	#
StructLayoutAttribute
�2�2	 
(
�2�2 

LayoutKind
�2�2 )
.
�2�2) *

Sequential
�2�2* 4
)
�2�24 5
]
�2�25 6
public
�2�2 
struct
�2�2 

�2�2 #
{
�2�2 	
public
�2�2 
NET_VCA_POLYGON
�2�2 "

struRegion
�2�2# -
;
�2�2- .
public
�2�2 
ushort
�2�2 
wRes
�2�2 
;
�2�2 
public
�2�2 
byte
�2�2 

�2�2 %
;
�2�2% &
[
�2�2 
MarshalAsAttribute
�2�2
(
�2�2  

�2�2  -
.
�2�2- .

ByValArray
�2�2. 8
,
�2�28 9
	SizeConst
�2�2: C
=
�2�2D E
$num
�2�2F G
,
�2�2G H
ArraySubType
�2�2I U
=
�2�2V W

�2�2X e
.
�2�2e f
I1
�2�2f h
)
�2�2h i
]
�2�2i j
public
�3�3 
byte
�3�3 
[
�3�3 
]
�3�3 
byRes
�3�3 
;
�3�3  
}
�3�3 	
[
�3�3 	#
StructLayoutAttribute
�3�3	 
(
�3�3 

LayoutKind
�3�3 )
.
�3�3) *

Sequential
�3�3* 4
)
�3�34 5
]
�3�35 6
public
�3�3 
struct
�3�3 
NET_VCA_FALL_DOWN
�3�3 '
{
�3�3 	
public
�3�3 
NET_VCA_POLYGON
�3�3 "

struRegion
�3�3# -
;
�3�3- .
public
�3�3 
ushort
�3�3 
	wDuration
�3�3 #
;
�3�3# $
public
�3�3 
byte
�3�3 

�3�3 %
;
�3�3% &
[
�3�3 
MarshalAsAttribute
�3�3
(
�3�3  

�3�3  -
.
�3�3- .

ByValArray
�3�3. 8
,
�3�38 9
	SizeConst
�3�3: C
=
�3�3D E
$num
�3�3F G
,
�3�3G H
ArraySubType
�3�3I U
=
�3�3V W

�3�3X e
.
�3�3e f
I1
�3�3f h
)
�3�3h i
]
�3�3i j
public
�3�3 
byte
�3�3 
[
�3�3 
]
�3�3 
byRes
�3�3 
;
�3�3  
}
�3�3 	
[
�3�3 	#
StructLayoutAttribute
�3�3	 
(
�3�3 

LayoutKind
�3�3 )
.
�3�3) *

Sequential
�3�3* 4
)
�3�34 5
]
�3�35 6
public
�3�3 
struct
�3�3 $
NET_VCA_AUDIO_ABNORMAL
�3�3 ,
{
�3�3 	
public
�3�3 
ushort
�3�3 
wDecibel
�3�3 "
;
�3�3" #
public
�3�3 
byte
�3�3 

�3�3 %
;
�3�3% &
public
�3�3 
byte
�3�3 
byAudioMode
�3�3 #
;
�3�3# $
public
�3�3 
byte
�3�3 
byEnable
�3�3  
;
�3�3  !
public
�3�3 
byte
�3�3 
byThreshold
�3�3 #
;
�3�3# $
[
�3�3 
MarshalAsAttribute
�3�3
(
�3�3  

�3�3  -
.
�3�3- .

ByValArray
�3�3. 8
,
�3�38 9
	SizeConst
�3�3: C
=
�3�3D E
$num
�3�3F H
,
�3�3H I
ArraySubType
�3�3J V
=
�3�3W X

�3�3Y f
.
�3�3f g
I1
�3�3g i
)
�3�3i j
]
�3�3j k
public
�3�3 
byte
�3�3 
[
�3�3 
]
�3�3 
byRes
�3�3 
;
�3�3  
}
�3�3 	
[
�3�3 	#
StructLayoutAttribute
�3�3	 
(
�3�3 

LayoutKind
�3�3 )
.
�3�3) *

Sequential
�3�3* 4
)
�3�34 5
]
�3�35 6
public
�3�3 
struct
�3�3 %
NET_DVR_AUDIO_EXCEPTION
�3�3 -
{
�3�3 	
public
�3�3 
uint
�3�3 
dwSize
�3�3 
;
�3�3 
public
�3�3 
byte
�3�3 &
byEnableAudioInException
�3�3 0
;
�3�30 1
[
�3�3 
MarshalAsAttribute
�3�3
(
�3�3  

�3�3  -
.
�3�3- .

ByValArray
�3�3. 8
,
�3�38 9
	SizeConst
�3�3: C
=
�3�3D E
$num
�3�3F G
,
�3�3G H
ArraySubType
�3�3I U
=
�3�3V W

�3�3X e
.
�3�3e f
I1
�3�3f h
)
�3�3h i
]
�3�3i j
public
�3�3 
byte
�3�3 
[
�3�3 
]
�3�3 
byRes1
�3�3  
;
�3�3  !
public
�3�3 $
NET_VCA_AUDIO_ABNORMAL
�3�3 )
struAudioAbnormal
�3�3* ;
;
�3�3; <
[
�3�3 
MarshalAsAttribute
�3�3
(
�3�3  

�3�3  -
.
�3�3- .

ByValArray
�3�3. 8
,
�3�38 9
	SizeConst
�3�3: C
=
�3�3D E
MAX_DAYS
�3�3F N
*
�3�3O P!
MAX_TIMESEGMENT_V30
�3�3Q d
,
�3�3d e
ArraySubType
�3�3f r
=
�3�3s t

.�3�3� �
Struct�3�3� �
)�3�3� �
]�3�3� �
public
�3�3 
NET_DVR_SCHEDTIME
�3�3 $
[
�3�3$ %
]
�3�3% &
struAlarmSched
�3�3' 5
;
�3�35 6
public
�3�3 )
NET_DVR_HANDLEEXCEPTION_V40
�3�3 .!
struHandleException
�3�3/ B
;
�3�3B C
public
�3�3 
uint
�3�3 #
dwMaxRelRecordChanNum
�3�3 -
;
�3�3- .
public
�3�3 
uint
�3�3  
dwRelRecordChanNum
�3�3 *
;
�3�3* +
[
�3�3 
MarshalAsAttribute
�3�3
(
�3�3  

�3�3  -
.
�3�3- .

ByValArray
�3�3. 8
,
�3�38 9
	SizeConst
�3�3: C
=
�3�3D E
MAX_CHANNUM_V30
�3�3F U
,
�3�3U V
ArraySubType
�3�3W c
=
�3�3d e

�3�3f s
.
�3�3s t
U4
�3�3t v
)
�3�3v w
]
�3�3w x
public
�3�3 
uint
�3�3 
[
�3�3 
]
�3�3 
byRelRecordChan
�3�3 )
;
�3�3) *
[
�3�3 
MarshalAsAttribute
�3�3
(
�3�3  

�3�3  -
.
�3�3- .

ByValArray
�3�3. 8
,
�3�38 9
	SizeConst
�3�3: C
=
�3�3D E
$num
�3�3F H
,
�3�3H I
ArraySubType
�3�3J V
=
�3�3W X

�3�3Y f
.
�3�3f g
I1
�3�3g i
)
�3�3i j
]
�3�3j k
public
�3�3 
byte
�3�3 
[
�3�3 
]
�3�3 
byRes2
�3�3  
;
�3�3  !
}
�3�3 	
[
�3�3 	#
StructLayoutAttribute
�3�3	 
(
�3�3 

LayoutKind
�3�3 )
.
�3�3) *

Sequential
�3�3* 4
)
�3�34 5
]
�3�35 6
public
�3�3 
struct
�3�3 "
NET_VCA_TOILET_TARRY
�3�3 *
{
�3�3 	
public
�3�3 
NET_VCA_POLYGON
�3�3 "

struRegion
�3�3# -
;
�3�3- .
public
�3�3 
ushort
�3�3 
wDelay
�3�3  
;
�3�3  !
[
�3�3 
MarshalAsAttribute
�3�3
(
�3�3  

�3�3  -
.
�3�3- .

ByValArray
�3�3. 8
,
�3�38 9
	SizeConst
�3�3: C
=
�3�3D E
$num
�3�3F G
,
�3�3G H
ArraySubType
�3�3I U
=
�3�3V W

�3�3X e
.
�3�3e f
I1
�3�3f h
)
�3�3h i
]
�3�3i j
public
�3�3 
byte
�3�3 
[
�3�3 
]
�3�3 
byRes
�3�3 
;
�3�3  
}
�3�3 	
[
�3�3 	#
StructLayoutAttribute
�3�3	 
(
�3�3 

LayoutKind
�3�3 )
.
�3�3) *

Sequential
�3�3* 4
)
�3�34 5
]
�3�35 6
public
�3�3 
struct
�3�3  
NET_VCA_YARD_TARRY
�3�3 (
{
�3�3 	
public
�3�3 
NET_VCA_POLYGON
�3�3 "

struRegion
�3�3# -
;
�3�3- .
public
�3�3 
ushort
�3�3 
wDelay
�3�3  
;
�3�3  !
[
�3�3 
MarshalAsAttribute
�3�3
(
�3�3  

�3�3  -
.
�3�3- .

ByValArray
�3�3. 8
,
�3�38 9
	SizeConst
�3�3: C
=
�3�3D E
$num
�3�3F G
,
�3�3G H
ArraySubType
�3�3I U
=
�3�3V W

�3�3X e
.
�3�3e f
I1
�3�3f h
)
�3�3h i
]
�3�3i j
public
�3�3 
byte
�3�3 
[
�3�3 
]
�3�3 
byRes
�3�3 
;
�3�3  
}
�3�3 	
[
�3�3 	#
StructLayoutAttribute
�3�3	 
(
�3�3 

LayoutKind
�3�3 )
.
�3�3) *

Sequential
�3�3* 4
)
�3�34 5
]
�3�35 6
public
�3�3 
struct
�3�3 &
NET_VCA_ADV_REACH_HEIGHT
�3�3 .
{
�3�3 	
public
�3�3 
NET_VCA_POLYGON
�3�3 "

struRegion
�3�3# -
;
�3�3- .
public
�3�3 
uint
�3�3 
dwCrossDirection
�3�3 (
;
�3�3( )
[
�3�3 
MarshalAsAttribute
�3�3
(
�3�3  

�3�3  -
.
�3�3- .

ByValArray
�3�3. 8
,
�3�38 9
	SizeConst
�3�3: C
=
�3�3D E
$num
�3�3F G
,
�3�3G H
ArraySubType
�3�3I U
=
�3�3V W

�3�3X e
.
�3�3e f
I1
�3�3f h
)
�3�3h i
]
�3�3i j
public
�3�3 
byte
�3�3 
[
�3�3 
]
�3�3 
byRes
�3�3 
;
�3�3  
}
�3�3 	
[
�3�3 	#
StructLayoutAttribute
�3�3	 
(
�3�3 

LayoutKind
�3�3 )
.
�3�3) *

Sequential
�3�3* 4
)
�3�34 5
]
�3�35 6
public
�3�3 
struct
�3�3 (
NET_VCA_ADV_TRAVERSE_PLANE
�3�3 0
{
�3�3 	
public
�3�3 
NET_VCA_POLYGON
�3�3 "

struRegion
�3�3# -
;
�3�3- .
public
�3�3 
uint
�3�3 
dwCrossDirection
�3�3 (
;
�3�3( )
public
�3�3 
byte
�3�3 

�3�3 %
;
�3�3% &
[
�3�3 
MarshalAsAttribute
�3�3
(
�3�3  

�3�3  -
.
�3�3- .

ByValArray
�3�3. 8
,
�3�38 9
	SizeConst
�3�3: C
=
�3�3D E
$num
�3�3F G
,
�3�3G H
ArraySubType
�3�3I U
=
�3�3V W

�3�3X e
.
�3�3e f
I1
�3�3f h
)
�3�3h i
]
�3�3i j
public
�3�3 
byte
�3�3 
[
�3�3 
]
�3�3 
byRes
�3�3 
;
�3�3  
}
�3�3 	
[
�3�3 	#
StructLayoutAttribute
�3�3	 
(
�3�3 

LayoutKind
�3�3 )
.
�3�3) *
Explicit
�3�3* 2
)
�3�32 3
]
�3�33 4
public
�3�3 
struct
�3�3 !
NET_VCA_EVENT_UNION
�3�3 )
{
�3�3 	
[
�3�3 
FieldOffsetAttribute
�3�3
(
�3�3! "
$num
�3�3" #
)
�3�3# $
]
�3�3$ %
[
�3�3 
MarshalAsAttribute
�3�3
(
�3�3  

�3�3  -
.
�3�3- .

ByValArray
�3�3. 8
,
�3�38 9
	SizeConst
�3�3: C
=
�3�3D E
$num
�3�3F H
,
�3�3H I
ArraySubType
�3�3J V
=
�3�3W X

�3�3Y f
.
�3�3f g
U4
�3�3g i
)
�3�3i j
]
�3�3j k
public
�3�3 
uint
�3�3 
[
�3�3 
]
�3�3 
uLen
�3�3 
;
�3�3 
[
�3�3 
FieldOffsetAttribute
�3�3
(
�3�3! "
$num
�3�3" #
)
�3�3# $
]
�3�3$ %
public
�3�3 $
NET_VCA_TRAVERSE_PLANE
�3�3 )
struTraversePlane
�3�3* ;
;
�3�3; <
[
�3�3 
FieldOffsetAttribute
�3�3
(
�3�3! "
$num
�3�3" #
)
�3�3# $
]
�3�3$ %
public
�3�3 
NET_VCA_AREA
�3�3 
struArea
�3�3  (
;
�3�3( )
[
�3�3 
FieldOffsetAttribute
�3�3
(
�3�3! "
$num
�3�3" #
)
�3�3# $
]
�3�3$ %
public
�3�3 
NET_VCA_INTRUSION
�3�3 $

�3�3% 2
;
�3�32 3
[
�3�3 
FieldOffsetAttribute
�3�3
(
�3�3! "
$num
�3�3" #
)
�3�3# $
]
�3�3$ %
public
�3�3 
NET_VCA_LOITER
�3�3 !

struLoiter
�3�3" ,
;
�3�3, -
[
�3�3 
FieldOffsetAttribute
�3�3
(
�3�3! "
$num
�3�3" #
)
�3�3# $
]
�3�3$ %
public
�3�3 
NET_VCA_TAKE_LEFT
�3�3 $
struTakeTeft
�3�3% 1
;
�3�31 2
[
�3�3 
FieldOffsetAttribute
�3�3
(
�3�3! "
$num
�3�3" #
)
�3�3# $
]
�3�3$ %
public
�3�3 
NET_VCA_PARKING
�3�3 "
struParking
�3�3# .
;
�3�3. /
[
�3�3 
FieldOffsetAttribute
�3�3
(
�3�3! "
$num
�3�3" #
)
�3�3# $
]
�3�3$ %
public
�3�3 
NET_VCA_RUN
�3�3 
struRun
�3�3 &
;
�3�3& '
[
�3�3 
FieldOffsetAttribute
�3�3
(
�3�3! "
$num
�3�3" #
)
�3�3# $
]
�3�3$ %
public
�3�3 "
NET_VCA_HIGH_DENSITY
�3�3 '
struHighDensity
�3�3( 7
;
�3�37 8
[
�3�3 
FieldOffsetAttribute
�3�3
(
�3�3! "
$num
�3�3" #
)
�3�3# $
]
�3�3$ %
public
�3�3 $
NET_VCA_VIOLENT_MOTION
�3�3 )
struViolentMotion
�3�3* ;
;
�3�3; <
[
�3�3 
FieldOffsetAttribute
�3�3
(
�3�3! "
$num
�3�3" #
)
�3�3# $
]
�3�3$ %
public
�3�3 !
NET_VCA_REACH_HIGHT
�3�3 &
struReachHight
�3�3' 5
;
�3�35 6
[
�3�3 
FieldOffsetAttribute
�3�3
(
�3�3! "
$num
�3�3" #
)
�3�3# $
]
�3�3$ %
public
�3�3 
NET_VCA_GET_UP
�3�3 !
	struGetUp
�3�3" +
;
�3�3+ ,
[
�3�3 
FieldOffsetAttribute
�3�3
(
�3�3! "
$num
�3�3" #
)
�3�3# $
]
�3�3$ %
public
�3�3 
NET_VCA_LEFT
�3�3 
struLeft
�3�3  (
;
�3�3( )
[
�3�3 
FieldOffsetAttribute
�3�3
(
�3�3! "
$num
�3�3" #
)
�3�3# $
]
�3�3$ %
public
�3�3 
NET_VCA_TAKE
�3�3 
struTake
�3�3  (
;
�3�3( )
[
�3�3 
FieldOffsetAttribute
�3�3
(
�3�3! "
$num
�3�3" #
)
�3�3# $
]
�3�3$ %
public
�3�3 !
NET_VCA_HUMAN_ENTER
�3�3 &
struHumanEnter
�3�3' 5
;
�3�35 6
[
�3�3 
FieldOffsetAttribute
�3�3
(
�3�3! "
$num
�3�3" #
)
�3�3# $
]
�3�3$ %
public
�3�3 
NET_VCA_OVER_TIME
�3�3 $
struOvertime
�3�3% 1
;
�3�31 2
[
�3�3 
FieldOffsetAttribute
�3�3
(
�3�3! "
$num
�3�3" #
)
�3�3# $
]
�3�3$ %
public
�3�3 
NET_VCA_STICK_UP
�3�3 #
struStickUp
�3�3$ /
;
�3�3/ 0
[
�3�3 
FieldOffsetAttribute
�3�3
(
�3�3! "
$num
�3�3" #
)
�3�3# $
]
�3�3$ %
public
�3�3 
NET_VCA_SCANNER
�3�3 "
struScanner
�3�3# .
;
�3�3. /
[
�3�3 
FieldOffsetAttribute
�3�3
(
�3�3! "
$num
�3�3" #
)
�3�3# $
]
�3�3$ %
public
�3�3 $
NET_VCA_LEAVE_POSITION
�3�3 )
struLeavePos
�3�3* 6
;
�3�36 7
[
�3�3 
FieldOffsetAttribute
�3�3
(
�3�3! "
$num
�3�3" #
)
�3�3# $
]
�3�3$ %
public
�3�3 

�3�3  
	struTrail
�3�3! *
;
�3�3* +
[
�4�4 
FieldOffsetAttribute
�4�4
(
�4�4! "
$num
�4�4" #
)
�4�4# $
]
�4�4$ %
public
�4�4 
NET_VCA_FALL_DOWN
�4�4 $
struFallDown
�4�4% 1
;
�4�41 2
[
�4�4 
FieldOffsetAttribute
�4�4
(
�4�4! "
$num
�4�4" #
)
�4�4# $
]
�4�4$ %
public
�4�4 $
NET_VCA_AUDIO_ABNORMAL
�4�4 )
struAudioAbnormal
�4�4* ;
;
�4�4; <
[
�4�4 
FieldOffsetAttribute
�4�4
(
�4�4! "
$num
�4�4" #
)
�4�4# $
]
�4�4$ %
public
�4�4 &
NET_VCA_ADV_REACH_HEIGHT
�4�4 +
struReachHeight
�4�4, ;
;
�4�4; <
[
�4�4 
FieldOffsetAttribute
�4�4
(
�4�4! "
$num
�4�4" #
)
�4�4# $
]
�4�4$ %
public
�4�4 "
NET_VCA_TOILET_TARRY
�4�4 '
struToiletTarry
�4�4( 7
;
�4�47 8
[
�4�4 
FieldOffsetAttribute
�4�4
(
�4�4! "
$num
�4�4" #
)
�4�4# $
]
�4�4$ %
public
�4�4  
NET_VCA_YARD_TARRY
�4�4 %

�4�4& 3
;
�4�43 4
[
�4�4 
FieldOffsetAttribute
�4�4
(
�4�4! "
$num
�4�4" #
)
�4�4# $
]
�4�4$ %
public
�4�4 (
NET_VCA_ADV_TRAVERSE_PLANE
�4�4 -"
struAdvTraversePlane
�4�4. B
;
�4�4B C
}
�4�4 	
public
�4�4 
enum
�4�4 
SIZE_FILTER_MODE
�4�4 $
{
�4�4 	
IMAGE_PIX_MODE
�4�4 
,
�4�4 
REAL_WORLD_MODE
�4�4 
,
�4�4 
DEFAULT_MODE
�4�4 
}
�4�4 	
[
�4�4 	#
StructLayoutAttribute
�4�4	 
(
�4�4 

LayoutKind
�4�4 )
.
�4�4) *

Sequential
�4�4* 4
)
�4�44 5
]
�4�45 6
public
�4�4 
struct
�4�4 !
NET_VCA_SIZE_FILTER
�4�4 )
{
�4�4 	
public
�4�4 
byte
�4�4 
byActive
�4�4  
;
�4�4  !
public
�4�4 
byte
�4�4 
byMode
�4�4 
;
�4�4 
[
�4�4 
MarshalAsAttribute
�4�4
(
�4�4  

�4�4  -
.
�4�4- .

ByValArray
�4�4. 8
,
�4�48 9
	SizeConst
�4�4: C
=
�4�4D E
$num
�4�4F G
,
�4�4G H
ArraySubType
�4�4I U
=
�4�4V W

�4�4X e
.
�4�4e f
I1
�4�4f h
)
�4�4h i
]
�4�4i j
public
�4�4 
byte
�4�4 
[
�4�4 
]
�4�4 
byRes
�4�4 
;
�4�4  
public
�4�4 
NET_VCA_RECT
�4�4 
struMiniRect
�4�4  ,
;
�4�4, -
public
�4�4 
NET_VCA_RECT
�4�4 
struMaxRect
�4�4  +
;
�4�4+ ,
}
�4�4 	
[
�4�4 	#
StructLayoutAttribute
�4�4	 
(
�4�4 

LayoutKind
�4�4 )
.
�4�4) *

Sequential
�4�4* 4
)
�4�44 5
]
�4�45 6
public
�4�4 
struct
�4�4 
NET_VCA_ONE_RULE
�4�4 &
{
�4�4 	
public
�4�4 
byte
�4�4 
byActive
�4�4  
;
�4�4  !
[
�4�4 
MarshalAsAttribute
�4�4
(
�4�4  

�4�4  -
.
�4�4- .

ByValArray
�4�4. 8
,
�4�48 9
	SizeConst
�4�4: C
=
�4�4D E
$num
�4�4F G
,
�4�4G H
ArraySubType
�4�4I U
=
�4�4V W

�4�4X e
.
�4�4e f
I1
�4�4f h
)
�4�4h i
]
�4�4i j
public
�4�4 
byte
�4�4 
[
�4�4 
]
�4�4 
byRes
�4�4 
;
�4�4  
[
�4�4 
MarshalAsAttribute
�4�4
(
�4�4  

�4�4  -
.
�4�4- .

ByValArray
�4�4. 8
,
�4�48 9
	SizeConst
�4�4: C
=
�4�4D E
NAME_LEN
�4�4F N
,
�4�4N O
ArraySubType
�4�4P \
=
�4�4] ^

�4�4_ l
.
�4�4l m
I1
�4�4m o
)
�4�4o p
]
�4�4p q
public
�4�4 
byte
�4�4 
[
�4�4 
]
�4�4 

byRuleName
�4�4 $
;
�4�4$ %
public
�4�4 
VCA_EVENT_TYPE
�4�4 !
dwEventType
�4�4" -
;
�4�4- .
public
�4�4 !
NET_VCA_EVENT_UNION
�4�4 &
uEventParam
�4�4' 2
;
�4�42 3
public
�4�4 !
NET_VCA_SIZE_FILTER
�4�4 &
struSizeFilter
�4�4' 5
;
�4�45 6
[
�4�4 
MarshalAsAttribute
�4�4
(
�4�4  

�4�4  -
.
�4�4- .

ByValArray
�4�4. 8
,
�4�48 9
	SizeConst
�4�4: C
=
�4�4D E
MAX_DAYS
�4�4F N
*
�4�4O P
MAX_TIMESEGMENT_2
�4�4Q b
,
�4�4b c
ArraySubType
�4�4d p
=
�4�4q r

.�4�4� �
Struct�4�4� �
)�4�4� �
]�4�4� �
public
�4�4 
NET_DVR_SCHEDTIME
�4�4 $
[
�4�4$ %
]
�4�4% &

�4�4' 4
;
�4�44 5
public
�4�4 )
NET_DVR_HANDLEEXCEPTION_V30
�4�4 .
struHandleType
�4�4/ =
;
�4�4= >
[
�4�4 
MarshalAsAttribute
�4�4
(
�4�4  

�4�4  -
.
�4�4- .

ByValArray
�4�4. 8
,
�4�48 9
	SizeConst
�4�4: C
=
�4�4D E
MAX_CHANNUM_V30
�4�4F U
,
�4�4U V
ArraySubType
�4�4W c
=
�4�4d e

�4�4f s
.
�4�4s t
I1
�4�4t v
)
�4�4v w
]
�4�4w x
public
�4�4 
byte
�4�4 
[
�4�4 
]
�4�4 
byRelRecordChan
�4�4 )
;
�4�4) *
}
�4�4 	
[
�4�4 	#
StructLayoutAttribute
�4�4	 
(
�4�4 

LayoutKind
�4�4 )
.
�4�4) *

Sequential
�4�4* 4
)
�4�44 5
]
�4�45 6
public
�4�4 
struct
�4�4 
NET_VCA_RULECFG
�4�4 %
{
�4�4 	
public
�4�4 
uint
�4�4 
dwSize
�4�4 
;
�4�4 
public
�4�4 
byte
�4�4 
byPicProType
�4�4 $
;
�4�4$ %
[
�4�4 
MarshalAsAttribute
�4�4
(
�4�4  

�4�4  -
.
�4�4- .

ByValArray
�4�4. 8
,
�4�48 9
	SizeConst
�4�4: C
=
�4�4D E
$num
�4�4F G
,
�4�4G H
ArraySubType
�4�4I U
=
�4�4V W

�4�4X e
.
�4�4e f
I1
�4�4f h
)
�4�4h i
]
�4�4i j
public
�4�4 
byte
�4�4 
[
�4�4 
]
�4�4 
byRes
�4�4 
;
�4�4  
public
�4�4 
NET_DVR_JPEGPARA
�4�4 #
struPictureParam
�4�4$ 4
;
�4�44 5
[
�4�4 
MarshalAsAttribute
�4�4
(
�4�4  

�4�4  -
.
�4�4- .

ByValArray
�4�4. 8
,
�4�48 9
	SizeConst
�4�4: C
=
�4�4D E
MAX_RULE_NUM
�4�4F R
,
�4�4R S
ArraySubType
�4�4T `
=
�4�4a b

�4�4c p
.
�4�4p q
Struct
�4�4q w
)
�4�4w x
]
�4�4x y
public
�4�4 
NET_VCA_ONE_RULE
�4�4 #
[
�4�4# $
]
�4�4$ %
struRule
�4�4& .
;
�4�4. /
}
�4�4 	
[
�4�4 	#
StructLayoutAttribute
�4�4	 
(
�4�4 

LayoutKind
�4�4 )
.
�4�4) *

Sequential
�4�4* 4
)
�4�44 5
]
�4�45 6
public
�4�4 
struct
�4�4 %
NET_VCA_FILTER_STRATEGY
�4�4 -
{
�4�4 	
public
�4�4 
byte
�4�4 

byStrategy
�4�4 "
;
�4�4" #
[
�4�4 
MarshalAsAttribute
�4�4
(
�4�4  

�4�4  -
.
�4�4- .

ByValArray
�4�4. 8
,
�4�48 9
	SizeConst
�4�4: C
=
�4�4D E
$num
�4�4F H
,
�4�4H I
ArraySubType
�4�4J V
=
�4�4W X

�4�4Y f
.
�4�4f g
I1
�4�4g i
)
�4�4i j
]
�4�4j k
public
�4�4 
byte
�4�4 
[
�4�4 
]
�4�4 
byRes
�4�4 
;
�4�4  
}
�4�4 	
[
�4�4 	#
StructLayoutAttribute
�4�4	 
(
�4�4 

LayoutKind
�4�4 )
.
�4�4) *

Sequential
�4�4* 4
)
�4�44 5
]
�4�45 6
public
�4�4 
struct
�4�4 (
NET_VCA_RULE_TRIGGER_PARAM
�4�4 0
{
�4�4 	
public
�4�4 
byte
�4�4 

�4�4 %
;
�4�4% &
public
�4�4 
byte
�4�4 
byTriggerPoint
�4�4 &
;
�4�4& '
[
�4�4 
MarshalAsAttribute
�4�4
(
�4�4  

�4�4  -
.
�4�4- .

ByValArray
�4�4. 8
,
�4�48 9
	SizeConst
�4�4: C
=
�4�4D E
$num
�4�4F G
,
�4�4G H
ArraySubType
�4�4I U
=
�4�4V W

�4�4X e
.
�4�4e f
I1
�4�4f h
)
�4�4h i
]
�4�4i j
public
�4�4 
byte
�4�4 
[
�4�4 
]
�4�4 
byRes1
�4�4  
;
�4�4  !
public
�4�4 
float
�4�4 
fTriggerArea
�4�4 %
;
�4�4% &
[
�4�4 
MarshalAsAttribute
�4�4
(
�4�4  

�4�4  -
.
�4�4- .

ByValArray
�4�4. 8
,
�4�48 9
	SizeConst
�4�4: C
=
�4�4D E
$num
�4�4F G
,
�4�4G H
ArraySubType
�4�4I U
=
�4�4V W

�4�4X e
.
�4�4e f
I1
�4�4f h
)
�4�4h i
]
�4�4i j
public
�4�4 
byte
�4�4 
[
�4�4 
]
�4�4 
byRes2
�4�4  
;
�4�4  !
}
�4�4 	
[
�4�4 	#
StructLayoutAttribute
�4�4	 
(
�4�4 

LayoutKind
�4�4 )
.
�4�4) *

Sequential
�4�4* 4
)
�4�44 5
]
�4�45 6
public
�4�4 
struct
�4�4 "
NET_VCA_ONE_RULE_V41
�4�4 *
{
�4�4 	
public
�4�4 
byte
�4�4 
byActive
�4�4  
;
�4�4  !
[
�4�4 
MarshalAsAttribute
�4�4
(
�4�4  

�4�4  -
.
�4�4- .

ByValArray
�4�4. 8
,
�4�48 9
	SizeConst
�4�4: C
=
�4�4D E
$num
�4�4F G
,
�4�4G H
ArraySubType
�4�4I U
=
�4�4V W

�4�4X e
.
�4�4e f
I1
�4�4f h
)
�4�4h i
]
�4�4i j
public
�4�4 
byte
�4�4 
[
�4�4 
]
�4�4 
byRes1
�4�4  
;
�4�4  !
public
�4�4 
ushort
�4�4 
wEventTypeEx
�4�4 &
;
�4�4& '
[
�4�4 
MarshalAsAttribute
�4�4
(
�4�4  

�4�4  -
.
�4�4- .

ByValArray
�4�4. 8
,
�4�48 9
	SizeConst
�4�4: C
=
�4�4D E
NAME_LEN
�4�4F N
,
�4�4N O
ArraySubType
�4�4P \
=
�4�4] ^

�4�4_ l
.
�4�4l m
I1
�4�4m o
)
�4�4o p
]
�4�4p q
public
�4�4 
byte
�4�4 
[
�4�4 
]
�4�4 

byRuleName
�4�4 $
;
�4�4$ %
public
�4�4 
VCA_EVENT_TYPE
�4�4 !
dwEventType
�4�4" -
;
�4�4- .
public
�4�4 !
NET_VCA_EVENT_UNION
�4�4 &
uEventParam
�4�4' 2
;
�4�42 3
public
�4�4 !
NET_VCA_SIZE_FILTER
�4�4 &
struSizeFilter
�4�4' 5
;
�4�45 6
[
�4�4 
MarshalAsAttribute
�4�4
(
�4�4  

�4�4  -
.
�4�4- .

ByValArray
�4�4. 8
,
�4�48 9
	SizeConst
�4�4: C
=
�4�4D E
MAX_DAYS
�4�4F N
*
�4�4O P!
MAX_TIMESEGMENT_V30
�4�4Q d
,
�4�4d e
ArraySubType
�4�4f r
=
�4�4s t

.�4�4� �
Struct�4�4� �
)�4�4� �
]�4�4� �
public
�4�4 
NET_DVR_SCHEDTIME
�4�4 $
[
�4�4$ %
]
�4�4% &

�4�4' 4
;
�4�44 5
public
�4�4 )
NET_DVR_HANDLEEXCEPTION_V30
�4�4 .
struHandleType
�4�4/ =
;
�4�4= >
[
�4�4 
MarshalAsAttribute
�4�4
(
�4�4  

�4�4  -
.
�4�4- .

ByValArray
�4�4. 8
,
�4�48 9
	SizeConst
�4�4: C
=
�4�4D E
MAX_CHANNUM_V30
�4�4F U
,
�4�4U V
ArraySubType
�4�4W c
=
�4�4d e

�4�4f s
.
�4�4s t
I1
�4�4t v
)
�4�4v w
]
�4�4w x
public
�4�4 
byte
�4�4 
[
�4�4 
]
�4�4 
byRelRecordChan
�4�4 )
;
�4�4) *
public
�4�4 
ushort
�4�4 
wAlarmDelay
�4�4 %
;
�4�4% &
[
�4�4 
MarshalAsAttribute
�4�4
(
�4�4  

�4�4  -
.
�4�4- .

ByValArray
�4�4. 8
,
�4�48 9
	SizeConst
�4�4: C
=
�4�4D E
$num
�4�4F G
,
�4�4G H
ArraySubType
�4�4I U
=
�4�4V W

�4�4X e
.
�4�4e f
I1
�4�4f h
)
�4�4h i
]
�4�4i j
public
�4�4 
byte
�4�4 
[
�4�4 
]
�4�4 
byRes2
�4�4  
;
�4�4  !
public
�4�4 %
NET_VCA_FILTER_STRATEGY
�4�4 * 
struFilterStrategy
�4�4+ =
;
�4�4= >
public
�4�4 (
NET_VCA_RULE_TRIGGER_PARAM
�4�4 -
struTriggerParam
�4�4. >
;
�4�4> ?
[
�4�4 
MarshalAsAttribute
�4�4
(
�4�4  

�4�4  -
.
�4�4- .

ByValArray
�4�4. 8
,
�4�48 9
	SizeConst
�4�4: C
=
�4�4D E
$num
�4�4F H
,
�4�4H I
ArraySubType
�4�4J V
=
�4�4W X

�4�4Y f
.
�4�4f g
I1
�4�4g i
)
�4�4i j
]
�4�4j k
public
�4�4 
byte
�4�4 
[
�4�4 
]
�4�4 
byRes
�4�4 
;
�4�4  
}
�4�4 	
[
�4�4 	#
StructLayoutAttribute
�4�4	 
(
�4�4 

LayoutKind
�4�4 )
.
�4�4) *

Sequential
�4�4* 4
)
�4�44 5
]
�4�45 6
public
�4�4 
struct
�4�4 !
NET_VCA_RULECFG_V41
�4�4 )
{
�4�4 	
public
�4�4 
uint
�4�4 
dwSize
�4�4 
;
�4�4 
public
�4�4 
byte
�4�4 
byPicProType
�4�4 $
;
�4�4$ %
public
�4�4 
byte
�4�4 

�4�4 %
;
�4�4% &
public
�4�4 
byte
�4�4 
byPicRecordEnable
�4�4 )
;
�4�4) *
public
�4�4 
byte
�4�4 
byRes1
�4�4 
;
�4�4 
public
�4�4 
NET_DVR_JPEGPARA
�4�4 #
struPictureParam
�4�4$ 4
;
�4�44 5
[
�4�4 
MarshalAsAttribute
�4�4
(
�4�4  

�4�4  -
.
�4�4- .

ByValArray
�4�4. 8
,
�4�48 9
	SizeConst
�4�4: C
=
�4�4D E
MAX_RULE_NUM
�4�4F R
,
�4�4R S
ArraySubType
�4�4T `
=
�4�4a b

�4�4c p
.
�4�4p q
Struct
�4�4q w
)
�4�4w x
]
�4�4x y
public
�4�4 "
NET_VCA_ONE_RULE_V41
�4�4 '
[
�4�4' (
]
�4�4( )
struRule
�4�4* 2
;
�4�42 3
[
�4�4 
MarshalAsAttribute
�4�4
(
�4�4  

�4�4  -
.
�4�4- .

ByValArray
�4�4. 8
,
�4�48 9
	SizeConst
�4�4: C
=
�4�4D E
$num
�4�4F H
,
�4�4H I
ArraySubType
�4�4J V
=
�4�4W X

�4�4Y f
.
�4�4f g
I1
�4�4g i
)
�4�4i j
]
�4�4j k
public
�5�5 
byte
�5�5 
[
�5�5 
]
�5�5 
byRes
�5�5 
;
�5�5  
}
�5�5 	
[
�5�5 	#
StructLayoutAttribute
�5�5	 
(
�5�5 

LayoutKind
�5�5 )
.
�5�5) *

Sequential
�5�5* 4
)
�5�54 5
]
�5�55 6
public
�5�5 
struct
�5�5 !
NET_VCA_TARGET_INFO
�5�5 )
{
�5�5 	
public
�5�5 
uint
�5�5 
dwID
�5�5 
;
�5�5 
public
�5�5 
NET_VCA_RECT
�5�5 
struRect
�5�5  (
;
�5�5( )
[
�5�5 
MarshalAsAttribute
�5�5
(
�5�5  

�5�5  -
.
�5�5- .

ByValArray
�5�5. 8
,
�5�58 9
	SizeConst
�5�5: C
=
�5�5D E
$num
�5�5F G
,
�5�5G H
ArraySubType
�5�5I U
=
�5�5V W

�5�5X e
.
�5�5e f
I1
�5�5f h
)
�5�5h i
]
�5�5i j
public
�5�5 
byte
�5�5 
[
�5�5 
]
�5�5 
byRes
�5�5 
;
�5�5  
}
�5�5 	
[
�5�5 	#
StructLayoutAttribute
�5�5	 
(
�5�5 

LayoutKind
�5�5 )
.
�5�5) *

Sequential
�5�5* 4
)
�5�54 5
]
�5�55 6
public
�5�5 
struct
�5�5 
NET_VCA_RULE_INFO
�5�5 '
{
�5�5 	
public
�5�5 
byte
�5�5 
byRuleID
�5�5  
;
�5�5  !
public
�5�5 
byte
�5�5 
byRes
�5�5 
;
�5�5 
public
�5�5 
ushort
�5�5 
wEventTypeEx
�5�5 &
;
�5�5& '
[
�5�5 
MarshalAsAttribute
�5�5
(
�5�5  

�5�5  -
.
�5�5- .

ByValArray
�5�5. 8
,
�5�58 9
	SizeConst
�5�5: C
=
�5�5D E
NAME_LEN
�5�5F N
,
�5�5N O
ArraySubType
�5�5P \
=
�5�5] ^

�5�5_ l
.
�5�5l m
I1
�5�5m o
)
�5�5o p
]
�5�5p q
public
�5�5 
byte
�5�5 
[
�5�5 
]
�5�5 

byRuleName
�5�5 $
;
�5�5$ %
public
�5�5 
VCA_EVENT_TYPE
�5�5 !
dwEventType
�5�5" -
;
�5�5- .
public
�5�5 !
NET_VCA_EVENT_UNION
�5�5 &
uEventParam
�5�5' 2
;
�5�52 3
}
�5�5 	
[
�5�5 	#
StructLayoutAttribute
�5�5	 
(
�5�5 

LayoutKind
�5�5 )
.
�5�5) *

Sequential
�5�5* 4
)
�5�54 5
]
�5�55 6
public
�5�5 
struct
�5�5 
NET_VCA_DEV_INFO
�5�5 &
{
�5�5 	
public
�5�5 
NET_DVR_IPADDR
�5�5 !
	struDevIP
�5�5" +
;
�5�5+ ,
public
�5�5 
ushort
�5�5 
wPort
�5�5 
;
�5�5  
public
�5�5 
byte
�5�5 
	byChannel
�5�5 !
;
�5�5! "
public
�5�5 
byte
�5�5 
byRes
�5�5 
;
�5�5 
}
�5�5 	
[
�5�5 	#
StructLayoutAttribute
�5�5	 
(
�5�5 

LayoutKind
�5�5 )
.
�5�5) *

Sequential
�5�5* 4
)
�5�54 5
]
�5�55 6
public
�5�5 
struct
�5�5  
NET_VCA_RULE_ALARM
�5�5 (
{
�5�5 	
public
�5�5 
uint
�5�5 
dwSize
�5�5 
;
�5�5 
public
�5�5 
uint
�5�5 
dwRelativeTime
�5�5 &
;
�5�5& '
public
�5�5 
uint
�5�5 
	dwAbsTime
�5�5 !
;
�5�5! "
public
�5�5 
NET_VCA_RULE_INFO
�5�5 $
struRuleInfo
�5�5% 1
;
�5�51 2
public
�5�5 !
NET_VCA_TARGET_INFO
�5�5 &
struTargetInfo
�5�5' 5
;
�5�55 6
public
�5�5 
NET_VCA_DEV_INFO
�5�5 #
struDevInfo
�5�5$ /
;
�5�5/ 0
public
�5�5 
uint
�5�5 
dwPicDataLen
�5�5 $
;
�5�5$ %
public
�5�5 
byte
�5�5 
	byPicType
�5�5 !
;
�5�5! "
[
�5�5 
MarshalAsAttribute
�5�5
(
�5�5  

�5�5  -
.
�5�5- .

ByValArray
�5�5. 8
,
�5�58 9
	SizeConst
�5�5: C
=
�5�5D E
$num
�5�5F G
,
�5�5G H
ArraySubType
�5�5I U
=
�5�5V W

�5�5X e
.
�5�5e f
I1
�5�5f h
)
�5�5h i
]
�5�5i j
public
�5�5 
byte
�5�5 
[
�5�5 
]
�5�5 
byRes
�5�5 
;
�5�5  
[
�5�5 
MarshalAsAttribute
�5�5
(
�5�5  

�5�5  -
.
�5�5- .

ByValArray
�5�5. 8
,
�5�58 9
	SizeConst
�5�5: C
=
�5�5D E
$num
�5�5F G
,
�5�5G H
ArraySubType
�5�5I U
=
�5�5V W

�5�5X e
.
�5�5e f
U4
�5�5f h
)
�5�5h i
]
�5�5i j
public
�5�5 
uint
�5�5 
[
�5�5 
]
�5�5 
dwRes
�5�5 
;
�5�5  
public
�5�5 
IntPtr
�5�5 
pImage
�5�5  
;
�5�5  !
}
�5�5 	
[
�5�5 	#
StructLayoutAttribute
�5�5	 
(
�5�5 

LayoutKind
�5�5 )
.
�5�5) *

Sequential
�5�5* 4
)
�5�54 5
]
�5�55 6
public
�5�5 
struct
�5�5 
NET_VCA_DRAW_MODE
�5�5 '
{
�5�5 	
public
�5�5 
uint
�5�5 
dwSize
�5�5 
;
�5�5 
public
�5�5 
byte
�5�5 
byDspAddTarget
�5�5 &
;
�5�5& '
public
�5�5 
byte
�5�5 
byDspAddRule
�5�5 $
;
�5�5$ %
public
�5�5 
byte
�5�5 
byDspPicAddTarget
�5�5 )
;
�5�5) *
public
�5�5 
byte
�5�5 
byDspPicAddRule
�5�5 '
;
�5�5' (
[
�5�5 
MarshalAsAttribute
�5�5
(
�5�5  

�5�5  -
.
�5�5- .

ByValArray
�5�5. 8
,
�5�58 9
	SizeConst
�5�5: C
=
�5�5D E
$num
�5�5F G
,
�5�5G H
ArraySubType
�5�5I U
=
�5�5V W

�5�5X e
.
�5�5e f
I1
�5�5f h
)
�5�5h i
]
�5�5i j
public
�5�5 
byte
�5�5 
[
�5�5 
]
�5�5 
byRes
�5�5 
;
�5�5  
}
�5�5 	
public
�5�5 
enum
�5�5 
OBJECT_TYPE_ENUM
�5�5 $
{
�5�5 	#
ENUM_OBJECT_TYPE_COAT
�5�5 !
=
�5�5" #
$num
�5�5$ %
}
�5�5 	
[
�5�5 	#
StructLayoutAttribute
�5�5	 
(
�5�5 

LayoutKind
�5�5 )
.
�5�5) *

Sequential
�5�5* 4
)
�5�54 5
]
�5�55 6
public
�5�5 
struct
�5�5 '
NET_DVR_OBJECT_COLOR_COND
�5�5 /
{
�5�5 	
public
�5�5 
uint
�5�5 
	dwChannel
�5�5 !
;
�5�5! "
public
�5�5 
uint
�5�5 
	dwObjType
�5�5 !
;
�5�5! "
[
�5�5 
MarshalAsAttribute
�5�5
(
�5�5  

�5�5  -
.
�5�5- .

ByValArray
�5�5. 8
,
�5�58 9
	SizeConst
�5�5: C
=
�5�5D E
$num
�5�5F H
,
�5�5H I
ArraySubType
�5�5J V
=
�5�5W X

�5�5Y f
.
�5�5f g
I1
�5�5g i
)
�5�5i j
]
�5�5j k
public
�5�5 
byte
�5�5 
[
�5�5 
]
�5�5 
byRes
�5�5 
;
�5�5  
}
�5�5 	
[
�5�5 	#
StructLayoutAttribute
�5�5	 
(
�5�5 

LayoutKind
�5�5 )
.
�5�5) *

Sequential
�5�5* 4
)
�5�54 5
]
�5�55 6
public
�5�5 
struct
�5�5 
NET_DVR_PIC
�5�5 !
{
�5�5 	
public
�5�5 
byte
�5�5 
	byPicType
�5�5 !
;
�5�5! "
[
�5�5 
MarshalAsAttribute
�5�5
(
�5�5  

�5�5  -
.
�5�5- .

ByValArray
�5�5. 8
,
�5�58 9
	SizeConst
�5�5: C
=
�5�5D E
$num
�5�5F G
,
�5�5G H
ArraySubType
�5�5I U
=
�5�5V W

�5�5X e
.
�5�5e f
I1
�5�5f h
)
�5�5h i
]
�5�5i j
public
�5�5 
byte
�5�5 
[
�5�5 
]
�5�5 
byRes1
�5�5  
;
�5�5  !
public
�5�5 
uint
�5�5 

dwPicWidth
�5�5 "
;
�5�5" #
public
�5�5 
uint
�5�5 
dwPicHeight
�5�5 #
;
�5�5# $
public
�5�5 
uint
�5�5 
dwPicDataLen
�5�5 $
;
�5�5$ %
public
�5�5 
uint
�5�5 
dwPicDataBuffLen
�5�5 (
;
�5�5( )
public
�5�5 
IntPtr
�5�5 

�5�5 '
;
�5�5' (
[
�5�5 
MarshalAsAttribute
�5�5
(
�5�5  

�5�5  -
.
�5�5- .

ByValArray
�5�5. 8
,
�5�58 9
	SizeConst
�5�5: C
=
�5�5D E
$num
�5�5F H
,
�5�5H I
ArraySubType
�5�5J V
=
�5�5W X

�5�5Y f
.
�5�5f g
I1
�5�5g i
)
�5�5i j
]
�5�5j k
public
�5�5 
byte
�5�5 
[
�5�5 
]
�5�5 
byRes2
�5�5  
;
�5�5  !
}
�5�5 	
[
�5�5 	#
StructLayoutAttribute
�5�5	 
(
�5�5 

LayoutKind
�5�5 )
.
�5�5) *

Sequential
�5�5* 4
)
�5�54 5
]
�5�55 6
public
�5�5 
struct
�5�5 (
NET_DVR_OBJECT_COLOR_UNION
�5�5 0
{
�5�5 	
public
�5�5 

�5�5  
	struColor
�5�5! *
;
�5�5* +
public
�5�5 
NET_DVR_PIC
�5�5 
struPicture
�5�5 *
;
�5�5* +
[
�5�5 
MarshalAsAttribute
�5�5
(
�5�5  

�5�5  -
.
�5�5- .

ByValArray
�5�5. 8
,
�5�58 9
	SizeConst
�5�5: C
=
�5�5D E
$num
�5�5F H
,
�5�5H I
ArraySubType
�5�5J V
=
�5�5W X

�5�5Y f
.
�5�5f g
I1
�5�5g i
)
�5�5i j
]
�5�5j k
public
�5�5 
byte
�5�5 
[
�5�5 
]
�5�5 
byRes
�5�5 
;
�5�5  
}
�5�5 	
[
�5�5 	#
StructLayoutAttribute
�5�5	 
(
�5�5 

LayoutKind
�5�5 )
.
�5�5) *

Sequential
�5�5* 4
)
�5�54 5
]
�5�55 6
public
�5�5 
struct
�5�5 "
NET_DVR_OBJECT_COLOR
�5�5 *
{
�5�5 	
public
�5�5 
uint
�5�5 
dwSize
�5�5 
;
�5�5 
public
�5�5 
byte
�5�5 
byEnable
�5�5  
;
�5�5  !
public
�5�5 
byte
�5�5 
byColorMode
�5�5 #
;
�5�5# $
[
�5�5 
MarshalAsAttribute
�5�5
(
�5�5  

�5�5  -
.
�5�5- .

ByValArray
�5�5. 8
,
�5�58 9
	SizeConst
�5�5: C
=
�5�5D E
$num
�5�5F G
,
�5�5G H
ArraySubType
�5�5I U
=
�5�5V W

�5�5X e
.
�5�5e f
I1
�5�5f h
)
�5�5h i
]
�5�5i j
public
�5�5 
byte
�5�5 
[
�5�5 
]
�5�5 
byRes1
�5�5  
;
�5�5  !
public
�5�5 (
NET_DVR_OBJECT_COLOR_UNION
�5�5 -
	uObjColor
�5�5. 7
;
�5�57 8
[
�5�5 
MarshalAsAttribute
�5�5
(
�5�5  

�5�5  -
.
�5�5- .

ByValArray
�5�5. 8
,
�5�58 9
	SizeConst
�5�5: C
=
�5�5D E
$num
�5�5F H
,
�5�5H I
ArraySubType
�5�5J V
=
�5�5W X

�5�5Y f
.
�5�5f g
I1
�5�5g i
)
�5�5i j
]
�5�5j k
public
�5�5 
byte
�5�5 
[
�5�5 
]
�5�5 
byRes2
�5�5  
;
�5�5  !
}
�5�5 	
public
�5�5 
enum
�5�5 
AREA_TYPE_ENUM
�5�5 "
{
�5�5 	!
ENUM_OVERLAP_REGION
�5�5 
=
�5�5  !
$num
�5�5" #
,
�5�5# $
ENUM_BED_LOCATION
�6�6 
=
�6�6 
$num
�6�6  !
}
�6�6 	
[
�6�6 	#
StructLayoutAttribute
�6�6	 
(
�6�6 

LayoutKind
�6�6 )
.
�6�6) *

Sequential
�6�6* 4
)
�6�64 5
]
�6�65 6
public
�6�6 
struct
�6�6 
NET_DVR_AUXAREA
�6�6 %
{
�6�6 	
public
�6�6 
uint
�6�6 

dwAreaType
�6�6 "
;
�6�6" #
public
�6�6 
byte
�6�6 
byEnable
�6�6  
;
�6�6  !
[
�6�6 
MarshalAsAttribute
�6�6
(
�6�6  

�6�6  -
.
�6�6- .

ByValArray
�6�6. 8
,
�6�68 9
	SizeConst
�6�6: C
=
�6�6D E
$num
�6�6F G
,
�6�6G H
ArraySubType
�6�6I U
=
�6�6V W

�6�6X e
.
�6�6e f
I1
�6�6f h
)
�6�6h i
]
�6�6i j
public
�6�6 
byte
�6�6 
[
�6�6 
]
�6�6 
byRes1
�6�6  
;
�6�6  !
public
�6�6 
NET_VCA_POLYGON
�6�6 "
struPolygon
�6�6# .
;
�6�6. /
[
�6�6 
MarshalAsAttribute
�6�6
(
�6�6  

�6�6  -
.
�6�6- .

ByValArray
�6�6. 8
,
�6�68 9
	SizeConst
�6�6: C
=
�6�6D E
$num
�6�6F H
,
�6�6H I
ArraySubType
�6�6J V
=
�6�6W X

�6�6Y f
.
�6�6f g
I1
�6�6g i
)
�6�6i j
]
�6�6j k
public
�6�6 
byte
�6�6 
[
�6�6 
]
�6�6 
byRes2
�6�6  
;
�6�6  !
}
�6�6 	
[
�6�6 	#
StructLayoutAttribute
�6�6	 
(
�6�6 

LayoutKind
�6�6 )
.
�6�6) *

Sequential
�6�6* 4
)
�6�64 5
]
�6�65 6
public
�6�6 
struct
�6�6 "
NET_DVR_AUXAREA_LIST
�6�6 *
{
�6�6 	
public
�6�6 
uint
�6�6 
dwSize
�6�6 
;
�6�6 
[
�6�6 
MarshalAsAttribute
�6�6
(
�6�6  

�6�6  -
.
�6�6- .

ByValArray
�6�6. 8
,
�6�68 9
	SizeConst
�6�6: C
=
�6�6D E
MAX_AUXAREA_NUM
�6�6F U
,
�6�6U V
ArraySubType
�6�6W c
=
�6�6d e

�6�6f s
.
�6�6s t
Struct
�6�6t z
)
�6�6z {
]
�6�6{ |
public
�6�6 
NET_DVR_AUXAREA
�6�6 "
[
�6�6" #
]
�6�6# $
struArea
�6�6% -
;
�6�6- .
[
�6�6 
MarshalAsAttribute
�6�6
(
�6�6  

�6�6  -
.
�6�6- .

ByValArray
�6�6. 8
,
�6�68 9
	SizeConst
�6�6: C
=
�6�6D E
$num
�6�6F H
,
�6�6H I
ArraySubType
�6�6J V
=
�6�6W X

�6�6Y f
.
�6�6f g
I1
�6�6g i
)
�6�6i j
]
�6�6j k
public
�6�6 
byte
�6�6 
[
�6�6 
]
�6�6 
byRes2
�6�6  
;
�6�6  !
}
�6�6 	
public
�6�6 
enum
�6�6  
CHAN_WORKMODE_ENUM
�6�6 &
{
�6�6 	,
ENUM_CHAN_WORKMODE_INDEPENDENT
�6�6 *
=
�6�6+ ,
$num
�6�6- .
,
�6�6. /'
ENUM_CHAN_WORKMODE_MASTER
�6�6 %
=
�6�6& '
$num
�6�6( )
,
�6�6) *&
ENUM_CHAN_WORKMODE_SLAVE
�6�6 $
=
�6�6% &
$num
�6�6' (
}
�6�6 	
[
�6�6 	#
StructLayoutAttribute
�6�6	 
(
�6�6 

LayoutKind
�6�6 )
.
�6�6) *

Sequential
�6�6* 4
)
�6�64 5
]
�6�65 6
public
�6�6 
struct
�6�6 &
NET_DVR_CHANNEL_WORKMODE
�6�6 .
{
�6�6 	
public
�6�6 
uint
�6�6 
dwSize
�6�6 
;
�6�6 
public
�6�6 
byte
�6�6 

byWorkMode
�6�6 "
;
�6�6" #
[
�6�6 
MarshalAsAttribute
�6�6
(
�6�6  

�6�6  -
.
�6�6- .

ByValArray
�6�6. 8
,
�6�68 9
	SizeConst
�6�6: C
=
�6�6D E
$num
�6�6F H
,
�6�6H I
ArraySubType
�6�6J V
=
�6�6W X

�6�6Y f
.
�6�6f g
I1
�6�6g i
)
�6�6i j
]
�6�6j k
public
�6�6 
byte
�6�6 
[
�6�6 
]
�6�6 
byRes
�6�6 
;
�6�6  
}
�6�6 	
[
�6�6 	#
StructLayoutAttribute
�6�6	 
(
�6�6 

LayoutKind
�6�6 )
.
�6�6) *

Sequential
�6�6* 4
)
�6�64 5
]
�6�65 6
public
�6�6 
struct
�6�6 
NET_DVR_CHANNEL
�6�6 %
{
�6�6 	
[
�6�6 
MarshalAsAttribute
�6�6
(
�6�6  

�6�6  -
.
�6�6- .

ByValArray
�6�6. 8
,
�6�68 9
	SizeConst
�6�6: C
=
�6�6D E
MAX_DOMAIN_NAME
�6�6F U
,
�6�6U V
ArraySubType
�6�6W c
=
�6�6d e

�6�6f s
.
�6�6s t
I1
�6�6t v
)
�6�6v w
]
�6�6w x
public
�6�6 
byte
�6�6 
[
�6�6 
]
�6�6 
	byAddress
�6�6 #
;
�6�6# $
public
�6�6 
ushort
�6�6 
wDVRPort
�6�6 "
;
�6�6" #
[
�6�6 
MarshalAsAttribute
�6�6
(
�6�6  

�6�6  -
.
�6�6- .

ByValArray
�6�6. 8
,
�6�68 9
	SizeConst
�6�6: C
=
�6�6D E
$num
�6�6F G
,
�6�6G H
ArraySubType
�6�6I U
=
�6�6V W

�6�6X e
.
�6�6e f
I1
�6�6f h
)
�6�6h i
]
�6�6i j
public
�6�6 
byte
�6�6 
[
�6�6 
]
�6�6 
byRes1
�6�6  
;
�6�6  !
[
�6�6 
MarshalAsAttribute
�6�6
(
�6�6  

�6�6  -
.
�6�6- .

ByValArray
�6�6. 8
,
�6�68 9
	SizeConst
�6�6: C
=
�6�6D E
NAME_LEN
�6�6F N
,
�6�6N O
ArraySubType
�6�6P \
=
�6�6] ^

�6�6_ l
.
�6�6l m
I1
�6�6m o
)
�6�6o p
]
�6�6p q
public
�6�6 
byte
�6�6 
[
�6�6 
]
�6�6 
	sUserName
�6�6 #
;
�6�6# $
[
�6�6 
MarshalAsAttribute
�6�6
(
�6�6  

�6�6  -
.
�6�6- .

ByValArray
�6�6. 8
,
�6�68 9
	SizeConst
�6�6: C
=
�6�6D E

PASSWD_LEN
�6�6F P
,
�6�6P Q
ArraySubType
�6�6R ^
=
�6�6_ `

�6�6a n
.
�6�6n o
I1
�6�6o q
)
�6�6q r
]
�6�6r s
public
�6�6 
byte
�6�6 
[
�6�6 
]
�6�6 
	sPassword
�6�6 #
;
�6�6# $
public
�6�6 
uint
�6�6 
	dwChannel
�6�6 !
;
�6�6! "
[
�6�6 
MarshalAsAttribute
�6�6
(
�6�6  

�6�6  -
.
�6�6- .

ByValArray
�6�6. 8
,
�6�68 9
	SizeConst
�6�6: C
=
�6�6D E
$num
�6�6F H
,
�6�6H I
ArraySubType
�6�6J V
=
�6�6W X

�6�6Y f
.
�6�6f g
I1
�6�6g i
)
�6�6i j
]
�6�6j k
public
�6�6 
byte
�6�6 
[
�6�6 
]
�6�6 
byRes2
�6�6  
;
�6�6  !
}
�6�6 	
[
�6�6 	
StructLayout
�6�6	 
(
�6�6 

LayoutKind
�6�6  
.
�6�6  !
Explicit
�6�6! )
)
�6�6) *
]
�6�6* +
public
�6�6 
struct
�6�6 )
NET_DVR_SLAVE_CHANNEL_UNION
�6�6 1
{
�6�6 	
[
�6�6 
FieldOffsetAttribute
�6�6
(
�6�6! "
$num
�6�6" #
)
�6�6# $
]
�6�6$ %
[
�6�6 
MarshalAsAttribute
�6�6
(
�6�6  

�6�6  -
.
�6�6- .

ByValArray
�6�6. 8
,
�6�68 9
	SizeConst
�6�6: C
=
�6�6D E
$num
�6�6F I
,
�6�6I J
ArraySubType
�6�6K W
=
�6�6X Y

�6�6Z g
.
�6�6g h
I1
�6�6h j
)
�6�6j k
]
�6�6k l
public
�6�6 
byte
�6�6 
[
�6�6 
]
�6�6 
byRes
�6�6 
;
�6�6  
[
�6�6 
FieldOffsetAttribute
�6�6
(
�6�6! "
$num
�6�6" #
)
�6�6# $
]
�6�6$ %
public
�6�6 
uint
�6�6 
dwLocalChannel
�6�6 &
;
�6�6& '
[
�6�6 
FieldOffsetAttribute
�6�6
(
�6�6! "
$num
�6�6" #
)
�6�6# $
]
�6�6$ %
public
�6�6 
NET_DVR_CHANNEL
�6�6 "
struRemoteChannel
�6�6# 4
;
�6�64 5
}
�6�6 	
[
�6�6 	#
StructLayoutAttribute
�6�6	 
(
�6�6 

LayoutKind
�6�6 )
.
�6�6) *

Sequential
�6�6* 4
)
�6�64 5
]
�6�65 6
public
�6�6 
struct
�6�6 )
NET_DVR_SLAVE_CHANNEL_PARAM
�6�6 1
{
�6�6 	
public
�6�6 
byte
�6�6 

byChanType
�6�6 "
;
�6�6" #
[
�6�6 
MarshalAsAttribute
�6�6
(
�6�6  

�6�6  -
.
�6�6- .

ByValArray
�6�6. 8
,
�6�68 9
	SizeConst
�6�6: C
=
�6�6D E
$num
�6�6F G
,
�6�6G H
ArraySubType
�6�6I U
=
�6�6V W

�6�6X e
.
�6�6e f
I1
�6�6f h
)
�6�6h i
]
�6�6i j
public
�6�6 
byte
�6�6 
[
�6�6 
]
�6�6 
byRes1
�6�6  
;
�6�6  !
public
�6�6 )
NET_DVR_SLAVE_CHANNEL_UNION
�6�6 .

�6�6/ <
;
�6�6< =
[
�6�6 
MarshalAsAttribute
�6�6
(
�6�6  

�6�6  -
.
�6�6- .

ByValArray
�6�6. 8
,
�6�68 9
	SizeConst
�6�6: C
=
�6�6D E
$num
�6�6F H
,
�6�6H I
ArraySubType
�6�6J V
=
�6�6W X

�6�6Y f
.
�6�6f g
I1
�6�6g i
)
�6�6i j
]
�6�6j k
public
�6�6 
byte
�6�6 
[
�6�6 
]
�6�6 
byRes2
�6�6  
;
�6�6  !
}
�6�6 	
[
�6�6 	#
StructLayoutAttribute
�6�6	 
(
�6�6 

LayoutKind
�6�6 )
.
�6�6) *

Sequential
�6�6* 4
)
�6�64 5
]
�6�65 6
public
�6�6 
struct
�6�6 '
NET_DVR_SLAVE_CHANNEL_CFG
�6�6 /
{
�6�6 	
public
�6�6 
uint
�6�6 
dwSize
�6�6 
;
�6�6 
[
�6�6 
MarshalAsAttribute
�6�6
(
�6�6  

�6�6  -
.
�6�6- .

ByValArray
�6�6. 8
,
�6�68 9
	SizeConst
�6�6: C
=
�6�6D E#
MAX_SLAVE_CHANNEL_NUM
�6�6F [
,
�6�6[ \
ArraySubType
�6�6] i
=
�6�6j k

�6�6l y
.
�6�6y z
Struct�6�6z �
)�6�6� �
]�6�6� �
public
�6�6 )
NET_DVR_SLAVE_CHANNEL_PARAM
�6�6 .
[
�6�6. /
]
�6�6/ 0

�6�61 >
;
�6�6> ?
[
�6�6 
MarshalAsAttribute
�6�6
(
�6�6  

�6�6  -
.
�6�6- .

ByValArray
�6�6. 8
,
�6�68 9
	SizeConst
�6�6: C
=
�6�6D E
$num
�6�6F H
,
�6�6H I
ArraySubType
�6�6J V
=
�6�6W X

�6�6Y f
.
�6�6f g
I1
�6�6g i
)
�6�6i j
]
�6�6j k
public
�6�6 
byte
�6�6 
[
�6�6 
]
�6�6 
byRes
�6�6 
;
�6�6  
}
�6�6 	
public
�6�6 
enum
�6�6 
VQD_EVENT_ENUM
�6�6 "
{
�6�6 	!
ENUM_VQD_EVENT_BLUR
�6�6 
=
�6�6  !
$num
�6�6" #
,
�6�6# $!
ENUM_VQD_EVENT_LUMA
�6�6 
=
�6�6  !
$num
�6�6" #
,
�6�6# $#
ENUM_VQD_EVENT_CHROMA
�6�6 !
=
�6�6" #
$num
�6�6$ %
,
�6�6% &!
ENUM_VQD_EVENT_SNOW
�6�6 
=
�6�6  !
$num
�6�6" #
,
�6�6# $#
ENUM_VQD_EVENT_STREAK
�6�6 !
=
�6�6" #
$num
�6�6$ %
,
�6�6% &#
ENUM_VQD_EVENT_FREEZE
�6�6 !
=
�6�6" #
$num
�6�6$ %
,
�6�6% &(
ENUM_VQD_EVENT_SIGNAL_LOSS
�6�6 &
=
�6�6' (
$num
�6�6) *
,
�6�6* + 
ENUM_VQD_EVENT_PTZ
�6�6 
=
�6�6  
$num
�6�6! "
,
�6�6" #*
ENUM_VQD_EVENT_SCNENE_CHANGE
�6�6 (
=
�6�6) *
$num
�6�6+ ,
,
�6�6, -+
ENUM_VQD_EVENT_VIDEO_ABNORMAL
�6�6 )
=
�6�6* +
$num
�6�6, .
,
�6�6. /(
ENUM_VQD_EVENT_VIDEO_BLOCK
�6�6 &
=
�6�6' (
$num
�6�6) +
,
�6�6+ ,
}
�6�6 	
[
�6�6 	#
StructLayoutAttribute
�6�6	 
(
�6�6 

LayoutKind
�6�6 )
.
�6�6) *

Sequential
�6�6* 4
)
�6�64 5
]
�6�65 6
public
�6�6 
struct
�6�6 $
NET_DVR_VQD_EVENT_COND
�6�6 ,
{
�6�6 	
public
�6�6 
uint
�6�6 
	dwChannel
�6�6 !
;
�6�6! "
public
�6�6 
uint
�6�6 
dwEventType
�6�6 #
;
�6�6# $
[
�6�6 
MarshalAsAttribute
�6�6
(
�6�6  

�6�6  -
.
�6�6- .

ByValArray
�6�6. 8
,
�6�68 9
	SizeConst
�6�6: C
=
�6�6D E
$num
�6�6F H
,
�6�6H I
ArraySubType
�6�6J V
=
�6�6W X

�6�6Y f
.
�6�6f g
I1
�6�6g i
)
�6�6i j
]
�6�6j k
public
�6�6 
byte
�6�6 
[
�6�6 
]
�6�6 
byRes
�6�6 
;
�6�6  
}
�6�6 	
[
�6�6 	#
StructLayoutAttribute
�6�6	 
(
�6�6 

LayoutKind
�6�6 )
.
�6�6) *

Sequential
�6�6* 4
)
�6�64 5
]
�6�65 6
public
�7�7 
struct
�7�7 %
NET_DVR_VQD_EVENT_PARAM
�7�7 -
{
�7�7 	
public
�7�7 
byte
�7�7 
byThreshold
�7�7 #
;
�7�7# $
public
�7�7 
byte
�7�7 

�7�7 %
;
�7�7% &
public
�7�7 
byte
�7�7 
byUploadPic
�7�7 #
;
�7�7# $
public
�7�7 
byte
�7�7 
byRes1
�7�7 
;
�7�7 
public
�7�7 
uint
�7�7 
dwTimeInterval
�7�7 &
;
�7�7& '
[
�7�7 
MarshalAsAttribute
�7�7
(
�7�7  

�7�7  -
.
�7�7- .

ByValArray
�7�7. 8
,
�7�78 9
	SizeConst
�7�7: C
=
�7�7D E
$num
�7�7F H
,
�7�7H I
ArraySubType
�7�7J V
=
�7�7W X

�7�7Y f
.
�7�7f g
I1
�7�7g i
)
�7�7i j
]
�7�7j k
public
�7�7 
byte
�7�7 
[
�7�7 
]
�7�7 
byRes2
�7�7  
;
�7�7  !
}
�7�7 	
[
�7�7 	#
StructLayoutAttribute
�7�7	 
(
�7�7 

LayoutKind
�7�7 )
.
�7�7) *

Sequential
�7�7* 4
)
�7�74 5
]
�7�75 6
public
�7�7 
struct
�7�7 $
NET_DVR_VQD_EVENT_RULE
�7�7 ,
{
�7�7 	
public
�7�7 
uint
�7�7 
dwSize
�7�7 
;
�7�7 
public
�7�7 
byte
�7�7 
byEnable
�7�7  
;
�7�7  !
[
�7�7 
MarshalAsAttribute
�7�7
(
�7�7  

�7�7  -
.
�7�7- .

ByValArray
�7�7. 8
,
�7�78 9
	SizeConst
�7�7: C
=
�7�7D E
$num
�7�7F G
,
�7�7G H
ArraySubType
�7�7I U
=
�7�7V W

�7�7X e
.
�7�7e f
I1
�7�7f h
)
�7�7h i
]
�7�7i j
public
�7�7 
byte
�7�7 
[
�7�7 
]
�7�7 
byRes1
�7�7  
;
�7�7  !
public
�7�7 %
NET_DVR_VQD_EVENT_PARAM
�7�7 *
struEventParam
�7�7+ 9
;
�7�79 :
[
�7�7 
MarshalAsAttribute
�7�7
(
�7�7  

�7�7  -
.
�7�7- .

ByValArray
�7�7. 8
,
�7�78 9
	SizeConst
�7�7: C
=
�7�7D E
MAX_DAYS
�7�7F N
*
�7�7O P!
MAX_TIMESEGMENT_V30
�7�7Q d
,
�7�7d e
ArraySubType
�7�7f r
=
�7�7s t

.�7�7� �
Struct�7�7� �
)�7�7� �
]�7�7� �
public
�7�7 
NET_DVR_SCHEDTIME
�7�7 $
[
�7�7$ %
]
�7�7% &

�7�7' 4
;
�7�74 5
public
�7�7 )
NET_DVR_HANDLEEXCEPTION_V30
�7�7 .
struHandleType
�7�7/ =
;
�7�7= >
[
�7�7 
MarshalAsAttribute
�7�7
(
�7�7  

�7�7  -
.
�7�7- .

ByValArray
�7�7. 8
,
�7�78 9
	SizeConst
�7�7: C
=
�7�7D E!
MAX_IVMS_IP_CHANNEL
�7�7F Y
,
�7�7Y Z
ArraySubType
�7�7[ g
=
�7�7h i

�7�7j w
.
�7�7w x
I1
�7�7x z
)
�7�7z {
]
�7�7{ |
public
�7�7 
byte
�7�7 
[
�7�7 
]
�7�7 
byRelRecordChan
�7�7 )
;
�7�7) *
[
�7�7 
MarshalAsAttribute
�7�7
(
�7�7  

�7�7  -
.
�7�7- .

ByValArray
�7�7. 8
,
�7�78 9
	SizeConst
�7�7: C
=
�7�7D E
$num
�7�7F I
,
�7�7I J
ArraySubType
�7�7K W
=
�7�7X Y

�7�7Z g
.
�7�7g h
I1
�7�7h j
)
�7�7j k
]
�7�7k l
public
�7�7 
byte
�7�7 
[
�7�7 
]
�7�7 
byRes2
�7�7  
;
�7�7  !
}
�7�7 	
[
�7�7 	#
StructLayoutAttribute
�7�7	 
(
�7�7 

LayoutKind
�7�7 )
.
�7�7) *

Sequential
�7�7* 4
)
�7�74 5
]
�7�75 6
public
�7�7 
struct
�7�7 $
NET_DVR_BASELINE_SCENE
�7�7 ,
{
�7�7 	
public
�7�7 
uint
�7�7 
dwSize
�7�7 
;
�7�7 
public
�7�7 
byte
�7�7 
byEnable
�7�7  
;
�7�7  !
[
�7�7 
MarshalAsAttribute
�7�7
(
�7�7  

�7�7  -
.
�7�7- .

ByValArray
�7�7. 8
,
�7�78 9
	SizeConst
�7�7: C
=
�7�7D E
$num
�7�7F H
,
�7�7H I
ArraySubType
�7�7J V
=
�7�7W X

�7�7Y f
.
�7�7f g
I1
�7�7g i
)
�7�7i j
]
�7�7j k
public
�7�7 
byte
�7�7 
[
�7�7 
]
�7�7 
byRes
�7�7 
;
�7�7  
}
�7�7 	
[
�7�7 	#
StructLayoutAttribute
�7�7	 
(
�7�7 

LayoutKind
�7�7 )
.
�7�7) *

Sequential
�7�7* 4
)
�7�74 5
]
�7�75 6
public
�7�7 
struct
�7�7 2
$NET_DVR_CONTROL_BASELINE_SCENE_PARAM
�7�7 :
{
�7�7 	
public
�7�7 
uint
�7�7 
dwSize
�7�7 
;
�7�7 
public
�7�7 
uint
�7�7 
	dwChannel
�7�7 !
;
�7�7! "
public
�7�7 
byte
�7�7 
	byCommand
�7�7 !
;
�7�7! "
[
�7�7 
MarshalAsAttribute
�7�7
(
�7�7  

�7�7  -
.
�7�7- .

ByValArray
�7�7. 8
,
�7�78 9
	SizeConst
�7�7: C
=
�7�7D E
$num
�7�7F I
,
�7�7I J
ArraySubType
�7�7K W
=
�7�7X Y

�7�7Z g
.
�7�7g h
I1
�7�7h j
)
�7�7j k
]
�7�7k l
public
�7�7 
byte
�7�7 
[
�7�7 
]
�7�7 
byRes
�7�7 
;
�7�7  
}
�7�7 	
[
�7�7 	#
StructLayoutAttribute
�7�7	 
(
�7�7 

LayoutKind
�7�7 )
.
�7�7) *

Sequential
�7�7* 4
)
�7�74 5
]
�7�75 6
public
�7�7 
struct
�7�7 
NET_DVR_VQD_ALARM
�7�7 '
{
�7�7 	
public
�7�7 
uint
�7�7 
dwSize
�7�7 
;
�7�7 
public
�7�7 
uint
�7�7 
dwRelativeTime
�7�7 &
;
�7�7& '
public
�7�7 
uint
�7�7 
	dwAbsTime
�7�7 !
;
�7�7! "
public
�7�7 
NET_VCA_DEV_INFO
�7�7 #
struDevInfo
�7�7$ /
;
�7�7/ 0
public
�7�7 
uint
�7�7 
dwEventType
�7�7 #
;
�7�7# $
public
�7�7 
float
�7�7 

fThreshold
�7�7 #
;
�7�7# $
public
�7�7 
uint
�7�7 
dwPicDataLen
�7�7 $
;
�7�7$ %
public
�7�7 
IntPtr
�7�7 
pImage
�7�7  
;
�7�7  !
[
�7�7 
MarshalAsAttribute
�7�7
(
�7�7  

�7�7  -
.
�7�7- .

ByValArray
�7�7. 8
,
�7�78 9
	SizeConst
�7�7: C
=
�7�7D E
$num
�7�7F I
,
�7�7I J
ArraySubType
�7�7K W
=
�7�7X Y

�7�7Z g
.
�7�7g h
I1
�7�7h j
)
�7�7j k
]
�7�7k l
public
�7�7 
byte
�7�7 
[
�7�7 
]
�7�7 
byRes
�7�7 
;
�7�7  
}
�7�7 	
[
�7�7 	#
StructLayoutAttribute
�7�7	 
(
�7�7 

LayoutKind
�7�7 )
.
�7�7) *

Sequential
�7�7* 4
)
�7�74 5
]
�7�75 6
public
�7�7 
struct
�7�7 
NET_DVR_CB_POINT
�7�7 &
{
�7�7 	
public
�7�7 

�7�7  
	struPoint
�7�7! *
;
�7�7* +
public
�7�7 
NET_DVR_PTZPOS
�7�7 !

struPtzPos
�7�7" ,
;
�7�7, -
[
�7�7 
MarshalAsAttribute
�7�7
(
�7�7  

�7�7  -
.
�7�7- .

ByValArray
�7�7. 8
,
�7�78 9
	SizeConst
�7�7: C
=
�7�7D E
$num
�7�7F G
,
�7�7G H
ArraySubType
�7�7I U
=
�7�7V W

�7�7X e
.
�7�7e f
I1
�7�7f h
)
�7�7h i
]
�7�7i j
public
�7�7 
byte
�7�7 
[
�7�7 
]
�7�7 
byRes
�7�7 
;
�7�7  
}
�7�7 	
[
�7�7 	#
StructLayoutAttribute
�7�7	 
(
�7�7 

LayoutKind
�7�7 )
.
�7�7) *

Sequential
�7�7* 4
)
�7�74 5
]
�7�75 6
public
�7�7 
struct
�7�7 -
NET_DVR_TRACK_CALIBRATION_PARAM
�7�7 5
{
�7�7 	
public
�7�7 
byte
�7�7 

byPointNum
�7�7 "
;
�7�7" #
[
�7�7 
MarshalAsAttribute
�7�7
(
�7�7  

�7�7  -
.
�7�7- .

ByValArray
�7�7. 8
,
�7�78 9
	SizeConst
�7�7: C
=
�7�7D E
$num
�7�7F G
,
�7�7G H
ArraySubType
�7�7I U
=
�7�7V W

�7�7X e
.
�7�7e f
I1
�7�7f h
)
�7�7h i
]
�7�7i j
public
�7�7 
byte
�7�7 
[
�7�7 
]
�7�7 
byRes
�7�7 
;
�7�7  
[
�7�7 
MarshalAsAttribute
�7�7
(
�7�7  

�7�7  -
.
�7�7- .

ByValArray
�7�7. 8
,
�7�78 9
	SizeConst
�7�7: C
=
�7�7D E
MAX_CALIB_PT
�7�7F R
,
�7�7R S
ArraySubType
�7�7T `
=
�7�7a b

�7�7c p
.
�7�7p q
Struct
�7�7q w
)
�7�7w x
]
�7�7x y
public
�7�7 
NET_DVR_CB_POINT
�7�7 #
[
�7�7# $
]
�7�7$ %
struCBPoint
�7�7& 1
;
�7�71 2
}
�7�7 	
[
�7�7 	#
StructLayoutAttribute
�7�7	 
(
�7�7 

LayoutKind
�7�7 )
.
�7�7) *

Sequential
�7�7* 4
)
�7�74 5
]
�7�75 6
public
�7�7 
struct
�7�7 
NET_DVR_TRACK_CFG
�7�7 '
{
�7�7 	
public
�7�7 
uint
�7�7 
dwSize
�7�7 
;
�7�7 
public
�7�7 
byte
�7�7 
byEnable
�7�7  
;
�7�7  !
public
�7�7 
byte
�7�7 
byFollowChan
�7�7 $
;
�7�7$ %
public
�7�7 
byte
�7�7 
byDomeCalibrate
�7�7 '
;
�7�7' (
public
�7�7 
byte
�7�7 
byRes
�7�7 
;
�7�7 
public
�7�7 -
NET_DVR_TRACK_CALIBRATION_PARAM
�7�7 2
struCalParam
�7�73 ?
;
�7�7? @
}
�7�7 	
public
�7�7 
enum
�7�7 

TRACK_MODE
�7�7 
{
�7�7 	
MANUAL_CTRL
�7�7 
=
�7�7 
$num
�7�7 
,
�7�7 
ALARM_TRACK
�7�7 
}
�7�7 	
[
�7�7 	#
StructLayoutAttribute
�7�7	 
(
�7�7 

LayoutKind
�7�7 )
.
�7�7) *

Sequential
�7�7* 4
)
�7�74 5
]
�7�75 6
public
�7�7 
struct
�7�7 &
NET_DVR_MANUAL_CTRL_INFO
�7�7 .
{
�7�7 	
public
�7�7 

�7�7  

�7�7! .
;
�7�7. /
[
�7�7 
MarshalAsAttribute
�7�7
(
�7�7  

�7�7  -
.
�7�7- .

ByValArray
�7�7. 8
,
�7�78 9
	SizeConst
�7�7: C
=
�7�7D E
$num
�7�7F G
,
�7�7G H
ArraySubType
�7�7I U
=
�7�7V W

�7�7X e
.
�7�7e f
I1
�7�7f h
)
�7�7h i
]
�7�7i j
public
�7�7 
byte
�7�7 
[
�7�7 
]
�7�7 
byRes
�7�7 
;
�7�7  
}
�7�7 	
[
�7�7 	#
StructLayoutAttribute
�7�7	 
(
�7�7 

LayoutKind
�7�7 )
.
�7�7) *

Sequential
�7�7* 4
)
�7�74 5
]
�7�75 6
public
�7�7 
struct
�7�7  
NET_DVR_TRACK_MODE
�7�7 (
{
�7�7 	
public
�7�7 
uint
�7�7 
dwSize
�7�7 
;
�7�7 
public
�7�7 
byte
�7�7 
byTrackMode
�7�7 #
;
�7�7# $
public
�7�7 
byte
�7�7 
byRuleConfMode
�7�7 &
;
�7�7& '
[
�7�7 
MarshalAsAttribute
�7�7
(
�7�7  

�7�7  -
.
�7�7- .

ByValArray
�7�7. 8
,
�7�78 9
	SizeConst
�7�7: C
=
�7�7D E
$num
�7�7F G
,
�7�7G H
ArraySubType
�7�7I U
=
�7�7V W

�7�7X e
.
�7�7e f
I1
�7�7f h
)
�7�7h i
]
�7�7i j
public
�7�7 
byte
�7�7 
[
�7�7 
]
�7�7 
byRes
�7�7 
;
�7�7  
[
�7�7 
StructLayout
�7�7
(
�7�7 

LayoutKind
�7�7 $
.
�7�7$ %
Explicit
�7�7% -
)
�7�7- .
]
�7�7. /
public
�7�7 
struct
�7�7 

uModeParam
�7�7 $
{
�7�7 
[
�7�7 "
FieldOffsetAttribute
�7�7 %
(
�7�7% &
$num
�7�7& '
)
�7�7' (
]
�7�7( )
[
�8�8  
MarshalAsAttribute
�8�8 #
(
�8�8# $

�8�8$ 1
.
�8�81 2

ByValArray
�8�82 <
,
�8�8< =
	SizeConst
�8�8> G
=
�8�8H I
$num
�8�8J K
,
�8�8K L
ArraySubType
�8�8M Y
=
�8�8Z [

�8�8\ i
.
�8�8i j
U4
�8�8j l
)
�8�8l m
]
�8�8m n
public
�8�8 
uint
�8�8 
[
�8�8 
]
�8�8 
dwULen
�8�8 $
;
�8�8$ %
[
�8�8 "
FieldOffsetAttribute
�8�8 %
(
�8�8% &
$num
�8�8& '
)
�8�8' (
]
�8�8( )
public
�8�8 &
NET_DVR_MANUAL_CTRL_INFO
�8�8 /
struManualCtrl
�8�80 >
;
�8�8> ?
}
�8�8 
}
�8�8 	
[
�8�8 	#
StructLayoutAttribute
�8�8	 
(
�8�8 

LayoutKind
�8�8 )
.
�8�8) *

Sequential
�8�8* 4
)
�8�84 5
]
�8�85 6
public
�8�8 
struct
�8�8  
NET_DVR_ALARM_JPEG
�8�8 (
{
�8�8 	
public
�8�8 
byte
�8�8 
byPicProType
�8�8 $
;
�8�8$ %
[
�8�8 
MarshalAsAttribute
�8�8
(
�8�8  

�8�8  -
.
�8�8- .

ByValArray
�8�8. 8
,
�8�88 9
	SizeConst
�8�8: C
=
�8�8D E
$num
�8�8F G
,
�8�8G H
ArraySubType
�8�8I U
=
�8�8V W

�8�8X e
.
�8�8e f
I1
�8�8f h
)
�8�8h i
]
�8�8i j
public
�8�8 
byte
�8�8 
[
�8�8 
]
�8�8 
byRes
�8�8 
;
�8�8  
public
�8�8 
NET_DVR_JPEGPARA
�8�8 #
struPicParam
�8�8$ 0
;
�8�80 1
}
�8�8 	
[
�8�8 	#
StructLayoutAttribute
�8�8	 
(
�8�8 

LayoutKind
�8�8 )
.
�8�8) *

Sequential
�8�8* 4
)
�8�84 5
]
�8�85 6
public
�8�8 
struct
�8�8 
NET_IVMS_ONE_RULE
�8�8 '
{
�8�8 	
public
�8�8 
byte
�8�8 
byActive
�8�8  
;
�8�8  !
[
�8�8 
MarshalAsAttribute
�8�8
(
�8�8  

�8�8  -
.
�8�8- .

ByValArray
�8�8. 8
,
�8�88 9
	SizeConst
�8�8: C
=
�8�8D E
$num
�8�8F G
,
�8�8G H
ArraySubType
�8�8I U
=
�8�8V W

�8�8X e
.
�8�8e f
I1
�8�8f h
)
�8�8h i
]
�8�8i j
public
�8�8 
byte
�8�8 
[
�8�8 
]
�8�8 
byRes1
�8�8  
;
�8�8  !
[
�8�8 
MarshalAsAttribute
�8�8
(
�8�8  

�8�8  -
.
�8�8- .

ByValArray
�8�8. 8
,
�8�88 9
	SizeConst
�8�8: C
=
�8�8D E
NAME_LEN
�8�8F N
,
�8�8N O
ArraySubType
�8�8P \
=
�8�8] ^

�8�8_ l
.
�8�8l m
I1
�8�8m o
)
�8�8o p
]
�8�8p q
public
�8�8 
byte
�8�8 
[
�8�8 
]
�8�8 

byRuleName
�8�8 $
;
�8�8$ %
public
�8�8 
VCA_EVENT_TYPE
�8�8 !
dwEventType
�8�8" -
;
�8�8- .
public
�8�8 !
NET_VCA_EVENT_UNION
�8�8 &
uEventParam
�8�8' 2
;
�8�82 3
public
�8�8 !
NET_VCA_SIZE_FILTER
�8�8 &
struSizeFilter
�8�8' 5
;
�8�85 6
[
�8�8 
MarshalAsAttribute
�8�8
(
�8�8  

�8�8  -
.
�8�8- .

ByValArray
�8�8. 8
,
�8�88 9
	SizeConst
�8�8: C
=
�8�8D E
$num
�8�8F H
,
�8�8H I
ArraySubType
�8�8J V
=
�8�8W X

�8�8Y f
.
�8�8f g
I1
�8�8g i
)
�8�8i j
]
�8�8j k
public
�8�8 
byte
�8�8 
[
�8�8 
]
�8�8 
byRes2
�8�8  
;
�8�8  !
}
�8�8 	
[
�8�8 	#
StructLayoutAttribute
�8�8	 
(
�8�8 

LayoutKind
�8�8 )
.
�8�8) *

Sequential
�8�8* 4
)
�8�84 5
]
�8�85 6
public
�8�8 
struct
�8�8 
NET_IVMS_RULECFG
�8�8 &
{
�8�8 	
[
�8�8 
MarshalAsAttribute
�8�8
(
�8�8  

�8�8  -
.
�8�8- .

ByValArray
�8�8. 8
,
�8�88 9
	SizeConst
�8�8: C
=
�8�8D E
MAX_RULE_NUM
�8�8F R
,
�8�8R S
ArraySubType
�8�8T `
=
�8�8a b

�8�8c p
.
�8�8p q
Struct
�8�8q w
)
�8�8w x
]
�8�8x y
public
�8�8 
NET_IVMS_ONE_RULE
�8�8 $
[
�8�8$ %
]
�8�8% &
struRule
�8�8' /
;
�8�8/ 0
}
�8�8 	
[
�8�8 	#
StructLayoutAttribute
�8�8	 
(
�8�8 

LayoutKind
�8�8 )
.
�8�8) *

Sequential
�8�8* 4
)
�8�84 5
]
�8�85 6
public
�8�8 
struct
�8�8 "
NET_IVMS_BEHAVIORCFG
�8�8 *
{
�8�8 	
public
�8�8 
uint
�8�8 
dwSize
�8�8 
;
�8�8 
public
�8�8 
byte
�8�8 
byPicProType
�8�8 $
;
�8�8$ %
[
�8�8 
MarshalAsAttribute
�8�8
(
�8�8  

�8�8  -
.
�8�8- .

ByValArray
�8�8. 8
,
�8�88 9
	SizeConst
�8�8: C
=
�8�8D E
$num
�8�8F G
,
�8�8G H
ArraySubType
�8�8I U
=
�8�8V W

�8�8X e
.
�8�8e f
I1
�8�8f h
)
�8�8h i
]
�8�8i j
public
�8�8 
byte
�8�8 
[
�8�8 
]
�8�8 
byRes
�8�8 
;
�8�8  
public
�8�8 
NET_DVR_JPEGPARA
�8�8 #
struPicParam
�8�8$ 0
;
�8�80 1
[
�8�8 
MarshalAsAttribute
�8�8
(
�8�8  

�8�8  -
.
�8�8- .

ByValArray
�8�8. 8
,
�8�88 9
	SizeConst
�8�8: C
=
�8�8D E
MAX_DAYS
�8�8F N
*
�8�8O P
MAX_TIMESEGMENT
�8�8Q `
,
�8�8` a
ArraySubType
�8�8b n
=
�8�8o p

�8�8q ~
.
�8�8~ 
Struct�8�8 �
)�8�8� �
]�8�8� �
public
�8�8 
NET_IVMS_RULECFG
�8�8 #
[
�8�8# $
]
�8�8$ %
struRuleCfg
�8�8& 1
;
�8�81 2
}
�8�8 	
[
�8�8 	#
StructLayoutAttribute
�8�8	 
(
�8�8 

LayoutKind
�8�8 )
.
�8�8) *

Sequential
�8�8* 4
)
�8�84 5
]
�8�85 6
public
�8�8 
struct
�8�8 
NET_IVMS_DEVSCHED
�8�8 '
{
�8�8 	
public
�8�8 
NET_DVR_SCHEDTIME
�8�8 $
struTime
�8�8% -
;
�8�8- .
public
�8�8 #
NET_DVR_PU_STREAM_CFG
�8�8 (
struPUStream
�8�8) 5
;
�8�85 6
}
�8�8 	
[
�8�8 	#
StructLayoutAttribute
�8�8	 
(
�8�8 

LayoutKind
�8�8 )
.
�8�8) *

Sequential
�8�8* 4
)
�8�84 5
]
�8�85 6
public
�8�8 
struct
�8�8  
NET_IVMS_STREAMCFG
�8�8 (
{
�8�8 	
public
�8�8 
uint
�8�8 
dwSize
�8�8 
;
�8�8 
[
�8�8 
MarshalAsAttribute
�8�8
(
�8�8  

�8�8  -
.
�8�8- .

ByValArray
�8�8. 8
,
�8�88 9
	SizeConst
�8�8: C
=
�8�8D E
MAX_DAYS
�8�8F N
*
�8�8O P
MAX_TIMESEGMENT
�8�8Q `
,
�8�8` a
ArraySubType
�8�8b n
=
�8�8o p

�8�8q ~
.
�8�8~ 
Struct�8�8 �
)�8�8� �
]�8�8� �
public
�8�8 
NET_IVMS_DEVSCHED
�8�8 $
[
�8�8$ %
]
�8�8% &
struDevSched
�8�8' 3
;
�8�83 4
}
�8�8 	
[
�8�8 	#
StructLayoutAttribute
�8�8	 
(
�8�8 

LayoutKind
�8�8 )
.
�8�8) *

Sequential
�8�8* 4
)
�8�84 5
]
�8�85 6
public
�8�8 
struct
�8�8 !
NET_VCA_MASK_REGION
�8�8 )
{
�8�8 	
public
�8�8 
byte
�8�8 
byEnable
�8�8  
;
�8�8  !
[
�8�8 
MarshalAsAttribute
�8�8
(
�8�8  

�8�8  -
.
�8�8- .

ByValArray
�8�8. 8
,
�8�88 9
	SizeConst
�8�8: C
=
�8�8D E
$num
�8�8F G
,
�8�8G H
ArraySubType
�8�8I U
=
�8�8V W

�8�8X e
.
�8�8e f
I1
�8�8f h
)
�8�8h i
]
�8�8i j
public
�8�8 
byte
�8�8 
[
�8�8 
]
�8�8 
byRes
�8�8 
;
�8�8  
public
�8�8 
NET_VCA_POLYGON
�8�8 "
struPolygon
�8�8# .
;
�8�8. /
}
�8�8 	
[
�8�8 	#
StructLayoutAttribute
�8�8	 
(
�8�8 

LayoutKind
�8�8 )
.
�8�8) *

Sequential
�8�8* 4
)
�8�84 5
]
�8�85 6
public
�8�8 
struct
�8�8 &
NET_VCA_MASK_REGION_LIST
�8�8 .
{
�8�8 	
public
�8�8 
uint
�8�8 
dwSize
�8�8 
;
�8�8 
[
�8�8 
MarshalAsAttribute
�8�8
(
�8�8  

�8�8  -
.
�8�8- .

ByValArray
�8�8. 8
,
�8�88 9
	SizeConst
�8�8: C
=
�8�8D E
$num
�8�8F G
,
�8�8G H
ArraySubType
�8�8I U
=
�8�8V W

�8�8X e
.
�8�8e f
I1
�8�8f h
)
�8�8h i
]
�8�8i j
public
�8�8 
byte
�8�8 
[
�8�8 
]
�8�8 
byRes
�8�8 
;
�8�8  
[
�8�8 
MarshalAsAttribute
�8�8
(
�8�8  

�8�8  -
.
�8�8- .

ByValArray
�8�8. 8
,
�8�88 9
	SizeConst
�8�8: C
=
�8�8D E!
MAX_MASK_REGION_NUM
�8�8F Y
,
�8�8Y Z
ArraySubType
�8�8[ g
=
�8�8h i

�8�8j w
.
�8�8w x
Struct
�8�8x ~
)
�8�8~ 
]�8�8 �
public
�8�8 !
NET_VCA_MASK_REGION
�8�8 &
[
�8�8& '
]
�8�8' (
struMask
�8�8) 1
;
�8�81 2
}
�8�8 	
[
�8�8 	#
StructLayoutAttribute
�8�8	 
(
�8�8 

LayoutKind
�8�8 )
.
�8�8) *

Sequential
�8�8* 4
)
�8�84 5
]
�8�85 6
public
�8�8 
struct
�8�8 "
NET_VCA_ENTER_REGION
�8�8 *
{
�8�8 	
public
�8�8 
uint
�8�8 
dwSize
�8�8 
;
�8�8 
public
�8�8 
byte
�8�8 
byEnable
�8�8  
;
�8�8  !
[
�8�8 
MarshalAsAttribute
�8�8
(
�8�8  

�8�8  -
.
�8�8- .

ByValArray
�8�8. 8
,
�8�88 9
	SizeConst
�8�8: C
=
�8�8D E
$num
�8�8F G
,
�8�8G H
ArraySubType
�8�8I U
=
�8�8V W

�8�8X e
.
�8�8e f
I1
�8�8f h
)
�8�8h i
]
�8�8i j
public
�8�8 
byte
�8�8 
[
�8�8 
]
�8�8 
byRes1
�8�8  
;
�8�8  !
public
�8�8 
NET_VCA_POLYGON
�8�8 "
struPolygon
�8�8# .
;
�8�8. /
[
�8�8 
MarshalAsAttribute
�8�8
(
�8�8  

�8�8  -
.
�8�8- .

ByValArray
�8�8. 8
,
�8�88 9
	SizeConst
�8�8: C
=
�8�8D E
$num
�8�8F H
,
�8�8H I
ArraySubType
�8�8J V
=
�8�8W X

�8�8Y f
.
�8�8f g
I1
�8�8g i
)
�8�8i j
]
�8�8j k
public
�8�8 
byte
�8�8 
[
�8�8 
]
�8�8 
byRes2
�8�8  
;
�8�8  !
}
�8�8 	
[
�8�8 	#
StructLayoutAttribute
�8�8	 
(
�8�8 

LayoutKind
�8�8 )
.
�8�8) *

Sequential
�8�8* 4
)
�8�84 5
]
�8�85 6
public
�8�8 
struct
�8�8 '
NET_IVMS_MASK_REGION_LIST
�8�8 /
{
�8�8 	
public
�8�8 
uint
�8�8 
dwSize
�8�8 
;
�8�8 
[
�8�8 
MarshalAsAttribute
�8�8
(
�8�8  

�8�8  -
.
�8�8- .

ByValArray
�8�8. 8
,
�8�88 9
	SizeConst
�8�8: C
=
�8�8D E
MAX_DAYS
�8�8F N
*
�8�8O P
MAX_TIMESEGMENT
�8�8Q `
,
�8�8` a
ArraySubType
�8�8b n
=
�8�8o p

�8�8q ~
.
�8�8~ 
Struct�8�8 �
)�8�8� �
]�8�8� �
public
�8�8 &
NET_VCA_MASK_REGION_LIST
�8�8 +
[
�8�8+ ,
]
�8�8, -
struList
�8�8. 6
;
�8�86 7
}
�8�8 	
[
�8�8 	#
StructLayoutAttribute
�8�8	 
(
�8�8 

LayoutKind
�8�8 )
.
�8�8) *

Sequential
�8�8* 4
)
�8�84 5
]
�8�85 6
public
�8�8 
struct
�8�8 #
NET_IVMS_ENTER_REGION
�8�8 +
{
�8�8 	
public
�8�8 
uint
�8�8 
dwSize
�8�8 
;
�8�8 
[
�8�8 
MarshalAsAttribute
�8�8
(
�8�8  

�8�8  -
.
�8�8- .

ByValArray
�8�8. 8
,
�8�88 9
	SizeConst
�8�8: C
=
�8�8D E
MAX_DAYS
�8�8F N
*
�8�8O P
MAX_TIMESEGMENT
�8�8Q `
,
�8�8` a
ArraySubType
�8�8b n
=
�8�8o p

�8�8q ~
.
�8�8~ 
Struct�8�8 �
)�8�8� �
]�8�8� �
public
�8�8 "
NET_VCA_ENTER_REGION
�8�8 '
[
�8�8' (
]
�8�8( )
	struEnter
�8�8* 3
;
�8�83 4
}
�8�8 	
[
�8�8 	#
StructLayoutAttribute
�8�8	 
(
�8�8 

LayoutKind
�8�8 )
.
�8�8) *

Sequential
�8�8* 4
)
�8�84 5
]
�8�85 6
public
�8�8 
struct
�8�8 !
NET_IVMS_ALARM_JPEG
�8�8 )
{
�8�8 	
public
�8�8 
byte
�8�8 
byPicProType
�8�8 $
;
�8�8$ %
[
�9�9 
MarshalAsAttribute
�9�9
(
�9�9  

�9�9  -
.
�9�9- .

ByValArray
�9�9. 8
,
�9�98 9
	SizeConst
�9�9: C
=
�9�9D E
$num
�9�9F G
,
�9�9G H
ArraySubType
�9�9I U
=
�9�9V W

�9�9X e
.
�9�9e f
I1
�9�9f h
)
�9�9h i
]
�9�9i j
public
�9�9 
byte
�9�9 
[
�9�9 
]
�9�9 
byRes
�9�9 
;
�9�9  
public
�9�9 
NET_DVR_JPEGPARA
�9�9 #
struPicParam
�9�9$ 0
;
�9�90 1
}
�9�9 	
[
�9�9 	#
StructLayoutAttribute
�9�9	 
(
�9�9 

LayoutKind
�9�9 )
.
�9�9) *

Sequential
�9�9* 4
)
�9�94 5
]
�9�95 6
public
�9�9 
struct
�9�9  
NET_IVMS_SEARCHCFG
�9�9 (
{
�9�9 	
public
�9�9 
uint
�9�9 
dwSize
�9�9 
;
�9�9 
public
�9�9 ,
NET_DVR_MATRIX_DEC_REMOTE_PLAY
�9�9 1
struRemotePlay
�9�92 @
;
�9�9@ A
public
�9�9 !
NET_IVMS_ALARM_JPEG
�9�9 &

�9�9' 4
;
�9�94 5
public
�9�9 
NET_IVMS_RULECFG
�9�9 #
struRuleCfg
�9�9$ /
;
�9�9/ 0
}
�9�9 	
[
�9�9 	#
StructLayoutAttribute
�9�9	 
(
�9�9 

LayoutKind
�9�9 )
.
�9�9) *

Sequential
�9�9* 4
)
�9�94 5
]
�9�95 6
public
�9�9 
struct
�9�9 *
NET_DVR_IDENTIFICATION_PARAM
�9�9 2
{
�9�9 	
[
�9�9 
MarshalAsAttribute
�9�9
(
�9�9  

�9�9  -
.
�9�9- .

ByValArray
�9�9. 8
,
�9�98 9
	SizeConst
�9�9: C
=
�9�9D E
NAME_LEN
�9�9F N
,
�9�9N O
ArraySubType
�9�9P \
=
�9�9] ^

�9�9_ l
.
�9�9l m
I1
�9�9m o
)
�9�9o p
]
�9�9p q
public
�9�9 
byte
�9�9 
[
�9�9 
]
�9�9 
	sUserName
�9�9 #
;
�9�9# $
[
�9�9 
MarshalAsAttribute
�9�9
(
�9�9  

�9�9  -
.
�9�9- .

ByValArray
�9�9. 8
,
�9�98 9
	SizeConst
�9�9: C
=
�9�9D E

PASSWD_LEN
�9�9F P
,
�9�9P Q
ArraySubType
�9�9R ^
=
�9�9_ `

�9�9a n
.
�9�9n o
I1
�9�9o q
)
�9�9q r
]
�9�9r s
public
�9�9 
byte
�9�9 
[
�9�9 
]
�9�9 
	sPassword
�9�9 #
;
�9�9# $
[
�9�9 
MarshalAsAttribute
�9�9
(
�9�9  

�9�9  -
.
�9�9- .

ByValArray
�9�9. 8
,
�9�98 9
	SizeConst
�9�9: C
=
�9�9D E
$num
�9�9F G
,
�9�9G H
ArraySubType
�9�9I U
=
�9�9V W

�9�9X e
.
�9�9e f
I1
�9�9f h
)
�9�9h i
]
�9�9i j
public
�9�9 
byte
�9�9 
[
�9�9 
]
�9�9 
byRes1
�9�9  
;
�9�9  !
}
�9�9 	
[
�9�9 	#
StructLayoutAttribute
�9�9	 
(
�9�9 

LayoutKind
�9�9 )
.
�9�9) *
Explicit
�9�9* 2
)
�9�92 3
]
�9�93 4
public
�9�9 
struct
�9�9 '
NET_DVR_MOUNT_PARAM_UNION
�9�9 /
{
�9�9 	
[
�9�9 
FieldOffsetAttribute
�9�9
(
�9�9! "
$num
�9�9" #
)
�9�9# $
]
�9�9$ %
[
�9�9 
MarshalAsAttribute
�9�9
(
�9�9  

�9�9  -
.
�9�9- .

ByValArray
�9�9. 8
,
�9�98 9
	SizeConst
�9�9: C
=
�9�9D E
$num
�9�9F H
,
�9�9H I
ArraySubType
�9�9J V
=
�9�9W X

�9�9Y f
.
�9�9f g
I1
�9�9g i
)
�9�9i j
]
�9�9j k
public
�9�9 
byte
�9�9 
[
�9�9 
]
�9�9 
uLen
�9�9 
;
�9�9 
[
�9�9 
FieldOffsetAttribute
�9�9
(
�9�9! "
$num
�9�9" #
)
�9�9# $
]
�9�9$ %
public
�9�9 *
NET_DVR_IDENTIFICATION_PARAM
�9�9 /%
struIdentificationParam
�9�90 G
;
�9�9G H
}
�9�9 	
[
�9�9 	#
StructLayoutAttribute
�9�9	 
(
�9�9 

LayoutKind
�9�9 )
.
�9�9) *

Sequential
�9�9* 4
)
�9�94 5
]
�9�95 6
public
�9�9 
struct
�9�9 %
NET_DVR_NAS_MOUNT_PARAM
�9�9 -
{
�9�9 	
public
�9�9 
byte
�9�9 
byMountType
�9�9 #
;
�9�9# $
[
�9�9 
MarshalAsAttribute
�9�9
(
�9�9  

�9�9  -
.
�9�9- .

ByValArray
�9�9. 8
,
�9�98 9
	SizeConst
�9�9: C
=
�9�9D E
$num
�9�9F G
,
�9�9G H
ArraySubType
�9�9I U
=
�9�9V W

�9�9X e
.
�9�9e f
I1
�9�9f h
)
�9�9h i
]
�9�9i j
public
�9�9 
byte
�9�9 
[
�9�9 
]
�9�9 
byRes
�9�9 
;
�9�9  
public
�9�9 '
NET_DVR_MOUNT_PARAM_UNION
�9�9 ,
uMountParam
�9�9- 8
;
�9�98 9
}
�9�9 	
[
�9�9 	#
StructLayoutAttribute
�9�9	 
(
�9�9 

LayoutKind
�9�9 )
.
�9�9) *
Explicit
�9�9* 2
)
�9�92 3
]
�9�93 4
public
�9�9 
struct
�9�9 -
NET_DVR_MOUNTMETHOD_PARAM_UNION
�9�9 5
{
�9�9 	
[
�9�9 
FieldOffsetAttribute
�9�9
(
�9�9! "
$num
�9�9" #
)
�9�9# $
]
�9�9$ %
[
�9�9 
MarshalAsAttribute
�9�9
(
�9�9  

�9�9  -
.
�9�9- .

ByValArray
�9�9. 8
,
�9�98 9
	SizeConst
�9�9: C
=
�9�9D E
$num
�9�9F H
,
�9�9H I
ArraySubType
�9�9J V
=
�9�9W X

�9�9Y f
.
�9�9f g
I1
�9�9g i
)
�9�9i j
]
�9�9j k
public
�9�9 
byte
�9�9 
[
�9�9 
]
�9�9 
uLen
�9�9 
;
�9�9 
[
�9�9 
FieldOffsetAttribute
�9�9
(
�9�9! "
$num
�9�9" #
)
�9�9# $
]
�9�9$ %
public
�9�9 %
NET_DVR_NAS_MOUNT_PARAM
�9�9 *
struNasMountParam
�9�9+ <
;
�9�9< =
}
�9�9 	
[
�9�9 	#
StructLayoutAttribute
�9�9	 
(
�9�9 

LayoutKind
�9�9 )
.
�9�9) *

Sequential
�9�9* 4
)
�9�94 5
]
�9�95 6
public
�9�9 
struct
�9�9 *
NET_DVR_SINGLE_NET_DISK_INFO
�9�9 2
{
�9�9 	
[
�9�9 
MarshalAsAttribute
�9�9
(
�9�9  

�9�9  -
.
�9�9- .

ByValArray
�9�9. 8
,
�9�98 9
	SizeConst
�9�9: C
=
�9�9D E
$num
�9�9F G
,
�9�9G H
ArraySubType
�9�9I U
=
�9�9V W

�9�9X e
.
�9�9e f
I1
�9�9f h
)
�9�9h i
]
�9�9i j
public
�9�9 
byte
�9�9 
[
�9�9 
]
�9�9 
byRes1
�9�9  
;
�9�9  !
public
�9�9 
NET_DVR_IPADDR
�9�9 !
struNetDiskAddr
�9�9" 1
;
�9�91 2
[
�9�9 
MarshalAsAttribute
�9�9
(
�9�9  

.