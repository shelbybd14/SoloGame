﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackground : MonoBehaviour {

	private Transform cameraTransform;
	private Vector3 lastCameraPosition;
	[SerializeField]
	private float parallaxEffectMultiplier;
	private float textureUnitSizeX;


	private void Start ()
	{
		cameraTransform = Camera.main.transform;
		lastCameraPosition = cameraTransform.position;
		Sprite sprite = GetComponent<SpriteRenderer>().sprite;
		Texture2D texture = sprite.texture;
		textureUnitSizeX = texture.width / sprite.pixelsPerUnit;
	}
	
	private void LateUpdate()
    {
		Vector3 deltaMovement = cameraTransform.position - lastCameraPosition;
		transform.position += deltaMovement * parallaxEffectMultiplier;
		lastCameraPosition = cameraTransform.position;

		if(Mathf.Abs(cameraTransform.position.x - transform.position.x) >= textureUnitSizeX)
        {
			float offsetPositionX = (cameraTransform.position.x - transform.position.x) % textureUnitSizeX;
			transform.position = new Vector3(cameraTransform.position.x, transform.position.y);
        }
    }

}
