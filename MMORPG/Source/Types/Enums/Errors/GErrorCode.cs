namespace MMORPG.Source.Types.Enums.Errors
{
    public enum GErrorCode
    {
        CommonSuccess = 0,
        CommonUnknownError,
        CommonNoWarning,
        CommonError = 0x00001000,
        CantFindPlayer,
        ComsumeFailed,

        NetCommandBegin = 0x00002000,
        NetCommandUnhandled,
        NetCommandSuccess,

        SessionHandleBegin = 0x00003000,
        SessionHandleKill,
        SessionHandleWarning,
        SessionHandleError,
        SessionHandleUnhandle,
        SessionHandleSuccess,
        SessionHandlePending,
        SessionHandleForward,

        SessionKickNormal = 0x00003100,
        SessionKickByGM,
        SessionKickMapServerExit,
        SessionKickAccountRelogin,
        SessionKickInitDataError,
        SessionKickDataError,
        SessionKickTimeOut,
        SessionKickMaintenance,
        SessionKickHacker,

        OSPBegin = 0x00003200,
        OSPSaveError,

        LoginBegin = 0x00004000,
        LoginSuccess,
        LoginErrorVErsionNotMatch,
        LoginErrorAccountNotExist,
        LoginErrorCharacterOnline,
        LoginErrorCharacterNotExist,
        LoginErrorMapServerOffline,
        LoginErrorSameAccountLoginAtTheSameTime,
        LoginQueue,
        LoginError,
        LoginErrorAccountLevelLawless,
        LoginErrorAccountFreeMaxLevelLimit,
        LoginErrorAccountFreeMaxTimeLimit,
        LoginErrorInvalidIP,
        LoginErrorMustRename,

        CharacterBegin = 0x00005000,
        CharCreateSuccess,
        CharDeleteSuccess,
        CharNotExist,
        CharNameAlreadyExist,
        CharNameInvalid,
        CharNumFull,
        CharMailToSelf,
        CharMigrateGuildMaster,
        CharMigrateHasMailOrItem,
        CharMigrateRename,
        CharRenameCanot,

        ItemBegin = 0x00006000,

        QuestBegin = 0x00007000,
        YouLoginFul,

        SpellBegin = 0x00008000,
        SpellCastBegin = SpellBegin,

        SpellTalent = 0x00008900,
        TalentInvalid,
        TalentInvalidSkillset,
        TalentRequireMoreCategoryTalents,
        TalentRequireParentTalent,
        TalentBeActived,
        TalentNotEnoughPoints,

        WarningBegin = 0x00009000,
        YourLevelTooLow,

        SocialBegin = 0x0000A000,
        TargetIsBusy,
        CantInviteNow,
        InviteRefuse,
        NotInTeam,
        NotTeamLeader,
        InviterIsnotExsit,
        YourTeamNotInQueueAnymore,
        PlayerIsInATeam,
        TeamIsFull,

        CantAddYouself,
        PlayerAlreadyExist,
        ListIsFull,

        CanNotDuelInArea,
        CanNotAttackYouself,
        CanNotFindTarget,
        DuelRequestRefused,
        TooFarAway,
        AlreadyInDuel,
        PlayerIsBusy,

        InvalidArenaType,
        InvalidMemberCount,
        AlreadyInArenaQueue,

        TargetLevelTooLow,

        CreatureBegin = 0x0000B000,
        InteractiveTooFar,
        InteractiveInvalid,
        ChatMenuInvalid,

        PlayerTradeBegin = 0x0000C000,
        TradeTargetOffline,
        TradeTargetTrading,
        TradeSuccessful,
        TradeFailed,

        GlAuthBegin = 0x0000D000,
        GlAuthSuccessful,
        GlAuthAccountNotExist,
        GlAuthPwdWrong,

        DungeonBegin = 0x0000E000,
        DungeonResetFailed,
        DungeonResetSuccess,
        InstanceStartFailed,
        InstanceIsFull
    };
}
