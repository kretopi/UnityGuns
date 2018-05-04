/**
 * Copyright (c) 2018 Enzien Audio, Ltd.
 * 
 * Redistribution and use in source and binary forms, with or without modification,
 * are permitted provided that the following conditions are met:
 * 
 * 1. Redistributions of source code must retain the above copyright notice,
 *    this list of conditions, and the following disclaimer.
 * 
 * 2. Redistributions in binary form must reproduce the phrase "powered by heavy",
 *    the heavy logo, and a hyperlink to https://enzienaudio.com, all in a visible
 *    form.
 * 
 *   2.1 If the Application is distributed in a store system (for example,
 *       the Apple "App Store" or "Google Play"), the phrase "powered by heavy"
 *       shall be included in the app description or the copyright text as well as
 *       the in the app itself. The heavy logo will shall be visible in the app
 *       itself as well.
 * 
 * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
 * AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO,
 * THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE
 * ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE
 * FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL
 * DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
 * SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER
 * CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY,
 * OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF
 * THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 * 
 */

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Assertions;
using AOT;

#if UNITY_EDITOR
using UnityEditor;

[CustomEditor(typeof(Hv_UnityGuns_AudioLib))]
public class Hv_UnityGuns_Editor : Editor {

  [MenuItem("Heavy/UnityGuns")]
  static void CreateHv_UnityGuns() {
    GameObject target = Selection.activeGameObject;
    if (target != null) {
      target.AddComponent<Hv_UnityGuns_AudioLib>();
    }
  }
  
  private Hv_UnityGuns_AudioLib _dsp;

  private void OnEnable() {
    _dsp = target as Hv_UnityGuns_AudioLib;
  }

