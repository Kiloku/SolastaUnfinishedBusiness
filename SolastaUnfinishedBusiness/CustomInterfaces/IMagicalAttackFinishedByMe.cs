﻿using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace SolastaUnfinishedBusiness.CustomInterfaces;

// triggers on any magical attack regardless of an attack roll or not
public interface IMagicalAttackFinishedByMe
{
    [UsedImplicitly]
    IEnumerator OnMagicalAttackFinishedByMe(
        GameLocationCharacter attacker,
        GameLocationCharacter defender,
        ActionModifier magicModifier,
        RulesetEffect rulesetEffect,
        List<EffectForm> actualEffectForms,
        bool firstTarget,
        bool criticalHit);
}
