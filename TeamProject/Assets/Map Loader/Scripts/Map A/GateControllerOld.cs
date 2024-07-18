using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 현재 사용하지 않음. 백업용 스크립트.
public class GateControllerOld : MonoBehaviour
{
    public GameObject[] gameObjects;
    public Rigidbody[] rigidbodies;

    private int GateLength = 0;
    private int RandomCount = 0;

    private void Start()
    {
        GateLength = gameObjects.Length;
        RandomCount = Random.Range(0, GateLength);

        if (RandomCount == 0)
        {
            if (GateLength == 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    // 0 , 1 , 2
                    rigidbodies[i].constraints = RigidbodyConstraints.None;
                    rigidbodies[i].mass = 10;
                }
            }

            if (GateLength == 4)
            {
                for (int i = 0; i < 3; i++)
                {
                    // 0 , 1 , 2
                    rigidbodies[i].constraints = RigidbodyConstraints.None;
                    rigidbodies[i].mass = 10;
                }
            }

            if (GateLength == 5)
            {
                for (int i = 0; i < 3; i++)
                {
                    // 0 , 1 , 2
                    rigidbodies[i].constraints = RigidbodyConstraints.None;
                    rigidbodies[i].mass = 10;
                }

                for (int i = 6; i < 9; i++)
                {
                    // 6 , 7 , 8
                    rigidbodies[i].constraints = RigidbodyConstraints.None;
                    rigidbodies[i].mass = 10;
                }
            }

            if (GateLength == 6)
            {
                for (int i = 0; i < 3; i++)
                {
                    // 0 , 1 , 2
                    rigidbodies[i].constraints = RigidbodyConstraints.None;
                    rigidbodies[i].mass = 10;
                }

                for (int i = 6; i < 9; i++)
                {
                    // 6 , 7 , 8
                    rigidbodies[i].constraints = RigidbodyConstraints.None;
                    rigidbodies[i].mass = 10;
                }
            }

            if (GateLength == 7)
            {
                for (int i = 0; i < 3; i++)
                {
                    // 0 , 1 , 2
                    rigidbodies[i].constraints = RigidbodyConstraints.None;
                    rigidbodies[i].mass = 10;
                }

                for (int i = 6; i < 9; i++)
                {
                    // 6 , 7 , 8
                    rigidbodies[i].constraints = RigidbodyConstraints.None;
                    rigidbodies[i].mass = 10;
                }

                for (int i = 12; i < 15; i++)
                {
                    // 12 , 13 , 14
                    rigidbodies[i].constraints = RigidbodyConstraints.None;
                    rigidbodies[i].mass = 10;
                }
            }
        }

        else if (RandomCount == 1)
        {
            if (GateLength == 3)
            {
                for (int i = 3; i < 6; i++)
                {
                    // 3 , 4 , 5
                    rigidbodies[i].constraints = RigidbodyConstraints.None;
                    rigidbodies[i].mass = 10;
                }
            }

            if (GateLength == 4)
            {
                for (int i = 3; i < 6; i++)
                {
                    // 3 , 4 , 5
                    rigidbodies[i].constraints = RigidbodyConstraints.None;
                    rigidbodies[i].mass = 10;
                }
            }

            if (GateLength == 5)
            {
                for (int i = 3; i < 6; i++)
                {
                    // 3 , 4 , 5
                    rigidbodies[i].constraints = RigidbodyConstraints.None;
                    rigidbodies[i].mass = 10;
                }

                for (int i = 9; i < 12; i++)
                {
                    // 9 , 10 , 11
                    rigidbodies[i].constraints = RigidbodyConstraints.None;
                    rigidbodies[i].mass = 10;
                }
            }

            if (GateLength == 6)
            {
                for (int i = 3; i < 6; i++)
                {
                    // 3 , 4 , 5
                    rigidbodies[i].constraints = RigidbodyConstraints.None;
                    rigidbodies[i].mass = 10;
                }

                for (int i = 9; i < 12; i++)
                {
                    // 9 , 10 , 11
                    rigidbodies[i].constraints = RigidbodyConstraints.None;
                    rigidbodies[i].mass = 10;
                }
            }

            if (GateLength == 7)
            {
                for (int i = 3; i < 6; i++)
                {
                    // 3 , 4 , 5
                    rigidbodies[i].constraints = RigidbodyConstraints.None;
                    rigidbodies[i].mass = 10;
                }

                for (int i = 9; i < 12; i++)
                {
                    // 9 , 10 , 11
                    rigidbodies[i].constraints = RigidbodyConstraints.None;
                    rigidbodies[i].mass = 10;
                }

                for (int i = 15; i < 18; i++)
                {
                    // 15 , 16 , 17
                    rigidbodies[i].constraints = RigidbodyConstraints.None;
                    rigidbodies[i].mass = 10;
                }
            }
        }

