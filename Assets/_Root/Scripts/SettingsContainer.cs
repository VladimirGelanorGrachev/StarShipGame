using Data;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Main
{
    public class SettingsContainer : Singleton<SettingsContainer>
    {
        [SerializeField] private SpaceShipSettings _spaceShipSettings;

        public SpaceShipSettings SpaceShipSettings => _spaceShipSettings;
    }
}
