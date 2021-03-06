//-------------------------------------------------------------------------
/*
Copyright (C) 1996, 2003 - 3D Realms Entertainment

This file is part of Duke Nukem 3D version 1.5 - Atomic Edition

Duke Nukem 3D is free software; you can redistribute it and/or
modify it under the terms of the GNU General Public License
as published by the Free Software Foundation; either version 2
of the License, or (at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  

See the GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program; if not, write to the Free Software
Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.

Original Source: 1996 - Todd Replogle
Prepared for public release: 03/21/2003 - Charlie Wiederhold, 3D Realms
*/
//-------------------------------------------------------------------------

#define SECTOREFFECTOR
#define ACTIVATOR
#define TOUCHPLATE
#define ACTIVATORLOCKED
#define MUSICANDSFX
#define LOCATORS
#define CYCLER
#define MASTERSWITCH
#define RESPAWN
#define GPSPEED
#define FOF
#define ARROW
#define FIRSTGUNSPRITE
#define CHAINGUNSPRITE
#define RPGSPRITE
#define FREEZESPRITE
#define SHRINKERSPRITE
#define HEAVYHBOMB
#define TRIPBOMBSPRITE
#define SHOTGUNSPRITE
#define DEVISTATORSPRITE
#define HEALTHBOX
#define AMMOBOX
#define GROWSPRITEICON
#define INVENTORYBOX
#define FREEZEAMMO
#define AMMO
#define BATTERYAMMO
#define DEVISTATORAMMO
#define RPGAMMO
#define GROWAMMO
#define CRYSTALAMMO
#define HBOMBAMMO
#define AMMOLOTS
#define SHOTGUNAMMO
#define COLA
#define SIXPAK
#define FIRSTAID
#define SHIELD
#define STEROIDS
#define AIRTANK
#define JETPACK
#define HEATSENSOR
#define ACCESSCARD
#define BOOTS
#define MIRRORBROKE
#define CLOUDYOCEAN
#define CLOUDYSKIES
#define MOONSKY1
#define MOONSKY2
#define MOONSKY3
#define MOONSKY4
#define BIGORBIT1
#define BIGORBIT2
#define BIGORBIT3
#define BIGORBIT4
#define BIGORBIT5
#define LA
#define REDSKY1
#define REDSKY2
#define ATOMICHEALTH
#define TECHLIGHT2
#define TECHLIGHTBUST2
#define TECHLIGHT4
#define TECHLIGHTBUST4
#define WALLLIGHT4
#define WALLLIGHTBUST4
#define ACCESSSWITCH
#define SLOTDOOR
#define LIGHTSWITCH
#define SPACEDOORSWITCH
#define SPACELIGHTSWITCH
#define FRANKENSTINESWITCH
#define NUKEBUTTON
#define MULTISWITCH
#define DOORTILE5
#define DOORTILE6
#define DOORTILE1
#define DOORTILE2
#define DOORTILE3
#define DOORTILE4
#define DOORTILE7
#define DOORTILE8
#define DOORTILE9
#define DOORTILE10
#define DOORSHOCK
#define DIPSWITCH
#define DIPSWITCH2
#define TECHSWITCH
#define DIPSWITCH3
#define ACCESSSWITCH2
#define REFLECTWATERTILE
#define FLOORSLIME
#define BIGFORCE
#define EPISODE
#define MASKWALL9
#define W_LIGHT
#define SCREENBREAK1
#define SCREENBREAK2
#define SCREENBREAK3
#define SCREENBREAK4
#define SCREENBREAK5
#define SCREENBREAK6
#define SCREENBREAK7
#define SCREENBREAK8
#define SCREENBREAK9
#define SCREENBREAK10
#define SCREENBREAK11
#define SCREENBREAK12
#define SCREENBREAK13
#define MASKWALL1
#define W_TECHWALL1
#define W_TECHWALL2
#define W_TECHWALL15
#define W_TECHWALL3
#define W_TECHWALL4
#define W_TECHWALL10
#define W_TECHWALL16
#define WATERTILE2
#define BPANNEL1
#define PANNEL1
#define PANNEL2
#define WATERTILE
#define STATIC
#define W_SCREENBREAK
#define W_HITTECHWALL3
#define W_HITTECHWALL4
#define W_HITTECHWALL2
#define W_HITTECHWALL1
#define MASKWALL10
#define MASKWALL11
#define DOORTILE22
#define FANSPRITE
#define FANSPRITEBROKE
#define FANSHADOW
#define FANSHADOWBROKE
#define DOORTILE18
#define DOORTILE19
#define DOORTILE20
// #define SPACESHUTTLE 487
#define SATELLITE
#define VIEWSCREEN2
#define VIEWSCREENBROKE
#define VIEWSCREEN
#define GLASS
#define GLASS2
#define STAINGLASS1
#define MASKWALL5
#define SATELITE
#define FUELPOD
#define SLIMEPIPE
#define CRACK1
#define CRACK2
#define CRACK3
#define CRACK4
#define FOOTPRINTS
#define DOMELITE
#define CAMERAPOLE
#define CHAIR1
#define CHAIR2
#define BROKENCHAIR
#define MIRROR
#define WATERFOUNTAIN
#define WATERFOUNTAINBROKE
#define FEMMAG1
#define TOILET
#define STALL
#define STALLBROKE
#define FEMMAG2
#define REACTOR2
#define REACTOR2BURNT
#define REACTOR2SPARK
#define GRATE1
#define BGRATE1
#define SOLARPANNEL
#define NAKED1
#define ANTENNA
#define MASKWALL12
#define TOILETBROKE
#define PIPE2
#define PIPE1B
#define PIPE3
#define PIPE1
#define CAMERA1
#define BRICK
#define SPLINTERWOOD
#define PIPE2B
#define BOLT1
#define W_NUMBERS
#define WATERDRIP
#define WATERBUBBLE
#define WATERBUBBLEMAKER
#define W_FORCEFIELD
#define VACUUM
#define FOOTPRINTS2
#define FOOTPRINTS3
#define FOOTPRINTS4
#define EGG
#define SCALE
#define CHAIR3
#define CAMERALIGHT
#define MOVIECAMERA
#define IVUNIT
#define POT1
#define POT2
#define POT3
#define PIPE3B
#define WALLLIGHT3
#define WALLLIGHTBUST3
#define WALLLIGHT1
#define WALLLIGHTBUST1
#define WALLLIGHT2
#define WALLLIGHTBUST2
#define LIGHTSWITCH2
#define WAITTOBESEATED
#define DOORTILE14
#define STATUE
#define MIKE
#define VASE
#define SUSHIPLATE1
#define SUSHIPLATE2
#define SUSHIPLATE3
#define SUSHIPLATE4
#define DOORTILE16
#define SUSHIPLATE5
#define OJ
#define MASKWALL13
#define HURTRAIL
#define POWERSWITCH1
#define LOCKSWITCH1
#define POWERSWITCH2
#define ATM
#define STATUEFLASH
#define ATMBROKE
#define BIGHOLE2
#define STRIPEBALL
#define QUEBALL
#define POCKET
#define WOODENHORSE
#define TREE1
#define TREE2
#define CACTUS
#define MASKWALL2
#define MASKWALL3
#define MASKWALL4
#define FIREEXT
#define TOILETWATER
#define NEON1
#define NEON2
#define CACTUSBROKE
#define BOUNCEMINE
#define BROKEFIREHYDRENT
#define BOX
#define BULLETHOLE
#define BOTTLE1
#define BOTTLE2
#define BOTTLE3
#define BOTTLE4
#define FEMPIC5
#define FEMPIC6
#define FEMPIC7
#define HYDROPLANT
#define OCEANSPRITE1
#define OCEANSPRITE2
#define OCEANSPRITE3
#define OCEANSPRITE4
#define OCEANSPRITE5
#define GENERICPOLE
#define CONE
#define HANGLIGHT
#define HYDRENT
#define MASKWALL14
#define TIRE
#define PIPE5
#define PIPE6
#define PIPE4
#define PIPE4B
#define BROKEHYDROPLANT
#define PIPE5B
#define NEON3
#define NEON4
#define NEON5
#define BOTTLE5
#define BOTTLE6
#define BOTTLE8
#define SPOTLITE
#define HANGOOZ
#define MASKWALL15
#define BOTTLE7
#define HORSEONSIDE
#define GLASSPIECES
#define HORSELITE
#define DONUTS
#define NEON6
#define MASKWALL6
#define CLOCK
#define RUBBERCAN
#define BROKENCLOCK
#define PLUG
#define OOZFILTER
#define FLOORPLASMA
#define REACTOR
#define REACTORSPARK
#define REACTORBURNT
#define DOORTILE15
#define HANDSWITCH
#define CIRCLEPANNEL
#define CIRCLEPANNELBROKE
#define PULLSWITCH
#define MASKWALL8
#define BIGHOLE
#define ALIENSWITCH
#define DOORTILE21
#define HANDPRINTSWITCH
#define BOTTLE10
#define BOTTLE11
#define BOTTLE12
#define BOTTLE13
#define BOTTLE14
#define BOTTLE15
#define BOTTLE16
#define BOTTLE17
#define BOTTLE18
#define BOTTLE19
#define DOORTILE17
#define MASKWALL7
#define JAILBARBREAK
#define DOORTILE11
#define DOORTILE12
#define VENDMACHINE
#define VENDMACHINEBROKE
#define COLAMACHINE
#define COLAMACHINEBROKE
#define CRANEPOLE
#define CRANE
#define BARBROKE
#define BLOODPOOL
#define NUKEBARREL
#define NUKEBARRELDENTED
#define NUKEBARRELLEAKED
#define CANWITHSOMETHING
#define MONEY
#define BANNER
#define EXPLODINGBARREL
#define EXPLODINGBARREL2
#define FIREBARREL
#define SEENINE
#define SEENINEDEAD
#define STEAM
#define CEILINGSTEAM
#define PIPE6B
#define TRANSPORTERBEAM
#define RAT
#define TRASH
#define FEMPIC1
#define FEMPIC2
#define BLANKSCREEN
#define PODFEM1
#define FEMPIC3
#define FEMPIC4
#define FEM1
#define FEM2
#define FEM3
#define FEM5
#define BLOODYPOLE
#define FEM4
#define FEM6
#define FEM6PAD
#define FEM8
#define HELECOPT
#define FETUSJIB
#define HOLODUKE
#define SPACEMARINE
#define INDY
#define FETUS
#define FETUSBROKE
#define MONK
#define LUKE
#define COOLEXPLOSION1
#define WATERSPLASH2
#define FIREVASE
#define SCRATCH
#define FEM7
#define APLAYERTOP
#define APLAYER
#define PLAYERONWATER
#define DUKELYINGDEAD
#define DUKETORSO
#define DUKEGUN
#define DUKELEG
#define SHARK
#define BLOOD
#define FIRELASER
#define TRANSPORTERSTAR
#define SPIT
#define LOOGIE
#define FIST
#define FREEZEBLAST
#define DEVISTATORBLAST
#define SHRINKSPARK
#define TONGUE
#define MORTER
#define SHRINKEREXPLOSION
#define RADIUSEXPLOSION
#define FORCERIPPLE
#define LIZTROOP
#define LIZTROOPRUNNING
#define LIZTROOPSTAYPUT
#define LIZTOP
#define LIZTROOPSHOOT
#define LIZTROOPJETPACK
#define LIZTROOPDSPRITE
#define LIZTROOPONTOILET
#define LIZTROOPJUSTSIT
#define LIZTROOPDUCKING
#define HEADJIB1
#define ARMJIB1
#define LEGJIB1
#define CANNONBALL
#define OCTABRAIN
#define OCTABRAINSTAYPUT
#define OCTATOP
#define OCTADEADSPRITE
#define INNERJAW
#define DRONE
#define EXPLOSION2
#define COMMANDER
#define COMMANDERSTAYPUT
#define RECON
#define TANK
#define PIGCOP
#define PIGCOPSTAYPUT
#define PIGCOPDIVE
#define PIGCOPDEADSPRITE
#define PIGTOP
#define LIZMAN
#define LIZMANSTAYPUT
#define LIZMANSPITTING
#define LIZMANFEEDING
#define LIZMANJUMP
#define LIZMANDEADSPRITE
#define FECES
#define LIZMANHEAD1
#define LIZMANARM1
#define LIZMANLEG1
#define EXPLOSION2BOT
#define USERWEAPON
#define HEADERBAR
#define JIBS1
#define JIBS2
#define JIBS3
#define JIBS4
#define JIBS5
#define BURNING
#define FIRE
#define JIBS6
#define BLOODSPLAT1
#define BLOODSPLAT3
#define BLOODSPLAT2
#define BLOODSPLAT4
#define OOZ
#define OOZ2
#define WALLBLOOD1
#define WALLBLOOD2
#define WALLBLOOD3
#define WALLBLOOD4
#define WALLBLOOD5
#define WALLBLOOD6
#define WALLBLOOD7
#define WALLBLOOD8
#define BURNING2
#define FIRE2
#define CRACKKNUCKLES
#define SMALLSMOKE
#define SMALLSMOKEMAKER
#define FLOORFLAME
#define ROTATEGUN
#define GREENSLIME
#define WATERDRIPSPLASH
#define SCRAP6
#define SCRAP1
#define SCRAP2
#define SCRAP3
#define SCRAP4
#define SCRAP5
#define ORGANTIC
#define BETAVERSION
#define PLAYERISHERE
#define PLAYERWASHERE
#define SELECTDIR
#define F1HELP
#define NOTCHON
#define NOTCHOFF
#define GROWSPARK
#define DUKEICON
#define BADGUYICON
#define FOODICON
#define GETICON
#define MENUSCREEN
#define MENUBAR
#define KILLSICON
#define FIRSTAID_ICON
#define HEAT_ICON
#define BOTTOMSTATUSBAR
#define BOOT_ICON
#define FRAGBAR
#define JETPACK_ICON
#define AIRTANK_ICON
#define STEROIDS_ICON
#define HOLODUKE_ICON
#define ACCESS_ICON
#define DIGITALNUM
#define DUKECAR
#define CAMCORNER
#define CAMLIGHT
#define LOGO
#define TITLE
#define NUKEWARNINGICON
#define MOUSECURSOR
#define SLIDEBAR
#define DREALMS
#define BETASCREEN
#define WINDOWBORDER1
#define TEXTBOX
#define WINDOWBORDER2
#define DUKENUKEM
#define THREEDEE
#define INGAMEDUKETHREEDEE
#define TENSCREEN
#define PLUTOPAKSPRITE
#define DEVISTATOR
#define KNEE
#define CROSSHAIR
#define FIRSTGUN
#define FIRSTGUNRELOAD
#define FALLINGCLIP
#define CLIPINHAND
#define HAND
#define SHELL
#define SHOTGUNSHELL
#define CHAINGUN
#define RPGGUN
#define RPGMUZZLEFLASH
#define FREEZE
#define CATLITE
#define SHRINKER
#define HANDHOLDINGLASER
#define TRIPBOMB
#define LASERLINE
#define HANDHOLDINGACCESS
#define HANDREMOTE
#define HANDTHROW
#define TIP
#define GLAIR
#define SCUBAMASK
#define SPACEMASK
#define FORCESPHERE
#define SHOTSPARK1
#define RPG
#define LASERSITE
#define SHOTGUN
#define BOSS1
#define BOSS1STAYPUT
#define BOSS1SHOOT
#define BOSS1LOB
#define BOSSTOP
#define BOSS2
#define BOSS3
#define SPINNINGNUKEICON
#define BIGFNTCURSOR
#define SMALLFNTCURSOR
#define STARTALPHANUM
#define ENDALPHANUM
#define BIGALPHANUM
#define BIGPERIOD
#define BIGCOMMA
#define BIGX
#define BIGQ
#define BIGSEMI
#define BIGCOLIN
#define THREEBYFIVE
#define BIGAPPOS
#define BLANK
#define MINIFONT
#define BUTTON1
#define GLASS3
#define RESPAWNMARKERRED
#define RESPAWNMARKERYELLOW
#define RESPAWNMARKERGREEN
#define BONUSSCREEN
#define VIEWBORDER
#define VICTORY1
#define ORDERING
#define TEXTSTORY
#define LOADSCREEN
#define BORNTOBEWILDSCREEN
#define BLIMP
#define FEM9
#define FOOTPRINT
#define POOP
#define FRAMEEFFECT1
#define PANNEL3
#define SCREENBREAK14
#define SCREENBREAK15
#define SCREENBREAK19
#define SCREENBREAK16
#define SCREENBREAK17
#define SCREENBREAK18
#define W_TECHWALL11
#define W_TECHWALL12
#define W_TECHWALL13
#define W_TECHWALL14
#define W_TECHWALL5
#define W_TECHWALL6
#define W_TECHWALL7
#define W_TECHWALL8
#define W_TECHWALL9
#define BPANNEL3
#define W_HITTECHWALL16
#define W_HITTECHWALL10
#define W_HITTECHWALL15
#define W_MILKSHELF
#define W_MILKSHELFBROKE
#define PURPLELAVA
#define LAVABUBBLE
#define DUKECUTOUT
#define TARGET
#define GUNPOWDERBARREL
#define DUCK
#define HATRACK
#define DESKLAMP
#define COFFEEMACHINE
#define CUPS
#define GAVALS
#define GAVALS2
#define POLICELIGHTPOLE
#define FLOORBASKET
#define PUKE
#define DOORTILE23
#define TOPSECRET
#define SPEAKER
#define TEDDYBEAR
#define ROBOTDOG
#define ROBOTPIRATE
#define ROBOTMOUSE
#define MAIL
#define MAILBAG
#define HOTMEAT
#define COFFEEMUG
#define DONUTS2
#define TRIPODCAMERA
#define METER
#define DESKPHONE
#define GUMBALLMACHINE
#define GUMBALLMACHINEBROKE
#define PAPER
#define MACE
#define GENERICPOLE2
#define XXXSTACY
#define WETFLOOR
#define BROOM
#define MOP
#define LETTER
#define PIRATE1A
#define PIRATE4A
#define PIRATE2A
#define PIRATE5A
#define PIRATE3A
#define PIRATE6A
#define PIRATEHALF
#define CHESTOFGOLD
#define SIDEBOLT1
#define FOODOBJECT1
#define FOODOBJECT2
#define FOODOBJECT3
#define FOODOBJECT4
#define FOODOBJECT5
#define FOODOBJECT6
#define FOODOBJECT7
#define FOODOBJECT8
#define FOODOBJECT9
#define FOODOBJECT10
#define FOODOBJECT11
#define FOODOBJECT12
#define FOODOBJECT13
#define FOODOBJECT14
#define FOODOBJECT15
#define FOODOBJECT16
#define FOODOBJECT17
#define FOODOBJECT18
#define FOODOBJECT19
#define FOODOBJECT20
#define HEADLAMP
#define TAMPON
#define SKINNEDCHICKEN
#define FEATHEREDCHICKEN
#define ROBOTDOG2
#define JOLLYMEAL
#define DUKEBURGER
#define SHOPPINGCART
#define CANWITHSOMETHING2
#define CANWITHSOMETHING3
#define CANWITHSOMETHING4
#define SNAKEP
#define DOLPHIN1
#define DOLPHIN2
#define NEWBEAST
#define NEWBEASTSTAYPUT
#define NEWBEASTJUMP
#define NEWBEASTHANG
#define NEWBEASTHANGDEAD
#define BOSS4
#define BOSS4STAYPUT
#define FEM10
#define TOUGHGAL
#define MAN
#define MAN2
#define WOMAN
#define PLEASEWAIT
#define NATURALLIGHTNING
#define WEATHERWARN
#define DUKETAG
#define SIGN1
#define SIGN2
#define JURYGUY