  public override void OnInspectorGUI() {
    bool isEnabled = _dsp.IsInstantiated();
    if (!isEnabled) {
      EditorGUILayout.LabelField("Press Play!",  EditorStyles.centeredGreyMiniLabel);
    }
    // events
    GUI.enabled = isEnabled;
    EditorGUILayout.Space();
    // Play
    if (GUILayout.Button("Play")) {
      _dsp.SendEvent(Hv_UnityGuns_AudioLib.Event.Play);
    }
    
    GUILayout.EndVertical();

    // parameters
    GUI.enabled = true;
    GUILayout.BeginVertical();
    EditorGUILayout.Space();
    EditorGUI.indentLevel++;
    
    // attack
    GUILayout.BeginHorizontal();
    float attack = _dsp.GetFloatParameter(Hv_UnityGuns_AudioLib.Parameter.Attack);
    float newAttack = EditorGUILayout.Slider("attack", attack, 0.0f, 100.0f);
    if (attack != newAttack) {
      _dsp.SetFloatParameter(Hv_UnityGuns_AudioLib.Parameter.Attack, newAttack);
    }
    GUILayout.EndHorizontal();
    
    // band
    GUILayout.BeginHorizontal();
    float band = _dsp.GetFloatParameter(Hv_UnityGuns_AudioLib.Parameter.Band);
    float newBand = EditorGUILayout.Slider("band", band, 0.0f, 20000.0f);
    if (band != newBand) {
      _dsp.SetFloatParameter(Hv_UnityGuns_AudioLib.Parameter.Band, newBand);
    }
    GUILayout.EndHorizontal();
    
    // bandQ
    GUILayout.BeginHorizontal();
    float bandQ = _dsp.GetFloatParameter(Hv_UnityGuns_AudioLib.Parameter.Bandq);
    float newBandq = EditorGUILayout.Slider("bandQ", bandQ, 0.0f, 500.0f);
    if (bandQ != newBandq) {
      _dsp.SetFloatParameter(Hv_UnityGuns_AudioLib.Parameter.Bandq, newBandq);
    }
    GUILayout.EndHorizontal();
    
    // decayTime
    GUILayout.BeginHorizontal();
    float decayTime = _dsp.GetFloatParameter(Hv_UnityGuns_AudioLib.Parameter.Decaytime);
    float newDecaytime = EditorGUILayout.Slider("decayTime", decayTime, 0.0f, 10.0f);
    if (decayTime != newDecaytime) {
      _dsp.SetFloatParameter(Hv_UnityGuns_AudioLib.Parameter.Decaytime, newDecaytime);
    }
    GUILayout.EndHorizontal();
    
    // hip
    GUILayout.BeginHorizontal();
    float hip = _dsp.GetFloatParameter(Hv_UnityGuns_AudioLib.Parameter.Hip);
    float newHip = EditorGUILayout.Slider("hip", hip, 0.0f, 20000.0f);
    if (hip != newHip) {
      _dsp.SetFloatParameter(Hv_UnityGuns_AudioLib.Parameter.Hip, newHip);
    }
    GUILayout.EndHorizontal();
    
    // lop
    GUILayout.BeginHorizontal();
    float lop = _dsp.GetFloatParameter(Hv_UnityGuns_AudioLib.Parameter.Lop);
    float newLop = EditorGUILayout.Slider("lop", lop, 0.0f, 20000.0f);
    if (lop != newLop) {
      _dsp.SetFloatParameter(Hv_UnityGuns_AudioLib.Parameter.Lop, newLop);
    }
    GUILayout.EndHorizontal();
    
    // randomBand
    GUILayout.BeginHorizontal();
    float randomBand = _dsp.GetFloatParameter(Hv_UnityGuns_AudioLib.Parameter.Randomband);
    float newRandomband = EditorGUILayout.Slider("randomBand", randomBand, 0.0f, 500.0f);
    if (randomBand != newRandomband) {
      _dsp.SetFloatParameter(Hv_UnityGuns_AudioLib.Parameter.Randomband, newRandomband);
    }
    GUILayout.EndHorizontal();
    
    // randomHi
    GUILayout.BeginHorizontal();
    float randomHi = _dsp.GetFloatParameter(Hv_UnityGuns_AudioLib.Parameter.Randomhi);
    float newRandomhi = EditorGUILayout.Slider("randomHi", randomHi, 0.0f, 500.0f);
    if (randomHi != newRandomhi) {
      _dsp.SetFloatParameter(Hv_UnityGuns_AudioLib.Parameter.Randomhi, newRandomhi);
    }
    GUILayout.EndHorizontal();
    
    // randomLow
    GUILayout.BeginHorizontal();
    float randomLow = _dsp.GetFloatParameter(Hv_UnityGuns_AudioLib.Parameter.Randomlow);
    float newRandomlow = EditorGUILayout.Slider("randomLow", randomLow, 0.0f, 500.0f);
    if (randomLow != newRandomlow) {
      _dsp.SetFloatParameter(Hv_UnityGuns_AudioLib.Parameter.Randomlow, newRandomlow);
    }
    GUILayout.EndHorizontal();
    
    // release
    GUILayout.BeginHorizontal();
    float release = _dsp.GetFloatParameter(Hv_UnityGuns_AudioLib.Parameter.Release);
    float newRelease = EditorGUILayout.Slider("release", release, 0.0f, 1000.0f);
    if (release != newRelease) {
      _dsp.SetFloatParameter(Hv_UnityGuns_AudioLib.Parameter.Release, newRelease);
    }
    GUILayout.EndHorizontal();
    
    // sustain
    GUILayout.BeginHorizontal();
    float sustain = _dsp.GetFloatParameter(Hv_UnityGuns_AudioLib.Parameter.Sustain);
    float newSustain = EditorGUILayout.Slider("sustain", sustain, 0.0f, 1000.0f);
    if (sustain != newSustain) {
      _dsp.SetFloatParameter(Hv_UnityGuns_AudioLib.Parameter.Sustain, newSustain);
    }
    GUILayout.EndHorizontal();
    
    // volBand
    GUILayout.BeginHorizontal();
    float volBand = _dsp.GetFloatParameter(Hv_UnityGuns_AudioLib.Parameter.Volband);
    float newVolband = EditorGUILayout.Slider("volBand", volBand, 0.0f, 2.0f);
    if (volBand != newVolband) {
      _dsp.SetFloatParameter(Hv_UnityGuns_AudioLib.Parameter.Volband, newVolband);
    }
    GUILayout.EndHorizontal();
    
    // volHigh
    GUILayout.BeginHorizontal();
    float volHigh = _dsp.GetFloatParameter(Hv_UnityGuns_AudioLib.Parameter.Volhigh);
    float newVolhigh = EditorGUILayout.Slider("volHigh", volHigh, 0.0f, 2.0f);
    if (volHigh != newVolhigh) {
      _dsp.SetFloatParameter(Hv_UnityGuns_AudioLib.Parameter.Volhigh, newVolhigh);
    }
    GUILayout.EndHorizontal();
    
    // volLow
    GUILayout.BeginHorizontal();
    float volLow = _dsp.GetFloatParameter(Hv_UnityGuns_AudioLib.Parameter.Vollow);
    float newVollow = EditorGUILayout.Slider("volLow", volLow, 0.0f, 2.0f);
    if (volLow != newVollow) {
      _dsp.SetFloatParameter(Hv_UnityGuns_AudioLib.Parameter.Vollow, newVollow);
    }
    GUILayout.EndHorizontal();
    
    // volMaster
    GUILayout.BeginHorizontal();
    float volMaster = _dsp.GetFloatParameter(Hv_UnityGuns_AudioLib.Parameter.Volmaster);
    float newVolmaster = EditorGUILayout.Slider("volMaster", volMaster, 0.0f, 2.0f);
    if (volMaster != newVolmaster) {
      _dsp.SetFloatParameter(Hv_UnityGuns_AudioLib.Parameter.Volmaster, newVolmaster);
    }
    GUILayout.EndHorizontal();
    EditorGUI.indentLevel--;
  }
}
#endif // UNITY_EDITOR

