using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressionManager : ProjectManager<ProgressionManager>
{
    public bool levelOneCompleted = false;

    public void ConfirmLevelOneCompletion()
    {
        levelOneCompleted = true;
    }
}
