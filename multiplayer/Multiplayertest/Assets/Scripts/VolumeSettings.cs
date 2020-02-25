using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/** 
 *  @class VolumeSettings
 *  @brief To control the game-wide audio settings
 *   
 *  @author Tom Dittrich
 *  @date 17.01.2018
 */
public class VolumeSettings : MonoBehaviour {

    public Slider slider;

    /**
     * @brief set the global sound volume
     */
    public void setVolume()
    {
        AudioListener.volume = slider.value;
    }
}