[RequireComponent (typeof (AudioSource))]
public class Hv_UnityGuns_AudioLib : MonoBehaviour {
  
  // Events are used to trigger bangs in the patch context (thread-safe).
  // Example usage:
  /*
    void Start () {
        Hv_UnityGuns_AudioLib script = GetComponent<Hv_UnityGuns_AudioLib>();
        script.SendEvent(Hv_UnityGuns_AudioLib.Event.Play);
    }
  */
  public enum Event : uint {
    Play = 0x82489465,
  }
  
  // Parameters are used to send float messages into the patch context (thread-safe).
  // Example usage:
  /*
    void Start () {
        Hv_UnityGuns_AudioLib script = GetComponent<Hv_UnityGuns_AudioLib>();
        // Get and set a parameter
        float attack = script.GetFloatParameter(Hv_UnityGuns_AudioLib.Parameter.Attack);
        script.SetFloatParameter(Hv_UnityGuns_AudioLib.Parameter.Attack, attack + 0.1f);
    }
  */
  public enum Parameter : uint {
    Attack = 0xEB9639BF,
    Band = 0xE84D8048,
    Bandq = 0xC90EA699,
    Decaytime = 0x7A9CE2DE,
    Hip = 0x474D7361,
    Lop = 0x57BFA7EA,
    Randomband = 0xF417BF4B,
    Randomhi = 0x75DEE76D,
    Randomlow = 0x649EE1FA,
    Release = 0x34A8D635,
    Sustain = 0xD3DE91D0,
    Volband = 0x7BE8D20A,
    Volhigh = 0x9EA7F5FD,
    Vollow = 0xB7DBC418,
    Volmaster = 0xBB68E1AA,
  }
  
  // Delegate method for receiving float messages from the patch context (thread-safe).
  // Example usage:
  /*
    void Start () {
        Hv_UnityGuns_AudioLib script = GetComponent<Hv_UnityGuns_AudioLib>();
        script.RegisterSendHook();
        script.FloatReceivedCallback += OnFloatMessage;
    }

    void OnFloatMessage(Hv_UnityGuns_AudioLib.FloatMessage message) {
        Debug.Log(message.receiverName + ": " + message.value);
    }
  */
  public class FloatMessage {
    public string receiverName;
    public float value;

    public FloatMessage(string name, float x) {
      receiverName = name;
      value = x;
    }
  }
  public delegate void FloatMessageReceived(FloatMessage message);
  public FloatMessageReceived FloatReceivedCallback;
  public float attack = 10.0f;
  public float band = 500.0f;
  public float bandQ = 50.0f;
  public float decayTime = 5.0f;
  public float hip = 2000.0f;
  public float lop = 200.0f;
  public float randomBand = 0.0f;
  public float randomHi = 0.0f;
  public float randomLow = 0.0f;
  public float release = 70.0f;
  public float sustain = 100.0f;
  public float volBand = 1.0f;
  public float volHigh = 1.0f;
  public float volLow = 1.0f;
  public float volMaster = 1.0f;

  // internal state
  private Hv_UnityGuns_Context _context;

  public bool IsInstantiated() {
    return (_context != null);
  }

  public void RegisterSendHook() {
    _context.RegisterSendHook();
  }
  
