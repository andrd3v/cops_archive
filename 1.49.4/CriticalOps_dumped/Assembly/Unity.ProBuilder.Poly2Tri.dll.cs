// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class Polygon
{
	// Fields
	protected System.Collections.Generic.List<UnityEngine.ProBuilder.Poly2Tri.TriangulationPoint> _points; // 0x10
	protected System.Collections.Generic.List<UnityEngine.ProBuilder.Poly2Tri.TriangulationPoint> _steinerPoints; // 0x18
	protected System.Collections.Generic.List<UnityEngine.ProBuilder.Poly2Tri.Polygon> _holes; // 0x20
	protected System.Collections.Generic.List<UnityEngine.ProBuilder.Poly2Tri.DelaunayTriangle> _triangles; // 0x28

	// Methods

	// RVA: 0x14C7D5C
	public void .ctor(System.Collections.Generic.IList<UnityEngine.ProBuilder.Poly2Tri.PolygonPoint> points) { }

	// RVA: 0x14C8144
	public void .ctor(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Poly2Tri.PolygonPoint> points) { }

	// RVA: 0x14C81F8
	public TriangulationMode get_TriangulationMode() { }

	// RVA: 0x14C8200
	public void AddHole(Polygon poly) { }

	// RVA: 0x14C82B8
	public System.Collections.Generic.IList<UnityEngine.ProBuilder.Poly2Tri.DelaunayTriangle> get_Triangles() { }

	// RVA: 0x14C82C0
	public void AddTriangle(DelaunayTriangle t) { }

	// RVA: 0x14C8324
	public void AddTriangles(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Poly2Tri.DelaunayTriangle> list) { }

	// RVA: 0x14C8388
	public void Prepare(TriangulationContext tcx) { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class PolygonPoint
{
	// Methods

	// RVA: 0x14C88A8
	public void .ctor(Double x, Double y, int index) { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class DelaunayTriangle
{
	// Fields
	public UnityEngine.ProBuilder.Poly2Tri.FixedArray3<UnityEngine.ProBuilder.Poly2Tri.TriangulationPoint> Points; // 0x10
	public UnityEngine.ProBuilder.Poly2Tri.FixedArray3<UnityEngine.ProBuilder.Poly2Tri.DelaunayTriangle> Neighbors; // 0x28
	public FixedBitArray3 EdgeIsConstrained; // 0x40
	public FixedBitArray3 EdgeIsDelaunay; // 0x43
	private bool <IsInterior>k__BackingField; // 0x46

	// Methods

	// RVA: 0x14C8928
	public bool get_IsInterior() { }

	// RVA: 0x14C8930
	public void set_IsInterior(bool value) { }

	// RVA: 0x14C8938
	public void .ctor(TriangulationPoint p1, TriangulationPoint p2, TriangulationPoint p3) { }

	// RVA: 0x14C89E0
	public int IndexOf(TriangulationPoint p) { }

	// RVA: 0x14C8A90
	public int IndexCCWFrom(TriangulationPoint p) { }

	// RVA: 0x14C8AC8
	public bool Contains(TriangulationPoint p) { }

	// RVA: 0x14C8B24
	private void MarkNeighbor(TriangulationPoint p1, TriangulationPoint p2, DelaunayTriangle t) { }

	// RVA: 0x14C8D6C
	public void MarkNeighbor(DelaunayTriangle t) { }

	// RVA: 0x14C8F9C
	public TriangulationPoint OppositePoint(DelaunayTriangle t, TriangulationPoint p) { }

	// RVA: 0x14C9128
	public DelaunayTriangle NeighborCWFrom(TriangulationPoint point) { }

	// RVA: 0x14C91D4
	public DelaunayTriangle NeighborCCWFrom(TriangulationPoint point) { }

	// RVA: 0x14C9280
	public DelaunayTriangle NeighborAcrossFrom(TriangulationPoint point) { }

	// RVA: 0x14C930C
	public TriangulationPoint PointCCWFrom(TriangulationPoint point) { }

	// RVA: 0x14C909C
	public TriangulationPoint PointCWFrom(TriangulationPoint point) { }

	// RVA: 0x14C9398
	private void RotateCW() { }

	// RVA: 0x14C9468
	public void Legalize(TriangulationPoint oPoint, TriangulationPoint nPoint) { }

	// RVA: 0x14C950C
	public override string ToString() { }

	// RVA: 0x14C96CC
	public void MarkConstrainedEdge(int index) { }

	// RVA: 0x14C97E0
	public void MarkConstrainedEdge(TriangulationPoint p, TriangulationPoint q) { }

	// RVA: 0x14C8C78
	public int EdgeIndex(TriangulationPoint p1, TriangulationPoint p2) { }

	// RVA: 0x14C98BC
	public bool GetConstrainedEdgeCCW(TriangulationPoint p) { }

	// RVA: 0x14C99F4
	public bool GetConstrainedEdgeCW(TriangulationPoint p) { }

	// RVA: 0x14C9AB0
	public void SetConstrainedEdgeCCW(TriangulationPoint p, bool ce) { }

	// RVA: 0x14C9B70
	public void SetConstrainedEdgeCW(TriangulationPoint p, bool ce) { }

	// RVA: 0x14C9C30
	public bool GetDelaunayEdgeCCW(TriangulationPoint p) { }

	// RVA: 0x14C9CEC
	public bool GetDelaunayEdgeCW(TriangulationPoint p) { }

	// RVA: 0x14C9DA8
	public void SetDelaunayEdgeCCW(TriangulationPoint p, bool ce) { }

	// RVA: 0x14C9E68
	public void SetDelaunayEdgeCW(TriangulationPoint p, bool ce) { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class AdvancingFront
{
	// Fields
	public AdvancingFrontNode Head; // 0x10
	public AdvancingFrontNode Tail; // 0x18
	protected AdvancingFrontNode Search; // 0x20

	// Methods

	// RVA: 0x14C9F28
	public void .ctor(AdvancingFrontNode head, AdvancingFrontNode tail) { }

	// RVA: 0x14C9F88
	public void AddNode(AdvancingFrontNode node) { }

	// RVA: 0x14C9F8C
	public void RemoveNode(AdvancingFrontNode node) { }

	// RVA: 0x14C9F90
	public override string ToString() { }

	// RVA: 0x14CA08C
	private AdvancingFrontNode FindSearchNode(Double x) { }

	// RVA: 0x14CA094
	public AdvancingFrontNode LocateNode(TriangulationPoint point) { }

	// RVA: 0x14CA124
	private AdvancingFrontNode LocateNode(Double x) { }

	// RVA: 0x14CA1AC
	public AdvancingFrontNode LocatePoint(TriangulationPoint point) { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class AdvancingFrontNode
{
	// Fields
	public AdvancingFrontNode Next; // 0x10
	public AdvancingFrontNode Prev; // 0x18
	public Double Value; // 0x20
	public TriangulationPoint Point; // 0x28
	public DelaunayTriangle Triangle; // 0x30

	// Methods

	// RVA: 0x14CA2B0
	public void .ctor(TriangulationPoint point) { }

	// RVA: 0x14CA2F8
	public bool get_HasNext() { }

	// RVA: 0x14CA308
	public bool get_HasPrev() { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal static class DTSweep
{
	// Methods

	// RVA: 0x14CA318
	public static void Triangulate(DTSweepContext tcx) { }

	// RVA: 0x14CA6B0
	private static void Sweep(DTSweepContext tcx) { }

	// RVA: 0x14CAB74
	private static void FinalizationConvexHull(DTSweepContext tcx) { }

	// RVA: 0x14CB768
	private static void TurnAdvancingFrontConvex(DTSweepContext tcx, AdvancingFrontNode b, AdvancingFrontNode c) { }

	// RVA: 0x14CA9E0
	private static void FinalizationPolygon(DTSweepContext tcx) { }

	// RVA: 0x14CB220
	private static AdvancingFrontNode PointEvent(DTSweepContext tcx, TriangulationPoint point) { }

	// RVA: 0x14CCB14
	private static AdvancingFrontNode NewFrontTriangle(DTSweepContext tcx, TriangulationPoint point, AdvancingFrontNode node) { }

	// RVA: 0x14CB4D0
	private static void EdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x14CD5B8
	private static void FillEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x14CDD4C
	private static void FillRightConcaveEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x14CDEB0
	private static void FillRightConvexEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x14CE060
	private static void FillRightBelowEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x14CD9A0
	private static void FillRightAboveEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x14CE308
	private static void FillLeftConvexEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x14CE4AC
	private static void FillLeftConcaveEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x14CE608
	private static void FillLeftBelowEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x14CDB78
	private static void FillLeftAboveEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x14CD3D4
	private static bool IsEdgeSideOfTriangle(DelaunayTriangle triangle, TriangulationPoint ep, TriangulationPoint eq) { }

	// RVA: 0x14CD5E8
	private static void EdgeEvent(DTSweepContext tcx, TriangulationPoint ep, TriangulationPoint eq, DelaunayTriangle triangle, TriangulationPoint point) { }

	// RVA: 0x14CE910
	private static void FlipEdgeEvent(DTSweepContext tcx, TriangulationPoint ep, TriangulationPoint eq, DelaunayTriangle t, TriangulationPoint p) { }

	// RVA: 0x14CF3D8
	private static TriangulationPoint NextFlipPoint(TriangulationPoint ep, TriangulationPoint eq, DelaunayTriangle ot, TriangulationPoint op) { }

	// RVA: 0x14CF1DC
	private static DelaunayTriangle NextFlipTriangle(DTSweepContext tcx, Orientation o, DelaunayTriangle t, DelaunayTriangle ot, TriangulationPoint p, TriangulationPoint op) { }

	// RVA: 0x14CF5B4
	private static void FlipScanEdgeEvent(DTSweepContext tcx, TriangulationPoint ep, TriangulationPoint eq, DelaunayTriangle flipTriangle, DelaunayTriangle t, TriangulationPoint p) { }

	// RVA: 0x14CCDCC
	private static void FillAdvancingFront(DTSweepContext tcx, AdvancingFrontNode n) { }

	// RVA: 0x14CFBD0
	private static void FillBasin(DTSweepContext tcx, AdvancingFrontNode node) { }

	// RVA: 0x14CFDE4
	private static void FillBasinReq(DTSweepContext tcx, AdvancingFrontNode node) { }

	// RVA: 0x14CFFC0
	private static bool IsShallow(DTSweepContext tcx, AdvancingFrontNode node) { }

	// RVA: 0x14CFA64
	private static Double HoleAngle(AdvancingFrontNode node) { }

	// RVA: 0x14CFB34
	private static Double BasinAngle(AdvancingFrontNode node) { }

	// RVA: 0x14CC8C4
	private static void Fill(DTSweepContext tcx, AdvancingFrontNode node) { }

	// RVA: 0x14CCED4
	private static bool Legalize(DTSweepContext tcx, DelaunayTriangle t) { }

	// RVA: 0x14CB96C
	private static void RotateTrianglePair(DelaunayTriangle t, TriangulationPoint p, DelaunayTriangle ot, TriangulationPoint op) { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class DTSweepBasin
{
	// Fields
	public AdvancingFrontNode leftNode; // 0x10
	public AdvancingFrontNode bottomNode; // 0x18
	public AdvancingFrontNode rightNode; // 0x20
	public Double width; // 0x28
	public bool leftHighest; // 0x30

	// Methods

	// RVA: 0x14D0118
	public void .ctor() { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class DTSweepConstraint
{
	// Methods

	// RVA: 0x14D0120
	public void .ctor(TriangulationPoint p1, TriangulationPoint p2) { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class DTSweepContext
{
	// Fields
	private readonly float ALPHA; // 0x40
	public AdvancingFront Front; // 0x48
	private TriangulationPoint <Head>k__BackingField; // 0x50
	private TriangulationPoint <Tail>k__BackingField; // 0x58
	public DTSweepBasin Basin; // 0x60
	public DTSweepEdgeEvent EdgeEvent; // 0x68
	private DTSweepPointComparator _comparator; // 0x70

	// Methods

	// RVA: 0x14D02A0
	public TriangulationPoint get_Head() { }

	// RVA: 0x14D02A8
	public void set_Head(TriangulationPoint value) { }

	// RVA: 0x14D02B0
	public TriangulationPoint get_Tail() { }

	// RVA: 0x14D02B8
	public void set_Tail(TriangulationPoint value) { }

	// RVA: 0x14D02C0
	public void .ctor() { }

	// RVA: 0x14D04B8
	public override bool get_IsDebugEnabled() { }

	// RVA: 0x14CC5A0
	public void RemoveFromList(DelaunayTriangle triangle) { }

	// RVA: 0x14CCA78
	public void MeshClean(DelaunayTriangle triangle) { }

	// RVA: 0x14D04C0
	private void MeshCleanReq(DelaunayTriangle triangle) { }

	// RVA: 0x14D0630
	public override void Clear() { }

	// RVA: 0x14CCDB0
	public void AddNode(AdvancingFrontNode node) { }

	// RVA: 0x14D0030
	public void RemoveNode(AdvancingFrontNode node) { }

	// RVA: 0x14CCA7C
	public AdvancingFrontNode LocateNode(TriangulationPoint point) { }

	// RVA: 0x14CA384
	public void CreateAdvancingFront() { }

	// RVA: 0x14CC2F4
	public void MapTriangleToNodes(DelaunayTriangle t) { }

	// RVA: 0x14D078C
	public override void PrepareTriangulation(Triangulatable t) { }

	// RVA: 0x14CC604
	public void FinalizeTriangulation() { }

	// RVA: 0x14D0BEC
	public override TriangulationConstraint NewConstraint(TriangulationPoint a, TriangulationPoint b) { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class DTSweepDebugContext
{
	// Fields
	private DelaunayTriangle _primaryTriangle; // 0x18
	private DelaunayTriangle _secondaryTriangle; // 0x20
	private TriangulationPoint _activePoint; // 0x28
	private AdvancingFrontNode _activeNode; // 0x30
	private DTSweepConstraint _activeConstraint; // 0x38

	// Methods

	// RVA: 0x14CD370
	public void set_PrimaryTriangle(DelaunayTriangle value) { }

	// RVA: 0x14CF0F8
	public void set_SecondaryTriangle(DelaunayTriangle value) { }

	// RVA: 0x14D0C58
	public void set_ActivePoint(TriangulationPoint value) { }

	// RVA: 0x14CC744
	public void set_ActiveNode(AdvancingFrontNode value) { }

	// RVA: 0x14CB46C
	public void set_ActiveConstraint(DTSweepConstraint value) { }

	// RVA: 0x14D0CBC
	public override void Clear() { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class DTSweepEdgeEvent
{
	// Fields
	public DTSweepConstraint ConstrainedEdge; // 0x10
	public bool Right; // 0x18

	// Methods

	// RVA: 0x14D03C8
	public void .ctor() { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class DTSweepPointComparator
{
	// Methods

	// RVA: 0x14D0E04
	public int Compare(TriangulationPoint p1, TriangulationPoint p2) { }

	// RVA: 0x14D03D0
	public void .ctor() { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class PointOnEdgeException
{
	// Fields
	public readonly TriangulationPoint A; // 0x90
	public readonly TriangulationPoint B; // 0x98
	public readonly TriangulationPoint C; // 0xA0

	// Methods

	// RVA: 0x14CE8AC
	public void .ctor(string message, TriangulationPoint a, TriangulationPoint b, TriangulationPoint c) { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal interface Triangulatable
{
	// Methods

	// RVA: -1
	public abstract void Prepare(TriangulationContext tcx) { }

	// RVA: -1
	public abstract System.Collections.Generic.IList<UnityEngine.ProBuilder.Poly2Tri.DelaunayTriangle> get_Triangles() { }

	// RVA: -1
	public abstract void AddTriangle(DelaunayTriangle t) { }

	// RVA: -1
	public abstract void AddTriangles(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Poly2Tri.DelaunayTriangle> list) { }

	// RVA: -1
	public abstract TriangulationMode get_TriangulationMode() { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal enum Orientation
{
	// Fields
	public int value__; // 0x10
	public const Orientation CW = 0;
	public const Orientation CCW = 1;
	public const Orientation Collinear = 2;
}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class PointSet
{
	// Fields
	private System.Collections.Generic.IList<UnityEngine.ProBuilder.Poly2Tri.TriangulationPoint> <Points>k__BackingField; // 0x10
	private System.Collections.Generic.IList<UnityEngine.ProBuilder.Poly2Tri.DelaunayTriangle> <Triangles>k__BackingField; // 0x18

	// Methods

	// RVA: 0x14D0E70
	public System.Collections.Generic.IList<UnityEngine.ProBuilder.Poly2Tri.TriangulationPoint> get_Points() { }

	// RVA: 0x14D0E78
	private void set_Points(System.Collections.Generic.IList<UnityEngine.ProBuilder.Poly2Tri.TriangulationPoint> value) { }

	// RVA: 0x14D0E80
	public System.Collections.Generic.IList<UnityEngine.ProBuilder.Poly2Tri.DelaunayTriangle> get_Triangles() { }

	// RVA: 0x14D0E88
	private void set_Triangles(System.Collections.Generic.IList<UnityEngine.ProBuilder.Poly2Tri.DelaunayTriangle> value) { }

	// RVA: 0x14D0E90
	public void .ctor(System.Collections.Generic.List<UnityEngine.ProBuilder.Poly2Tri.TriangulationPoint> points) { }

	// RVA: 0x14D0F2C
	public virtual TriangulationMode get_TriangulationMode() { }

	// RVA: 0x14D0F34
	public void AddTriangle(DelaunayTriangle t) { }

	// RVA: 0x14D0FEC
	public void AddTriangles(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Poly2Tri.DelaunayTriangle> list) { }

	// RVA: 0x14D1330
	public virtual void Prepare(TriangulationContext tcx) { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class TriangulationConstraint
{
	// Fields
	public TriangulationPoint P; // 0x10
	public TriangulationPoint Q; // 0x18

	// Methods

	// RVA: 0x14D01E0
	public void .ctor() { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal abstract class TriangulationContext
{
	// Fields
	private TriangulationDebugContext <DebugContext>k__BackingField; // 0x10
	public readonly System.Collections.Generic.List<UnityEngine.ProBuilder.Poly2Tri.DelaunayTriangle> Triangles; // 0x18
	public readonly System.Collections.Generic.List<UnityEngine.ProBuilder.Poly2Tri.TriangulationPoint> Points; // 0x20
	private TriangulationMode <TriangulationMode>k__BackingField; // 0x28
	private Triangulatable <Triangulatable>k__BackingField; // 0x30
	private int <StepCount>k__BackingField; // 0x38
	private bool <IsDebugEnabled>k__BackingField; // 0x3C

	// Methods

	// RVA: 0x14D14FC
	public TriangulationDebugContext get_DebugContext() { }

	// RVA: 0x14D1504
	public TriangulationMode get_TriangulationMode() { }

	// RVA: 0x14D150C
	protected void set_TriangulationMode(TriangulationMode value) { }

	// RVA: 0x14D1514
	public Triangulatable get_Triangulatable() { }

	// RVA: 0x14D151C
	private void set_Triangulatable(Triangulatable value) { }

	// RVA: 0x14D1524
	public int get_StepCount() { }

	// RVA: 0x14D152C
	private void set_StepCount(int value) { }

	// RVA: 0x14CB210
	public void Done() { }

	// RVA: 0x14D0ACC
	public virtual void PrepareTriangulation(Triangulatable t) { }

	// RVA: -1
	public abstract TriangulationConstraint NewConstraint(TriangulationPoint a, TriangulationPoint b) { }

	// RVA: 0x14CB764
	public void Update(string message) { }

	// RVA: 0x14D06D8
	public virtual void Clear() { }

	// RVA: 0x14D1534
	public virtual bool get_IsDebugEnabled() { }

	// RVA: 0x14CB3E4
	public DTSweepDebugContext get_DTDebugContext() { }

	// RVA: 0x14D03D8
	protected void .ctor() { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal abstract class TriangulationDebugContext
{
	// Fields
	protected TriangulationContext _tcx; // 0x10

	// Methods

	// RVA: -1
	public abstract void Clear() { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal enum TriangulationMode
{
	// Fields
	public int value__; // 0x10
	public const TriangulationMode Unconstrained = 0;
	public const TriangulationMode Constrained = 1;
	public const TriangulationMode Polygon = 2;
}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class TriangulationPoint
{
	// Fields
	private System.Collections.Generic.List<UnityEngine.ProBuilder.Poly2Tri.DTSweepConstraint> <Edges>k__BackingField; // 0x10
	public Double X; // 0x18
	public Double Y; // 0x20
	public int Index; // 0x28

	// Methods

	// RVA: 0x14D153C
	public System.Collections.Generic.List<UnityEngine.ProBuilder.Poly2Tri.DTSweepConstraint> get_Edges() { }

	// RVA: 0x14D1544
	private void set_Edges(System.Collections.Generic.List<UnityEngine.ProBuilder.Poly2Tri.DTSweepConstraint> value) { }

	// RVA: 0x14C88E8
	public void .ctor(Double x, Double y, int index) { }

	// RVA: 0x14D154C
	public override string ToString() { }

	// RVA: 0x14D01E8
	public void AddEdge(DTSweepConstraint e) { }

	// RVA: 0x14CB3D4
	public bool get_HasEdges() { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class TriangulationUtil
{
	// Fields
	public static Double EPSILON; // 0x0

	// Methods

	// RVA: 0x14D004C
	public static bool SmartIncircle(TriangulationPoint pa, TriangulationPoint pb, TriangulationPoint pc, TriangulationPoint pd) { }

	// RVA: 0x14CF15C
	public static bool InScanArea(TriangulationPoint pa, TriangulationPoint pb, TriangulationPoint pc, TriangulationPoint pd) { }

	// RVA: 0x14CC7A8
	public static Orientation Orient2d(TriangulationPoint pa, TriangulationPoint pb, TriangulationPoint pc) { }

	// RVA: 0x14D16A8
	private static void .cctor() { }

}

// Namespace: 
private sealed class <Enumerate>d__10
{
	// Fields
	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	public UnityEngine.ProBuilder.Poly2Tri.FixedArray3<T> <>4__this; // 0x0
	public UnityEngine.ProBuilder.Poly2Tri.FixedArray3<T> <>3__<>4__this; // 0x0
	private int <i>5__2; // 0x0

	// Methods

	// RVA: 0x30A24F0
	public void .ctor(int <>1__state) { }

	// RVA: 0x30A2378
	private void System.IDisposable.Dispose() { }

	// RVA: 0x30A1224
	private bool MoveNext() { }

	// RVA: 0x315B3A8
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }

	// RVA: 0x30A2378
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x30A17DC
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x30A17DC
	private System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	// RVA: 0x30A17DC
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal struct FixedArray3<T0>
{
	// Fields
	public T _0; // 0x0
	public T _1; // 0x0
	public T _2; // 0x0

	// Methods

	// RVA: 0x315B3A8
	public T get_Item(int index) { }

	// RVA: 0x315B3A8
	public void set_Item(int index, T value) { }

	// RVA: 0x315B3A8
	public bool Contains(T value) { }

	// RVA: 0x315B3A8
	public int IndexOf(T value) { }

	// RVA: 0x30A2378
	public void Clear() { }

	// RVA: 0x30A17DC
	private System.Collections.Generic.IEnumerable<T> Enumerate() { }

	// RVA: 0x30A17DC
	public System.Collections.Generic.IEnumerator<T> GetEnumerator() { }

	// RVA: 0x30A17DC
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: 
private sealed class <Enumerate>d__10
{
	// Fields
	private int <>1__state; // 0x10
	private bool <>2__current; // 0x14
	private int <>l__initialThreadId; // 0x18
	public FixedBitArray3 <>4__this; // 0x1C
	public FixedBitArray3 <>3__<>4__this; // 0x1F
	private int <i>5__2; // 0x24

	// Methods

	// RVA: 0x14D178C
	public void .ctor(int <>1__state) { }

	// RVA: 0x14D18DC
	private void System.IDisposable.Dispose() { }

	// RVA: 0x14D18E0
	private bool MoveNext() { }

	// RVA: 0x14D19AC
	private bool System.Collections.Generic.IEnumerator<System.Boolean>.get_Current() { }

	// RVA: 0x14D19B4
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x14D19F4
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x14D1A5C
	private System.Collections.Generic.IEnumerator<System.Boolean> System.Collections.Generic.IEnumerable<System.Boolean>.GetEnumerator() { }

	// RVA: 0x14D1B04
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal struct FixedBitArray3
{
	// Fields
	public bool _0; // 0x10
	public bool _1; // 0x11
	public bool _2; // 0x12

	// Methods

	// RVA: 0x14C9978
	public bool get_Item(int index) { }

	// RVA: 0x14C9768
	public void set_Item(int index, bool value) { }

	// RVA: 0x14CFA58
	public void Clear() { }

	// RVA: 0x14D1704
	private System.Collections.Generic.IEnumerable<System.Boolean> Enumerate() { }

	// RVA: 0x14D17C4
	public System.Collections.Generic.IEnumerator<System.Boolean> GetEnumerator() { }

	// RVA: 0x14D18D8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}


