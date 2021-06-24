package com.inha.dsp.causality.type;

import java.io.Serializable;
import java.util.UUID;

public class Context implements Serializable {
    private UUID _guid;
    public UUID getGUID() {
        return _guid;
    }
    public SerialNumber CurrentScenario;
    public SerialNumber CurrentScene;
    public SerialNumber CurrentCaption;

    public Context(UUID guid)
    {
        _guid = guid;
    }
}