  // see Hv_UnityGuns_AudioLib.Event for definitions
  public void SendEvent(Hv_UnityGuns_AudioLib.Event e) {
    if (IsInstantiated()) _context.SendBangToReceiver((uint) e);
  }
  
  // see Hv_UnityGuns_AudioLib.Parameter for definitions
  public float GetFloatParameter(Hv_UnityGuns_AudioLib.Parameter param) {
    switch (param) {
      case Parameter.Attack: return attack;
      case Parameter.Band: return band;
      case Parameter.Bandq: return bandQ;
      case Parameter.Decaytime: return decayTime;
      case Parameter.Hip: return hip;
      case Parameter.Lop: return lop;
      case Parameter.Randomband: return randomBand;
      case Parameter.Randomhi: return randomHi;
      case Parameter.Randomlow: return randomLow;
      case Parameter.Release: return release;
      case Parameter.Sustain: return sustain;
      case Parameter.Volband: return volBand;
      case Parameter.Volhigh: return volHigh;
      case Parameter.Vollow: return volLow;
      case Parameter.Volmaster: return volMaster;
      default: return 0.0f;
    }
  }

  public void SetFloatParameter(Hv_UnityGuns_AudioLib.Parameter param, float x) {
    switch (param) {
      case Parameter.Attack: {
        x = Mathf.Clamp(x, 0.0f, 100.0f);
        attack = x;
        break;
      }
      case Parameter.Band: {
        x = Mathf.Clamp(x, 0.0f, 20000.0f);
        band = x;
        break;
      }
      case Parameter.Bandq: {
        x = Mathf.Clamp(x, 0.0f, 500.0f);
        bandQ = x;
        break;
      }
      case Parameter.Decaytime: {
        x = Mathf.Clamp(x, 0.0f, 10.0f);
        decayTime = x;
        break;
      }
      case Parameter.Hip: {
        x = Mathf.Clamp(x, 0.0f, 20000.0f);
        hip = x;
        break;
      }
      case Parameter.Lop: {
        x = Mathf.Clamp(x, 0.0f, 20000.0f);
        lop = x;
        break;
      }
      case Parameter.Randomband: {
        x = Mathf.Clamp(x, 0.0f, 500.0f);
        randomBand = x;
        break;
      }
      case Parameter.Randomhi: {
        x = Mathf.Clamp(x, 0.0f, 500.0f);
        randomHi = x;
        break;
      }
      case Parameter.Randomlow: {
        x = Mathf.Clamp(x, 0.0f, 500.0f);
        randomLow = x;
        break;
      }
      case Parameter.Release: {
        x = Mathf.Clamp(x, 0.0f, 1000.0f);
        release = x;
        break;
      }
      case Parameter.Sustain: {
        x = Mathf.Clamp(x, 0.0f, 1000.0f);
        sustain = x;
        break;
      }
      case Parameter.Volband: {
        x = Mathf.Clamp(x, 0.0f, 2.0f);
        volBand = x;
        break;
      }
      case Parameter.Volhigh: {
        x = Mathf.Clamp(x, 0.0f, 2.0f);
        volHigh = x;
        break;
      }
      case Parameter.Vollow: {
        x = Mathf.Clamp(x, 0.0f, 2.0f);
        volLow = x;
        break;
      }
      case Parameter.Volmaster: {
        x = Mathf.Clamp(x, 0.0f, 2.0f);
        volMaster = x;
        break;
      }
      default: return;
    }
    if (IsInstantiated()) _context.SendFloatToReceiver((uint) param, x);
  }
  
  public void FillTableWithMonoAudioClip(string tableName, AudioClip clip) {
    if (clip.channels > 1) {
      Debug.LogWarning("Hv_UnityGuns_AudioLib: Only loading first channel of '" +
          clip.name + "' into table '" +
          tableName + "'. Multi-channel files are not supported.");
    }
    float[] buffer = new float[clip.samples]; // copy only the 1st channel
    clip.GetData(buffer, 0);
    _context.FillTableWithFloatBuffer(tableName, buffer);
  }

  public void FillTableWithFloatBuffer(string tableName, float[] buffer) {
    _context.FillTableWithFloatBuffer(tableName, buffer);
  }

  private void Awake() {
    _context = new Hv_UnityGuns_Context((double) AudioSettings.outputSampleRate);
  }
  
