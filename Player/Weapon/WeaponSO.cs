﻿using Player.Animation.MotionWarp;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Player.Weapon {
    [CreateAssetMenu(fileName = "Weapon", menuName = "Player/Weapon")]
    public class WeaponSO : ScriptableObject {
        [Title("User Interface")]
        public string weaponName;
        [TextArea(2, 4)] public string weaponDescription;
        public Sprite weaponSprite;
        
        [Title("Animation")]
        [InfoBox("Don't forget to set the WeaponPositionData in the References" +
                 "for Equip, UnEquip and Hit Detection, also add e.g. Collider & Scripts to the Equipped Weapon for Input tracking")]
        public AnimatorOverrideController animatorOverrideController;

        [Title("Attack Data")]
        [HideLabel] public AttackData lightAttack;
        [HideLabel] public AttackData heavyAttack;
        
        [Title("Finisher")]
        [HideLabel] public WarpData finisherData;
    }
}