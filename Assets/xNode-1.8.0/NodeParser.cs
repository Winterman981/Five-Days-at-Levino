using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using XNode;

public class NodeParser : MonoBehaviour
{
    public DialogueGraph graph;
    Coroutine parser;
    public TextMeshProUGUI speaker;
    public TextMeshProUGUI dialogue;

    private void Start()
    {
        foreach (BaseNode b in graph.nodes)
        {
            if(b.GetString() == "Start")
            {
                graph.current = b;
                break;
            }
        }

        parser = StartCoroutine(ParseNode());
    }

    IEnumerator ParseNode()
    {
        BaseNode b = graph.current;
        string data = b.GetString();
        string[] dataParts = data.Split('/');
        if (dataParts[0] == "Start")
        {
            NextNode("exit");
        }

        if(dataParts[0] == "DialogueNode")
        {
            speaker.text = dataParts[1];
            dialogue.text = dataParts[2];
            yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
            yield return new WaitUntil(() => Input.GetMouseButtonUp(0));
            NextNode("exit");
        }
    }

    public void NextNode(string fieldName)
    {
        if(parser != null)
        {
            StopCoroutine(parser);
            parser = null;
        }

        foreach (NodePort p in graph.current.Ports)
        {
            if(p.fieldName == fieldName)
            {
                graph.current = p.Connection.node as BaseNode;
                break;
            }
        }

        parser = StartCoroutine(ParseNode());
    }
}