  private void Start() {
    _context.SendFloatToReceiver((uint) Parameter.Attack, attack);
    _context.SendFloatToReceiver((uint) Parameter.Band, band);
    _context.SendFloatToReceiver((uint) Parameter.Bandq, bandQ);
    _context.SendFloatToReceiver((uint) Parameter.Decaytime, decayTime);
    _context.SendFloatToReceiver((uint) Parameter.Hip, hip);
    _context.SendFloatToReceiver((uint) Parameter.Lop, lop);
    _context.SendFloatToReceiver((uint) Parameter.Randomband, randomBand);
    _context.SendFloatToReceiver((uint) Parameter.Randomhi, randomHi);
    _context.SendFloatToReceiver((uint) Parameter.Randomlow, randomLow);
    _context.SendFloatToReceiver((uint) Parameter.Release, release);
    _context.SendFloatToReceiver((uint) Parameter.Sustain, sustain);
    _context.SendFloatToReceiver((uint) Parameter.Volband, volBand);
    _context.SendFloatToReceiver((uint) Parameter.Volhigh, volHigh);
    _context.SendFloatToReceiver((uint) Parameter.Vollow, volLow);
    _context.SendFloatToReceiver((uint) Parameter.Volmaster, volMaster);
  }
  
  private void Update() {
    // retreive sent messages
    if (_context.IsSendHookRegistered()) {
      Hv_UnityGuns_AudioLib.FloatMessage tempMessage;
      while ((tempMessage = _context.msgQueue.GetNextMessage()) != null) {
        FloatReceivedCallback(tempMessage);
      }
    }
  }

  private void OnAudioFilterRead(float[] buffer, int numChannels) {
    Assert.AreEqual(numChannels, _context.GetNumOutputChannels()); // invalid channel configuration
    _context.Process(buffer, buffer.Length / numChannels); // process dsp
  }
}

class Hv_UnityGuns_Context {

#if UNITY_IOS && !UNITY_EDITOR
  private const string _dllName = "__Internal";
#else
  private const string _dllName = "Hv_UnityGuns_AudioLib";
#endif

  // Thread-safe message queue
  public class SendMessageQueue {
    private readonly object _msgQueueSync = new object();
    private readonly Queue<Hv_UnityGuns_AudioLib.FloatMessage> _msgQueue = new Queue<Hv_UnityGuns_AudioLib.FloatMessage>();

    public Hv_UnityGuns_AudioLib.FloatMessage GetNextMessage() {
      lock (_msgQueueSync) {
        return (_msgQueue.Count != 0) ? _msgQueue.Dequeue() : null;
      }
    }

    public void AddMessage(string receiverName, float value) {
      Hv_UnityGuns_AudioLib.FloatMessage msg = new Hv_UnityGuns_AudioLib.FloatMessage(receiverName, value);
      lock (_msgQueueSync) {
        _msgQueue.Enqueue(msg);
      }
    }
  }

  public readonly SendMessageQueue msgQueue = new SendMessageQueue();
  private readonly GCHandle gch;
  private readonly IntPtr _context; // handle into unmanaged memory
  private SendHook _sendHook = null;

  [DllImport (_dllName)]
  private static extern IntPtr hv_UnityGuns_new_with_options(double sampleRate, int poolKb, int inQueueKb, int outQueueKb);

  [DllImport (_dllName)]
  private static extern int hv_processInlineInterleaved(IntPtr ctx,
      [In] float[] inBuffer, [Out] float[] outBuffer, int numSamples);

  [DllImport (_dllName)]
  private static extern void hv_delete(IntPtr ctx);

  [DllImport (_dllName)]
  private static extern double hv_getSampleRate(IntPtr ctx);

  [DllImport (_dllName)]
  private static extern int hv_getNumInputChannels(IntPtr ctx);

  [DllImport (_dllName)]
  private static extern int hv_getNumOutputChannels(IntPtr ctx);

  [DllImport (_dllName)]
  private static extern void hv_setSendHook(IntPtr ctx, SendHook sendHook);

  [DllImport (_dllName)]
  private static extern void hv_setPrintHook(IntPtr ctx, PrintHook printHook);

  [DllImport (_dllName)]
  private static extern int hv_setUserData(IntPtr ctx, IntPtr userData);

  [DllImport (_dllName)]
  private static extern IntPtr hv_getUserData(IntPtr ctx);

