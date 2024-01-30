namespace Celeste64;

public static class Sfx
{
	public const string UI_PAUSE = "event:/sfx/ui/pause";
	public const string UI_MOVE = "event:/sfx/ui/rollover";
	public const string UI_SELECT = "event:/sfx/ui/select";
	public const string UI_UNPAUSE = "event:/sfx/ui/unpause";
	public const string UI_NPC_POPUP = "event:/sfx/ui/npc_popup";
	public const string UI_DIALOG_ADVANCE = "event:/sfx/ui/dialog_advance";
	public const string UI_SPOTLIGHT_IN = "event:/sfx/general/spotlight_in";
	public const string UI_SPOUTLIGHT_OUT = "event:/sfx/general/spotlight_out";

	public const string MAIN_MENU_FIRST_INPUT = "event:/sfx/ui/main/first_input";
	public const string MAIN_MENU_POSTCARD_FLIP = "event:/sfx/ui/main/postcard_flip";
	public const string MAIN_MENU_POSTCARD_FLIP_BACK = "event:/sfx/ui/main/postcard_flip_back";
	public const string MAIN_MENU_START_GAME = "event:/sfx/ui/main/start_game";
	public const string MAIN_MENU_TOGGLE_ON = "event:/sfx/ui/main/toggle_on";
	public const string MAIN_MENU_TOGGLE_OFF = "event:/sfx/ui/main/toggle_off";
	public const string MAIN_MENU_ROLL_UP = "event:/sfx/ui/main/roll_up";
	public const string MAIN_MENU_ROLL_DOWN = "event:/sfx/ui/main/roll_down";
	public const string MAIN_MENU_RESTART_CONFIRM_POPUP = "event:/sfx/ui/main/restart_cancel"; // TODO: Base game has these swapped due to a typo
	public const string MAIN_MENU_RESTART_CANCEL = "event:/sfx/ui/main/restart_confirm_popup";

	public const string AMB_MOUNTAIN = "event:/sfx/ambience/mountain";
	public const string SFX_FOOTSTEP_GENERAL = "event:/sfx/madeline/footstep";
	public const string SFX_JUMP = "event:/sfx/madeline/jump";
	public const string SFX_JUMP_WALL = "event:/sfx/madeline/jump_wall";
	public const string SFX_JUMP_ASSISTED = "event:/sfx/madeline/jump_assisted";
	public const string SFX_JUMP_SUPERSLIDE = "event:/sfx/madeline/jump_superslide";
	public const string SFX_JUMP_SKID = "event:/sfx/madeline/skid_jump";
	public const string SFX_LAND = "event:/sfx/madeline/land";
	public const string SFX_GRAB = "event:/sfx/madeline/grab";
	public const string SFX_SKID = "event:/sfx/madeline/skid";
	public const string SFX_LET_GO = "event:/sfx/madeline/letgo";
	public const string SFX_CLIMB_LEDGE = "event:/sfx/madeline/climb_ledge";
	public const string SFX_WALL_SLIDE = "event:/sfx/madeline/wall_slide";
	public const string SFX_HANDHOLD = "event:/sfx/madeline/handhold";
	public const string SFX_DASH_RED = "event:/sfx/madeline/dash_red";
	public const string SFX_DASH_PINK = "event:/sfx/madeline/dash_pink";
	public const string SFX_DEATH = "event:/sfx/madeline/death";
	public const string SFX_REVIVE = "event:/sfx/madeline/revive";

	public const string SFX_BUBBLE_IN = "event:/sfx/general/bubble_in";
	public const string SFX_BUBBLE_LOOP = "event:/sfx/general/bubble_travel_loop";
	public const string SFX_BUBBLE_OUT = "event:/sfx/general/bubble_out";

	public const string SFX_GLASSBREAK = "event:/sfx/prop/glass_break";
	public const string SFX_SECRET = "event:/sfx/general/secret_revealed";