        else if (RandomCount == 2)
        {
            if (GateLength == 3)
            {
                for (int i = 6; i < 9; i++)
                {
                    // 6 , 7 , 8
                    rigidbodies[i].constraints = RigidbodyConstraints.None;
                    rigidbodies[i].mass = 10;
                }
            }

            if (GateLength == 4)
            {
                for (int i = 6; i < 9; i++)
                {
                    // 6 , 7 , 8
                    rigidbodies[i].constraints = RigidbodyConstraints.None;
                    rigidbodies[i].mass = 10;
                }
            }

            if (GateLength == 5)
            {
                for (int i = 6; i < 9; i++)
                {
                    // 6 , 7 , 8
                    rigidbodies[i].constraints = RigidbodyConstraints.None;
                    rigidbodies[i].mass = 10;
                }

                for (int i = 12; i < 15; i++)
                {
                    // 12 , 13 , 14
                    rigidbodies[i].constraints = RigidbodyConstraints.None;
                    rigidbodies[i].mass = 10;
                }
            }

            if (GateLength == 6)
            {
                for (int i = 6; i < 9; i++)
                {
                    // 6 , 7 , 8
                    rigidbodies[i].constraints = RigidbodyConstraints.None;
                    rigidbodies[i].mass = 10;
                }

                for (int i = 12; i < 15; i++)
                {
                    // 12 , 13 , 14
                    rigidbodies[i].constraints = RigidbodyConstraints.None;
                    rigidbodies[i].mass = 10;
                }
            }

            if (GateLength == 7)
            {
                for (int i = 6; i < 9; i++)
                {
                    // 6 , 7 , 8
                    rigidbodies[i].constraints = RigidbodyConstraints.None;
                    rigidbodies[i].mass = 10;
                }

                for (int i = 12; i < 15; i++)
                {
                    // 12 , 13 , 14
                    rigidbodies[i].constraints = RigidbodyConstraints.None;
                    rigidbodies[i].mass = 10;
                }

                for (int i = 18; i < 21; i++)
                {
                    // 18 , 19 , 20
                    rigidbodies[i].constraints = RigidbodyConstraints.None;
                    rigidbodies[i].mass = 10;
                }
            }
        }

        else if (RandomCount == 3)
        {
            if (GateLength == 4)
            {
                for (int i = 9; i < 12; i++)
                {
                    // 9 , 10 , 11
                    rigidbodies[i].constraints = RigidbodyConstraints.None;
                    rigidbodies[i].mass = 10;
                }
            }

            if (GateLength == 5)
            {
                for (int i = 0; i < 3; i++)
                {
                    // 0 , 1 , 2
                    rigidbodies[i].constraints = RigidbodyConstraints.None;
                    rigidbodies[i].mass = 10;
                }

                for (int i = 9; i < 12; i++)
                {
                    // 9 , 10 , 11
                    rigidbodies[i].constraints = RigidbodyConstraints.None;
                    rigidbodies[i].mass = 10;
                }
            }

            if (GateLength == 6)
            {
                for (int i = 9; i < 12; i++)
                {
                    // 9 , 10 , 11
                    rigidbodies[i].constraints = RigidbodyConstraints.None;
                    rigidbodies[i].mass = 10;
                }

                for (int i = 15; i < 18; i++)
                {
                    // 15 , 16 , 17
                    rigidbodies[i].constraints = RigidbodyConstraints.None;
                    rigidbodies[i].mass = 10;
                }
            }

            if (GateLength == 7)
            {
                for (int i = 0; i < 3; i++)
                {
                    // 0 , 1 , 2
                    rigidbodies[i].constraints = RigidbodyConstraints.None;
                    rigidbodies[i].mass = 10;
                }

                for (int i = 6; i < 9; i++)
                {
                    // 6 , 7 , 8
                    rigidbodies[i].constraints = RigidbodyConstraints.None;
                    rigidbodies[i].mass = 10;
                }

                for (int i = 18; i < 21; i++)
                {
                    // 18 , 19 , 20
                    rigidbodies[i].constraints = RigidbodyConstraints.None;
                    rigidbodies[i].mass = 10;
                }
            }
        }