  [DllImport (_dllName)]
  private static extern void hv_sendBangToReceiver(IntPtr ctx, uint receiverHash);

  [DllImport (_dllName)]
  private static extern void hv_sendFloatToReceiver(IntPtr ctx, uint receiverHash, float x);

  [DllImport (_dllName)]
  private static extern uint hv_msg_getTimestamp(IntPtr message);

  [DllImport (_dllName)]
  private static extern bool hv_msg_hasFormat(IntPtr message, string format);

  [DllImport (_dllName)]
  private static extern float hv_msg_getFloat(IntPtr message, int index);

  [DllImport (_dllName)]
  private static extern bool hv_table_setLength(IntPtr ctx, uint tableHash, uint newSampleLength);

  [DllImport (_dllName)]
  private static extern IntPtr hv_table_getBuffer(IntPtr ctx, uint tableHash);

  [DllImport (_dllName)]
  private static extern float hv_samplesToMilliseconds(IntPtr ctx, uint numSamples);

  [DllImport (_dllName)]
  private static extern uint hv_stringToHash(string s);

  private delegate void PrintHook(IntPtr context, string printName, string str, IntPtr message);

  private delegate void SendHook(IntPtr context, string sendName, uint sendHash, IntPtr message);

  public Hv_UnityGuns_Context(double sampleRate, int poolKb=10, int inQueueKb=15, int outQueueKb=2) {
    gch = GCHandle.Alloc(msgQueue);
    _context = hv_UnityGuns_new_with_options(sampleRate, poolKb, inQueueKb, outQueueKb);
    hv_setPrintHook(_context, new PrintHook(OnPrint));
    hv_setUserData(_context, GCHandle.ToIntPtr(gch));
  }

  ~Hv_UnityGuns_Context() {
    hv_delete(_context);
    GC.KeepAlive(_context);
    GC.KeepAlive(_sendHook);
    gch.Free();
  }

  public void RegisterSendHook() {
    // Note: send hook functionality only applies to messages containing a single float value
    if (_sendHook == null) {
      _sendHook = new SendHook(OnMessageSent);
      hv_setSendHook(_context, _sendHook);
    }
  }

  public bool IsSendHookRegistered() {
    return (_sendHook != null);
  }

  public double GetSampleRate() {
    return hv_getSampleRate(_context);
  }

  public int GetNumInputChannels() {
    return hv_getNumInputChannels(_context);
  }

  public int GetNumOutputChannels() {
    return hv_getNumOutputChannels(_context);
  }

  public void SendBangToReceiver(uint receiverHash) {
    hv_sendBangToReceiver(_context, receiverHash);
  }

  public void SendFloatToReceiver(uint receiverHash, float x) {
    hv_sendFloatToReceiver(_context, receiverHash, x);
  }

  public void FillTableWithFloatBuffer(string tableName, float[] buffer) {
    uint tableHash = hv_stringToHash(tableName);
    if (hv_table_getBuffer(_context, tableHash) != IntPtr.Zero) {
      hv_table_setLength(_context, tableHash, (uint) buffer.Length);
      Marshal.Copy(buffer, 0, hv_table_getBuffer(_context, tableHash), buffer.Length);
    } else {
      Debug.Log(string.Format("Table '{0}' doesn't exist in the patch context.", tableName));
    }
  }

  public uint StringToHash(string s) {
    return hv_stringToHash(s);
  }

  public int Process(float[] buffer, int numFrames) {
    return hv_processInlineInterleaved(_context, buffer, buffer, numFrames);
  }

  [MonoPInvokeCallback(typeof(PrintHook))]
  private static void OnPrint(IntPtr context, string printName, string str, IntPtr message) {
    float timeInSecs = hv_samplesToMilliseconds(context, hv_msg_getTimestamp(message)) / 1000.0f;
    Debug.Log(string.Format("{0} [{1:0.000}]: {2}", printName, timeInSecs, str));
  }

  [MonoPInvokeCallback(typeof(SendHook))]
  private static void OnMessageSent(IntPtr context, string sendName, uint sendHash, IntPtr message) {
    if (hv_msg_hasFormat(message, "f")) {
      SendMessageQueue msgQueue = (SendMessageQueue) GCHandle.FromIntPtr(hv_getUserData(context)).Target;
      msgQueue.AddMessage(sendName, hv_msg_getFloat(message, 0));
    }
  }
}
