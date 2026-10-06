using BepInEx;
using UnityEngine;

namespace REPO_CS2_Mod
{
    [BepInPlugin("com.loka521.repocsgo", "CS2 Weapons and Buy Menu", "0.1.0")]
    public class CS2WeaponsMod : BaseUnityPlugin
    {
        private bool isMenuOpen = false;

        void Awake()
        {
            Logger.LogInfo("Мод CS2 Weapons & Buy Menu успешно загружен хостом!");
        }

        void Update()
        {
            // Отслеживаем нажатие кнопки B для вызова кругового меню
            if (Input.GetKeyDown(KeyCode.B))
            {
                isMenuOpen = !isMenuOpen;
                Logger.LogInfo(isMenuOpen ? "Круговое меню закупки открыто" : "Круговое меню закупки закрыто");
            }
        }

        void OnGUI()
        {
            if (!isMenuOpen) return;

            // Рисуем временный интерфейс кругового меню закупки (упрощенная разметка для теста)
            Rect menuRect = new Rect(Screen.width / 2 - 150, Screen.height / 2 - 150, 300, 300);
            GUI.Box(menuRect, "=== КРУГОВОЕ МЕНЮ ЗАКУПКИ (CS2) ===");

            if (GUI.Button(new Rect(Screen.width / 2 - 120, Screen.height / 2 - 80, 240, 40), "1. Купить Desert Eagle (Бесплатно)"))
            {
                Logger.LogInfo("Выдан Desert Eagle!");
                isMenuOpen = false;
            }
            if (GUI.Button(new Rect(Screen.width / 2 - 120, Screen.height / 2 - 30, 240, 40), "2. Купить AK-47 (Бесплатно)"))
            {
                Logger.LogInfo("Выдан AK-47!");
                isMenuOpen = false;
            }
            if (GUI.Button(new Rect(Screen.width / 2 - 120, Screen.height / 2 + 20, 240, 40), "3. Купить HE Grenade (Бесплатно)"))
            {
                Logger.LogInfo("Выдана осколочная граната HE!");
                isMenuOpen = false;
            }

            GUI.Label(new Rect(Screen.width / 2 - 100, Screen.height / 2 + 80, 200, 30), "Нажмите 'B' для закрытия");
        }
    }
}