	public const string SFX_FEATHER_GET = "event:/sfx/prop/feather_get";
	public const string SFX_FEATHER_RENEW = "event:/sfx/prop/feather_renew";
	public const string SFX_FEATHER_REAPPEAR = "event:/sfx/prop/feather_reapper";
	public const string SFX_FEATHER_STATE_ACTIVE_LOOP = "event:/sfx/prop/feather_state_loop";
	public const string SFX_FEATHER_STATE_END_WARNING = "event:/sfx/prop/feather_state_warning";
	public const string SFX_FEATHER_STATE_END = "event:/sfx/prop/feather_state_end";
	public const string SFX_FEATHER_STATE_BUMP_WALL = "event:/sfx/prop/feather_state_bump";
	public const string SFX_BREAKABLE_WALL_DIRT = "event:/sfx/prop/breakable_dirt";
	public const string SFX_BREAKABLE_WALL_WOOD = "event:/sfx/prop/breakable_wood";
	public const string SFX_TOUCH_SWITCH_ANY = "event:/sfx/prop/touchswitch_any";
	public const string SFX_TOUCH_SWITCH_LAST = "event:/sfx/prop/touchswitch_last";
	public const string SFX_TOUCH_SWITCH_GATE_OPEN_MOVE = "event:/sfx/prop/touchswitch_gate_open";
	public const string SFX_TOUCH_SWITCH_GATE_FINISH = "event:/sfx/prop/touchswitch_gate_finish";

	public const string SFX_CASSETTE_ENTER = "event:/sfx/general/cassette_enter";
	public const string SFX_CASSETTE_EXIT = "event:/sfx/general/cassette_exit";
	
	public const string SFX_DASHCRYSTAL = "event:/sfx/prop/dashCrystal";
	public const string SFX_DASHCRYSTAL_RETURN = "event:/sfx/prop/dashCrystal_return";
	public const string SFX_DASHCRYSTAL_DOUBLE = "event:/sfx/prop/dashCrystal_double";
	public const string SFX_DASHCRYSTAL_DOUBLE_RETURN = "event:/sfx/prop/dashCrystal_double_return";

	public const string SFX_FALLINGBLOCK_SHAKE = "event:/sfx/prop/fallingblock_shake";
	public const string SFX_FALLINGBLOCK_FALL = "event:/sfx/prop/fallingblock_fall";
	public const string SFX_FALLINGBLOCK_LAND = "event:/sfx/prop/fallingblock_land";
	public const string SFX_SPRINGBOARD = "event:/sfx/prop/springboard";
	public const string SFX_ZIPMOVER_START = "event:/sfx/prop/zipmover_start";
	public const string SFX_ZIPMOVER_LOOP = "event:/sfx/prop/zipmover_loop";
	public const string SFX_ZIPMOVER_STOP = "event:/sfx/prop/zipmover_stop";
	public const string SFX_ZIPMOVER_RETRACT_START = "event:/sfx/prop/zipmover_retract_start";
	public const string SFX_ZIPMOVER_RETRACT_LOOP = "event:/sfx/prop/zipmover_retract_loop";
	public const string SFX_ZIPMOVER_RETRACT_STOP = "event:/sfx/prop/zipmover_retract_stop";
	public const string SFX_READSIGN_IN = "event:/sfx/prop/sign_in";
	public const string SFX_READSIGN_OUT = "event:/sfx/prop/sign_out";
	public const string SFX_COLLECT_STRAWB = "event:/sfx/general/strawberry_get";
	public const string SFX_COLLECT_STRAWB_BSIDE = "event:/sfx/general/strawberry_get_bside";
	public const string SFX_BERRY_APPEAR = "event:/sfx/general/berry_appear";
	public const string SFX_CHECKPOINT = "event:/sfx/general/checkpoint_get";
	public const string SFX_COLLECT_CASSETTE = "event:/sfx/general/cassette_get";
	public const string SFX_END_LEVEL = "event:/sfx/general/end_level";

	public const string SFX_CAR_UP = "event:/sfx/prop/car_up";
	public const string SFX_CAR_DOWN = "event:/sfx/prop/car_down";

	public const string SNAPSHOT_DIALOG = "snapshot:/dialog_active";
	public const string SNAPSHOT_PAUSE = "snapshot:/paused";

	public const string BUS_GAMEPLAY = "bus:/sfx/gameplay";
	public const string BUS_GAMEPLAY_WORLD = "bus:/sfx/gameplay/world";
	public const string BUS_BSIDE_MUSIC = "bus:/music/bside";
	public const string BUS_DIALOG = "bus:/sfx/ui/dialog";
}