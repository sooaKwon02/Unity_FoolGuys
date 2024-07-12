using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchScript : MonoBehaviour
{
    private GameObject target = null;
    Animator anim;

    private void Awake()
    {
        anim = GetComponentInParent<Animator>();
    }

    void Update()
    {
        // Ű�� ������ �� ��ü�� �ڽ����� �����
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            if (target != null)
            {
                target.transform.SetParent(transform);
                anim.SetBool("isCatch", true);
            }
            else
            {
                //��ü�� null�̸� ����� �ִϸ��̼�
                anim.SetTrigger("NonCatch");
            }
        }

        // Ű�� ���� �� �ڽĿ��� ����
        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            if(target != null)
                target.transform.SetParent(null);
            anim.SetTrigger("Catch");
            anim.SetBool("isCatch", false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other != null)//���� �ʿ��� tag�� ���濹��
        {
            target = other.gameObject;
        }
    }

    //�ƹ����� Ű ������ ���� ������Ʈ ��ü�� �÷��̾ �����
    //null������ �������� ��.
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == target)
        {
            target = null;
        }
    }
}