        else if (RandomCount == 4)
        {
            if (GateLength == 5)
            {
                for (int i = 3; i < 6; i++)
                {
                    // 3 , 4 , 5
                    rigidbodies[i].constraints = RigidbodyConstraints.None;
                    rigidbodies[i].mass = 10;
                }

                for (int i = 12; i < 15; i++)
                {
                    // 12 , 13 , 14
                    rigidbodies[i].constraints = RigidbodyConstraints.None;
                    rigidbodies[i].mass = 10;
                }
            }

            if (GateLength == 6)
            {
                for (int i = 0; i < 3; i++)
                {
                    // 0 , 1 , 2
                    rigidbodies[i].constraints = RigidbodyConstraints.None;
                    rigidbodies[i].mass = 10;
                }

                for (int i = 12; i < 15; i++)
                {
                    // 12 , 13 , 14
                    rigidbodies[i].constraints = RigidbodyConstraints.None;
                    rigidbodies[i].mass = 10;
                }
            }

            if (GateLength == 7)
            {
                for (int i = 0; i < 3; i++)
                {
                    // 0 , 1 , 2
                    rigidbodies[i].constraints = RigidbodyConstraints.None;
                    rigidbodies[i].mass = 10;
                }

                for (int i = 12; i < 15; i++)
                {
                    // 12 , 13 , 14
                    rigidbodies[i].constraints = RigidbodyConstraints.None;
                    rigidbodies[i].mass = 10;
                }

                for (int i = 18; i < 21; i++)
                {
                    // 18 , 19 , 20
                    rigidbodies[i].constraints = RigidbodyConstraints.None;
                    rigidbodies[i].mass = 10;
                }
            }
        }

        else if (RandomCount == 5)
        {
            if (GateLength == 6)
            {
                for (int i = 3; i < 6; i++)
                {
                    // 3 , 4 , 5
                    rigidbodies[i].constraints = RigidbodyConstraints.None;
                    rigidbodies[i].mass = 10;
                }

                for (int i = 15; i < 18; i++)
                {
                    // 15 , 16 , 17
                    rigidbodies[i].constraints = RigidbodyConstraints.None;
                    rigidbodies[i].mass = 10;
                }
            }

            if (GateLength == 7)
            {
                for (int i = 6; i < 9; i++)
                {
                    // 6 , 7 , 8
                    rigidbodies[i].constraints = RigidbodyConstraints.None;
                    rigidbodies[i].mass = 10;
                }

                for (int i = 9; i < 12; i++)
                {
                    // 9 , 10 , 11
                    rigidbodies[i].constraints = RigidbodyConstraints.None;
                    rigidbodies[i].mass = 10;
                }

                for (int i = 12; i < 15; i++)
                {
                    // 12 , 13 , 14
                    rigidbodies[i].constraints = RigidbodyConstraints.None;
                    rigidbodies[i].mass = 10;
                }
            }
        }

        else if (RandomCount == 6)
        {
            if (GateLength == 7)
            {
                for (int i = 0; i < 3; i++)
                {
                    // 0 , 1 , 2
                    rigidbodies[i].constraints = RigidbodyConstraints.None;
                    rigidbodies[i].mass = 10;
                }

                for (int i = 9; i < 12; i++)
                {
                    // 9 , 10 , 11
                    rigidbodies[i].constraints = RigidbodyConstraints.None;
                    rigidbodies[i].mass = 10;
                }

                for (int i = 18; i < 21; i++)
                {
                    // 18 , 19 , 20
                    rigidbodies[i].constraints = RigidbodyConstraints.None;
                    rigidbodies[i].mass = 10;
                }
            }
        }

        else
        {
            Debug.Log("경고! 게이트 컨트롤러에 문제가 있습니다!");
        }
    }
}