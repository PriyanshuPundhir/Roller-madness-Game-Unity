using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EquipmentManager : MonoBehaviour {

	#region Singleton

    public enum MeshBlendShape {Torso, Arms, Legs };
    public Equipment[] defaultEquipment;

	public static EquipmentManager instance;
	public SkinnedMeshRenderer targetMesh;

    SkinnedMeshRenderer[] currentMeshes;

	void Awake ()
	{
		instance = this;
	}

	#endregion

	Equipment[] currentEquipment;   

	public delegate void OnEquipmentChanged(Equipment newItem, Equipment oldItem);
	public OnEquipmentChanged onEquipmentChanged;
   

	Inventory inventory;	

	void Start ()
	{
		inventory = Inventory.instance;		

		int numSlots = System.Enum.GetNames(typeof(EquipmentSlot)).Length;
		currentEquipment = new Equipment[numSlots];
        currentMeshes = new SkinnedMeshRenderer[numSlots];

        EquipDefaults();
	}
		
	public void Equip (Equipment newItem)
	{
		int slotIndex = (int)newItem.equipSlot;

        //Equipment oldItem = Unequip(slotIndex);

		/*if (onEquipmentChanged != null)
		{
			onEquipmentChanged.Invoke(newItem, oldItem);
		}*/
			
		currentEquipment[slotIndex] = newItem;
       // AttachToMesh(newItem, slotIndex);
	}


/*	public Equipment Unequip (int slotIndex)
	{
        Equipment oldItem = null;

		if (currentEquipment[slotIndex] != null)
		{
			oldItem = currentEquipment[slotIndex];
			inventory.Add(oldItem);

            SetBlendShapeWeight(oldItem, 0);

            if (currentMeshes[slotIndex] != null)
            {
                Destroy(currentMeshes[slotIndex].gameObject);
            }
				
			currentEquipment[slotIndex] = null;

			if (onEquipmentChanged != null)
			{
				onEquipmentChanged.Invoke(null, oldItem);
			}
		}
        return oldItem;
	}*/
		
	/*public void UnequipAll ()
	{
		for (int i = 0; i < currentEquipment.Length; i++)
		{
			Unequip(i);
		}

        EquipDefaults();
	}*/

   /* void AttachToMesh(Equipment item, int slotIndex)
	{

        SkinnedMeshRenderer newMesh = Instantiate(item.mesh) as SkinnedMeshRenderer;
        newMesh.transform.parent = targetMesh.transform.parent;

        newMesh.rootBone = targetMesh.rootBone;
		newMesh.bones = targetMesh.bones;
		
		currentMeshes[slotIndex] = newMesh;


        SetBlendShapeWeight(item, 100);
       
	}*/

   /* void SetBlendShapeWeight(Equipment item, int weight)
    {
		foreach (MeshBlendShape blendshape in item.coveredMeshRegions)
		{
			int shapeIndex = (int)blendshape;
            targetMesh.SetBlendShapeWeight(shapeIndex, weight);
		}
    }*/

    void EquipDefaults()
    {
		foreach (Equipment e in defaultEquipment)
		{
			Equip(e);
		}
    }

	/*void Update ()
	{
		if (Input.GetKeyDown(KeyCode.U))
			UnequipAll();
	}*/

}
