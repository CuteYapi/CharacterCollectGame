public enum StatusReason
{
    None = -1,

    LevelStatus,

    Max,
}

public enum GachaErrorFlag
{
    None = -1,

    Possible = 0,

    Close,
    StartDateError,
    EndDateError,
    NotEnoughGem,
    NotEnoughTicket,

    Max,
}

public enum GachaType
{
    None = -1,

    SingleGem,
    MultyGem,

    SingleTicket,
    MultyTicket,

    Max,
}