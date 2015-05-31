using UnityEditor;

namespace InstantiateEx {

    [CustomEditor(typeof(Instantiate))]
    [CanEditMultipleObjects]
    public sealed class InstantiateEditor : Editor {
        #region FIELDS

        private Instantiate Script { get; set; }

        #endregion FIELDS

        #region SERIALIZED PROPERTIES

        private SerializedProperty description;

        #endregion SERIALIZED PROPERTIES

        #region UNITY MESSAGES

        public override void OnInspectorGUI() {
            serializedObject.Update();

            DrawVersionLabel();
            DrawDescriptionTextArea();

            EditorGUILayout.Space();

            serializedObject.ApplyModifiedProperties();
        }

        private void OnEnable() {
            Script = (Instantiate)target;

            description = serializedObject.FindProperty("description");
        }

        #endregion UNITY MESSAGES

        #region INSPECTOR CONTROLS

        private void DrawVersionLabel() {
            EditorGUILayout.LabelField(
                string.Format(
                    "{0} ({1})",
                    InstantiateEx.Instantiate.Version,
                    InstantiateEx.Instantiate.Extension));
        }

        private void DrawDescriptionTextArea() {
            description.stringValue = EditorGUILayout.TextArea(
                description.stringValue);
        }

        #endregion INSPECTOR

        #region METHODS

        [MenuItem("Component/Instantiate")]
        private static void AddEntryToComponentMenu() {
            if (Selection.activeGameObject != null) {
                Selection.activeGameObject.AddComponent(typeof(Instantiate));
            }
        }

        #endregion METHODS
    }

}