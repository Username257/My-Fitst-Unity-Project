using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

//========================================
//##		������ ���� SingleTon		##
//========================================
/*
	�̱��� ���� :
	���� �� ���� Ŭ���� �ν��Ͻ����� ������ ����
	�̿� ���� �������� �������� ����

	���� :
	1. �������� ���� ������ �ν��Ͻ��� �ּҸ� ���� ����
	������ ���� �޸� ������ Ȱ�� (��������)
	2. ���������� Ȱ���Ͽ� ĸ��ȭ�� ����
	3. �������� ���ٱ����� �ܺο��� ������ �� ������ ����
	4. Instance �Ӽ��� ���� �ν��Ͻ��� ������ �� �ֵ��� ��
	5. instance ������ �� �ϳ��� �ֵ��� ����
	private�� ����� new �� �� ����� ��

	���� :
	1. �ϳ����� ����� �ֿ� Ŭ����, �������� ������ ��
	2. ������ �������� ������ �ʿ��� �۾��� ���� �������ٰ���
	3. �ν��Ͻ����� �̱����� ���Ͽ� �����͸� �����ϱ� ������

	���� :
	1. �̱����� �ʹ� ���� å���� �������� ��츦 �����ؾ���
	2. �̱����� ���߷� ���������� �������� �Ǵ� ���, ������ �ڵ� ���յ��� ������
	3. �̱����� �����͸� ������ ��� ������ ������ �����ؾ���
*/


public class Inventory
{
	private static Inventory instance = null;
    private Inventory()
    {

    }
    public static Inventory GetInstance()
    {
		if (instance != null)
			return instance;

		instance = new Inventory();
		return instance;
    }
}

public class Player
{
	Inventory inventory;
	public Player()
	{
		inventory = Inventory.GetInstance();
	}
}

public class Singleton
{
    private static Singleton instance;

    public static Singleton Instance
    {
        get
        {
            if (instance == null)
                instance = new Singleton();

            return instance;
        }
    }

    private Singleton() { }
}

public class Player2
{
	public void Test()
	{
		Singleton singleton = Singleton.Instance;

		//Singleton singleton2 = new Singleton(); ����
	}
}